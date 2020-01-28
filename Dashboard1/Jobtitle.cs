using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
   public class Jobtitle
    {
        public string Id { get; set; }
        public string Jobtitle_Name { get; set; }

        public Jobtitle() { }

        public Jobtitle(string id, string jobtitle_name)
        {
            this.Id = id;
            this.Jobtitle_Name = jobtitle_name;
        }

        public virtual void Update(string jobtitle_name)
        {
            this.Jobtitle_Name = jobtitle_name;

        }

        public virtual void Delete(string id)
        {
            this.Id = id;

        }
    }
}
