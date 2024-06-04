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

        //public ObservableCollection<Client> LesClients
        //{
        //    get
        //    {
        //        return this.lesClients;
        //    }

        //    set
        //    {
        //        this.lesClients = value;
        //    }
        //}

    

        public ApplicationData()
        {

         }



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
            //public int Create(Client c)
            //{
            //    int nb;
            //    String sql = $"insert into client (nom,prenom,email,genre,telephone, dateNaissance)"
            //    + $" values ('{c.Nom}','{c.Prenom}','{c.Email}'"
            //    + $",'{(char)c.Genre}','{c.Telephone}', "
            //    + $"'{c.DateNaissance.Year}-{c.DateNaissance.Month}-{c.DateNaissance.Day}'); ";
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand(sql, Connexion);
            //        nb = cmd.ExecuteNonQuery();
            //        return nb;
            //        //nb permet de connaître le nb de lignes affectées par un insert, update, delete
            //    }
            //    catch (Exception sqlE)
            //    {
            //        Console.WriteLine("pb de requete : " + sql + "" + sqlE);
            //        // juste pour le debug : à transformer en MsgBox
            //        return 0;
            //    }
            //}
            
           

        public int Read()
        {
            String sql = "SELECT * from salarie";
            try
            {
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
