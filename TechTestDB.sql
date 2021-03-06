USE [master]
GO
 
CREATE DATABASE [TechTestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechTestDB', FILENAME = N'C:\Users\User\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\TechTestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechTestDB_log', FILENAME = N'C:\Users\User\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\TechTestDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TechTestDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechTestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechTestDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [TechTestDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [TechTestDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [TechTestDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [TechTestDB] SET ARITHABORT ON 
GO
ALTER DATABASE [TechTestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechTestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechTestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechTestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechTestDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [TechTestDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [TechTestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechTestDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [TechTestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechTestDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechTestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechTestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechTestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechTestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechTestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechTestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechTestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechTestDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TechTestDB] SET  MULTI_USER 
GO
ALTER DATABASE [TechTestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechTestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechTestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechTestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechTestDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechTestDB] SET QUERY_STORE = OFF
GO
USE [TechTestDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [TechTestDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 18/12/2019 09:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[SurName] [nvarchar](255) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[EmployeeNumber] [nvarchar](13) NOT NULL,
	[IsActive] [bit] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TechTestDB] SET  READ_WRITE 
GO
