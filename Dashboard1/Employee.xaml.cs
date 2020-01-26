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


            //SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

            //var check = sqlCon.Execute("exec SP_Insert_Employee @Name,@PlaceBirth,@BirthDay,@NIK,@Regional,@Email,@Address,@Phone,@NPWP,@Bachelor,@University,@JoinDate,@Departmen_Id",
            //    new
            //    {
            //        //name = txtNameEmp.Text,
            //        //PlaceBirth = txtPlaceBirth.Text,
            //        //BirthDate = dpBirthDay.SelectedDate,
            //        //NIK = txtNIK.Text,
            //        //Religion = cmbReligion.SelectedItem,
            //        //Email = txtEmail.Text,
            //        //Address = txtAddress.Text,
            //        //Phone = txtPhone.Text,
            //        //NPWP = txtNPWP.Text,
            //        //Bachelor = cmbBachelor.Text,
            //        //University = txtUniversity.Text,
            //        //JoinDate = dpJoinDate.SelectedDate,
            //        //Department_Id = 1                    
            //    });


            //MessageBox.Show("Data Sucess Entering");
            
           
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
