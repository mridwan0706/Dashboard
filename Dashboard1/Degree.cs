using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
    public class Degree
    {
        public int Id { get; set; }
        public string Degree_Name { get; set; }

        public Degree() { }

        public Degree(int id, string degree_name)
        {
            this.Id = id;
            this.Degree_Name = degree_name;
        }

        public virtual void Update(string degree_name)
        {
            this.Degree_Name = degree_name;

        }

        public virtual void Delete(int id)
        {
            this.Id = id;

        }
    }
}
