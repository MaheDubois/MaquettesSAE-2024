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
        ObservableCollection<Couleur> lesCouleurs;
        public ApplicationData()
        {
            this.LesCouleurs = Couleur.Read();
            this.LesCouleurs.ToString();

        }

        public ObservableCollection<Couleur> LesCouleurs { get => lesCouleurs; set => lesCouleurs = value; }
    }
}
