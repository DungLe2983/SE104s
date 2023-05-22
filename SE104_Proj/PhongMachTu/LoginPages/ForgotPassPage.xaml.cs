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
using System.Windows.Shapes;

namespace PhongMachTu.LoginPages
{
    /// <summary>
    /// Interaction logic for ForgotPassPage.xaml
    /// </summary>
    public partial class ForgotPassPage : Window
    {
        static private LoginWindow pgC;
        public ForgotPassPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Test.Navigate(new System.Uri("LoginPages/PageGuiMa.xaml", UriKind.RelativeOrAbsolute));
            txtEmail.Visibility = Visibility.Hidden;
            txtConfirm.Visibility = Visibility.Hidden;
            txtNewPassw.Visibility = Visibility.Hidden;
            btnBack.Visibility = Visibility.Hidden;
            btnNext.Visibility = Visibility.Hidden;
            lbAccount.Visibility = Visibility.Hidden;
            lbConfirm.Visibility = Visibility.Hidden;
            lbEmailIN.Visibility = Visibility.Hidden;
            lbPass.Visibility = Visibility.Hidden;   
            imgLogo.Visibility = Visibility.Hidden;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            pgC = new LoginWindow();
            pgC.Show();
            this.Close();
        }
    }
}
