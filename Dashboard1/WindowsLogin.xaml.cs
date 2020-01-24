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
            

                SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

                var check = sqlCon.QueryAsync<Login>("exec SP_Retrieve_Login @Username,@Password ",
                    new
                    {
                        Username = Username.Text,
                        Password = Password.Password
                    }).Result.SingleOrDefault();

                if (check != null)
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
