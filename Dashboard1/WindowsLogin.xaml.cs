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
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for WindowsLogin.xaml
    /// </summary>
    public partial class WindowsLogin : Window
    {
        public WindowsLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string myPassword = PasswordBox.Password;          
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);
            var getPassword = sqlCon.Query<User>("exec SP_Retrieve_Login @Username",
                    new
                    { Username = UsernameBox.Text}).SingleOrDefault();
            var result = BCrypt.Net.BCrypt.Verify(myPassword, getPassword.Password);
            if (result)
            {
                MessageBox.Show("Sucessfull");
                var dashboard = new MainWindow();
                dashboard.Show();
                Close();
            }              
                else
                {
                    MessageBox.Show("Username Or Password Incorrected");
                }


            
        }
    }
}
