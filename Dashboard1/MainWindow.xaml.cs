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
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Dashboard1
{
    /// </summary>
    public partial class MainWindow : Window
    {

       

        
        public MainWindow()
        {
            InitializeComponent();

            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);

           

        }
      

        //private void EmptyDetail()
        //{
        //    txtName.Text = "";
        //    txtManager.Text = "";
        //    CmbDivision.Text = "";
        //}
       

        

        //public void LoadGridCombo()
        //{
        //    try
        //    {
        //        CmbDivision.ItemsSource = DataService.GetAllDivision();
        //        CmbDivision.DisplayMemberPath = "Name";
        //        CmbDivision.SelectedValuePath = "Id";

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.InnerException);
        //        Console.Write(ex.StackTrace);
        //    }
        //}

        //private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        //private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //private void DataDepartment_Loaded(object sender, RoutedEventArgs e)
        //{
        //    SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

        //    var check = sqlCon.QueryAsync<Department>("exec SP_Retrive_Department",
        //        new
        //        {
                    
        //        }).Result.ToList();

            
        //    var grid = sender as DataGrid;
        //    grid.ItemsSource = check;
        //}

      



        //private void BtnAdd_Click(object sender, RoutedEventArgs e)
        //{


        //    SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString);

        //    var check = sqlCon.Execute("exec SP_Insert_Department @name,@Manager,@Division_Id",
        //        new
        //        {
        //            Name = txtName.Text,
        //            Manager = txtManager.Text,
        //            DivisionId = CmbDivision.SelectedValue
        //        });
        //    LoadGridCombo();
        //    EmptyDetail();



        //}

       
        //private void DataDepartment_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        //{
        //    object item = DataDepartment.SelectedItem;
        //    txtName.Text = (DataDepartment.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
        //    txtManager.Text = (DataDepartment.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
        //    CmbDivision.Text = (DataDepartment.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
        //}

        //private void CmbDivision_Loaded_1(object sender, RoutedEventArgs e)
        //{
        //    CmbDivision.ItemsSource = DataService.GetAllDivision();
           
           
        //}

        private void BtnManageData_Click(object sender, RoutedEventArgs e)
        {
            UCManageData manage = new UCManageData();
            M_ManageData.Children.Clear();
            M_ManageData.Children.Add(manage);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    internal class ConsumoViewModel
    {
        public List<Consumo> Consumo { get; private set; }

        public ConsumoViewModel(Consumo consumo)
        {
            Consumo = new List<Consumo>();
            Consumo.Add(consumo);
        }
    }

    internal class Consumo
    {
        public string Titulo { get; private set; }
        public int Porcentagem { get; private set; }

        public Consumo()
        {
            Titulo = "Consumo Atual";
            Porcentagem = CalcularPorcentagem();
        }

        private int CalcularPorcentagem()
        {
            return 47; //Calculo da porcentagem de consumo
        }
    }
}
