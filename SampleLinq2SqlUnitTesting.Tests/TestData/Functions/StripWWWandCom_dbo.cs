using UnitTestHelperLibrary;

namespace SampleLinq2SqlUnitTesting.Tests.TestData.Functions
{
    // DO NOT MODIFY! This code is auto-generated.
    public class StripWWWandCom : StoredProc
    {
        private static StoredProc _instance;
        public static StoredProc Instance => _instance ?? (_instance = new StripWWWandCom());
        public override string Name => "StripWWWandCom";
        public override string Database => "Linq2SqlDemoData";
        public override string Code
        {
            get
            {
                return @"CREATE FUNCTION dbo.StripWWWandCom (@input VARCHAR(250))
RETURNS VARCHAR(250)
AS BEGIN
    DECLARE @Work VARCHAR(250)

    SET @Work = @Input

    SET @Work = REPLACE(@Work, 'www.', '')
    SET @Work = REPLACE(@Work, '.com', '')

    RETURN @work
END
";
            }
        }
    }
}
