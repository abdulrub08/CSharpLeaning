USE [mailing project]
GO
/****** Object:  Table [dbo].[impound_mail]    Script Date: 06/23/2012 11:27:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[impound_mail](
	[fromempid] [varchar](20) NULL,
	[toempid] [varchar](20) NULL,
	[tocc] [varchar](200) NULL,
	[tobcc] [varchar](200) NULL,
	[subject] [varchar](max) NULL,
	[message] [nvarchar](max) NULL,
	[af1] [varchar](100) NULL,
	[af2] [varchar](100) NULL,
	[af3] [varchar](100) NULL,
	[af4] [varchar](100) NULL,
	[af5] [varchar](100) NULL,
	[entrydate] [datetime] NULL,
	[activestatus] [bit] NULL CONSTRAINT [DF_impound mail_activestatus]  DEFAULT ((1))
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 06/23/2012 11:27:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userinfo](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[username] [varchar](25) NULL,
	[empid] [varchar](15) NOT NULL,
	[password] [varchar](20) NULL,
	[designation] [varchar](20) NULL,
	[address] [varchar](50) NULL,
	[contactno] [varchar](15) NULL,
	[remark] [varchar](50) NULL,
	[entrydate] [datetime] NULL,
	[activestatus] [bit] NULL CONSTRAINT [DF_userinfo_activestatus]  DEFAULT ((1)),
 CONSTRAINT [PK_userinfo] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
