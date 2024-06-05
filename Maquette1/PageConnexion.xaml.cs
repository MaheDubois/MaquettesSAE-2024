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
    /// Logique d'interaction pour PageConnexion.xaml
    /// </summary>
    public partial class PageConnexion : Window
    {

        



        private bool seConnecter = false;

        public PageConnexion()
        {
            InitializeComponent();
        }

        public bool SeConnecter { get => seConnecter; set => seConnecter = value; }

        private void ButtonSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            SeConnecter = true;
            
        }
    }
}
