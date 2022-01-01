USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_section]    Script Date: 12/27/2021 10:50:01 AM ******/
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
