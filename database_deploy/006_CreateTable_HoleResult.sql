USE [Golf]
GO

/****** Object:  Table [dbo].[HoleResult]    Script Date: 9/26/2020 12:02:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HoleResult](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoleId] [int] NULL,
	[RoundId] [int] NULL,
	[PersonId] [int] NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_HoleResult] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HoleResult]  WITH CHECK ADD  CONSTRAINT [FK_HoleResult_Hole] FOREIGN KEY([HoleId])
REFERENCES [dbo].[Hole] ([Id])
GO

ALTER TABLE [dbo].[HoleResult] CHECK CONSTRAINT [FK_HoleResult_Hole]
GO

ALTER TABLE [dbo].[HoleResult]  WITH CHECK ADD  CONSTRAINT [FK_HoleResult_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO

ALTER TABLE [dbo].[HoleResult] CHECK CONSTRAINT [FK_HoleResult_Person]
GO

ALTER TABLE [dbo].[HoleResult]  WITH CHECK ADD  CONSTRAINT [FK_HoleResult_Round] FOREIGN KEY([RoundId])
REFERENCES [dbo].[Round] ([Id])
GO

ALTER TABLE [dbo].[HoleResult] CHECK CONSTRAINT [FK_HoleResult_Round]
GO


