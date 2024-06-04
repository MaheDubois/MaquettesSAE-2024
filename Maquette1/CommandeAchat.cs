using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class CommandeAchat
    {
        int num_commande;
        string date_commande;
        string date_livraison;

        public int Num_commande { get => num_commande; set => num_commande = value; }
        public string Date_commande { get => date_commande; set => date_commande = value; }
        public string Date_livraison { get => date_livraison; set => date_livraison = value; }

        public CommandeAchat(int num_commande, string date_commande, string date_livraison)
        {
            Num_commande = num_commande;
            Date_commande = date_commande;
            Date_livraison = date_livraison;
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

        public static ObservableCollection<CommandeAchat> Read()
        {
            ObservableCollection<CommandeAchat> lesCommandesAchats = new ObservableCollection<CommandeAchat>();
            String sql = "SELECT * from botanic.commande_achat";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                CommandeAchat nouveau = new CommandeAchat(int.Parse(res["num_commande"].ToString()),
                res["date_commande"].ToString(), res["date_livraison"].ToString());
                lesCommandesAchats.Add(nouveau);
            }
            return lesCommandesAchats;
        }
    }
}
