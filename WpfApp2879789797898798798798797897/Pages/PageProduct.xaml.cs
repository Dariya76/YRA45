using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp2879789797898798798798797897.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public PageProduct()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
            ConnectOdb.ConObj.Provider.Load();
            gridList.ItemsSource = ConnectOdb.ConObj.Product.ToList();

        }

        private void UpdateData(object sender, EventArgs e)
        {
            var HistoryProduct = ConnectOdb.ConObj.Product.ToList();
            ListProduct.ItemsSource = HistoryProduct;
            ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Where(x => x.name.StartsWith(TxtSearch.Text)).ToList();
            ConnectOdb.ConObj.Manufacturer.Load();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditNew((sender as Button).DataContext as Product));
        }
        private void RbDown_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            gridList.ItemsSource = ConnectOdb.ConObj.Product.OrderByDescending(x => x.name).ToList();
        }

        private void RbUp_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            gridList.ItemsSource = ConnectOdb.ConObj.Product.OrderBy(x => x.name).ToList();
        }
    }
}
