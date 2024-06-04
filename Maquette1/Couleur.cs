using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Couleur
    {
        int id_couleur;
        string nom_couleur;

        public int Id_couleur { get => id_couleur; set => id_couleur = value; }
        public string Nom_couleur { get => nom_couleur; set => nom_couleur = value; }

        public Couleur(int id_couleur, string nom_couleur)
        {
            Id_couleur = id_couleur;
            Nom_couleur = nom_couleur;
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
