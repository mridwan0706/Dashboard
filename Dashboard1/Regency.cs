using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
    class Regency
    {
        public int Id { get; set; }
        public string Regency_Name { get; set; }

        public Regency() { }

        public Regency(int id, string regency_name)
        {
            this.Id = id;
            this.Regency_Name = regency_name;
        }

      
        }
    }
}
