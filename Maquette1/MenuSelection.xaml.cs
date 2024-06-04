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
    /// Logique d'interaction pour MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : Page
    {
        public MenuSelection()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataAccess dataAccess = DataAccess.Instance;
                DataTable dataTable = dataAccess.GetData("SELECT * FROM botanic.fournisseur");

                if (dataTable != null)
                {
                    dataGrid.ItemsSource = dataTable.DefaultView;
                }
                else
                {
                    MessageBox.Show("No data returned from the query.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
