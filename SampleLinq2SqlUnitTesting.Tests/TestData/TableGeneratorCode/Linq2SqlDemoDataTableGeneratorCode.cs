using System;
using HelperLibrary;
using System.Collections.Generic;

namespace DataLayer.Linq2SqlDemoData.TableGenerator
{
	// DO NOT MODIFY! This code is auto-generated.
	public partial class Linq2SqlDemoDataTables
	{
		public static string DatabaseName {
			get 
			{
				return "Linq2SqlDemoData";
			}
		}

		public static List<TableDefinition> TableList = new List<TableDefinition> {
			new TableDefinition {Name="Department", CreateScript="CREATE TABLE [dbo].[Department]([ID][int] IDENTITY(1,1) NOT NULL,[Name][varchar](50) NOT NULL, CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED ([ID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"},
			new TableDefinition {Name="Employee", CreateScript="CREATE TABLE [dbo].[Employee]([FirstName][varchar](50) NOT NULL,[LastName][varchar](50) NOT NULL,[Department][int] NOT NULL)"},
		};
	}
}
