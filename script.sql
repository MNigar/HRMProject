/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [HR]    Script Date: 6/11/2021 5:01:23 PM ******/
CREATE DATABASE [HR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HR] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HR] SET ARITHABORT OFF 
GO
ALTER DATABASE [HR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HR] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HR] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HR] SET RECOVERY FULL 
GO
ALTER DATABASE [HR] SET  MULTI_USER 
GO
ALTER DATABASE [HR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HR] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HR', N'ON'
GO
ALTER DATABASE [HR] SET QUERY_STORE = OFF
GO
USE [HR]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [HR]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/11/2021 5:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 6/11/2021 5:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 6/11/2021 5:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactTypes]    Script Date: 6/11/2021 5:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_ContactTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DismissalTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DismissalTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_DismissalTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_DocumentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationInstitutes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationInstitutes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_EducationInstitutes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationLevels]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationLevels](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_EducationLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExcludedDays]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExcludedDays](
	[Id] [uniqueidentifier] NOT NULL,
	[HolidayDate] [datetime2](7) NOT NULL,
	[IsHoliday] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsNew] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_ExcludedDays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IssuedOrganizations]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IssuedOrganizations](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_IssuedOrganizations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KnowledgeLevels]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KnowledgeLevels](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_KnowledgeLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localities]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localities](
	[Id] [uniqueidentifier] NOT NULL,
	[CountryId] [uniqueidentifier] NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Localities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MartialStatuses]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MartialStatuses](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MartialStatuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrganizationStructures]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrganizationStructures](
	[Id] [uniqueidentifier] NOT NULL,
	[OrganizationStructureId] [uniqueidentifier] NULL,
	[StructureId] [uniqueidentifier] NOT NULL,
	[BranchId] [uniqueidentifier] NOT NULL,
	[ParentBranchId] [uniqueidentifier] NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_OrganizationStructures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Privileges]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privileges](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Privileges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationshipTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationshipTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_RelationshipTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialities]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialities](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[VacationDayLimit] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_StaffTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffUnits]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffUnits](
	[Id] [uniqueidentifier] NOT NULL,
	[OrganizationStructureId] [uniqueidentifier] NOT NULL,
	[StaffTypeId] [uniqueidentifier] NOT NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[NeedCount] [int] NULL,
	[SalaryMin] [decimal](18, 2) NULL,
	[SalaryMax] [decimal](18, 2) NULL,
	[OrderNum] [decimal](18, 2) NULL,
	[BranchId] [uniqueidentifier] NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_StaffUnits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Structures]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Structures](
	[Id] [uniqueidentifier] NOT NULL,
	[StructureTypeId] [uniqueidentifier] NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Structures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StructureTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StructureTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_StructureTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transports]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transports](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Transports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkTypes]    Script Date: 6/11/2021 5:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_WorkTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Localities_CountryId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Localities_CountryId] ON [dbo].[Localities]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrganizationStructures_BranchId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrganizationStructures_BranchId] ON [dbo].[OrganizationStructures]
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrganizationStructures_OrganizationStructureId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrganizationStructures_OrganizationStructureId] ON [dbo].[OrganizationStructures]
(
	[OrganizationStructureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrganizationStructures_ParentBranchId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrganizationStructures_ParentBranchId] ON [dbo].[OrganizationStructures]
(
	[ParentBranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrganizationStructures_StructureId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrganizationStructures_StructureId] ON [dbo].[OrganizationStructures]
(
	[StructureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffUnits_BranchId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_StaffUnits_BranchId] ON [dbo].[StaffUnits]
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffUnits_StaffTypeId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_StaffUnits_StaffTypeId] ON [dbo].[StaffUnits]
(
	[StaffTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Structures_StructureTypeId]    Script Date: 6/11/2021 5:01:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Structures_StructureTypeId] ON [dbo].[Structures]
(
	[StructureTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Localities]  WITH CHECK ADD  CONSTRAINT [FK_Localities_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Localities] CHECK CONSTRAINT [FK_Localities_Countries_CountryId]
GO
ALTER TABLE [dbo].[OrganizationStructures]  WITH CHECK ADD  CONSTRAINT [FK_OrganizationStructures_Branches_BranchId] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrganizationStructures] CHECK CONSTRAINT [FK_OrganizationStructures_Branches_BranchId]
GO
ALTER TABLE [dbo].[OrganizationStructures]  WITH CHECK ADD  CONSTRAINT [FK_OrganizationStructures_Branches_ParentBranchId] FOREIGN KEY([ParentBranchId])
REFERENCES [dbo].[Branches] ([Id])
GO
ALTER TABLE [dbo].[OrganizationStructures] CHECK CONSTRAINT [FK_OrganizationStructures_Branches_ParentBranchId]
GO
ALTER TABLE [dbo].[OrganizationStructures]  WITH CHECK ADD  CONSTRAINT [FK_OrganizationStructures_OrganizationStructures_OrganizationStructureId] FOREIGN KEY([OrganizationStructureId])
REFERENCES [dbo].[OrganizationStructures] ([Id])
GO
ALTER TABLE [dbo].[OrganizationStructures] CHECK CONSTRAINT [FK_OrganizationStructures_OrganizationStructures_OrganizationStructureId]
GO
ALTER TABLE [dbo].[OrganizationStructures]  WITH CHECK ADD  CONSTRAINT [FK_OrganizationStructures_Structures_StructureId] FOREIGN KEY([StructureId])
REFERENCES [dbo].[Structures] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrganizationStructures] CHECK CONSTRAINT [FK_OrganizationStructures_Structures_StructureId]
GO
ALTER TABLE [dbo].[StaffUnits]  WITH CHECK ADD  CONSTRAINT [FK_StaffUnits_Branches_BranchId] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([Id])
GO
ALTER TABLE [dbo].[StaffUnits] CHECK CONSTRAINT [FK_StaffUnits_Branches_BranchId]
GO
ALTER TABLE [dbo].[StaffUnits]  WITH CHECK ADD  CONSTRAINT [FK_StaffUnits_StaffTypes_StaffTypeId] FOREIGN KEY([StaffTypeId])
REFERENCES [dbo].[StaffTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StaffUnits] CHECK CONSTRAINT [FK_StaffUnits_StaffTypes_StaffTypeId]
GO
ALTER TABLE [dbo].[Structures]  WITH CHECK ADD  CONSTRAINT [FK_Structures_StructureTypes_StructureTypeId] FOREIGN KEY([StructureTypeId])
REFERENCES [dbo].[StructureTypes] ([Id])
GO
ALTER TABLE [dbo].[Structures] CHECK CONSTRAINT [FK_Structures_StructureTypes_StructureTypeId]
GO
USE [master]
GO
ALTER DATABASE [HR] SET  READ_WRITE 
GO
