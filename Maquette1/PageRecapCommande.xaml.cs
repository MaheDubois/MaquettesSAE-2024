using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Maquette1
{
    /// <summary>
    /// Logique d'interaction pour PageRecapCommande.xaml
    /// </summary>
    public partial class PageRecapCommande : Window
    {
        public string NomMagasin;
        private bool seConnecter = false;
        public PageRecapCommande()
        {
            InitializeComponent();
         PageConnexion pageConnexion = new PageConnexion();
            //NomMagasin = pageConnexion.tb_NomMagasin.Text;
        }
        private void ButtonSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            seConnecter = true;
        }

    }
}
