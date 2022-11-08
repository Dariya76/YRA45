using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2879789797898798798798797897.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegistr.xaml
    /// </summary>
    public partial class PageRegistr : Page
    {
        public PageRegistr()
        {
            InitializeComponent();
            ConnectOdb.ConObj.Role.Load();
            comboBox1.ItemsSource = ConnectOdb.ConObj.Role.Local;
        }

        private void BtnRg_Click(object sender, RoutedEventArgs e)
        {
            if (ConnectOdb.ConObj.Users.Count(x => x.login == tbLog1.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже  существует", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                Users userObj = new Users()
                {
                    FIO = tbFio.Text,
                    role1 = (comboBox1.SelectedItem as Role).id,
                    login = tbLog1.Text,
                    password = tbPas1.Text
                };
                ConnectOdb.ConObj.Users.Add(userObj);
                ConnectOdb.ConObj.SaveChanges();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameObj.MainFrame.Navigate(new PageRegistr());

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }
    }
}

