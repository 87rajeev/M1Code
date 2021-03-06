/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'customerfeedbackDB')
DROP table customerfeedbackDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerfeedbackDB](
	[customerid] [uniqueidentifier] NOT NULL,
	[MainCategory] [nvarchar](50) NULL,
	[SubCategory] [nvarchar](50) NULL,
	[Comments] [nvarchar](3500) NULL,
	[Salutation] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[IDType] [nvarchar](50) NULL,
	[ID] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[M1Customer] [nvarchar](50) NULL,
	[UserIDorExistingM1Number] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EnterpriseRSVP]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'EnterpriseRSVP')
DROP table EnterpriseRSVP
GO
CREATE TABLE [dbo].[EnterpriseRSVP](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CampaignName] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[Dietary] [bit] NULL,
	[DietaryPreference] [nvarchar](50) NULL,
	[PreferredDate] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CompanyBRN] [nvarchar](50) NULL,
	[CustomerEmail] [nvarchar](50) NULL,
	[CustomerDetail1] [nvarchar](50) NULL,
	[CustomerDetail2] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](50) NULL,
	[Designation] [nvarchar](100) NULL,
	[CustomerDetail3] [nvarchar](100) NULL,
	[CustomerDetail4] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExpressPreorderReserve]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'ExpressPreorderReserve')
DROP table ExpressPreorderReserve
GO
CREATE TABLE [dbo].[ExpressPreorderReserve](
	[Transaction_ID] [uniqueidentifier] NULL,
	[M1ID] [nvarchar](50) NULL,
	[IDnumber] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Contactnumber] [numeric](18, 0) NULL,
	[PreOrderUrl] [nvarchar](250) NULL,
	[ReContract] [nvarchar](2) NULL,
	[ReContractSvcNo] [numeric](18, 0) NULL,
	[ChangePlan] [nvarchar](2) NULL,
	[Prospect] [nvarchar](2) NULL,
	[PreferredModel1] [nvarchar](50) NULL,
	[PreferredModel2] [nvarchar](50) NULL,
	[PreferredModel3] [nvarchar](50) NULL,
	[EligiblePreOrder] [nvarchar](2) NULL,
	[ROIDate] [datetime] NULL,
	[EligibleCheckDate] [datetime] NULL,
	[OrderXMLTransactionID] [nvarchar](50) NULL,
	[CollectionLocation] [nvarchar](50) NULL,
	[RuleEngineErrCode] [nvarchar](50) NULL,
	[RuleEngineErrMsg] [varchar](4000) NULL,
	[Device] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[useragent] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HBBInterest]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'HBBInterest')
DROP table HBBInterest
GO
CREATE TABLE [dbo].[HBBInterest](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CampaignName] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[PostalCode] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[BlockNum] [nvarchar](50) NULL,
	[FloorNum] [nvarchar](50) NULL,
	[UnitNum] [nvarchar](50) NULL,
	[NRIC] [nvarchar](50) NULL,
	[StreetName] [nvarchar](100) NULL,
	[ApartmentName] [nvarchar](100) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[HomeRenoCompletion] [nvarchar](100) NULL,
	[ServiceStatus] [nvarchar](100) NULL,
	[ContactNumber] [nvarchar](50) NULL,
	[CustomerDetail1] [nvarchar](50) NULL,
	[CustomerDetail2] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[M1GolfRSVP]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'M1GolfRSVP')
DROP table M1GolfRSVP
GO
CREATE TABLE [dbo].[M1GolfRSVP](
	[CustomerID] [int] NOT NULL,
	[CampaignName] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](100) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[CustomerDesignation] [nvarchar](100) NULL,
	[CurrentHandicap] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[CustomerEmail] [nvarchar](50) NULL,
	[HomeClub] [nvarchar](50) NULL,
	[ClubMemberNo] [nvarchar](50) NULL,
	[Attendance] [nvarchar](10) NULL,
	[CreateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[M1SearchTerm]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'M1SearchTerm')
DROP table M1SearchTerm
GO
CREATE TABLE [dbo].[M1SearchTerm](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SearchTerm] [nvarchar](500) NULL,
	[UserAgent] [nvarchar](500) NULL,
	[Channel] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[Value1] [nvarchar](500) NULL,
	[Value2] [nvarchar](500) NULL,
	[Value3] [nvarchar](500) NULL,
	[Value4] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MegadealsROI]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'MegadealsROI')
