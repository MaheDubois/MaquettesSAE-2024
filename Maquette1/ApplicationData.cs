using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Npgsql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class ApplicationData
    {

        //private ObservableCollection<Client> lesClients;
        private NpgsqlConnection connexion = null;   // futur lien à la BD

        private ObservableCollection<Salarie> lesSalaries;

        public ObservableCollection<Salarie> LesSalaries
        {
            get
            {
                return this.lesSalaries;
            }

            set
            {
                this.lesSalaries = value;
            }
        }

        private ObservableCollection<Produit> lesProduits;

        public ObservableCollection<Produit> LesProduits
        {
            get
            {
                return this.lesProduits;
            }

            set
            {
                this.lesProduits = value;
            }
        }



        public NpgsqlConnection Connexion
        {
            get
            {
                return this.connexion;
            }

            set
            {
                this.connexion = value;
            }
        }

        public ApplicationData()
        {

            
           
        }



        //public void Read()
        //{
        //    this.LesClients = new ObservableCollection<Client>();
        //}

        //public int Read()
        //{
        //    this.LesClients = new ObservableCollection<Client>();
        //    String sql = "SELECT id, nom,prenom,email,genre,telephone, dateNaissance FROM Client";
        //    try
        //    {
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connexion);
        //        DataTable dataTable = new DataTable();
        //        dataAdapter.Fill(dataTable);
        //        foreach (DataRow res in dataTable.Rows)
        //        {
        //            Client nouveau = new Client(int.Parse(res["id"].ToString()),
        //            res["nom"].ToString(), res["prenom"].ToString(),
        //            res["email"].ToString(), DateTime.Parse(res["dateNaissance"].ToString()),
        //            res["telephone"].ToString(),
        //            (GenreClient)char.Parse(res["genre"].ToString()));
        //            LesClients.Add(nouveau);
        //        }
        //        return dataTable.Rows.Count;
        //    }
        //    catch (SqlException e)
        //    { Console.WriteLine("pb de requete : " + e); return 0; }
        //}


        public int Read()
        {
            String sql = "SELECT * from salarie";
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                foreach (DataRow res in dataTable.Rows)
                {
                    Salarie nouveau = new Salarie(int.Parse(res["num_salarie"].ToString()),
                    res["login_salarie"].ToString(), res["mdp_salarie"].ToString());
                    LesSalaries.Add(nouveau);
                }
                return dataTable.Rows.Count;
            }
            catch (NpgsqlException e)
            { Console.WriteLine("pb de requete : " + e); return 0; }
        }
    }
}
