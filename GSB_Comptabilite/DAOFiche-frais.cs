using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class DAOFiche_frais
    {

        private Dbal undbal;


        public DAOFiche_frais(Dbal undbalFiche_frais)
        {
            undbal = undbalFiche_frais;
        }



        public void Insert(Fiche_frais unFiche_frais)
        {
            string value = "'" + unFiche_frais.User_id + "'," + " '" + unFiche_frais.Etat_id + "',"+ " '" + unFiche_frais.Mois +
                "'," + " '" + unFiche_frais.Nb_justificatifs + "'," + " '" + unFiche_frais.Montant_valide + "'," + " '" + 
                unFiche_frais.Date_modif + "';";

            undbal.Insert("Fiche_frais", value);
        }

        public void Delete(Fiche_frais unFiche_frais)
        {
            string condition = "'" + "User_id =" + "'" + unFiche_frais.User_id + "';";
            undbal.Delete("Fiche_frais", condition);

        }

        public List<Fiche_frais> SelectAll()
        {
            List<Fiche_frais> listFiche_frais = new List<Fiche_frais>();
            DataTable myTable = undbal.SelectAll("Fiche_frais");

            foreach (DataRow r in myTable.Rows)
            {
                listFiche_frais.Add(new Fiche_frais((int)r["user_id"], (int)r["etat_id"], (string)r["mois"],
                    (int)r["nb_justificatifs"], (double)r["montant_valide"], (DateTime)r["date_modif"]));
            }
            return listFiche_frais;
        }
    }
}
