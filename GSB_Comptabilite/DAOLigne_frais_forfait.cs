using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOLigne_frais_forfait
    {
        private Dbal undbal;


        public DAOLigne_frais_forfait(Dbal undbalLigne_frais_forfait)
        {
            undbal = undbalLigne_frais_forfait;
        }



        public void Insert(Ligne_frais_forfait unLigne_frais_forfait)
        {
            string value = "'" + unLigne_frais_forfait.Fichefrais_id + "'," + " '" + unLigne_frais_forfait.Fraisforfait_id +
                "'," + " '" + unLigne_frais_forfait.Quantite + "';";

            undbal.Insert("Ligne_frais_forfait", value);
        }

        public void Update(Ligne_frais_forfait unLigne_frais_forfait)
        {
            string value = "'" + unLigne_frais_forfait.Quantite + "'";
            string condition = "libelle =" + unLigne_frais_forfait.Fichefrais_id;
            undbal.Update("Ligne_frais_forfait", value, condition);
        }

        public void Delete(Ligne_frais_forfait unLigne_frais_forfait)
        {
            string condition = "'" + "libelle=" + "'" + unLigne_frais_forfait.Fichefrais_id + "'";
            undbal.Delete("Ligne_frais_forfait", condition);

        }

        public List<Ligne_frais_forfait> SelectAll()
        {
            List<Ligne_frais_forfait> listLigne_frais_forfait = new List<Ligne_frais_forfait>();
            DataTable myTable = undbal.SelectAll("Ligne_frais_forfait");

            foreach (DataRow r in myTable.Rows)
            {
                listLigne_frais_forfait.Add(new Ligne_frais_forfait((int)r["Fichefrais_id"], (int)r["fraisforfait_id"],
                    (int)r["quantite"]));
            }
            return listLigne_frais_forfait;
        }

    }
}
