USE [master]
GO
/****** Object:  Database [TechnoparkPractic]    Script Date: 19.05.2024 21:44:45 ******/
CREATE DATABASE [TechnoparkPractic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechnoparkPractic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TechnoparkPractic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechnoparkPractic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TechnoparkPractic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TechnoparkPractic] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechnoparkPractic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechnoparkPractic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechnoparkPractic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechnoparkPractic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechnoparkPractic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechnoparkPractic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TechnoparkPractic] SET  MULTI_USER 
GO
ALTER DATABASE [TechnoparkPractic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechnoparkPractic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechnoparkPractic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechnoparkPractic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechnoparkPractic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechnoparkPractic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TechnoparkPractic] SET QUERY_STORE = ON
GO
ALTER DATABASE [TechnoparkPractic] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TechnoparkPractic]
GO
/****** Object:  Table [dbo].[EducationInstitution]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationInstitution](
	[EducationalID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TypeEducationID] [int] NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[ContactPerson] [nvarchar](150) NOT NULL,
	[PhoneContact] [nvarchar](50) NOT NULL,
	[Contract] [nvarchar](150) NULL,
	[CostOfTrainees] [int] NULL,
	[ContractTime] [nvarchar](100) NULL,
 CONSTRAINT [PK_EducationInstitution] PRIMARY KEY CLUSTERED 
(
	[EducationalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_MasterClass]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_MasterClass](
	[IDLabMaster] [int] NOT NULL,
	[LabID] [int] NULL,
	[MasterClassID] [int] NULL,
 CONSTRAINT [PK_Lab_MasterClass] PRIMARY KEY CLUSTERED 
(
	[IDLabMaster] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratory]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratory](
	[LabID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[HeadOfLab] [nvarchar](150) NOT NULL,
	[PassportOfLab] [nvarchar](150) NULL,
	[NumberOfSeats] [int] NOT NULL,
 CONSTRAINT [PK_Laboratory] PRIMARY KEY CLUSTERED 
(
	[LabID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasterClass]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterClass](
	[MasterClassID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Duration] [nvarchar](50) NULL,
	[MasterClassTopic] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
	[File] [nvarchar](100) NULL,
 CONSTRAINT [PK_MasterClass] PRIMARY KEY CLUSTERED 
(
	[MasterClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainee]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainee](
	[TraineeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[LabID] [int] NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[EducationalID] [int] NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Trainee] PRIMARY KEY CLUSTERED 
(
	[TraineeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfEducationInstitution]    Script Date: 19.05.2024 21:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfEducationInstitution](
	[TypeEducationID] [int] NOT NULL,
	[NameOfType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfEducationInstitution] PRIMARY KEY CLUSTERED 
(
	[TypeEducationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Laboratory] ON 

INSERT [dbo].[Laboratory] ([LabID], [Name], [Address], [HeadOfLab], [PassportOfLab], [NumberOfSeats]) VALUES (1, N'Лаборатория Адаптивного производства', N'ул. Вильгельма Пика д.4 к.8', N'Бочаров Олег Семенович', NULL, 14)
INSERT [dbo].[Laboratory] ([LabID], [Name], [Address], [HeadOfLab], [PassportOfLab], [NumberOfSeats]) VALUES (2, N'Лаборатория VR/AR', N'ул. Вильгельма Пика д.4 к.8', N'Рубаков Алексей Валерьевич', NULL, 15)
INSERT [dbo].[Laboratory] ([LabID], [Name], [Address], [HeadOfLab], [PassportOfLab], [NumberOfSeats]) VALUES (6, N'123у', N'йцу', N'йцу', NULL, 1)
SET IDENTITY_INSERT [dbo].[Laboratory] OFF
GO
INSERT [dbo].[TypeOfEducationInstitution] ([TypeEducationID], [NameOfType]) VALUES (1, N'Колледж')
INSERT [dbo].[TypeOfEducationInstitution] ([TypeEducationID], [NameOfType]) VALUES (2, N'Школа')
INSERT [dbo].[TypeOfEducationInstitution] ([TypeEducationID], [NameOfType]) VALUES (3, N'Университет')
GO
ALTER TABLE [dbo].[EducationInstitution]  WITH CHECK ADD  CONSTRAINT [FK_EducationInstitution_TypeOfEducationInstitution] FOREIGN KEY([TypeEducationID])
REFERENCES [dbo].[TypeOfEducationInstitution] ([TypeEducationID])
GO
ALTER TABLE [dbo].[EducationInstitution] CHECK CONSTRAINT [FK_EducationInstitution_TypeOfEducationInstitution]
GO
ALTER TABLE [dbo].[Lab_MasterClass]  WITH CHECK ADD  CONSTRAINT [FK_Lab_MasterClass_Laboratory] FOREIGN KEY([LabID])
REFERENCES [dbo].[Laboratory] ([LabID])
GO
ALTER TABLE [dbo].[Lab_MasterClass] CHECK CONSTRAINT [FK_Lab_MasterClass_Laboratory]
GO
ALTER TABLE [dbo].[Lab_MasterClass]  WITH CHECK ADD  CONSTRAINT [FK_Lab_MasterClass_MasterClass] FOREIGN KEY([MasterClassID])
REFERENCES [dbo].[MasterClass] ([MasterClassID])
GO
ALTER TABLE [dbo].[Lab_MasterClass] CHECK CONSTRAINT [FK_Lab_MasterClass_MasterClass]
GO
ALTER TABLE [dbo].[Trainee]  WITH CHECK ADD  CONSTRAINT [FK_Trainee_EducationInstitution] FOREIGN KEY([EducationalID])
REFERENCES [dbo].[EducationInstitution] ([EducationalID])
GO
ALTER TABLE [dbo].[Trainee] CHECK CONSTRAINT [FK_Trainee_EducationInstitution]
GO
ALTER TABLE [dbo].[Trainee]  WITH CHECK ADD  CONSTRAINT [FK_Trainee_Laboratory] FOREIGN KEY([LabID])
REFERENCES [dbo].[Laboratory] ([LabID])
GO
ALTER TABLE [dbo].[Trainee] CHECK CONSTRAINT [FK_Trainee_Laboratory]
GO
USE [master]
GO
ALTER DATABASE [TechnoparkPractic] SET  READ_WRITE 
GO
