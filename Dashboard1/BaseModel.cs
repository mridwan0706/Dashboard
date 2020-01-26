using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
    public class BaseModel : Metadata
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Metadata
    {
        public bool IsDelete { get; set; }
    }
}
