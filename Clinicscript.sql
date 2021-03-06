USE [master]
GO
/****** Object:  Database [ClinicManagement]    Script Date: 05/01/2017 11:10:57 PM ******/
CREATE DATABASE [ClinicManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClinicManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ClinicManagement.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ClinicManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ClinicManagement_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ClinicManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ClinicManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClinicManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ClinicManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClinicManagement] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ClinicManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ClinicManagement]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NOT NULL,
	[ServiceFee] [money] NOT NULL,
	[MedicineFee] [money] NOT NULL,
	[DateOfBill] [smalldatetime] NOT NULL,
	[Amount] [money] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceFee] [money] NOT NULL,
	[Note] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicalRecord]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[MedicalRecord](
	[MedicalRecordID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[ExamineReason] [nvarchar](200) NULL,
	[Diagnostic] [nvarchar](200) NULL,
	[ExamineDate] [smalldatetime] NOT NULL,
	[ReExamineDate] [smalldatetime] NULL,
	[Note] [nvarchar](200) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_MedicalRecord] PRIMARY KEY CLUSTERED 
(
	[MedicalRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[MedicineID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineName] [nvarchar](50) NOT NULL,
	[MedicineTypeID] [int] NOT NULL,
	[WayToUseID] [int] NOT NULL,
	[PharmacyTypeID] [int] NOT NULL,
	[UnitID] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[MedicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicineType]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineType](
	[MedicineTypeID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MedicineType] PRIMARY KEY CLUSTERED 
(
	[MedicineTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[DateOfBirth] [smalldatetime] NOT NULL,
	[Job] [nvarchar](200) NULL,
	[Phone] [varchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PermissionDetail]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionDetail](
	[PermissionDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionID] [int] NOT NULL,
	[UserGroupID] [int] NOT NULL,
 CONSTRAINT [PK_PermissionDetail] PRIMARY KEY CLUSTERED 
(
	[PermissionDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NOT NULL,
	[Amount] [money] NOT NULL,
 CONSTRAINT [PK_Prescription] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PrescriptionDetail]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrescriptionDetail](
	[PrescriptionID] [int] NOT NULL,
	[MedicineID] [int] NOT NULL,
	[MedicineFee] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[HowToUse] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC,
	[MedicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PharmacyType]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacyType](
	[PharmacyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PharmacyTypeName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_PharmacyType] PRIMARY KEY CLUSTERED 
(
	[PharmacyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Queue]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Queue](
	[QueueID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[ExamineReason] [nvarchar](200) NOT NULL,
	[ExamineDate] [smalldatetime] NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[DoctorID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QueueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[PatientScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Phone] [varchar](15) NULL,
	[Address] [nvarchar](50) NULL,
	[DoctorID] [int] NOT NULL,
	[Note] [nvarchar](200) NULL,
	[ScheduleDate] [smalldatetime] NOT NULL,
	[ScheduleType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[PatientScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Service]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](200) NOT NULL,
	[ServiceFee] [money] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServiceDetail]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceDetail](
	[ServiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ServiceFee] [money] NOT NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[ServiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Unit]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Email] [varchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[DateOfBirth] [smalldatetime] NULL,
	[UserGroupID] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[UserGroupID] [int] IDENTITY(1,1) NOT NULL,
	[UserGroupName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[UserGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WayToUse]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WayToUse](
	[WayToUseID] [int] IDENTITY(1,1) NOT NULL,
	[WayToUseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_WayToUse] PRIMARY KEY CLUSTERED 
(
	[WayToUseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (1, 7, 250000.0000, 0.0000, CAST(N'2017-01-03 00:00:00' AS SmallDateTime), 250000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (2, 9, -110000.0000, 360000.0000, CAST(N'2017-01-03 00:00:00' AS SmallDateTime), 250000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (3, 9, -110000.0000, 360000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 250000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (4, 8, 200000.0000, 50000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 250000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (5, 10, 100000.0000, 320000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 420000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (6, 11, 110000.0000, 140000.0000, CAST(N'2017-01-04 00:00:00' AS SmallDateTime), 250000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (7, 14, 0.0000, 220000.0000, CAST(N'2017-01-05 00:00:00' AS SmallDateTime), 220000.0000, 1)
INSERT [dbo].[Bill] ([BillID], [MedicalRecordID], [ServiceFee], [MedicineFee], [DateOfBill], [Amount], [UserID]) VALUES (8, 15, 100000.0000, 420000.0000, CAST(N'2017-01-05 00:00:00' AS SmallDateTime), 520000.0000, 1)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[MedicalRecord] ON 

INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (1, 1, 2, N'Tai kham', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'', NULL)
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (2, 3, 2, N'Đau bụng', N'Chắc là đau bụng', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'', NULL)
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (3, 2, 3, N'Mất ngủ', N'adas', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'', N'Examined')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (4, 5, 3, N'Mất ngủ', N'Thiếu máu', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'nhớ uống thuốc đúng giờ', N'Examined')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (5, 6, 2, N'Bệnh gì đó', N'Chắc là bệnh gì đó', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), CAST(N'2017-01-19 00:00:00' AS SmallDateTime), N'', NULL)
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (6, 7, 2, N'Mất ngủ', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, NULL, N'Examining')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (7, 8, 3, N'Đau lưng, khó vận động', N'Chắc là đau lưng đó mà', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), CAST(N'2017-01-12 00:00:00' AS SmallDateTime), N'Nhớ tái khám', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (8, 9, 2, N'Mệt mỏi', N'Bệnh gì đó', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), CAST(N'2017-01-12 00:00:00' AS SmallDateTime), N'Nhớ tái khám', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (9, 10, 3, N'Không có', N'Bệnh nặng', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (10, 5, 2, N'Bens', N'njkasjdk', CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, N'', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (11, 8, 3, N'hsjkdfk', N'hjkahfknl', CAST(N'2017-01-04 00:00:00' AS SmallDateTime), NULL, N'', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (12, 7, 3, N'Mất ngủ', N'Mất ngủ do thiếu máu', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-20 00:00:00' AS SmallDateTime), N'', N'Examining')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (13, 5, 3, N'Đau bụng', N'', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), NULL, NULL, N'Examining')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (14, 8, 2, N'Trật khớp', N'Trật khớp cổ chân', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-13 00:00:00' AS SmallDateTime), N'', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (15, 4, 2, N'Đau toàn thân', N'Chèn dây thần kinh', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-20 00:00:00' AS SmallDateTime), N'Nhớ tái khám', N'Payment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (16, 1, 3, N'Mất ngủ', N'Mất ngủ do lo lắng', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-13 00:00:00' AS SmallDateTime), N'Nhớ tái khám', N'NotPayment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (17, 11, 2, N'Đau cột sống', N'Gai cột sống', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-13 00:00:00' AS SmallDateTime), N'Nhớ tái khám', N'NotPayment')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note], [Status]) VALUES (18, 12, 2, N'jksdn', N'sadgsg', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), CAST(N'2017-01-11 00:00:00' AS SmallDateTime), N'', N'NotPayment')
SET IDENTITY_INSERT [dbo].[MedicalRecord] OFF
SET IDENTITY_INSERT [dbo].[Medicine] ON 

INSERT [dbo].[Medicine] ([MedicineID], [MedicineName], [MedicineTypeID], [WayToUseID], [PharmacyTypeID], [UnitID], [Price]) VALUES (1, N'abcsjdk', 1, 1, 1, 1, 10000.0000)
INSERT [dbo].[Medicine] ([MedicineID], [MedicineName], [MedicineTypeID], [WayToUseID], [PharmacyTypeID], [UnitID], [Price]) VALUES (2, N'Thuốc gì đó', 2, 1, 2, 2, 40000.0000)
SET IDENTITY_INSERT [dbo].[Medicine] OFF
SET IDENTITY_INSERT [dbo].[MedicineType] ON 

INSERT [dbo].[MedicineType] ([MedicineTypeID], [MedicineTypeName]) VALUES (1, N'Giảm đau')
INSERT [dbo].[MedicineType] ([MedicineTypeID], [MedicineTypeName]) VALUES (2, N'Thuốc ngoại')
SET IDENTITY_INSERT [dbo].[MedicineType] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (1, N'Huynh Minh Tri', N'Nam', N'Bình Dương', CAST(N'1995-12-24 00:00:00' AS SmallDateTime), N'Sinh viên', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (2, N'Bệnh nhân A', N'Nữ', N'Quận 1, HCM', CAST(N'1995-01-01 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (3, N'Bệnh nhân B', N'Nam', N'Quận Thủ Đức, HCM', CAST(N'1980-02-15 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (4, N'Lê Văn Hà', N'Nam', N'Quận 2, HCM', CAST(N'1990-05-20 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (5, N'Nguyễn Thị  Nữ', N'Nữ', N'Bình Dương', CAST(N'1990-01-30 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (6, N'hjfkhsjdf', N'Nam', N'Thu Duc', CAST(N'1990-05-20 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (7, N'Đặng Trung Tín', N'Nam', N'Thủ Đức', CAST(N'1995-11-04 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (8, N'Lê Văn Nam', N'Nam', N'Bình Dương', CAST(N'1987-01-15 00:00:00' AS SmallDateTime), N'Công nhân', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (9, N'Hồ Hữu Tài', N'Nam', N'Thủ Đức', CAST(N'1992-05-02 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (10, N'Bệnh nhân thứ n', N'Nam', N'HCM', CAST(N'2000-01-01 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (11, N'Đào Văn Khê', N'Nam', N'Quận 2, HCM', CAST(N'1986-08-15 00:00:00' AS SmallDateTime), N'Giáo viên', N'', N'', CAST(N'2017-01-05 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (12, N'Trần Quốc Tuấn', N'Nam', N'HCM', CAST(N'1993-01-01 00:00:00' AS SmallDateTime), N'SV', N'', N'', CAST(N'2017-01-05 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Permission] ON 

INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (1, N'Tiếp nhận bệnh nhân')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (2, N'Khám bệnh')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (3, N'Thanh toán')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (4, N'Quản lý bệnh nhân')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (5, N'Quản lý thuốc')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (6, N'Loại thuốc')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (7, N'Dạng bào chế')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (8, N'Đường dùng')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (9, N'Đơn vị tính')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (10, N'Quản lý lịch hẹn')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (11, N'Dịch vụ')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (12, N'Quản lý người dùng')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (13, N'Phân quyền')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (14, N'Thay đổi cơ sở dữ liệu')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (15, N'Báo cáo lượt khám')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (16, N'Báo cáo doanh thu')
SET IDENTITY_INSERT [dbo].[Permission] OFF
SET IDENTITY_INSERT [dbo].[PermissionDetail] ON 

INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (3, 12, 2)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (4, 13, 2)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (5, 14, 2)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (6, 1, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (7, 2, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (8, 3, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (9, 4, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (10, 5, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (11, 6, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (12, 7, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (13, 8, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (14, 9, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (15, 10, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (16, 11, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (17, 12, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (18, 13, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (19, 14, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (20, 15, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (21, 16, 3)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (22, 3, 4)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (27, 2, 1)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (28, 4, 1)
INSERT [dbo].[PermissionDetail] ([PermissionDetailID], [PermissionID], [UserGroupID]) VALUES (29, 10, 1)
SET IDENTITY_INSERT [dbo].[PermissionDetail] OFF
SET IDENTITY_INSERT [dbo].[Prescription] ON 

INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (1, 3, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (2, 4, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (3, 5, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (4, 2, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (5, 7, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (6, 8, 50000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (7, 9, 360000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (8, 10, 320000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (9, 11, 140000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (10, 14, 220000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (11, 15, 420000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (12, 16, 0.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (13, 17, 120000.0000)
INSERT [dbo].[Prescription] ([PrescriptionID], [MedicalRecordID], [Amount]) VALUES (14, 18, 0.0000)
SET IDENTITY_INSERT [dbo].[Prescription] OFF
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (1, 1, 0.0000, 2, N'Sangs jalkdfj')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (2, 1, 0.0000, 10, N'Sáng 1 viên, tối 1 viên')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (2, 2, 0.0000, 5, N'Sáng nửa chai, tối nửa chai')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (3, 1, 0.0000, 10, N'Sáng 1, tối 1')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (3, 2, 0.0000, 5, N'sáng 1, tối 1')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (5, 1, 0.0000, 4, N'sáng 1 viên, tối 1 viên')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (5, 2, 0.0000, 2, N'Sáng nửa chai, tối nửa chai')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (6, 1, 10000.0000, 20, N'Sángdjk')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (6, 2, 40000.0000, 10, N'sdfgjshkf sgd a')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (7, 1, 200000.0000, 20, N'dssdfsgf')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (7, 2, 160000.0000, 4, N'sdfgdf')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (8, 1, 120000.0000, 12, N'sgsgsd sdf')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (8, 2, 200000.0000, 5, N'wertrefg')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (9, 1, 20000.0000, 2, N'w wsf as')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (9, 2, 120000.0000, 3, N'dwry ')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (10, 1, 100000.0000, 10, N'ánkjn aknsk')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (10, 2, 120000.0000, 3, N'ahjsjshdbj')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (11, 1, 20000.0000, 2, N'jkạn bahjs')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (11, 2, 400000.0000, 10, N'ánkjn jká')
INSERT [dbo].[PrescriptionDetail] ([PrescriptionID], [MedicineID], [MedicineFee], [Quantity], [HowToUse]) VALUES (13, 2, 120000.0000, 3, N'shdkjh nsjkd')
SET IDENTITY_INSERT [dbo].[PharmacyType] ON 

INSERT [dbo].[PharmacyType] ([PharmacyTypeID], [PharmacyTypeName]) VALUES (1, N'viên')
INSERT [dbo].[PharmacyType] ([PharmacyTypeID], [PharmacyTypeName]) VALUES (2, N'nước')
SET IDENTITY_INSERT [dbo].[PharmacyType] OFF
SET IDENTITY_INSERT [dbo].[Queue] ON 

INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (1, 1, N'Đau chân', CAST(N'2017-01-02 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (2, 2, N'Mất ngủ', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (3, 3, N'Đau bụng', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (4, 1, N'Tai kham', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (5, 4, N'Thích thì khám', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (6, 5, N'Mất ngủ', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (7, 6, N'Bệnh gì đó', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (8, 7, N'Mất ngủ', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'A', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (9, 8, N'Đau lưng, khó vận động', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (10, 9, N'Mệt mỏi', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (11, 10, N'Không có', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (12, 5, N'Bens', CAST(N'2017-01-04 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (13, 8, N'hsjkdfk', CAST(N'2017-01-04 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (14, 7, N'Mất ngủ', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'A', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (15, 5, N'Đau bụng', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'A', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (16, 8, N'Trật khớp', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (17, 4, N'Đau toàn thân', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (18, 5, N'Viêm xoan', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'A', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (19, 1, N'Mất ngủ', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'I', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (20, 11, N'Đau cột sống', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (21, 12, N'jksdn', CAST(N'2017-01-05 00:00:00' AS SmallDateTime), N'I', 2)
SET IDENTITY_INSERT [dbo].[Queue] OFF
SET IDENTITY_INSERT [dbo].[Schedule] ON 

INSERT [dbo].[Schedule] ([PatientScheduleID], [FullName], [Phone], [Address], [DoctorID], [Note], [ScheduleDate], [ScheduleType]) VALUES (1, N'Trần Quốc Tuấn', N'01564864156', N'Quận 1', 2, N'', CAST(N'2017-01-13 00:00:00' AS SmallDateTime), N'Hẹn khám')
INSERT [dbo].[Schedule] ([PatientScheduleID], [FullName], [Phone], [Address], [DoctorID], [Note], [ScheduleDate], [ScheduleType]) VALUES (2, N'jkshjkfhk', N'2456456374', N'jkhd', 3, N'', CAST(N'2017-01-06 00:00:00' AS SmallDateTime), N'Hẹn khám')
SET IDENTITY_INSERT [dbo].[Schedule] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (1, N'Khám bệnh', 100000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (2, N'Chụp X-Quang', 80000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (3, N'Nội soi', 150000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (4, N'Tiểu phẩu', 200000.0000)
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[ServiceDetail] ON 

INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (12, 2, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (13, 1, 1, 80000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (14, 1, 2, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (21, 5, 1, 80000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (22, 4, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (23, 4, 3, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (27, 7, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (28, 7, 2, 80000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (29, 7, 3, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (32, 8, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (33, 8, 3, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (36, 9, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (37, 9, 3, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (40, 10, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (41, 10, 4, 200000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (44, 11, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (45, 11, 3, 150000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (46, 12, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (48, 14, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (51, 15, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (52, 15, 2, 80000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (61, 16, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (62, 16, 2, 80000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (64, 17, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (67, 18, 1, 100000.0000)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID], [ServiceFee]) VALUES (68, 18, 2, 80000.0000)
SET IDENTITY_INSERT [dbo].[ServiceDetail] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitID], [UnitName]) VALUES (1, N'viên')
INSERT [dbo].[Unit] ([UnitID], [UnitName]) VALUES (2, N'chai')
INSERT [dbo].[Unit] ([UnitID], [UnitName]) VALUES (3, N'hộp')
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (1, N'Admin', N'admin@gmail.com', N'Thủ Đức', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), 3, N'admin', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (2, N'Nguyễn Văn A', N'', N'', NULL, 1, N'doctor1', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (3, N'Đỗ Hữu Tài', N'', N'', NULL, 1, N'doctor2', N'e10adc3949ba59abbe56e057f20f883e')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserGroup] ON 

INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (1, N'Doctor')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (2, N'Admin')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (3, N'SuperAdmin')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (4, N'KeToan')
SET IDENTITY_INSERT [dbo].[UserGroup] OFF
SET IDENTITY_INSERT [dbo].[WayToUse] ON 

INSERT [dbo].[WayToUse] ([WayToUseID], [WayToUseName]) VALUES (1, N'uống')
INSERT [dbo].[WayToUse] ([WayToUseID], [WayToUseName]) VALUES (2, N'chích')
SET IDENTITY_INSERT [dbo].[WayToUse] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_MedicalRecord] FOREIGN KEY([MedicalRecordID])
REFERENCES [dbo].[MedicalRecord] ([MedicalRecordID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_MedicalRecord]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[MedicalRecord]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecord_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[MedicalRecord] CHECK CONSTRAINT [FK_MedicalRecord_Patient]
GO
ALTER TABLE [dbo].[MedicalRecord]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecord_User] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[MedicalRecord] CHECK CONSTRAINT [FK_MedicalRecord_User]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_MedicineType] FOREIGN KEY([MedicineTypeID])
REFERENCES [dbo].[MedicineType] ([MedicineTypeID])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_MedicineType]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_PharmacyType] FOREIGN KEY([PharmacyTypeID])
REFERENCES [dbo].[PharmacyType] ([PharmacyTypeID])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_PharmacyType]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Unit] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Unit]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_WayToUse] FOREIGN KEY([WayToUseID])
REFERENCES [dbo].[WayToUse] ([WayToUseID])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_WayToUse]
GO
ALTER TABLE [dbo].[PermissionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PermissionDetail_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([PermissionID])
GO
ALTER TABLE [dbo].[PermissionDetail] CHECK CONSTRAINT [FK_PermissionDetail_Permission]
GO
ALTER TABLE [dbo].[PermissionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PermissionDetail_UserGroup] FOREIGN KEY([UserGroupID])
REFERENCES [dbo].[UserGroup] ([UserGroupID])
GO
ALTER TABLE [dbo].[PermissionDetail] CHECK CONSTRAINT [FK_PermissionDetail_UserGroup]
GO
ALTER TABLE [dbo].[PrescriptionDetail]  WITH CHECK ADD FOREIGN KEY([MedicineID])
REFERENCES [dbo].[Medicine] ([MedicineID])
GO
ALTER TABLE [dbo].[PrescriptionDetail]  WITH CHECK ADD FOREIGN KEY([MedicineID])
REFERENCES [dbo].[Medicine] ([MedicineID])
GO
ALTER TABLE [dbo].[PrescriptionDetail]  WITH CHECK ADD FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[Prescription] ([PrescriptionID])
GO
ALTER TABLE [dbo].[Queue]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Queue]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[ServiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_MedicalRecord] FOREIGN KEY([MedicalRecordID])
REFERENCES [dbo].[MedicalRecord] ([MedicalRecordID])
GO
ALTER TABLE [dbo].[ServiceDetail] CHECK CONSTRAINT [FK_Detail_MedicalRecord]
GO
ALTER TABLE [dbo].[ServiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[ServiceDetail] CHECK CONSTRAINT [FK_Detail_Service]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserGroup] FOREIGN KEY([UserGroupID])
REFERENCES [dbo].[UserGroup] ([UserGroupID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserGroup]
GO
/****** Object:  StoredProcedure [dbo].[GET_EXAMINE_TURN]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create
  PROCEDURE [dbo].[GET_EXAMINE_TURN]
    @DateFrom smalldatetime,
	@DateTo smalldatetime 
    AS
    Select count (MedicalRecordID) as 'Số lượt khám', ExamineDate as 'Ngày khám'
	from MedicalRecord
	where ExamineDate >= @DateFrom and ExamineDate <= @DateTo
	group by ExamineDate

GO
/****** Object:  StoredProcedure [dbo].[GET_REVANUE]    Script Date: 05/01/2017 11:10:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create
 PROCEDURE [dbo].[GET_REVANUE]
    @DateFrom smalldatetime,
	@DateTo smalldatetime 
    AS
    Select sum (ServiceFee) as 'Thu phí Dịch vụ', SUM (MedicineFee) as 'Tiền bán thuốc', sum(Amount) as 'Tổng doanh thu' ,DateOfBill as 'Ngày thanh toán'
	from Bill
	where DateOfBill >= @DateFrom and DateOfBill <= @DateTo
	group by DateOfBill
GO
USE [master]
GO
ALTER DATABASE [ClinicManagement] SET  READ_WRITE 
GO
