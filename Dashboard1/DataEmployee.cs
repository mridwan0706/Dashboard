﻿using System;
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
        public string IdEmp{ get; set; }
        public string EmployeeName { get; set; }
        public string PlaceBirth { get; set; }
        public string BirthDate { get; set; }
        public string NIK { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string NPWP { get; set; }
        public string Graduate { get; set; }
        public string JoinDate { get; set; }
        public string Status { get; set; }
        public string Departmen_Id { get; set; }
    }
}
