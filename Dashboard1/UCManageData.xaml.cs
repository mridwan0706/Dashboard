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
            NameBox.Text = "";
            ManagerBox.Text = "";
            cmbDivisi.Text = "";
        }




        public void LoadGridCombo()
        {
            try
            {
                cmbDivisi.ItemsSource = DataService.GetAllDepartment();
                cmbDivisi.DisplayMemberPath = "Division";
                cmbDivisi.SelectedValuePath = "DivisionId";

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
            NameBox.Text = (GridDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            ManagerBox.Text = (GridDepartment.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            cmbDivisi.Text = (GridDepartment.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void CmbDivisi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var getDivision = Convert.ToInt16(cmbDivisi.SelectedValue);
            
        }

        private void CmbDivisi_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDivisi.ItemsSource = DataService.GetAllDepartment();
            cmbDivisi.DisplayMemberPath = "Division";
            cmbDivisi.SelectedValuePath = "DivisionId";
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
            LoadGridCombo();
            EmptyDetail();

        }



    }
}