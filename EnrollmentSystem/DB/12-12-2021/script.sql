USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_course]    Script Date: 12/12/2021 6:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_course](
	[Course Code] [varchar](50) NOT NULL,
	[Course Name] [varchar](50) NOT NULL,
	[Years] [decimal](18, 2) NOT NULL,
	[Semesters] [decimal](18, 2) NOT NULL,
	[Required Units] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tbl_course] PRIMARY KEY CLUSTERED 
(
	[Course Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculum]    Script Date: 12/12/2021 6:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculum](
	[Curriculum Code] [varchar](50) NOT NULL,
	[Course Code] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Total Units] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbl_curriculum] PRIMARY KEY CLUSTERED 
(
	[Curriculum Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_curriculum_subject]    Script Date: 12/12/2021 6:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_curriculum_subject](
	[Curriculum Code] [varchar](50) NOT NULL,
	[Subject Code] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_subject]    Script Date: 12/12/2021 6:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_subject](
	[Subject Code] [varchar](50) NOT NULL,
	[Subject Name] [varchar](50) NOT NULL,
	[Units] [decimal](18, 2) NOT NULL,
	[Category] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
