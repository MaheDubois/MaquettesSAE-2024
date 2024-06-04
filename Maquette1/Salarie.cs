using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Salarie
    {
        int numsalarie;
        string login_salarie, mdp_salarie;

        public int Numsalarie { get => numsalarie; set => numsalarie = value; }
        public string Login_salarie { get => login_salarie; set => login_salarie = value; }
        public string Mdp_salarie { get => mdp_salarie; set => mdp_salarie = value; }

        public Salarie(int numsalarie, string login_salarie, string mdp_salarie)
        {
            Numsalarie = numsalarie;
            Login_salarie = login_salarie;
            Mdp_salarie = mdp_salarie;
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

        public static ObservableCollection<Salarie> Read()
        {
            ObservableCollection<Salarie> lesSalaries = new ObservableCollection<Salarie>();
            String sql = "SELECT num_salarie, login_salarie, mdp_salarie FROM botanic.salarie";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Salarie nouveau = new Salarie(int.Parse(res["num_salarie"].ToString()), res["login_salarie"].ToString(),
                res["mdp_salarie"].ToString());
                lesSalaries.Add(nouveau);
            }
            return lesSalaries;
        }
    }

  



}
