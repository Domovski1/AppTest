using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AAA.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для DatesPage.xaml
    /// </summary>
    public partial class DatesPage : Page
    {
        TestBaseEnt _db = new TestBaseEnt();
        public DatesPage()
        {
            InitializeComponent();
            ShowList.ItemsSource = _db.mainTable.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить данные. Востановление будет невозможно", "ВНИМАНИЕ", MessageBoxButton.YesNo);
                
                if (result == MessageBoxResult.Yes)
                {
                    int id = (ShowList.SelectedItem as mainTable).ID;
                    var delete = _db.mainTable.Where(m => m.ID == id).Single();
                    _db.mainTable.Remove(delete);
                    _db.SaveChanges();

                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, ex.Source + " Error");
                
            }

            ShowList.ItemsSource = _db.mainTable.ToList();
        }

    }
}
