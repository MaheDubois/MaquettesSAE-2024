using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

        public Couleur( string nom_couleur, int id_couleur)
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

        public static ObservableCollection<Couleur> Read()
        {
            ObservableCollection<Couleur> lesCouleurs = new ObservableCollection<Couleur>();
            String sql = "SELECT * from botanic.couleur";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Couleur nouveau = new Couleur(res["nom_couleur"].ToString(), int.Parse(res["id_couleur"].ToString()));
                lesCouleurs.Add(nouveau);
            }
            return lesCouleurs;
        }

    }
}
