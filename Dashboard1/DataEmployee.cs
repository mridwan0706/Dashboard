using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace Dashboard1
{
    public  class DataEmployee 
    {
        public int Id { get; set; }
        public string Employee_Name { get; set; }
        public string NIK { get; set; }
        public string PlaceBirth { get; set; }
        public string BirthDate { get; set; }      
        public string University { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NPWP { get; set; }
        public string Address { get; set; }
        public string JoinDate { get; set; }
        public int Province_Id { get; set; }
        public int Regency_Id { get; set; }
        public int Religion_Id { get; set; }
        public int Departmen_Id { get; set; }
        public string Jobtitle_id { get; set; }
        public int _Degree { get; set; }


        public DataEmployee() { }

        public DataEmployee(int id, string employee_name, string nik, string placebirth, string birthdate,
            string university, string phone, string email, string npwp, string address, string joindate, int province_id, int regency_id, int religion_id, int department_id, string jobtitle_id, int degree_id)
        {
            this.Id = id;
            this.Employee_Name = employee_name;
            this.NIK = nik;
            this.PlaceBirth = placebirth;
            this.BirthDate = birthdate;         
            this.University = university;
            this.Phone = phone;
            this.Email = email;
            this.NPWP = npwp;
            this.Address = address;
            this.JoinDate = joindate;
            this.Province_Id = province_id;
            this.Regency_Id = regency_id;
            this.Religion_Id = religion_id;
            this.Departmen_Id = department_id;
            this.Jobtitle_id = jobtitle_id;
            this._Degree = degree_id;

        }

        public virtual void UpdateEmployee(string employee_name, string nik, string placebirth, string birthdate,
            string university, string phone, string email, string npwp, string address, string joindate, int province_id, int regency_id, int religion_id, int department_id, string jobtitle_id, int degree_id)
        {
            this.Employee_Name = employee_name;
            this.NIK = nik;
            this.PlaceBirth = placebirth;
            this.BirthDate = birthdate;
            this.University = university;
            this.Phone = phone;
            this.Email = email;
            this.NPWP = npwp;
            this.Address = address;
            this.JoinDate = joindate;
            this.Province_Id = province_id;
            this.Regency_Id = regency_id;
            this.Religion_Id = religion_id;
            this.Departmen_Id = department_id;
            this.Jobtitle_id = jobtitle_id;
            this._Degree = degree_id;
        }

        public virtual void DeleteEmployee(int id)
        {
            this.Id = id;

        }







    }
}
