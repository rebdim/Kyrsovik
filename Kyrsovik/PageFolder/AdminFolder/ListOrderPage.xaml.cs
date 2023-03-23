using Kyrsovik.ClassFolder;
using Kyrsovik.DataFolder;
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

namespace Kyrsovik.PageFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для ListOrderPage.xaml
    /// </summary>
    public partial class ListOrderPage : Page
    {
        public ListOrderPage()
        {
            InitializeComponent();
            ListOrderLb.ItemsSource = DBEntities.GetContext().Order.ToList();
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
           
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
