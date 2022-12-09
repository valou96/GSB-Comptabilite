using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class Ligne_frais_forfait
    {
        private int fichefrais_id;
        private int fraisforfait_id;
        private int quantite;

        public Ligne_frais_forfait(int fichefrais_id, 
            int fraisforfait_id, int quantite)
        {
            this.fichefrais_id = fichefrais_id;
            this.fraisforfait_id = fraisforfait_id;
            this.quantite = quantite;
        }

        public int Fichefrais_id { get => fichefrais_id; set => fichefrais_id = value; }
        public int Fraisforfait_id { get => fraisforfait_id; set => fraisforfait_id = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
