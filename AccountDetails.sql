USE [work21]
GO
/****** Object:  Table [dbo].[AccountDetails]    Script Date: 28-Aug-22 10:14:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountType] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Firstname] [varchar](50) NULL,
	[DateOfBirth] [datetime] NULL,
	[MiddleName] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL,
	[StreetName] [varchar](max) NULL,
	[HouseNumber] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[PostalCode] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[MaritalStatus] [varchar](50) NULL,
	[IsTermAgreed] [bit] NULL,
	[DateCreated] [datetime] NULL,
	[SignatureURL] [varchar](max) NULL,
	[CurrentBalance] [decimal](18, 0) NULL,
	[BookBalance] [decimal](18, 0) NULL,
	[AccountNumber] [bigint] NULL,
	[AccountName] [varchar](50) NULL,
	[BranchLocation] [varchar](50) NULL,
 CONSTRAINT [PK_AccountDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 28-Aug-22 10:14:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TransactionID] [bigint] NULL,
	[AccountID] [bigint] NULL,
	[TransactionType] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_TransactionDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountDetails] ON 
GO
INSERT [dbo].[AccountDetails] ([ID], [AccountType], [Surname], [Firstname], [DateOfBirth], [MiddleName], [PhoneNumber], [EmailAddress], [StreetName], [HouseNumber], [City], [State], [PostalCode], [Country], [MaritalStatus], [IsTermAgreed], [DateCreated], [SignatureURL], [CurrentBalance], [BookBalance], [AccountNumber], [AccountName], [BranchLocation]) VALUES (1, N'string', N'string', N'string', CAST(N'2022-08-27T12:10:23.310' AS DateTime), N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', 1, CAST(N'2022-08-27T12:10:23.310' AS DateTime), N'string', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, NULL, NULL)
GO
INSERT [dbo].[AccountDetails] ([ID], [AccountType], [Surname], [Firstname], [DateOfBirth], [MiddleName], [PhoneNumber], [EmailAddress], [StreetName], [HouseNumber], [City], [State], [PostalCode], [Country], [MaritalStatus], [IsTermAgreed], [DateCreated], [SignatureURL], [CurrentBalance], [BookBalance], [AccountNumber], [AccountName], [BranchLocation]) VALUES (2, N'string', N'string', N'string', CAST(N'2022-08-27T12:43:42.837' AS DateTime), N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', 1, CAST(N'2022-08-27T12:43:42.837' AS DateTime), N'string', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, N'string', N'string')
GO
INSERT [dbo].[AccountDetails] ([ID], [AccountType], [Surname], [Firstname], [DateOfBirth], [MiddleName], [PhoneNumber], [EmailAddress], [StreetName], [HouseNumber], [City], [State], [PostalCode], [Country], [MaritalStatus], [IsTermAgreed], [DateCreated], [SignatureURL], [CurrentBalance], [BookBalance], [AccountNumber], [AccountName], [BranchLocation]) VALUES (3, N'string', N'string', N'string', CAST(N'2022-08-27T15:18:29.610' AS DateTime), N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', 1, CAST(N'2022-08-27T15:18:29.610' AS DateTime), N'string', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, N'string', N'string')
GO
SET IDENTITY_INSERT [dbo].[AccountDetails] OFF
GO
ALTER TABLE [dbo].[AccountDetails] ADD  CONSTRAINT [DF_AccountDetails_ITermAgreed]  DEFAULT ((0)) FOR [IsTermAgreed]
GO
