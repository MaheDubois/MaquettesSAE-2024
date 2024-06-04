using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class DetailCaracteristique
    {
        int num_produit, num_caracteristique;
        string valeur_caracteristique;

        public int Num_produit { get => num_produit; set => num_produit = value; }
        public int Num_caracteristique { get => num_caracteristique; set => num_caracteristique = value; }
        public string Valeur_caracteristique { get => valeur_caracteristique; set => valeur_caracteristique = value; }

        public DetailCaracteristique(int num_produit, int num_caracteristique, string valeur_caracteristique)
        {
            Num_produit = num_produit;
            Num_caracteristique = num_caracteristique;
            Valeur_caracteristique = valeur_caracteristique;
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

        public static ObservableCollection<DetailCaracteristique> Read()
        {
            ObservableCollection<DetailCaracteristique> lesDetailsCaracteristiques = new ObservableCollection<DetailCaracteristique>();
            String sql = "SELECT * from botanic.detail_caracteristque";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                DetailCaracteristique nouveau = new DetailCaracteristique(int.Parse(res["num_produit"].ToString()), int.Parse(res["num_caracteristique"].ToString()), 
                res["valeur_caracteristique"].ToString());
                lesDetailsCaracteristiques.Add(nouveau);
            }
            return lesDetailsCaracteristiques;
        }
    }


}
