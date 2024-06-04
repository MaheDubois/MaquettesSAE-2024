using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Fournisseur
    {
        int num_fournisseur;
        string nom_founisseur;
        bool code_local;

        public int Num_fournisseur { get => num_fournisseur; set => num_fournisseur = value; }
        public string Nom_founisseur { get => nom_founisseur; set => nom_founisseur = value; }
        public bool Code_local { get => code_local; set => code_local = value; }

        public Fournisseur(int num_fournisseur, string nom_founisseur, bool code_local)
        {
            Num_fournisseur = num_fournisseur;
            Nom_founisseur = nom_founisseur;
            Code_local = code_local;
        }

        public static ObservableCollection<Fournisseur> Read()
        {
            ObservableCollection<Fournisseur> lesFournisseurs = new ObservableCollection<Fournisseur>();
            String sql = "SELECT num_fournisseur, nom_fournisseur, code_local FROM botanic.fournisseur";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Fournisseur nouveau = new Fournisseur(int.Parse(res["num_fournisseur"].ToString()), res["nom_fournisseur"].ToString(),
                bool.Parse(res["code_local"].ToString()));
                lesFournisseurs.Add(nouveau);
            }
            return lesFournisseurs;
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
