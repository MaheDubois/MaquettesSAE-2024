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
            Console.WriteLine(Couleur.Read());
            //LoadData();
            //PageConnexion fenetreConnexion = new PageConnexion();
            //fenetreConnexion.ShowDialog();
            //if (fenetreConnexion.DialogResult == false)
            //{
            //    System.Windows.Application.Current.Shutdown();
            //}

            //PageRecapCommande fenetreCommmande = new PageRecapCommande();
            //fenetreCommmande.ShowDialog();
            //if (fenetreCommmande.DialogResult == false)
            //{
            //    System.Windows.Application.Current.Shutdown();
            //}
        }

        //private void LoadData()
        //{
        //    try
        //    {
        //        DataAccess dataAccess = DataAccess.Instance;
        //        Console.WriteLine("Attempting to retrieve data...");
        //        DataTable dataTable = dataAccess.GetData("SELECT * FROM YourTableName");

        //        if (dataTable != null && dataTable.Rows.Count > 0)
        //        {
        //            Console.WriteLine("Data retrieved successfully.");
        //            dataGrid.ItemsSource = dataTable.DefaultView;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No data returned from the query.");
        //            Console.WriteLine("DataTable is null or has no rows.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading data: " + ex.Message);
        //        Console.WriteLine("Error loading data: " + ex.Message);
        //    }
        //}
    }
}
