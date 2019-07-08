using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting.Tests
{
    [TestClass]
    public class BusinessClassTests
    {
        [TestCleanup]
        public void Cleanup()
        {
            UnitTestHelpers.TruncateData();
        }

        [TestMethod]
        public void AllEmployeesTest()
        {
            UnitTestHelpers.ReadData("SampleLinq2SqlUnitTesting.Tests.TestData.DefaultData.xml");

            var businessClass = new BusinessClass();
            var allEmployeeNames = businessClass.GetAllEmployeeNames();

            Assert.AreEqual(4,allEmployeeNames.Count);
        }

        [TestMethod]
        public void FunctionTest()
        {
            var businessClass = new BusinessClass();
            var result = businessClass.StripWWWAndCom("www.test.com");

            Assert.AreEqual("test",result);
        }

        [TestMethod]
        public void StoredProcedureTest()
        {
            UnitTestHelpers.ExecuteSQLCodeFromFile("SampleLinq2SqlUnitTesting.Tests.TestData.PopulateDepartmentTable.sql", "Linq2SqlDemoData");

            var businessClass = new BusinessClass();
            var result = businessClass.GetAllDepartments();

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void ExecuteDirectSqlStatement()
        {
            UnitTestHelpers.ExecuteSQLQuery("INSERT INTO Department (Name) values ('IT')", "Linq2SqlDemoData");
            UnitTestHelpers.ExecuteSQLQuery("INSERT INTO Department (Name) values ('Accounting')", "Linq2SqlDemoData");

            var businessClass = new BusinessClass();
            var result = businessClass.GetAllDepartments();

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void ReadDepartmentList()
        {
            UnitTestHelpers.ExecuteSQLCodeFromFile("SampleLinq2SqlUnitTesting.Tests.TestData.PopulateDepartmentTable.sql", "Linq2SqlDemoData");

            var listOfDepartments = UnitTestHelpers.ReadDataFromTable<TestDTO.Department>("department", "Linq2SqlDemoData");

            Assert.AreEqual(3, listOfDepartments.Count);
            Assert.AreEqual("Sales", listOfDepartments[0].Name);
        }
    }
}
