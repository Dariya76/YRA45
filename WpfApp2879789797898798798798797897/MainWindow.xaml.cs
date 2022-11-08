using System;
using System.Windows;
using WpfApp2879789797898798798798797897.Pages;

namespace WpfApp2879789797898798798798797897
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectOdb.ConObj = new det_houseEntities();
            FrameObj.MainFrame = frmMain;
            frmMain.Navigate(new PageAvtoriz());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Не, ну ты реально хочешь закрыть окно?", "закрытие приложения", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void frmMain_ContentRendered(object sender, EventArgs e)
        {
            if (frmMain.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.GoBack();

        }
    }
}
