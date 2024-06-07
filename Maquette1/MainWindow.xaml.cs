﻿using System;
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
            //dgProduit.Items.Filter = Rechercher;
            
        }

        //private bool Rechercher(object obj)
        //{
        //    Produit unProduit = obj as Produit;
        //    if (String.IsNullOrEmpty(tb_Rechercher.Text))
        //        return true;
        //    else
        //        return (unProduit.Nom_produit.StartsWith(tb_Rechercher.Text, StringComparison.OrdinalIgnoreCase));
        //}

        

        
        public void bt_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            AjouterProduitsSelectionne();

            
        }

        

        public void AjouterProduitsSelectionne()
        {

            if (dgProduit.SelectedItem != null)
            {
                Produit produitSelectionne = (Produit)dgProduit.SelectedItem;
                data.LesProduitsCommande.Add(produitSelectionne);


                MessageBox.Show("Produit ajouté: ");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit.");
            }
        }

        //private void tb_Rechercher_TextChanged(object sender, TextChangedEventArgs e)
        //{
            
        //   CollectionViewSource.GetDefaultView(dgProduit.ItemsSource).Refresh();
        //}

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
