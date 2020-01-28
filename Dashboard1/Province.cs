using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
  public class Province
    {
        public int Id { get; set; }
        public string Province_Name { get; set; }

        public Province() { }

        public Province(int id, string province_name)
        {
            this.Id = id;
            this.Province_Name = province_name;
        }

        public virtual void Update(string province_name)
        {
            this.Province_Name = province_name;

        }

        public virtual void Delete(int id)
        {
            this.Id = id;

        }
    }
}
