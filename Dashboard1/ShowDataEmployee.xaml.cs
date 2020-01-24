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
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for ShowDataEmployee.xaml
    /// </summary>
    public partial class ShowDataEmployee : Window
    {
        public ShowDataEmployee()
        {
            InitializeComponent();
        }



        private void DataEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            //var data = new List<DataEmployee>();
            //var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            //var show = con.QueryAsync<DataEmployee>("EXEC SP_Retrive_Employee").Result.ToList();

            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

            var check = sqlCon.QueryAsync<DataEmployee>("exec SP_Retrive_Employee",
                new
                {
                    
                }).Result.ToList();

            var grid = sender as DataGrid;
            grid.ItemsSource = check;
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var add = new Employee();
            add.Show();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    
    }
}
