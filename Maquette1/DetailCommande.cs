using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class DetailCommande
    {
        int num_commande, num_produit, num_fournisseur, quantite_commandee;

        public int Num_commande { get => num_commande; set => num_commande = value; }
        public int Num_produit { get => num_produit; set => num_produit = value; }
        public int Num_fournisseur { get => num_fournisseur; set => num_fournisseur = value; }
        public int Quantite_commandee { get => quantite_commandee; set => quantite_commandee = value; }

        public DetailCommande(int num_commande, int num_produit, int num_fournisseur, int quantite_commandee)
        {
            Num_commande = num_commande;
            Num_produit = num_produit;
            Num_fournisseur = num_fournisseur;
            Quantite_commandee = quantite_commandee;
        }

        public static ObservableCollection<DetailCommande> Read()
        {
            ObservableCollection<DetailCommande> lesDetailsCommandes = new ObservableCollection<DetailCommande>();
            String sql = "SELECT * FROM botanic.detail_commande";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                DetailCommande nouveau = new DetailCommande(int.Parse(res["num_commande"].ToString()), int.Parse(res["num_produit"].ToString()), int.Parse(res["num_fournisseur"].ToString()), int.Parse(res["quantite_commandee"].ToString()));
                lesDetailsCommandes.Add(nouveau);
            }
            return lesDetailsCommandes;
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
