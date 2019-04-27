using System.Collections.Generic;
using System.Linq;

namespace SampleLinq2SqlUnitTesting
{
    public class BusinessClass
    {
        public List<string> GetAllEmployeeNames()
        {
            using (var db = new LinqDataClassesDataContext(DatabaseConnectionString.Get()))
            {
                var result = (from e in db.Employees select e.LastName + ", " + e.FirstName).ToList();

                return result;
            }
        }

        public string StripWWWAndCom(string url)
        {
            using (var db = new LinqDataClassesDataContext(DatabaseConnectionString.Get()))
            {
                return db.ExecuteQuery<string>($"SELECT dbo.StripWWWandCom('{url}')").FirstOrDefault();
            }
        }

        public List<Department> GetAllDepartments()
        {
            using (var db = new LinqDataClassesDataContext(DatabaseConnectionString.Get()))
            {
                return db.ExecuteQuery<Department>("exec AllDepartments").ToList();
            }
        }
    }
}
