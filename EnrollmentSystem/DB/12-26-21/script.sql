USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_curriculum]    Script Date: 12/26/2021 11:02:17 AM ******/
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
/****** Object:  Table [dbo].[tbl_curriculum_subject]    Script Date: 12/26/2021 11:02:18 AM ******/
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
/****** Object:  Table [dbo].[tbl_section]    Script Date: 12/26/2021 11:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_section](
	[Section Code] [varchar](50) NOT NULL,
	[Curriculum Code] [varchar](50) NOT NULL,
	[Year Level] [varchar](50) NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[Number of Students] [int] NOT NULL,
 CONSTRAINT [PK_tbl_section] PRIMARY KEY CLUSTERED 
(
	[Section Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
