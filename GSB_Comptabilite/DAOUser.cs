using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOUser
    {
        private Dbal undbal;


        public DAOUser(Dbal undbalUser)
        {
            undbal = undbalUser;
        }



        public void Insert(User unUser)
        {
            string value = "'" + unUser.Login + "'," + " '" + unUser.Role + "'," + " '" + unUser.Password + "'," + " '"
                + unUser.Nom + "'," + " '" + unUser.Prenom + "'," + " '" + unUser.Adresse + "'," + " '" + unUser.Cp
                + "'," + " '" + unUser.Date_embauche + "'," + " '" + unUser.Ville + "'," + " '" + unUser.Old_id + "';";

            undbal.Insert("User", value);
        }

        public void Update(User unUser)
        {
            string value = "'" + unUser.Role + "'," + " '" + unUser.Password + "'," + " '"
                + unUser.Nom + "'," + " '" + unUser.Prenom + "'," + " '" + unUser.Adresse + "'," + " '" + unUser.Cp
                + "'," + " '" + unUser.Date_embauche + "'," + " '" + unUser.Ville + "'," + " '" + unUser.Old_id + "'";
            string condition = "Login =" + unUser.Login;
            undbal.Update("User", value, condition);
        }

        public void Delete(User unUser)
        {
            string condition = "'" + "Login=" + "'" + unUser.Login + "'";
            undbal.Delete("User", condition);

        }

        public List<User> SelectAll()
        {
            List<User> listUser = new List<User>();
            DataTable myTable = undbal.SelectAll("User");

            foreach (DataRow r in myTable.Rows)
            {
                listUser.Add(new User((string)r["login"], (string)r["role"], (string)r["password"], (string)r["nom"],
                    (string)r["prenom"], (string)r["adresse"], (string)r["cp"], (DateTime)r["date_embauche"], (string)r
                    ["ville"], (string)r["old_id"]));
            }
            return listUser;
        }

    }
}
