using System.Collections.Generic;
using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting.Tests.TestData.Constraints
{
	public class Linq2SqlDemoDataConstraints
	{
		public static List<ConstraintDefinition> ConstraintList = new List<ConstraintDefinition> {
			new ConstraintDefinition { DatabaseName="Linq2SqlDemoData", PkTable = "Department", PkField = "ID", FkTable = "Employee", FkField = "Department", SchemaName = "dbo" }
		};
	}
}
