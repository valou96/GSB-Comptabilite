using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Comptabilite
{
    public class Etat
    {
        private string libelle;

        public Etat(string libelle)
        {
            this.libelle = libelle;
        }

        public string Libelle { get => libelle; set => libelle = value; }
    }



}
