﻿using System;
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
using Dapper;
using System.Data.SqlClient;
using System.Configuration;



namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for UCManageUser.xaml
    /// </summary>
    public partial class UCManageUser : UserControl
    {
        public UCManageUser()
        {
            InitializeComponent();
        }

        
        private void EmptyDetail()
        {
            IDbox.Text = "";
            userNamebox.Text = "";
            Passbox.Password = "";
            cmbRoleUser.Text = "";
        }

        public void LoadGridCombo()
        {
            try
            {
                gridUser.ItemsSource = DataService.GetAllUser();
                cmbRoleUser.ItemsSource = DataService.GetAllUser();
                cmbRoleUser.DisplayMemberPath = "Name";
                

            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
                Console.Write(ex.StackTrace);
            }
        }

       
        private void BtnaddUser_Click(object sender, RoutedEventArgs e)
        {

            //string myPassword = Passbox.Password;
            //string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            //string myHash = BCrypt.Net.BCrypt.HashPassword(myPassword, mySalt);


            //User param = new User()
            //{
            //    Username = userNamebox.Text,
            //    Password = myHash,
            //    Role = cmbRoleUser.Text

            //};
            //DataService.InsertUser(param);
            //MessageBox.Show("Data Saved Successfully");
            //EmptyDetail();
            //LoadGridCombo();


            string myPassword = Passbox.Password;
            string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            string myHash = BCrypt.Net.BCrypt.HashPassword(myPassword, mySalt);
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);
            var affectedRows = sqlCon.Execute("INSERT INTO TB_M_User (Username,Password,Role) VALUES (@Username, @Password,@Role)", new { Username = userNamebox.Text, Password = myHash ,Role=cmbRoleUser.Text});
            if (affectedRows < 0)
            {
                MessageBox.Show("Failed to Register");
            }
            else
            {
                MessageBox.Show("Success to Register");
                EmptyDetail();
                LoadGridCombo();
            }

        }

        private void GridUser_Loaded(object sender, RoutedEventArgs e)
        {

            var data = DataService.GetAllUser();
            var grid = sender as DataGrid;
            grid.ItemsSource = data;
        }

        private void GridUser_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = gridUser.SelectedItem;
            IDbox.Text = (gridUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            userNamebox.Text = (gridUser.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            Passbox.Password = (gridUser.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            cmbRoleUser.Text = (gridUser.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataService.DeleteUser(Convert.ToInt16(IDbox.Text));
            MessageBox.Show("Data Deleted Successfully");
            EmptyDetail();
            LoadGridCombo();

        }
    }
}
