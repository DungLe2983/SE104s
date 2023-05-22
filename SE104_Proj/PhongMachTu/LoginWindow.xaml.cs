using PhongMachTu.LoginPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PhongMachTu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private NavigationService nav;
        public LoginWindow()
        {
            InitializeComponent();
            nav = NavigationService.GetNavigationService(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            var getWd = Window.GetWindow(this);  //Lấy Window của cái Trang này(PageChinh)
            getWd.Close();                       //Đăng Nhập thành công => đóng Form Đăng Nhập

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnForgot_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassPage passPage = new ForgotPassPage();
            passPage.Show();
            this.Hide();
        }
    }
}
