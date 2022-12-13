using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOLigne_frais_hors_forfait
    {
        private Dbal undbal;


        public DAOLigne_frais_hors_forfait(Dbal unDbalLigne_frais_hors_forfait)
        {
            undbal = unDbalLigne_frais_hors_forfait;
        }



        public void Insert(Ligne_frais_hors_forfait unLigne_frais_hors_forfait)
        {
            string value = "'" + unLigne_frais_hors_forfait.Fichefrais_id + "'," + " '" + unLigne_frais_hors_forfait.Libelle +
                "'," + " '" + unLigne_frais_hors_forfait.Date + "'," + " '" + unLigne_frais_hors_forfait.Montant + "';";

            undbal.Insert("Ligne_frais_hors_forfait", value);
        }

        public void Update(Ligne_frais_hors_forfait unLigne_frais_hors_forfait)
        {
            string value = "'" + unLigne_frais_hors_forfait.Libelle + "'," + "'" + unLigne_frais_hors_forfait.Date + "'," + "'"
                + unLigne_frais_hors_forfait.Montant + "';";
            string condition = "Fichefrais_id =" + unLigne_frais_hors_forfait.Fichefrais_id + ";";
            undbal.Update("Ligne_frais_hors_forfait", value, condition);
        }

        public void Delete(Ligne_frais_hors_forfait unLigne_frais_hors_forfait)
        {
            string condition = "'" + "Ligne_frais_hors_forfait=" + "'" + unLigne_frais_hors_forfait + "';";
            undbal.Delete("Ligne_frais_hors_forfait", condition);

        }

        public List<Ligne_frais_hors_forfait> SelectAll()
        {
            List<Ligne_frais_hors_forfait> listLigne_frais_hors_forfait = new List<Ligne_frais_hors_forfait>();
            DataTable myTable = undbal.SelectAll("Lignes_frais_hors_forfait");

            foreach (DataRow r in myTable.Rows)
            {
                listLigne_frais_hors_forfait.Add(new Ligne_frais_hors_forfait((int)r["fichefrais_id"], (string)r["libelle"],
                    (DateTime)r["date"], (double)r["montant"]));
            }
            return listLigne_frais_hors_forfait;
        }

    }
}
