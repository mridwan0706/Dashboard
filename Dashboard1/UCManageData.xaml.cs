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
using System.Configuration;
using System.Data.SqlClient;

namespace Dashboard1
{
    /// <summary>
    /// Interaction logic for UCManageData.xaml
    /// </summary>
    public partial class UCManageData : UserControl
    {
        public UCManageData()
        {
            InitializeComponent();
        }

        private void EmptyDetail()
        {
            IdBox.Text = "";
            NameBox.Text = "";
            ManagerBox.Text = "";
            cmbDivisi.Text = "";
        }
       
        public void LoadGridCombo()
        {
            try
            {
                GridDepartment.ItemsSource = DataService.GetAllDepartment();
                cmbDivisi.ItemsSource = DataService.GetAllDivision();
                cmbDivisi.DisplayMemberPath = "Name";
                cmbDivisi.SelectedValuePath = "Id";

            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
                Console.Write(ex.StackTrace);
            }
        }

        private void GridDepartment_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

            var check = sqlCon.QueryAsync<Department>("exec SP_Retrive_Department",
                new
                {

                }).Result.ToList();


            var grid = sender as DataGrid;
            grid.ItemsSource = check;
        }

        private void GridDepartment_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = GridDepartment.SelectedItem;
            IdBox.Text = (GridDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            NameBox.Text = (GridDepartment.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            ManagerBox.Text = (GridDepartment.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            cmbDivisi.Text = (GridDepartment.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void CmbDivisi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getDivision = Convert.ToInt16(cmbDivisi.SelectedValue);
            
        }

        private void CmbDivisi_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDivisi.ItemsSource = DataService.GetAllDivision();
            cmbDivisi.DisplayMemberPath = "Name";
            cmbDivisi.SelectedValuePath = "Id";
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Department param = new Department()
            {
                Name = NameBox.Text,
                Manager = ManagerBox.Text,
                DivisionId = Convert.ToInt16(cmbDivisi.SelectedValue)
          
            };
            DataService.Insert(param);
            MessageBox.Show("Data Saved Successfully");            
            EmptyDetail();
            LoadGridCombo();

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Department param = new Department()
            {
                Name = NameBox.Text,
                Manager = ManagerBox.Text,
                DivisionId = Convert.ToInt16(cmbDivisi.SelectedValue)

            };
            DataService.Update(Convert.ToInt16(IdBox.Text), param);
            MessageBox.Show("Data Updated Successfully");
            EmptyDetail();
            LoadGridCombo();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataService.Delete(Convert.ToInt16(IdBox.Text));
            MessageBox.Show("Data Deleted Successfully");
            EmptyDetail();
            LoadGridCombo();
        }

        private void DepartmentId_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDepartment.ItemsSource = DataService.GetAllDept();
            cmbDepartment.DisplayMemberPath = "Name";
            cmbDepartment.SelectedValuePath = "Id";

        }

        private void DepartmentId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getDepartment = Convert.ToInt16(cmbDepartment.SelectedValue);
        }

        private void CmbReligion_Loaded(object sender, RoutedEventArgs e)
        {
            cmbReligion.ItemsSource = DataService.GetAllReligion();
            cmbReligion.DisplayMemberPath = "Religion_Name";
            cmbReligion.SelectedValuePath = "Id";
        }

        private void CmbReligion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getReligion = Convert.ToInt16(cmbReligion.SelectedValue);
        }


        private void TxtDegree_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getDegree = Convert.ToInt16(txtDegree.SelectedValue);
        }

        private void TxtDegree_Loaded(object sender, RoutedEventArgs e)
        {
            txtDegree.ItemsSource = DataService.GetAllDegree();
            txtDegree.DisplayMemberPath = "Degree_Name";
            txtDegree.SelectedValuePath = "Id";
        }

        private void CmbProvence_Loaded(object sender, RoutedEventArgs e)
        {
            cmbProvence.ItemsSource = DataService.GetAllProvince();
            cmbProvence.DisplayMemberPath = "Province_Name";
            cmbProvence.SelectedValuePath = "Id";
        }

        private void CmbProvence_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getProvince = Convert.ToInt16(cmbProvence.SelectedValue);
        }

        private void CmbJobTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getJobtitle = Convert.ToString(cmbJobTitle.SelectedValue);
        }

        private void CmbJobTitle_Loaded(object sender, RoutedEventArgs e)
        {
            cmbJobTitle.ItemsSource = DataService.GetAllJobtitle();
            cmbJobTitle.DisplayMemberPath = "Jobtitle_Name";
            cmbJobTitle.SelectedValuePath = "Id";
        }

        private void DataGridEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            var data = DataService.GetAllEmployee();
            var grid = sender as DataGrid;
            grid.ItemsSource = data;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGridEmployee_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dataGridEmployee.SelectedItem;
            IdBox.Text = (GridDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            NameBox.Text = (GridDepartment.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            ManagerBox.Text = (GridDepartment.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            cmbDivisi.Text = (GridDepartment.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;

        }

        private void CmbRegency_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
