using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class TypeProduit
    {
        int num_type;
        string designation_type;

        public int Num_type { get => num_type; set => num_type = value; }
        public string Designation_type { get => designation_type; set => designation_type = value; }

        public TypeProduit(int num_type, string designation_type)
        {
            this.Num_type = num_type;
            this.Designation_type = designation_type;
        }

        public static ObservableCollection<TypeProduit> Read()
        {
            ObservableCollection<TypeProduit> lesTypeProduit = new ObservableCollection<TypeProduit>();
            String sql = "SELECT num_type,designation_type FROM botanic.TypeProduit";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                TypeProduit nouveau = new TypeProduit(int.Parse(res["num_type"].ToString()),
                res["designation_type"].ToString());
                lesTypeProduit.Add(nouveau);
            }
            return lesTypeProduit;
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
