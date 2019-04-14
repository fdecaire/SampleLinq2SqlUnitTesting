
-- linq2sqldemodata
/****** Object:  Database [Linq2SqlDemoData]    Script Date: 4/13/2019 5:22:30 PM ******/
CREATE DATABASE [Linq2SqlDemoData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Linq2SqlDemoData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQL2014\MSSQL\DATA\Linq2SqlDemoData.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Linq2SqlDemoData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQL2014\MSSQL\DATA\Linq2SqlDemoData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Linq2SqlDemoData] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Linq2SqlDemoData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Linq2SqlDemoData] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET ARITHABORT OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Linq2SqlDemoData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Linq2SqlDemoData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Linq2SqlDemoData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Linq2SqlDemoData] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Linq2SqlDemoData] SET  MULTI_USER 
GO

ALTER DATABASE [Linq2SqlDemoData] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Linq2SqlDemoData] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Linq2SqlDemoData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Linq2SqlDemoData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Linq2SqlDemoData] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Linq2SqlDemoData] SET  READ_WRITE 
GO

USE [Linq2SqlDemoData]
GO

CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Employee](
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Department] [int] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeDepartment] FOREIGN KEY([Department])
REFERENCES [dbo].[Department] ([ID])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_EmployeeDepartment]
GO



-- insert test data here
INSERT INTO Department (Name) values ('Sales')
INSERT INTO Department (Name) values ('Help Desk')
INSERT INTO Department (Name) values ('HR')

INSERT INTO Employee (FirstName,LastName,Department) VALUES ('Joe','Cool',1)
INSERT INTO Employee (FirstName,LastName,Department) VALUES ('Jane','Whipple',2)
INSERT INTO Employee (FirstName,LastName,Department) VALUES ('Mark','Delaney',2)
INSERT INTO Employee (FirstName,LastName,Department) VALUES ('Sue','Smith',3)
