USE [Golf]
GO

/****** Object:  Table [dbo].[Round]    Script Date: 9/26/2020 12:02:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Round](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NULL,
	[StartTime] [datetimeoffset](7) NULL,
	[EndTime] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_Round] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Round]  WITH CHECK ADD  CONSTRAINT [FK_Round_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO

ALTER TABLE [dbo].[Round] CHECK CONSTRAINT [FK_Round_Course]
GO


