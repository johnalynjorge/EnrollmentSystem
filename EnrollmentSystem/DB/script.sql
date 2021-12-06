USE [master]
GO
/****** Object:  Database [EnrollmentSystemDB]    Script Date: 12/6/2021 3:33:24 PM ******/
CREATE DATABASE [EnrollmentSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnrollmentSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EnrollmentSystemDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnrollmentSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EnrollmentSystemDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EnrollmentSystemDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnrollmentSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnrollmentSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnrollmentSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EnrollmentSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EnrollmentSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnrollmentSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EnrollmentSystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [EnrollmentSystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EnrollmentSystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnrollmentSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnrollmentSystemDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EnrollmentSystemDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EnrollmentSystemDB] SET QUERY_STORE = OFF
GO
USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_course]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_course](
	[Course Code] [varchar](50) NOT NULL,
	[Course Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_course] PRIMARY KEY CLUSTERED 
(
	[Course Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculum_subject]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculum_subject](
	[Curriculum Code] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL,
	[Hours Required] [decimal](2, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculums]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculums](
	[Curriculum Code] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Total Units] [int] NULL,
 CONSTRAINT [PK_tbl_curriculums] PRIMARY KEY CLUSTERED 
(
	[Curriculum Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_faculty]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_faculty](
	[InstructorID] [varchar](50) NOT NULL,
	[First Name] [varchar](50) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
	[Contact num] [varchar](50) NOT NULL,
	[Department] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_faculty] PRIMARY KEY CLUSTERED 
(
	[InstructorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_irregularsched]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_irregularsched](
	[StudentID] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL,
	[InstructorID] [varchar](50) NOT NULL,
	[Day] [varchar](50) NOT NULL,
	[Start Time] [varchar](50) NOT NULL,
	[End Time] [varchar](50) NOT NULL,
	[Room] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_schedule]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_schedule](
	[Section Code] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL,
	[InstructorID] [varchar](50) NOT NULL,
	[Day] [varchar](50) NOT NULL,
	[Start Time] [varchar](50) NOT NULL,
	[End Time] [varchar](50) NOT NULL,
	[Room] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_section]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_section](
	[Section Code] [varchar](50) NOT NULL,
	[Curriculum Code] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_section] PRIMARY KEY CLUSTERED 
(
	[Section Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_section_student]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_section_student](
	[Section Code] [varchar](50) NOT NULL,
	[StudentID] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_student]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_student](
	[StudentID] [varchar](50) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
	[First Name] [varchar](50) NOT NULL,
	[Middle Name] [varchar](50) NOT NULL,
	[School Year] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Mobile Number] [varchar](15) NOT NULL,
	[EMail] [varchar](50) NOT NULL,
	[Birthdate] [date] NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_subject]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_subject](
	[Subject Code] [varchar](50) NOT NULL,
	[Subject Name] [varchar](50) NOT NULL,
	[Units] [int] NOT NULL,
	[Category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_subject] PRIMARY KEY CLUSTERED 
(
	[Subject Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 12/6/2021 3:33:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[usernames] [varchar](50) NOT NULL,
	[passwords] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [EnrollmentSystemDB] SET  READ_WRITE 
GO
