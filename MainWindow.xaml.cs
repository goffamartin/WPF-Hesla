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
using System.Text.RegularExpressions;

namespace WPF___Hesla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
            if(UsernameBox.Text != "" && PasswordBox.Password != "")
            {
                AlertLabel.Content = "";
                if(reg.IsMatch(PasswordBox.Password))
                {
                    MessageBox.Show("Succesfully logged in :)");
                    this.Close();
                }
                else
                    AlertLabel.Content = "* Incorect Password";
            }
            else
                AlertLabel.Content = "* Fill in the login details";
        }
    }
}
