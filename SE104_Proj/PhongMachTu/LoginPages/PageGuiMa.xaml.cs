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

namespace PhongMachTu.LoginPages
{
    /// <summary>
    /// Interaction logic for PageGuiMa.xaml
    /// </summary>
    public partial class PageGuiMa : Page
    {
        private LoginWindow _loginWindow;
        private ForgotPassPage _forgotPassPage;
        public PageGuiMa()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            _loginWindow = new LoginWindow();
            _loginWindow.Show();
           this.Visibility = Visibility.Hidden;
           _forgotPassPage = new ForgotPassPage();
            _forgotPassPage.Close();
            _forgotPassPage.Close();
        }
    }
}
