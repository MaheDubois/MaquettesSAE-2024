using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class modeDeTransport
    {
        string mode_transport;

        public string Mode_transport { get => mode_transport; set => mode_transport = value; }

        public modeDeTransport(string mode_transport)
        {
            Mode_transport = mode_transport;
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
