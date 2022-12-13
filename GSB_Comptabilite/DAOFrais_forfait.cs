using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOFrais_forfait
    {

        private Dbal undbal;


        public DAOFrais_forfait(Dbal undbalFrais_forfait)
        {
            undbal = undbalFrais_forfait;
        }



        public void Insert(Frais_forfait unFrais_forfait)
        {
            string value = "'" + unFrais_forfait.Libelle + "'," + " '" + unFrais_forfait.Montant + "';";

            undbal.Insert("Fiche_frais", value);
        }

        public void Update(Frais_forfait unFrais_forfait)
        {
            string value = "'" + unFrais_forfait.Libelle + "'";
            string condition = "libelle =" + unFrais_forfait.Libelle;
            undbal.Update("Frais_forfait", value, condition);
        }

        public void Delete(Frais_forfait unFrais_forfait)
        {
            string condition = "'" + "libelle=" + "'" + unFrais_forfait.Libelle + "'";
            undbal.Delete("Frais_forfait", condition);

        }

        public List<Frais_forfait> SelectAll()
        {
            List<Frais_forfait> listFrais_forfait = new List<Frais_forfait>();
            DataTable myTable = undbal.SelectAll("Frais_forfait");

            foreach (DataRow r in myTable.Rows)
            {
                listFrais_forfait.Add(new Frais_forfait((string)r["libelle"], (double)r["montant"]));
            }
            return listFrais_forfait;
        }
    }
}
