using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{

    internal class Magasin
    {
        private int numMagagasin;
        private string nomMagasin;
        private string rue;
        private string cP;
        private string ville;
        private string horaire;

        public int NumMagagasin { get => numMagagasin; set => numMagagasin = value; }
        public string NomMagasin { get => nomMagasin; set => nomMagasin = value; }
        public string Rue { get => rue; set => rue = value; }
        public string CP { get => cP; set => cP = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Horaire { get => horaire; set => horaire = value; }

        public Magasin(int numMagagasin, string nomMagasin, string rue, string cP, string ville, string horaire)
        {
            this.NumMagagasin = numMagagasin;
            this.NomMagasin = nomMagasin;
            this.Rue = rue;
            this.CP = cP;
            this.Ville = ville;
            this.Horaire = horaire;
        }


        

    }
}
