using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleLinq2SqlUnitTesting.Tests.TestData.Functions;
using SampleLinq2SqlUnitTesting.Tests.TestData.StoredProcedures;
using SampleLinq2SqlUnitTesting.Tests.TestData.TableGeneratorCode;
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
            StripWWWandCom.Instance.CreateStoredProcedure();
            AllDepartments.Instance.CreateStoredProcedure();
        }

        [AssemblyCleanup]
        public static void ClassEndCleanup()
        {
            UnitTestHelpers.End();
        }
    }
}
