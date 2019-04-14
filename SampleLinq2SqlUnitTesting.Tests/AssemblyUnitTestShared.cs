using DataLayer.Linq2SqlDemoData.TableGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting.Tests
{
    [TestClass]
    public class AssemblyUnitTestShared
    {
        [AssemblyInitialize]
        public static void ClassStartInitialize(TestContext testContext)
        {
            UnitTestHelpers.Start("sampledatatestinstance", new string[] { "Linq2SqlDemoData" });

            // create tables
            UnitTestHelpers.CreateAllTables(Linq2SqlDemoDataTables.TableList, Linq2SqlDemoDataTables.DatabaseName);
        }

        [AssemblyCleanup]
        public static void ClassEndCleanup()
        {
            UnitTestHelpers.End();
        }
    }
}
