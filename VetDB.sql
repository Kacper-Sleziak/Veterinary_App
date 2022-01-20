USE [VetDB]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_PersonalData]
GO
ALTER TABLE [dbo].[OrderedProducts] DROP CONSTRAINT [FK_OrderedProducts_Products]
GO
ALTER TABLE [dbo].[OrderedProducts] DROP CONSTRAINT [FK_OrderedProducts_Orders]
GO
ALTER TABLE [dbo].[FreeTerms] DROP CONSTRAINT [FK_FreeTerms_Employees]
GO
ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_PersonalData]
GO
ALTER TABLE [dbo].[Credentials] DROP CONSTRAINT [FK_Credentials_PersonalData]
GO
ALTER TABLE [dbo].[Animals] DROP CONSTRAINT [FK_Animals_PersonalData]
GO
ALTER TABLE [dbo].[PersonalData] DROP CONSTRAINT [DF_PersonalData_Stamps]
GO
/****** Object:  Table [dbo].[VisitTypes]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VisitTypes]') AND type in (N'U'))
DROP TABLE [dbo].[VisitTypes]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Visits]') AND type in (N'U'))
DROP TABLE [dbo].[Visits]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[PersonalData]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonalData]') AND type in (N'U'))
DROP TABLE [dbo].[PersonalData]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orders]') AND type in (N'U'))
DROP TABLE [dbo].[Orders]
GO
/****** Object:  Table [dbo].[OrderedProducts]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderedProducts]') AND type in (N'U'))
DROP TABLE [dbo].[OrderedProducts]
GO
/****** Object:  Table [dbo].[FreeTerms]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FreeTerms]') AND type in (N'U'))
DROP TABLE [dbo].[FreeTerms]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Credentials]') AND type in (N'U'))
DROP TABLE [dbo].[Credentials]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 20.01.2022 18:06:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Animals]') AND type in (N'U'))
DROP TABLE [dbo].[Animals]
GO
USE [master]
GO
/****** Object:  Database [VetDB]    Script Date: 20.01.2022 18:06:54 ******/
DROP DATABASE [VetDB]
GO
/****** Object:  Database [VetDB]    Script Date: 20.01.2022 18:06:54 ******/
CREATE DATABASE [VetDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VetDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DEMBINSKISQL\MSSQL\DATA\VetDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VetDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DEMBINSKISQL\MSSQL\DATA\VetDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VetDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VetDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VetDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VetDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VetDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VetDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VetDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VetDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VetDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VetDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VetDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VetDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VetDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VetDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VetDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VetDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VetDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VetDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VetDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VetDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VetDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VetDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VetDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VetDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VetDB] SET RECOVERY FULL 
GO
ALTER DATABASE [VetDB] SET  MULTI_USER 
GO
ALTER DATABASE [VetDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VetDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VetDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VetDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VetDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VetDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VetDB', N'ON'
GO
ALTER DATABASE [VetDB] SET QUERY_STORE = OFF
GO
USE [VetDB]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Species] [nvarchar](50) NOT NULL,
	[Weight] [float] NOT NULL,
	[OwnerId] [int] NOT NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credentials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [char](64) NOT NULL,
	[Password] [char](64) NOT NULL,
	[PersonalDataId] [int] NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobName] [nvarchar](50) NOT NULL,
	[PersonalDataId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreeTerms]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreeTerms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_FreeTerms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderedProducts]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderedProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_OrderedProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OwnerId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[ZipCode] [int] NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[Delivery] [nvarchar](50) NOT NULL,
	[ApartmentNumber] [int] NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalData]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Stamps] [int] NOT NULL,
 CONSTRAINT [PK_PersonalData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[VisitTypeId] [int] NOT NULL,
	[AnimalId] [int] NOT NULL,
	[VetId] [int] NOT NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitTypes]    Script Date: 20.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Duration] [int] NOT NULL,
	[Price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_VisitTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PersonalData] ADD  CONSTRAINT [DF_PersonalData_Stamps]  DEFAULT ((0)) FOR [Stamps]
GO
ALTER TABLE [dbo].[Animals]  WITH CHECK ADD  CONSTRAINT [FK_Animals_PersonalData] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[PersonalData] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Animals] CHECK CONSTRAINT [FK_Animals_PersonalData]
GO
ALTER TABLE [dbo].[Credentials]  WITH CHECK ADD  CONSTRAINT [FK_Credentials_PersonalData] FOREIGN KEY([PersonalDataId])
REFERENCES [dbo].[PersonalData] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Credentials] CHECK CONSTRAINT [FK_Credentials_PersonalData]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_PersonalData] FOREIGN KEY([PersonalDataId])
REFERENCES [dbo].[PersonalData] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_PersonalData]
GO
ALTER TABLE [dbo].[FreeTerms]  WITH CHECK ADD  CONSTRAINT [FK_FreeTerms_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FreeTerms] CHECK CONSTRAINT [FK_FreeTerms_Employees]
GO
ALTER TABLE [dbo].[OrderedProducts]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderedProducts_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderedProducts] CHECK CONSTRAINT [FK_OrderedProducts_Orders]
GO
ALTER TABLE [dbo].[OrderedProducts]  WITH NOCHECK ADD  CONSTRAINT [FK_OrderedProducts_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderedProducts] CHECK CONSTRAINT [FK_OrderedProducts_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PersonalData] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[PersonalData] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PersonalData]
GO
USE [master]
GO
ALTER DATABASE [VetDB] SET  READ_WRITE 
GO
