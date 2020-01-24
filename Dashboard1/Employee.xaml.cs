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
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
        }

       

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);
            var check = sqlCon.QueryAsync<DataEmployee>("EXEC dbo.SP_Insert_Employee @idEmp,@nameEmp,@PlaceBirth,@BirthDate,@NIK,@Religion,@Email,@Address,@Phone,@NPWP,@Graduate,@JoinDate,@Status,@Departmen_Id",
                new {
                    IdEmp = txtIdEmp.Text,
                    EmployeeName = txtNameEmp.Text,
                    PlaceBirth = txtPlaceBirth.Text,
                    BirthDay = Convert.ToDateTime(dpBirthDay.SelectedDate).ToString("yyyy-MM-dd"),
                    NIK = txtNIK.Text,
                    Religion = txtReligion.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    NPWP = txtNPWP.Text,
                    Graduate = txtGraduate.Text,
                    JoinDate = Convert.ToDateTime(dpJoinDate.SelectedDate).ToString("yyyy-MM-dd"),
                    Status = txtStatus.Text,
                    Departmen_Id = txtDepId.Text
                });
            
            MessageBox.Show("Data Sucess Entering");
           
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
