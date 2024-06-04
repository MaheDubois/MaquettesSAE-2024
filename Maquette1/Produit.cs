using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Produit
    {
        int num_produit, num_categorie;
        string nom_produit, taille_produit, description_produit;
        double prix_vente;

        public int Num_produit { get => num_produit; set => num_produit = value; }
        public int Num_categorie { get => num_categorie; set => num_categorie = value; }
        public string Nom_produit { get => nom_produit; set => nom_produit = value; }
        public string Taille_produit { get => taille_produit; set => taille_produit = value; }
        public string Description_produit { get => description_produit; set => description_produit = value; }
        public double Prix_vente { get => prix_vente; set => prix_vente = value; }

        public Produit(int num_produit, int num_categorie, string nom_produit, string taille_produit, string description_produit, double prix_vente)
        {
            Num_produit = num_produit;
            Num_categorie = num_categorie;
            Nom_produit = nom_produit;
            Taille_produit = taille_produit;
            Description_produit = description_produit;
            Prix_vente = prix_vente;
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


        public int Read()
        {
            String sql = "SELECT * from Produit";
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                foreach (DataRow res in dataTable.Rows)
                {
                    Salarie nouveau = new Produit(int.Parse(res["num_produit"].ToString()),
                    int.Parse(res["num_categorie"].ToString(), res["nom_produit"].ToString());
                    LesProduits.Add(nouveau);
                }
                return dataTable.Rows.Count;
            }
            catch (NpgsqlException e)
            { Console.WriteLine("pb de requete : " + e); return 0; }
        }
    }
}
