using System.Configuration;
using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting
{
    public static class DatabaseConnectionString
    {
        public static string Get()
        {
            if (UnitTestHelpers.IsInUnitTest)
            {
                return "Data Source=(localdb)\\" + UnitTestHelpers.InstanceName + ";Initial Catalog=linq2sqldemodata;Integrated Security=True";
            }

            return ConfigurationManager.AppSettings["SampleLinq2SqlUnitTesting.Properties.Settings.linq2sqldemodataConnectionString"];
        }
    }
}
