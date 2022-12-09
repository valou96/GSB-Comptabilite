using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB_Comptabilite
{
    public class Dbal
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public Dbal()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "gsb-frais-symfony";
            uid = "root";
            password = "&6HAUTdanslaFauré";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void CUDquery(string query)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            CloseConnection();
        }


        public void Insert(string table, string values)
        {
            string query = "INSERT INTO " + table + " VALUES(" + values + ");";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                CUDquery(query);
            }
        }

        public void Update(string table, string values, string condition)
        {
            string query = "UPDATE " + table + " SET " + values + " WHERE " + condition + ";";

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                CUDquery(query);
            }
        }


        public void Delete(string table, string condition)
        {
            string query = "DELETE FROM " + table + " WHERE " + condition + ";";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        private DataSet RQuery(string query)
        {
            DataSet dataset = new DataSet();
            //Open connection
            if (OpenConnection() == true)
            {
                //Add query data in a DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataset);
                CloseConnection();
            }
            return dataset;
        }

        public DataTable SelectAll(string table)
        {
            string query = " SELECT * FROM " + table;
            DataSet dataset = RQuery(query);
            return dataset.Tables[0];
        }

        public DataRow SelectById(string table, int id)

        {
            string query = "SELECT * FROM " + table + " where id = '" + id + "'";
            DataSet dataset = RQuery(query);
            return dataset.Tables[0].Rows[0];
        }

    }
}