DROP table MegadealsROI
GO

CREATE TABLE [dbo].[MegadealsROI](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CampaignName] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[CustomerDetail1] [nvarchar](100) NULL,
	[CustomerDetail2] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
GO
/****** Object:  Table [dbo].[UnSubscribeDigiCamp]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'UnSubscribeDigiCamp')
DROP table UnSubscribeDigiCamp
GO

CREATE TABLE [dbo].[UnSubscribeDigiCamp](
	[M1ID] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Contactnumber] [numeric](18, 0) NULL,
	[TNC] [nvarchar](2) NULL,
	[Value1] [nvarchar](500) NULL,
	[Value2] [nvarchar](500) NULL,
	[Value3] [nvarchar](500) NULL,
	[Value4] [nvarchar](500) NULL,
	[Value5] [nvarchar](500) NULL,
	[UnSubDate] [datetime] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UnSubscribeDigiCampTrans]    Script Date: 3/20/2018 3:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'UnSubscribeDigiCampTrans')
DROP table UnSubscribeDigiCampTrans
GO


CREATE TABLE [dbo].[UnSubscribeDigiCampTrans](
	[M1ID] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Contactnumber] [numeric](18, 0) NULL,
	[TNC] [nvarchar](2) NULL,
	[Value1] [nvarchar](500) NULL,
	[Value2] [nvarchar](500) NULL,
	[Value3] [nvarchar](500) NULL,
	[Value4] [nvarchar](500) NULL,
	[Value5] [nvarchar](500) NULL,
	[UnSubDate] [datetime] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'ContestSubmission')
DROP table ContestSubmission
GO


CREATE TABLE "ContestSubmission" (
 "CampaignName" NVARCHAR(50) NULL,
 "M1ID" NVARCHAR(50) NULL,
 "NRIC" NVARCHAR(50) NULL,
 "Name" NVARCHAR(50) NULL,
 "Contactnumber" NUMERIC NULL,
 "ContestAnswer" NVARCHAR(2000) NULL,
 "Value1" NVARCHAR(500) NULL,
 "Value2" NVARCHAR(500) NULL,
 "Value3" NVARCHAR(500) NULL,
 "Value4" NVARCHAR(500) NULL,
 "SubmissionDate" DATETIME NULL,
 "ID" INT NOT NULL IDENTITY,
 PRIMARY KEY ("ID")
);

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'M1ShopWorkshop')
DROP table M1ShopWorkshop
GO

CREATE TABLE "M1ShopWorkshop" (
 "CustomerID" INT NOT NULL,
 "CreateDate" DATETIME NULL,
 "CampaignName" NVARCHAR(50) NULL,
 "CustomerName" NVARCHAR(100) NULL,
 "Email" NVARCHAR(100) NULL,
 "NRIC" NVARCHAR(50) NULL,
 "MobileNumber" NVARCHAR(50) NULL,
 "ContactNumber" NVARCHAR(50) NULL,
 "WorkshopName" NVARCHAR(100) NULL,
 "WorkshopLocation" NVARCHAR(50) NULL,
 "WorkshopDate" NVARCHAR(50) NULL,
 "WorkshopTime" NVARCHAR(50) NULL,
 "BringFriend" BIT NULL,
 "NumberofAttandance" INT NOT NULL,
 "AltEmail" NVARCHAR(50) NULL,
 "CustomerDetail1" NVARCHAR(50) NULL,
 "CustomerDetail2" NVARCHAR(100) NULL,
 PRIMARY KEY ("CustomerID")
);

/* Drop table if the table already exists ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'SalesEnquiry')
DROP table SalesEnquiry
GO
CREATE TABLE [dbo].[SalesEnquiry](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[M1BusinessCustomer] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[ContactNumber] [nvarchar](50) NULL,
	[ProductType] [nvarchar](100) NULL,
	[ContractExpiry] [datetime] NULL,
	[ExpectingReContractSoon] [nvarchar](100) NULL,
	[PromoCode] [nvarchar](50) NULL,
	[HowCanWeAssist] [nvarchar](100) NULL,
	[SubscribeToMailing] [bit] NULL,
	[Email] [nvarchar](50) NULL
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]