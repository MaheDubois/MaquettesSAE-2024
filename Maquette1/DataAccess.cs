using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Maquette1
{
    public class DataAccess
    {
        public static DataAccess instance;
        public string mdp = "";
        public string user = "";
        
        public DataAccess()
        {
            ConnexionBD();
        }

        public static DataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccess();
                }
                return instance;
            }
        }

        public NpgsqlConnection? Connexion
        {
            get;
            set;
        }
        public void ConnexionBD()
        {
           string strConnexion = "Host= srv-peda-new;Port=5433;Database=BotanicTP11;Username="+user+";Password="+mdp+";Persist Security Info=True";
            
            try
            {
                Connexion = new NpgsqlConnection();
                Connexion.ConnectionString = strConnexion;
                Connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("pb de connexion : " + e);
                // juste pour le debug : à transformer en MsgBox
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

        public DataTable GetData(string selectSQL)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(selectSQL, Connexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("pb avec : " + selectSQL + e.ToString());
                return null;
            }
        }
        public int SetData(string setSQL)
        {

            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand(setSQL, Connexion);
                int nbLines = sqlCommand.ExecuteNonQuery();
                return nbLines;
            }
            catch (Exception e)
            {
                Console.WriteLine("pb avec : " + setSQL + e.ToString());
                return 0;
            }
        }

    }

    

}
