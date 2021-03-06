USE [PM]
GO
/****** Object:  Table [dbo].[FiscalPeriod]    Script Date: 09/09/2020 5:16:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalPeriod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FromDate] [datetime] NULL,
	[Todate] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_FiscalPeriod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
