USE [EnrollmentSystemDB]
GO
/****** Object:  Table [dbo].[tbl_irregularsched]    Script Date: 1/13/2022 2:38:15 PM ******/
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
