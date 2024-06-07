using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maquette1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();
            //dgProduits.Items.Filter = Rechercher;
            Couleur.Read();
        }

        private bool Rechercher(object obj)
        {
            Produit unProduit = obj as Produit;
            if (String.IsNullOrEmpty(tb_Rechercher.Text))
                return true;
            else
                return (unProduit.Nom_produit.StartsWith(tb_Rechercher.Text, StringComparison.OrdinalIgnoreCase));
        }

        

        private void cb_FiltreType_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Ajouter_Click()
        {

        }

        private void tb_Rechercher_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           // CollectionViewSource.GetDefaultView(dgProduits.ItemsSource).Refresh();
        }
    }
}
