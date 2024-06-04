using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    internal class Categorie
    {
        private int numCategorie;
        private int numType;
        private String libelleCategorie;

        public Categorie(int numCategorie, int numType, string libelleCategorie)
        {
            NumCategorie = numCategorie;
            NumType = numType;
            LibelleCategorie = libelleCategorie;
        }

        public int NumCategorie { get => numCategorie; set => numCategorie = value; }
        public int NumType { get => numType; set => numType = value; }
        public string LibelleCategorie { get => libelleCategorie; set => libelleCategorie = value; }
    }
}
