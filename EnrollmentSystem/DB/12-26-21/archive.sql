USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_archive]    Script Date: 1/1/2022 11:17:56 AM ******/
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
/****** Object:  Table [dbo].[tbl_student]    Script Date: 1/1/2022 11:17:56 AM ******/
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
