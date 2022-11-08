using System.Windows;
using System.Windows.Controls;

namespace WpfApp2879789797898798798798797897.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3Admin.xaml
    /// </summary>
    public partial class Page3Admin : Page
    {
        public Page3Admin(object DataContext)
        {
            InitializeComponent();
            adminTX.Text = (string)DataContext;
        }

        private void BtnTovar_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageProduct());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageAddProduct());
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageClientSpisok());
        }
    }
}
