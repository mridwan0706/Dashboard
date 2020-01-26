using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1
{
    public interface IDepartment
    {
        Department Get(int? id);
        IEnumerable<Department> Get();
        void Insert(Department param);
        void Update(int id, Department param);
        void Delete(int id);
    }
}
