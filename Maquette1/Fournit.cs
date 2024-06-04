using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Fournit
    {
        int num_fournisseur, num_produit;
        double prix_achat;

        public int Num_fournisseur { get => num_fournisseur; set => num_fournisseur = value; }
        public int Num_produit { get => num_produit; set => num_produit = value; }
        public double Prix_achat { get => prix_achat; set => prix_achat = value; }

        public Fournit(int num_fournisseur, int num_produit, double prix_achat)
        {
            Num_fournisseur = num_fournisseur;
            Num_produit = num_produit;
            Prix_achat = prix_achat;
        }

        public static ObservableCollection<Fournit> Read()
        {
            ObservableCollection<Fournit> lesFournits = new ObservableCollection<Fournit>();
            String sql = "SELECT num_fournisseur, num_produit, prix_achat FROM botanic.fournit";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Fournit nouveau = new Fournit(int.Parse(res["num_fournisseur"].ToString()), int.Parse(res["num_produit"].ToString()),
                double.Parse(res["prix_achat"].ToString()));
                lesFournits.Add(nouveau);
            }
            return lesFournits;
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
