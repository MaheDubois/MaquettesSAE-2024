using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

        public static ObservableCollection<Caracteristique> Read()
        {
            ObservableCollection<Caracteristique> lesCaracteristiques = new ObservableCollection<Caracteristique>();
            String sql = "SELECT * from botanic.caracteristique";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Caracteristique nouveau = new Caracteristique(int.Parse(res["num_caracteristique"].ToString()), res["nom_caracteristique"].ToString());
                lesCaracteristiques.Add(nouveau);
            }
            return lesCaracteristiques;
        }
    }
}
