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
    //WITH JOIN
       public static List<Department> GetAllDepartment()
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {               
                return sqlCon.QueryAsync<Department>("exec SP_Retrive_Department", new { }).Result.ToList();
            }
        }

        //TANPA JOIN
        public static List<Department> GetAllDept()
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.QueryAsync<Department>("exec SP_Retrive_Dept", new { }).Result.ToList();
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

        public static int Update(int id, Department department)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.Execute("exec SP_Update_Department @id,@Name,@Manager,@Division_Id", new { Id= id, Name=department.Name,Manager=department.Manager,Division_Id = department.DivisionId});
            }
        }

        public static int Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.Execute("exec SP_Delete_Department @id", new { Id = id});
            }
        }



        //Tabel Division
        public static List<Department> GetAllDivision()
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.QueryAsync<Department>("exec SP_Retrieve_Division", new { }).Result.ToList();
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

        //TABEL USER

        //TABEL DEPARTMENT
        public static List<User> GetAllUser()
        {

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.QueryAsync<User>("exec SP_Retrive_User", new { }).Result.ToList();
            }
        }
        public static int InsertUser(User user)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                var affectedRow = sqlCon.Execute("exec SP_Insert_User @Username,@Password,@Role", new { Username = user.Username, Password = user.Password, Role = user.Role });
                return affectedRow;
            }
        }

        public static int UpdateUser(int id, User user)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.Execute("exec SP_Update_User @id,@Username,@Password,@Role", new { Id = id, Username = user.Username, Password = user.Password, Role = user.Role });
            }
        }

        public static int DeleteUser(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConection"].ConnectionString))
            {
                return sqlCon.Execute("exec SP_Delete_User @id", new { Id = id });
            }
        }





    }


}
