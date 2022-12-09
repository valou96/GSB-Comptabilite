using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class fiche_frais
    {
        private int user_id;
        private int etat_id;
        private string mois;
        private int nb_justificatifs;
        private double montant_valide;
        private DateTime date_modif;

        public fiche_frais(int user_id, int etat_id, string mois, 
            int nb_justificatifs, double montant_valide, 
            DateTime date_modif)
        {
            this.user_id = user_id;
            this.etat_id = etat_id;
            this.mois = mois;
            this.nb_justificatifs = nb_justificatifs;
            this.montant_valide = montant_valide;
            this.date_modif = date_modif;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public int Etat_id { get => etat_id; set => etat_id = value; }
        public string Mois { get => mois; set => mois = value; }
        public int Nb_justificatifs { get => nb_justificatifs; set => nb_justificatifs = value; }
        public double Montant_valide { get => montant_valide; set => montant_valide = value; }
        public DateTime Date_modif { get => date_modif; set => date_modif = value; }
    }
}
