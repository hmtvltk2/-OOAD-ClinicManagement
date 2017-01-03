USE [master]
GO
/****** Object:  Database [ClinicManagement]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Bill]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[BillDetail]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[MedicalRecord]    Script Date: 03/01/2017 9:35:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
 CONSTRAINT [PK_MedicalRecord] PRIMARY KEY CLUSTERED 
(
	[MedicalRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[MedicineType]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Permission]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[PermissionDetail]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Prescription]    Script Date: 03/01/2017 9:35:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NOT NULL,
 CONSTRAINT [PK_Prescription] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PrescriptionDetail]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[PharmacyType]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Queue]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[Schedule]    Script Date: 03/01/2017 9:35:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[PatientScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Phone] [varchar](15) NOT NULL,
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
/****** Object:  Table [dbo].[Service]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[ServiceDetail]    Script Date: 03/01/2017 9:35:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceDetail](
	[ServiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[ServiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Unit]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[UserGroup]    Script Date: 03/01/2017 9:35:26 AM ******/
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
/****** Object:  Table [dbo].[WayToUse]    Script Date: 03/01/2017 9:35:26 AM ******/
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
SET IDENTITY_INSERT [dbo].[MedicalRecord] ON 

INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note]) VALUES (1, 1, 2, N'Tai kham', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'')
INSERT [dbo].[MedicalRecord] ([MedicalRecordID], [PatientID], [DoctorID], [ExamineReason], [Diagnostic], [ExamineDate], [ReExamineDate], [Note]) VALUES (2, 3, 2, N'Đau bụng', N'Chắc là đau bụng', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), NULL, N'')
SET IDENTITY_INSERT [dbo].[MedicalRecord] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (1, N'Huynh Minh Tri', N'Nam', N'Bình Dương', CAST(N'1995-12-24 00:00:00' AS SmallDateTime), N'Sinh viên', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (2, N'Bệnh nhân A', N'Nữ', N'Quận 1, HCM', CAST(N'1995-01-01 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (3, N'Bệnh nhân B', N'Nam', N'Quận Thủ Đức, HCM', CAST(N'1980-02-15 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-02 00:00:00' AS SmallDateTime))
INSERT [dbo].[Patient] ([PatientID], [FullName], [Gender], [Address], [DateOfBirth], [Job], [Phone], [Note], [CreateDate]) VALUES (4, N'Lê Văn Hà', N'Nam', N'Quận 2, HCM', CAST(N'1990-05-20 00:00:00' AS SmallDateTime), N'', N'', N'', CAST(N'2017-01-03 00:00:00' AS SmallDateTime))
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
SET IDENTITY_INSERT [dbo].[Queue] ON 

INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (1, 1, N'Đau chân', CAST(N'2017-01-02 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (2, 2, N'Mất ngủ', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'A', 3)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (3, 3, N'Đau bụng', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (4, 1, N'Tai kham', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
INSERT [dbo].[Queue] ([QueueID], [PatientID], [ExamineReason], [ExamineDate], [Status], [DoctorID]) VALUES (5, 4, N'Thích thì khám', CAST(N'2017-01-03 00:00:00' AS SmallDateTime), N'I', 2)
SET IDENTITY_INSERT [dbo].[Queue] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (1, N'Khám bệnh', 100000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (2, N'Chụp X-Quang', 80000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (3, N'Nội soi', 150000.0000)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServiceFee]) VALUES (4, N'Tiểu phẩu', 200000.0000)
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[ServiceDetail] ON 

INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID]) VALUES (12, 2, 1)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID]) VALUES (13, 1, 1)
INSERT [dbo].[ServiceDetail] ([ServiceDetailID], [MedicalRecordID], [ServiceID]) VALUES (14, 1, 2)
SET IDENTITY_INSERT [dbo].[ServiceDetail] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (1, N'Admin', N'admin@gmail.com', N'', NULL, 3, N'admin', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (2, N'Nguyễn Văn A', N'', N'', NULL, 1, N'doctor1', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[User] ([UserID], [FullName], [Email], [Address], [DateOfBirth], [UserGroupID], [Username], [Password]) VALUES (3, N'Đỗ Hữu Tài', N'', N'', NULL, 1, N'doctor2', N'e10adc3949ba59abbe56e057f20f883e')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserGroup] ON 

INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (1, N'Doctor')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (2, N'Admin')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (3, N'SuperAdmin')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupName]) VALUES (4, N'KeToan')
SET IDENTITY_INSERT [dbo].[UserGroup] OFF
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
ALTER TABLE [dbo].[PrescriptionDetail]  WITH CHECK ADD FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[Prescription] ([PrescriptionID])
GO
ALTER TABLE [dbo].[Queue]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Queue]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
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
USE [master]
GO
ALTER DATABASE [ClinicManagement] SET  READ_WRITE 
GO
