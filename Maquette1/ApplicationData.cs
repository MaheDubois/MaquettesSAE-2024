using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class ApplicationData
    {

        //private ObservableCollection<Client> lesClients;
        private SqlConnection connexion = null;   // futur lien à la BD


        public ObservableCollection<Client> LesClients
        {
            get
            {
                return this.lesClients;
            }

            set
            {
                this.lesClients = value;
            }
        }

        public SqlConnection Connexion
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

            this.ConnexionBD();
            this.Read();
        }
        public void ConnexionBD()
        {
            try
            {
                Connexion = new SqlConnection();
                Connexion.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\S2\R2_02_IHM_WPF\TD3_Binding_BD\P1_BD_Locale\BD_Clients.mdf;Integrated Security=True";
                // à compléter dans les ""
                // @ sert à enlever tout pb avec les caractères
                Connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("pb de connexion : " + e);
                // juste pour le debug : à transformer en MsgBox
            }
        }


        //public void Read()
        //{
        //    this.LesClients = new ObservableCollection<Client>();
        //}

        public int Read()
        {
            this.LesClients = new ObservableCollection<Client>();
            String sql = "SELECT id, nom,prenom,email,genre,telephone, dateNaissance FROM Client";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                foreach (DataRow res in dataTable.Rows)
                {
                    Client nouveau = new Client(int.Parse(res["id"].ToString()),
                    res["nom"].ToString(), res["prenom"].ToString(),
                    res["email"].ToString(), DateTime.Parse(res["dateNaissance"].ToString()),
                    res["telephone"].ToString(),
                    (GenreClient)char.Parse(res["genre"].ToString()));
                    LesClients.Add(nouveau);
                }
                return dataTable.Rows.Count;
            }
            catch (SqlException e)
            { Console.WriteLine("pb de requete : " + e); return 0; }
        }
        public int Create(Client c)
        {
            int nb;
            String sql = $"insert into client (nom,prenom,email,genre,telephone, dateNaissance)"
            + $" values ('{c.Nom}','{c.Prenom}','{c.Email}'"
            + $",'{(char)c.Genre}','{c.Telephone}', "
            + $"'{c.DateNaissance.Year}-{c.DateNaissance.Month}-{c.DateNaissance.Day}'); ";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connexion);
                nb = cmd.ExecuteNonQuery();
                return nb;
                //nb permet de connaître le nb de lignes affectées par un insert, update, delete
            }
            catch (Exception sqlE)
            {
                Console.WriteLine("pb de requete : " + sql + "" + sqlE);
                // juste pour le debug : à transformer en MsgBox
                return 0;
            }
        }
        public void DeconnexionBD()
        {
            try
            {
                Connexion.Close();
            }
            catch (Exception e)
            { Console.WriteLine("pb à la déconnexion : " + e); }
        }


    }
}
