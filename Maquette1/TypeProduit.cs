using System;
using System.Collections.Generic;
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
            Num_type = num_type;
            Designation_type = designation_type;
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
