using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinq2SqlUnitTesting
{
    public class BusinessClass
    {
        public List<string> GetAllEmployeeNames()
        {
            using (var db = new LinqDataClassesDataContext())
            {
                var result = (from e in db.Employees select e.LastName + ", " + e.FirstName).ToList();

                return result;
            }
        }
    }
}
