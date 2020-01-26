using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Dashboard1
{
   public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Division { get; set; }
        public int DivisionId { get; set; }


        public Department() { }

        public Department(int id,string name,string manager, string division,int division_id)
        {
            this.Id = id;
            this.Name = name;
            this.Manager = manager;
            this.Division = division;
            this.DivisionId = division_id;
        }

        public virtual void Update(string name, string manager, string division, int division_id)
        {
            this.Name = name;
            this.Manager = manager;
            this.Division = division;
            this.DivisionId = division_id;
        }

        public virtual void Delete(int id)
        {
            this.Id = id;
            
        }



    }
}
