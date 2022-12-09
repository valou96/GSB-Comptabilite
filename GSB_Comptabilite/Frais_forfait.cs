using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    internal class Frais_forfait
    {
        private string libelle;
        private double montant;

        public Frais_forfait(string libelle, double montant)
        {
            this.libelle = libelle;
            this.montant = montant;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public double Montant { get => montant; set => montant = value; }
    }
}
