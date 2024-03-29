USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_archive]    Script Date: 1/20/2022 4:13:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_archive](
	[StudentID] [varchar](50) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
	[First Name] [varchar](50) NOT NULL,
	[Middle Name] [varchar](50) NULL,
	[School Year] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Mobile Number] [varchar](15) NOT NULL,
	[EMail] [varchar](50) NOT NULL,
	[Birthdate] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_archive] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_course]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_course](
	[Course Code] [varchar](50) NOT NULL,
	[Course Name] [varchar](100) NOT NULL,
	[Years] [int] NOT NULL,
	[Semesters] [int] NOT NULL,
	[Required Units] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tbl_course] PRIMARY KEY CLUSTERED 
(
	[Course Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculum]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculum](
	[Curriculum Code] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_curriculum] PRIMARY KEY CLUSTERED 
(
	[Curriculum Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculum_subject]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculum_subject](
	[Curriculum Code] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL,
	[Year level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_faculty]    Script Date: 1/20/2022 4:13:22 PM ******/
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
/****** Object:  Table [dbo].[tbl_irregularsched]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_irregularsched](
	[StudentID] [varchar](50) NOT NULL,
	[Section Code] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_schedule]    Script Date: 1/20/2022 4:13:22 PM ******/
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
/****** Object:  Table [dbo].[tbl_section]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_section](
	[Section Code] [varchar](50) NOT NULL,
	[Curriculum Code] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Number of Students] [int] NOT NULL,
 CONSTRAINT [PK_tbl_section] PRIMARY KEY CLUSTERED 
(
	[Section Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_section_student]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_section_student](
	[Section Code] [varchar](50) NOT NULL,
	[StudentID] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_student]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_student](
	[StudentID] [varchar](50) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
	[First Name] [varchar](50) NOT NULL,
	[Middle Name] [varchar](50) NULL,
	[School Year] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Mobile Number] [varchar](15) NOT NULL,
	[EMail] [varchar](50) NOT NULL,
	[Birthdate] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_subject]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_subject](
	[Subject Code] [varchar](50) NOT NULL,
	[Subject Name] [varchar](100) NOT NULL,
	[Units] [decimal](18, 2) NOT NULL,
	[Category] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 1/20/2022 4:13:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[usernames] [varchar](50) NOT NULL,
	[passwords] [varchar](50) NULL
) ON [PRIMARY]
GO
