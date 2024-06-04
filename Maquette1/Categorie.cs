using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class Categorie
    {
        private int numCategorie;
        private int numType;
        private String libelleCategorie;

        public Categorie(int numCategorie, int numType, string libelleCategorie)
        {
            NumCategorie = numCategorie;
            NumType = numType;
            LibelleCategorie = libelleCategorie;
        }

        public int NumCategorie { get => numCategorie; set => numCategorie = value; }
        public int NumType { get => numType; set => numType = value; }
        public string LibelleCategorie { get => libelleCategorie; set => libelleCategorie = value; }

        public static ObservableCollection<Categorie> Read()
        {
            ObservableCollection<Categorie> lesCaracteristiques = new ObservableCollection<Categorie>();
            String sql = "SELECT * from botanic.Categorie";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                Categorie nouveau = new Categorie(int.Parse(res["num_categorie"].ToString()), int.Parse(res["num_type"].ToString()),
                res["libelle_categorie"].ToString());
                lesCaracteristiques.Add(nouveau);
            }
            return lesCaracteristiques;
        }
    }
   
}
