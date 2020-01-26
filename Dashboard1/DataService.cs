using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;

namespace Dashboard1
{
    public class DataService
    {

    //TABEL DEPARTMENT
       public static List<Department> GetAllDepartment()
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {               
                return sqlCon.QueryAsync<Department>("exec SP_Retrive_Department", new { }).Result.ToList();
            }
        }
        public static int Insert (Department department)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                var affectedRow= sqlCon.Execute("exec SP_Insert_Department @Name,@Manager,@Division_Id", new { Name = department.Name, Manager = department.Manager, Division_Id = department.DivisionId });
                return affectedRow;
            }
        }

        public int Update(int id, Department department)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.Execute("exec SP_Update_Department @id,@Name,@Manager,@Division_Id", new { Id= id, Name=department.Name,Manager=department.Manager,Division_Id = department.DivisionId});
            }
        }


        public static List<Division> GetDivision(string DivisionName)
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.QueryAsync<Division>("exec SP_GetDivision @name", new { Name = DivisionName }).Result.ToList();
            }
        }

        //public string Insert(string nama, string manager, int divisionid)
        //{
        //    using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
        //    {
        //        var data = sqlCon.Execute("exec SP_Insert_Department @name,@Manager,@Division_Id", new { Name = nama, Manager = manager, DivisionId = divisionid }, commandType: CommandType.StoredProcedure);
        //        return data;
        //    }


        //}


        //TABEL DEPARTMENT
        //public static list<department> insertdepartment(string name, string manager, int id)
        //{

        //    using (sqlconnection sqlcon = new sqlconnection(configurationmanager.connectionstrings["myconection"].connectionstring))
        //    {
        //        return sqlcon.execute("exec sp_insert_department @name,@manager,@division_id", new { name = name, manager = manager, divisionid = id });
        //    }

        //}

        //TABEL EMPLOYEE




    }


}
