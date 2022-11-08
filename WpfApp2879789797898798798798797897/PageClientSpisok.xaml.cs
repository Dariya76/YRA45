using System;
using System.Linq;
using System.Windows.Controls;

namespace WpfApp2879789797898798798798797897
{
    /// <summary>
    /// Логика взаимодействия для PageClientSpisok.xaml
    /// </summary>
    public partial class PageClientSpisok : Page
    {
        public PageClientSpisok()
        {
            InitializeComponent();
            CmbxUser.DisplayMemberPath = "FIO";
            CmbxUser.SelectedValuePath = "ID";
            CmbxUser.ItemsSource = ConnectOdb.ConObj.Users.Where(x => x.role1 == 2).ToList();
            GridUser.IsReadOnly = true;
            if (UserObj.ID != null)
            {
                GridUser.ItemsSource = ConnectOdb.ConObj.Users.Where(x => x.id == UserObj.ID).ToList();
            }
        }


        private void CmbxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridUser.ItemsSource = null;
            int SelectUser = Convert.ToInt32(CmbxUser.SelectedValue);
            GridUser.ItemsSource = ConnectOdb.ConObj.Users.Where(x => x.id == SelectUser).ToList();
            
        }
    }
}
