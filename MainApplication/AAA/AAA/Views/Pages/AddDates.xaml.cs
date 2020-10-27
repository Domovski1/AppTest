using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddDates.xaml
    /// </summary>
    public partial class AddDates : Page
    {
        TestBaseEnt _db = new TestBaseEnt();

        public AddDates()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "(*.jpg); (*.png)|*.jpg; *.png";
                if (file.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage(new Uri(file.FileName));
                    imgBox.Source = image;
                }


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString());
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mainTable dates = new mainTable();
                dates.Title = txtName.Text;
                dates.GroupID = int.Parse(txtGroup.Text);
                dates.Size = int.Parse(txtSize.Text);
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgBox.Source));
                encoder.Save(stream);
                dates.icon = stream.ToArray();

                _db.mainTable.Add(dates);
                _db.SaveChanges();
                MessageBox.Show("Данные были добавлены", "Выполнено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " Error");
            }
        }
    }
}
