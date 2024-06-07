using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
        public double prixTotal = 0;
        public MainWindow()
        {

            PageConnexion pageConnexion = new PageConnexion();
            pageConnexion.ShowDialog();
            


            InitializeComponent();
            
           
            dgProduit.Items.Filter = Rechercher;

        }

        private bool Rechercher(object obj)
        {
            Produit unProduit = obj as Produit;
            if (String.IsNullOrEmpty(tb_Rechercher.Text) )
                return true;
            else
                return (unProduit.Nom_produit.StartsWith(tb_Rechercher.Text, StringComparison.OrdinalIgnoreCase));
        }

        private bool FiltrageCategorie(object obj)
        {
            Produit unProduit = obj as Produit;
            if (cb_FiltreCategorie.SelectedItem == null)
                return true;
            else
                return (unProduit.Num_categorie.ToString().StartsWith(tb_Rechercher.Text, StringComparison.OrdinalIgnoreCase));
        }

        private bool RechercherCouleur(object obj)
        {
            Produit unProduit = obj as Produit;
            if (String.IsNullOrEmpty(tb_Rechercher.Text))
                return true;
            else
                return (unProduit.Id_couleur.ToString().StartsWith(tb_Rechercher.Text, StringComparison.OrdinalIgnoreCase));
        }


    

        

        
        public void bt_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            AjouterProduitsSelectionne();

            
        }

        //public double CalculPrixTotal()
        //{
        //    double total =0;
        //    foreach (Produit produitPrix in lesProduitsCommande)
        //    {
        //        total = Produit.P
        //    }
        //}

        public void AjouterProduitsSelectionne()
        {
            
            if (dgProduit.SelectedItem != null)
            {

                Produit produitSelectionne = (Produit)dgProduit.SelectedItem;
                data.LesProduitsCommande.Add(produitSelectionne);
                MessageBox.Show("Produit ajouté: ");

                List<double> PrixT = new List<double>();
                double Prix = produitSelectionne.Prix_vente;
                PrixT.Add(Prix);
                
                foreach (double prix in PrixT)
                {
                    prixTotal += prix;
                    lb_Prix.Content = prixTotal + " euro(s)";
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit.");
                
            }
        }

        private void tb_Rechercher_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dgProduit.ItemsSource != null)            
               CollectionViewSource.GetDefaultView(dgProduit.ItemsSource).Refresh();
            
             
        }

        private void cb_FiltreType_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void cb_FiltreCouleur_Selected(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dgProduit.ItemsSource).Refresh();
        }

        private void cb_FiltreCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cb_FiltreCategorie.SelectedItem != null)
            {
                switch (cb_FiltreCategorie.SelectedItem)
                {
                    //case "Plantes":

                }
            }

        }




        //private void bt_ValiderVisu_Click(object sender, RoutedEventArgs e)
        //{
        //    ValiderCommande();
        //}

        //public void ValiderCommande()
        //{
        //    data.LesProduitsArchives.Add(data.LesProduitsCommande);
        //}
    }
}
