using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class ModeDeTransport
    {
        string mode_transport;

        public string Mode_transport { get => mode_transport; set => mode_transport = value; }

        public ModeDeTransport(string mode_transport)
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
            return mode_transport.ToString();
        }

        public static ObservableCollection<ModeDeTransport> Read()
        {
            ObservableCollection<ModeDeTransport> lesModeDeTransports = new ObservableCollection<ModeDeTransport>();
            String sql = "SELECT * from botanic.mode_de_transport";
            DataTable dt = DataAccess.Instance.GetData(sql);
            foreach (DataRow res in dt.Rows)
            {
                ModeDeTransport nouveau = new ModeDeTransport( res["Mode_transport"].ToString());
                lesModeDeTransports.Add(nouveau);
            }
            return lesModeDeTransports;
        }
    }
}
