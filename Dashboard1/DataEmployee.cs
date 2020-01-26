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
        public string Employe_Name { get; set; }
        public string NIK { get; set; }
        public string PlaceBirth { get; set; }
        public string BirthDate { get; set; }        
        public string Religion { get; set; }
        public string Graduate { get; set; }
        public string University { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NPWP { get; set; }
        public string Address { get; set; }
        public string JoinDate { get; set; }
        public int Departmen_Id { get; set; }
        public int Jobtitle_id { get; set; }


        public DataEmployee() { }

        public DataEmployee(int id, string employee_name, string nik, string placebirth, string birthdate, string religion, string graduate,
            string university, string phone, string email, string npwp, string address, string joindate, int department_id, int jobtitle_id)
        {
            this.Id = id;
            this.Employe_Name = employee_name;
            this.NIK = nik;
            this.PlaceBirth = placebirth;
            this.BirthDate = birthdate;
            this.Religion = religion;
            this.Graduate = graduate;
            this.University = university;
            this.Phone = phone;
            this.Email = email;
            this.NPWP = npwp;
            this.Address = address;
            this.JoinDate = joindate;
            this.Departmen_Id = department_id;
            this.Jobtitle_id = jobtitle_id;
        }

        public virtual void UpdateEmployee(string employee_name, string nik, string placebirth, string birthdate, string religion, string graduate,
            string university, string phone, string email, string npwp, string address, string joindate, int department_id, int jobtitle_id)
        {
            this.Employe_Name = employee_name;
            this.NIK = nik;
            this.PlaceBirth = placebirth;
            this.BirthDate = birthdate;
            this.Religion = religion;
            this.Graduate = graduate;
            this.University = university;
            this.Phone = phone;
            this.Email = email;
            this.NPWP = npwp;
            this.Address = address;
            this.JoinDate = joindate;
            this.Departmen_Id = department_id;
            this.Jobtitle_id = jobtitle_id;
        }

        public virtual void DeleteEmployee(int id)
        {
            this.Id = id;

        }







    }
}
