using Kyrsovik.ClassFolder;
using Kyrsovik.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public AddOrderPage()
        {
            InitializeComponent();
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(FIOTb.Text))
            {
                MBClass.ErrorMB("Вы не ввели ФИО заказчика");
                FIOTb.Focus();
            }
            else if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                MBClass.ErrorMB("Вы не ввели название ресторана");
                NameTb.Focus();
            }
            else if(DishCb.SelectedIndex == -1)
            {
                MBClass.ErrorMB("Вы не выбрали блюдо");
                DishCb.Focus();
            }
            else
            {
                try
                {
                    DBEntities.GetContext()
                        .Order
                        .Add(new Order()
                        {
                            //Client = FIOTb.Text,
                            //Restoraunt = NameTb.Text,
                            IdMenu = Int32.Parse(DishCb.SelectedValue.ToString())
                        });
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }
    }
}
