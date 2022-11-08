using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp2879789797898798798798797897.BD;

namespace WpfApp2879789797898798798798797897.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {
        public PageEditNew(Product product)
        {
            InitializeComponent();
            comboBox2.SelectedIndex = (int)product.manufacturer2 - 1;
            comboBox2.SelectedValuePath = "ID";
            comboBox2.DisplayMemberPath = "Manufacturer1";
            comboBox2.ItemsSource = ConnectOdb.ConObj.Manufacturer.ToList();


            comboBox3.SelectedIndex = (int)product.provider2 - 1;
            comboBox3.SelectedValuePath = "ID";
            comboBox3.DisplayMemberPath = "provider1";
            comboBox3.ItemsSource = ConnectOdb.ConObj.Provider.ToList();



            ProductObj.article_number = product.article_number;

            articleTX.Text = product.article_number;
            titleTX.Text = product.name;
            StoimTX.Text = Convert.ToString(product.stroimost);
            MaxSkdTX.Text = Convert.ToString(product.max_discount);
            descTX.Text = product.description;
            StringImage.Text = product.photo;


        }

        private void saveAddBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<Product> products = ConnectOdb.ConObj.Product.Where(x => x.article_number == ProductObj.article_number).AsEnumerable().
            Select(x =>
            {
                x.article_number = articleTX.Text;
                x.name = titleTX.Text;
                x.stroimost = Convert.ToInt32(StoimTX.Text);
                x.max_discount = Convert.ToInt32(MaxSkdTX.Text);
                x.description = descTX.Text;

                if (string.IsNullOrWhiteSpace(StringImage.Text))
                {
                    x.photo = "../Resources/logo.png";
                }
                else
                {
                    x.photo = StringImage.Text;
                }


                return x;
            });

                foreach (Product product in products)
                {
                    ConnectOdb.ConObj.Entry(product).State = System.Data.Entity.EntityState.Modified;
                }

                ConnectOdb.ConObj.SaveChanges();
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameObj.MainFrame.Navigate(new PageProduct());
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }
    }
}
