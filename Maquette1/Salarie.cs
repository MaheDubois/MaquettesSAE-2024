using System;
using System.Collections.Generic;
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

        
    }

  



}
