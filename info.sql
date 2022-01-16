USE [Customer]
GO

/****** Object:  Table [dbo].[info]    Script Date: 16.01.2022 22:56:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[info](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Product] [varchar](50) NULL,
	[Price] [int] NULL,
	[Payment] [varchar](50) NULL,
	[Installment] [int] NULL,
	[Last_debt] [int] NULL
) ON [PRIMARY]
GO

