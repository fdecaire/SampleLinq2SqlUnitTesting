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
    }
}
