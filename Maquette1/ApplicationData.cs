using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Npgsql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using System.Windows;

namespace Maquette1
{
    public class ApplicationData
    {
        ObservableCollection<Couleur> lesCouleurs;
        ObservableCollection<Caracteristique> lesCaracteristiques;
        ObservableCollection<Categorie> lesCategories;
        ObservableCollection<CommandeAchat> lesCommandes_achat;
        ObservableCollection<DetailCaracteristique> lesDetailsCaracteristiques;
        ObservableCollection<DetailCommande> lesDetailsCommandes;
        ObservableCollection<Fournisseur> lesFournisseurs;
        ObservableCollection<Fournit> lesFournits;
        ObservableCollection<Magasin> lesMagasins;
        ObservableCollection<ModeDeTransport> lesModesTransports;
        ObservableCollection<Produit> lesProduits;
        ObservableCollection<Salarie> lesSalaries;
        ObservableCollection<TypeProduit> lesTypesProduits;
        ObservableCollection<Produit> lesProduitsCommande = new ObservableCollection<Produit>();
        ObservableCollection<Produit> lesProduitsArchives = new ObservableCollection<Produit>();
        public ApplicationData()
        {
            
            this.LesCouleurs = Couleur.Read();
            this.LesCouleurs.ToString();

            this.LesCaracteristiques = Caracteristique.Read();
            this.LesCaracteristiques.ToString();

            this.LesCategories = Categorie.Read();
            this.LesCategories.ToString();

            this.LesCommandes_achat = CommandeAchat.Read();
            this.LesCommandes_achat.ToString();

            this.LesDetailsCaracteristiques = DetailCaracteristique.Read();
            this.LesDetailsCaracteristiques.ToString();

            this.LesDetailsCommandes = DetailCommande.Read();
            this.LesDetailsCommandes.ToString();

            this.LesFournisseurs = Fournisseur.Read();
            this.LesFournisseurs.ToString();

            this.LesFournits = Fournit.Read();
            this.LesFournits.ToString();

            this.LesMagasins = Magasin.Read();
            this.LesMagasins.ToString();

            this.LesModesTransports = ModeDeTransport.Read();
            this.LesModesTransports.ToString();

            this.LesProduits = Produit.Read();
            this.LesProduits.ToString();

            this.LesSalaries = Salarie.Read();
            this.LesSalaries.ToString();

            this.LesTypesProduits = TypeProduit.Read();
            this.LesTypesProduits.ToString();

            

        }

        public ObservableCollection<Couleur> LesCouleurs { get => lesCouleurs; set => lesCouleurs = value; }
        public ObservableCollection<Caracteristique> LesCaracteristiques { get => lesCaracteristiques; set => lesCaracteristiques = value; }
        public ObservableCollection<Categorie> LesCategories { get => lesCategories; set => lesCategories = value; }
        public ObservableCollection<CommandeAchat> LesCommandes_achat { get => lesCommandes_achat; set => lesCommandes_achat = value; }
        public ObservableCollection<DetailCaracteristique> LesDetailsCaracteristiques { get => lesDetailsCaracteristiques; set => lesDetailsCaracteristiques = value; }
        public ObservableCollection<DetailCommande> LesDetailsCommandes { get => lesDetailsCommandes; set => lesDetailsCommandes = value; }
        public ObservableCollection<Fournisseur> LesFournisseurs { get => lesFournisseurs; set => lesFournisseurs = value; }
        public ObservableCollection<Fournit> LesFournits { get => lesFournits; set => lesFournits = value; }
        public ObservableCollection<ModeDeTransport> LesModesTransports { get => lesModesTransports; set => lesModesTransports = value; }
        public ObservableCollection<Produit> LesProduits { get => lesProduits; set => lesProduits = value; }
        public ObservableCollection<Salarie> LesSalaries { get => lesSalaries; set => lesSalaries = value; }
        public ObservableCollection<TypeProduit> LesTypesProduits { get => lesTypesProduits; set => lesTypesProduits = value; }
        public ObservableCollection<Produit> LesProduitsCommande { get => lesProduitsCommande; set => lesProduitsCommande = value; }
        public ObservableCollection<Magasin> LesMagasins { get => lesMagasins; set => lesMagasins = value; }
        public ObservableCollection<Produit> LesProduitsArchives { get => lesProduitsArchives; set => lesProduitsArchives = value; }
    }
}
