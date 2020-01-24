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
       public static List<DataEmployee> GetAll()
        {
            using (IDbConnection db= new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.QueryAsync<DataEmployee>("EXEC SP_Retrive_Employee").Result.ToList();
            }
        }


    }

   
}
