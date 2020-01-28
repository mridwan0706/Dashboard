using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
    public class Religion
    {
        public int Id { get; set; }
        public string Religion_Name { get; set; }

        public Religion() { }

        public Religion(int id, string religion_name)
        {
            this.Id = id;
            this.Religion_Name = religion_name;           
        }

        public virtual void Update(string religion_name)
        {
            this.Religion_Name = religion_name;
           
        }

        public virtual void Delete(int id)
        {
            this.Id = id;

        }
    }
}
