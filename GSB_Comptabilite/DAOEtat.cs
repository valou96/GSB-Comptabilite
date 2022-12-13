using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOEtat
    {
        private Dbal undbal;


        public DAOEtat(Dbal undbalEtat)
        {
            undbal = undbalEtat;
        }



        public void Insert(Etat unEtat)
        {
            string value = "'" + unEtat.Libelle + "'";

            undbal.Insert("Etat", value);
        }

        public void Update(Etat unEtat)
        {
            string value = "'" + unEtat.Libelle + "'";
            string condition = "libelle =" + unEtat.Libelle;
            undbal.Update("Etat", value, condition);
        }

        public void Delete(Etat unEtat)
        {
            string condition = "'" + "libelle=" + "'" + unEtat.Libelle + "'";
            undbal.Delete("Etat", condition);

        }

        public List<Etat> SelectAll()
        {
            List<Etat> listEtat = new List<Etat>();
            DataTable myTable = undbal.SelectAll("Etat");

            foreach (DataRow r in myTable.Rows)
            {
                listEtat.Add(new Etat((string)r["libelle"]));
            }
            return listEtat;
        }
        /*
        public Etat SelectById(int idPays)
        {
            DataRow result = undbal.SelectById("Pays", idPays);
            return new Pays((string)result["name"], (int)result["id"]);
        }
        */
    }
}
