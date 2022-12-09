using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class ligne_frais_hors_forfait
    {
        private int fichefrais_id;
        private string libelle;
        private DateTime date;
        private double montant;

        public ligne_frais_hors_forfait(int fichefrais_id, 
            string libelle, DateTime date, double montant)
        {
            this.fichefrais_id = fichefrais_id;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
        }

        public int Fichefrais_id { get => fichefrais_id; set => fichefrais_id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Montant { get => montant; set => montant = value; }
    }
}
