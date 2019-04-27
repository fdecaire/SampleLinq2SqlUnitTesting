using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting.Tests.TestData.StoredProcedures
{
    // DO NOT MODIFY! This code is auto-generated.
    public class AllDepartments : StoredProc
    {
        private static StoredProc _instance;
        public static StoredProc Instance => _instance ?? (_instance = new AllDepartments());
        public override string Name => "AllDepartments";
        public override string Database => "Linq2SqlDemoData";
        public override string Code =>
            @"USE [Linq2SqlDemoData]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO 
CREATE PROCEDURE [dbo].[AllDepartments]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.Department
END
";
    }
}
