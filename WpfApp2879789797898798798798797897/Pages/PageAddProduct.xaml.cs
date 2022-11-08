using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2879789797898798798798797897.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        public PageAddProduct()
        {
            InitializeComponent();
            ConnectOdb.ConObj.Manufacturer.Load();
            comboBox2.ItemsSource = ConnectOdb.ConObj.Manufacturer.Local;
            ConnectOdb.ConObj.Provider.Load();
            comboBox3.ItemsSource = ConnectOdb.ConObj.Provider.Local;

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditNew((sender as Button).DataContext as Product));
        }
    }
}
