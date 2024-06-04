using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Caracteristique
    {
        int num_caracteristique;
        string nom_caracteristique;

        public int Num_caracteristique { get => num_caracteristique; set => num_caracteristique = value; }
        public string Nom_caracteristique { get => nom_caracteristique; set => nom_caracteristique = value; }

        public Caracteristique(int num_caracteristique, string nom_caracteristique)
        {
            Num_caracteristique = num_caracteristique;
            Nom_caracteristique = nom_caracteristique;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
