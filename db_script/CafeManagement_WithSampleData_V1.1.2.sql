
USE [CafeManagement]
GO
/****** Object:  UserDefinedTableType [dbo].[typeDealDetail]    Script Date: 4/19/2020 1:05:44 PM ******/
CREATE TYPE [dbo].[typeDealDetail] AS TABLE(
	[ID] [int] NULL,
	[ItemID] [int] NULL,
	[DealQnty] [int] NULL,
	[SalePrice] [float] NULL,
	[DealPrice] [float] NULL DEFAULT ((0)),
	[Tax_Perc] [float] NULL DEFAULT ((0)),
	[Tax_Amnt] [float] NULL DEFAULT ((0)),
	[DealAmnt] [float] NULL DEFAULT ((0))
)
GO
/****** Object:  UserDefinedTableType [dbo].[typeSaleDetail]    Script Date: 4/19/2020 1:05:44 PM ******/
CREATE TYPE [dbo].[typeSaleDetail] AS TABLE(
	[ID] [int] NULL,
	[ItemID] [int] NULL,
	[DealID] [int] NULL,
	[SaleQnty] [int] NULL,
	[SalePrice] [float] NULL,
	[Tax_Perc] [float] NULL,
	[Tax_Amnt] [float] NULL,
	[SaleAmnt] [float] NULL
)
GO
/****** Object:  Table [dbo].[AccountMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctName] [nvarchar](150) NULL,
	[AcctType] [nvarchar](50) NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[CellNo] [nvarchar](50) NULL,
	[Remarks] [nvarchar](500) NULL,
	[InActive] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DealDetail]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DealDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DealID] [int] NULL,
	[ItemID] [int] NULL,
	[DealQnty] [int] NULL,
	[DealPrice] [float] NULL DEFAULT ((0)),
	[Tax_Perc] [float] NULL DEFAULT ((0)),
	[Tax_Amnt] [float] NULL DEFAULT ((0)),
	[DealAmnt] [float] NULL DEFAULT ((0)),
	[SalePrice] [float] NULL DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DealMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DealMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DealName] [nvarchar](100) NULL,
	[DealDescription] [nvarchar](500) NULL,
	[DealPerson] [int] NULL,
	[Remarks] [nvarchar](1000) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[DealAmnt] [float] NULL,
	[InActive] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CatgName] [nvarchar](100) NULL,
	[InActive] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](150) NULL,
	[ShortName] [nvarchar](20) NULL,
	[CatgID] [int] NULL,
	[CostPrice] [float] NULL,
	[SalePrice] [float] NULL,
	[InActive] [bit] NULL,
	[Tax_Perc] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleDetail]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NULL,
	[ItemID] [int] NULL,
	[SaleQnty] [int] NULL,
	[SalePrice] [float] NULL,
	[Tax_Perc] [float] NULL,
	[Tax_Amnt] [float] NULL DEFAULT ((0)),
	[SaleAmnt] [float] NULL DEFAULT ((0)),
	[DealID] [int] NULL DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SaleDate] [date] NULL,
	[SaleType] [nvarchar](50) NULL,
	[TableSetupID] [int] NULL,
	[Walk_Cust] [nvarchar](150) NULL,
	[CellNo] [nvarchar](50) NULL,
	[Remarks] [nvarchar](500) NULL,
	[AddOn] [datetime] NULL,
	[EditOn] [datetime] NULL,
	[IsBilled] [bit] NULL,
	[DiscPerc] [float] NULL DEFAULT ((0)),
	[DiscAmnt] [float] NULL DEFAULT ((0)),
	[AcctID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableSetup]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableSetup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableDesc] [nvarchar](100) NULL,
	[InActive] [bit] NULL,
	[ShortName] [nvarchar](20) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AccountMaster] ON 

GO
INSERT [dbo].[AccountMaster] ([ID], [AcctName], [AcctType], [ContactPerson], [CellNo], [Remarks], [InActive]) VALUES (1, N'Food Panda', N'Delivery', N'', N'', N'', 0)
GO
INSERT [dbo].[AccountMaster] ([ID], [AcctName], [AcctType], [ContactPerson], [CellNo], [Remarks], [InActive]) VALUES (2, N'Cash sale', N'Regular', N'contact person', N'cell no', N'remarks', 0)
GO
SET IDENTITY_INSERT [dbo].[AccountMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[DealDetail] ON 

GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (1, 1, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (2, 1, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (3, 2, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (4, 2, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (5, 3, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (6, 3, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (7, 1, 1, 1, 135, 0, 0, 135, NULL)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (8, 4, 8, 1, 60, 10, 5.5, 60, 70)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (9, 4, 7, 1, 35, 0, 0, 35, 55)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (10, 4, 2, 1, 160, 0, 0, 160, 180)
GO
INSERT [dbo].[DealDetail] ([ID], [DealID], [ItemID], [DealQnty], [DealPrice], [Tax_Perc], [Tax_Amnt], [DealAmnt], [SalePrice]) VALUES (11, 4, 1, 1, 120, 0, 0, 120, 11)
GO
SET IDENTITY_INSERT [dbo].[DealDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[DealMaster] ON 

GO
INSERT [dbo].[DealMaster] ([ID], [DealName], [DealDescription], [DealPerson], [Remarks], [StartDate], [EndDate], [DealAmnt], [InActive]) VALUES (1, N'D3', N'', 2, N'', CAST(N'2020-04-13 00:00:00.000' AS DateTime), CAST(N'2020-04-13 00:00:00.000' AS DateTime), 375.5, 0)
GO
INSERT [dbo].[DealMaster] ([ID], [DealName], [DealDescription], [DealPerson], [Remarks], [StartDate], [EndDate], [DealAmnt], [InActive]) VALUES (2, N'D2', N'', 1, N'', CAST(N'2020-04-13 00:00:00.000' AS DateTime), CAST(N'2020-04-13 00:00:00.000' AS DateTime), 200, 0)
GO
INSERT [dbo].[DealMaster] ([ID], [DealName], [DealDescription], [DealPerson], [Remarks], [StartDate], [EndDate], [DealAmnt], [InActive]) VALUES (3, N'D1', N'', 1, N'', CAST(N'2020-04-13 00:00:00.000' AS DateTime), CAST(N'2020-04-13 00:00:00.000' AS DateTime), 200, 0)
GO
INSERT [dbo].[DealMaster] ([ID], [DealName], [DealDescription], [DealPerson], [Remarks], [StartDate], [EndDate], [DealAmnt], [InActive]) VALUES (4, N'D4', N'', 0, N'', CAST(N'2020-04-13 00:00:00.000' AS DateTime), CAST(N'2020-04-13 00:00:00.000' AS DateTime), 380.5, 0)
GO
SET IDENTITY_INSERT [dbo].[DealMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemCategory] ON 

GO
INSERT [dbo].[ItemCategory] ([ID], [CatgName], [InActive]) VALUES (1, N'Bevareges', 0)
GO
INSERT [dbo].[ItemCategory] ([ID], [CatgName], [InActive]) VALUES (2, N'Fast Food', 0)
GO
INSERT [dbo].[ItemCategory] ([ID], [CatgName], [InActive]) VALUES (3, N'General Items', 1)
GO
SET IDENTITY_INSERT [dbo].[ItemCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemMaster] ON 

GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (1, N'Chicken Burger', N'ChickenBurger', 2, 100, 135, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (2, N'BEEF BURGER', N'BEEF BURGER', 2, 115, 180, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (3, N'Pepsi Regular 250 ml', N'PEPSI 250ml', 1, 22, 30, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (4, N'7UP Regular 250 ml', N'7up 250ml', 1, 20, 30, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (5, N'Miranda Regular 250 ml', N'Miranda 250ml', 1, 25, 30, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (6, N'Water Bottle 500 ml', N'Water Small', 1, 17, 30, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (7, N'7up Regular 500 ml', N'7up 500 ml', 1, 42, 55, 0, NULL)
GO
INSERT [dbo].[ItemMaster] ([ID], [ItemName], [ShortName], [CatgID], [CostPrice], [SalePrice], [InActive], [Tax_Perc]) VALUES (8, N'Pepsi Regular 500 ml', N'Pepsi 500 ml', 1, 44, 55, 0, 10)
GO
SET IDENTITY_INSERT [dbo].[ItemMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleDetail] ON 

GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (2, 0, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (3, 3, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (4, 4, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (5, 5, 3, 1, 30, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (6, 5, 8, 1, 55, 10, 5.5, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (7, 5, 1, 1, 135, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (8, 6, 8, 1, 55, 10, 5.5, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (27, 12, 8, 3, 55, 10, 16.5, 181.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (28, 12, 7, 1, 55, 0, 0, 55, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (30, 13, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (31, 14, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (32, 14, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (36, 15, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (37, 15, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (38, 16, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (39, 16, 1, 1, 135, 0, 0, 135, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (40, 16, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (41, 17, 1, 1, 120, 0, 0, 120, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (42, 17, 2, 1, 160, 0, 0, 160, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (43, 17, 7, 1, 35, 0, 0, 35, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (44, 17, 8, 1, 60, 10, 6, 66, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (45, 17, 1, 1, 135, 0, 0, 135, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (52, 18, 2, 1, 180, 0, 0, 180, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (53, 18, 1, 2, 120, 0, 0, 240, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (54, 18, 2, 2, 160, 0, 0, 320, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (55, 18, 7, 2, 35, 0, 0, 70, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (56, 18, 8, 2, 60, 10, 12, 132, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (57, 19, 1, 1, 120, 0, 0, 120, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (58, 19, 2, 1, 160, 0, 0, 160, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (59, 19, 7, 1, 35, 0, 0, 35, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (60, 19, 8, 1, 60, 10, 6, 66, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (61, 19, 2, 1, 180, 0, 0, 180, 0)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (62, 20, 2, 1, 180, 0, 0, 180, 3)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (63, 20, 8, 1, 55, 10, 5.5, 60.5, 3)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (64, 20, 1, 1, 120, 0, 0, 120, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (65, 20, 2, 1, 160, 0, 0, 160, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (66, 20, 7, 1, 35, 0, 0, 35, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (67, 20, 8, 1, 60, 10, 6, 66, 4)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (9, 7, 8, 1, 55, 10, 5.5, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (10, 8, 8, 1, 55, 10, 5.5, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (11, 9, 8, 1, 55, 10, 5.5, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (12, 8, 1, 1, 135, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (13, 9, 2, 1, 180, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (14, 8, 7, 1, 55, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (15, 10, 7, 1, 55, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (16, 10, 2, 1, 180, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (17, 10, 1, 1, 135, 0, 0, 0, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (24, 11, 8, 1, 55, 10, 5.5, 60.5, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (25, 11, 7, 1, 55, 0, 0, 55, NULL)
GO
INSERT [dbo].[SaleDetail] ([ID], [SaleID], [ItemID], [SaleQnty], [SalePrice], [Tax_Perc], [Tax_Amnt], [SaleAmnt], [DealID]) VALUES (26, 11, 5, 1, 30, 0, 0, 30, NULL)
GO
SET IDENTITY_INSERT [dbo].[SaleDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleMaster] ON 

GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (1, CAST(N'2020-04-11' AS Date), N'False', 5, N'', N'', N'', CAST(N'2020-04-11 04:37:37.690' AS DateTime), NULL, NULL, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (2, CAST(N'2020-04-11' AS Date), N'False', 5, N'name', N'cell no', N'remarks', CAST(N'2020-04-11 04:43:39.913' AS DateTime), NULL, NULL, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (3, CAST(N'2020-04-11' AS Date), N'False', 5, N'name', N'cell no', N'remarks', CAST(N'2020-04-11 04:44:01.617' AS DateTime), CAST(N'2020-04-12 19:42:13.360' AS DateTime), 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (4, CAST(N'2020-04-11' AS Date), N'True', 0, N'', N'', N'', CAST(N'2020-04-11 15:51:05.963' AS DateTime), CAST(N'2020-04-11 23:47:33.843' AS DateTime), 1, 4, 2.42, 1)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (5, CAST(N'2020-04-12' AS Date), N'True', 0, N'cash on delivery', N'te', N'', CAST(N'2020-04-12 02:57:29.023' AS DateTime), NULL, 1, 0, 0, 1)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (6, CAST(N'2020-04-12' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-12 03:00:49.573' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (12, CAST(N'2020-04-13' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-13 01:58:25.680' AS DateTime), CAST(N'2020-04-13 02:49:03.307' AS DateTime), 1, 0, 50, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (13, CAST(N'2020-04-13' AS Date), N'False', 1, N'', N'', N'', CAST(N'2020-04-13 16:53:37.060' AS DateTime), CAST(N'2020-04-13 16:53:44.760' AS DateTime), 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (14, CAST(N'2020-04-13' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-13 16:58:48.630' AS DateTime), NULL, 1, 0, 100, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (15, CAST(N'2020-04-13' AS Date), N'False', 1, N'', N'', N'', CAST(N'2020-04-13 16:58:56.777' AS DateTime), CAST(N'2020-04-13 16:59:01.140' AS DateTime), 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (16, CAST(N'2020-04-13' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-13 16:59:17.317' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (17, CAST(N'2020-04-13' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-13 21:49:20.660' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (18, CAST(N'2020-04-13' AS Date), N'False', 1, N'', N'', N'', CAST(N'2020-04-13 21:50:15.230' AS DateTime), CAST(N'2020-04-13 21:50:19.640' AS DateTime), 0, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (19, CAST(N'2020-04-13' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-13 21:55:40.710' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (20, CAST(N'2020-04-19' AS Date), N'False', 0, N'', N'', N'', CAST(N'2020-04-19 12:19:27.970' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (7, CAST(N'2020-04-12' AS Date), N'False', 1, N'', N'', N'', CAST(N'2020-04-12 03:26:00.293' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (8, CAST(N'2020-04-12' AS Date), N'False', 1, N'casg', N'', N'', CAST(N'2020-04-12 03:30:08.550' AS DateTime), CAST(N'2020-04-12 15:18:03.457' AS DateTime), 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (9, CAST(N'2020-04-12' AS Date), N'False', 2, N'', N'', N'', CAST(N'2020-04-12 03:30:41.393' AS DateTime), CAST(N'2020-04-12 03:33:54.167' AS DateTime), 0, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (10, CAST(N'2020-04-12' AS Date), N'True', 0, N'', N'', N'', CAST(N'2020-04-12 17:11:35.483' AS DateTime), NULL, 1, 0, 0, 0)
GO
INSERT [dbo].[SaleMaster] ([ID], [SaleDate], [SaleType], [TableSetupID], [Walk_Cust], [CellNo], [Remarks], [AddOn], [EditOn], [IsBilled], [DiscPerc], [DiscAmnt], [AcctID]) VALUES (11, CAST(N'2020-04-12' AS Date), N'False', 1, N'', N'', N'', CAST(N'2020-04-12 19:51:57.367' AS DateTime), CAST(N'2020-04-12 19:52:23.443' AS DateTime), 1, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[SaleMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TableSetup] ON 

GO
INSERT [dbo].[TableSetup] ([ID], [TableDesc], [InActive], [ShortName]) VALUES (1, N'table 01', 0, N'TBL 01- 90988763')
GO
INSERT [dbo].[TableSetup] ([ID], [TableDesc], [InActive], [ShortName]) VALUES (2, N'Table 02', 0, N'TBL-02 12-345-6789-0')
GO
INSERT [dbo].[TableSetup] ([ID], [TableDesc], [InActive], [ShortName]) VALUES (3, N'Table 03', 0, N'T-03-123-456-789')
GO
INSERT [dbo].[TableSetup] ([ID], [TableDesc], [InActive], [ShortName]) VALUES (4, N'Table 04', 1, N'T04')
GO
INSERT [dbo].[TableSetup] ([ID], [TableDesc], [InActive], [ShortName]) VALUES (5, N'T 01', 0, N'01234567890123456789')
GO
SET IDENTITY_INSERT [dbo].[TableSetup] OFF
GO
/****** Object:  StoredProcedure [dbo].[spGetAll_AccountMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
create PROCEDURE [dbo].[spGetAll_AccountMaster]
(
	@Id nvarchar(10) = '%',
	@AcctName nvarchar(150) = '%',
	@AcctType nvarchar(50) = '%',
	@InActive nvarchar(10) = '%'
)
AS
BEGIN


	select  ID, AcctName, AcctType, ContactPerson, CellNo, Remarks, InActive
	from AccountMaster
	where convert(varchar, ID) like @Id
	and AcctName like @AcctName
	and AcctType like @AcctType
	and convert(nvarchar, InActive) like @InActive
	order by ID DESC

END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_Deal]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
CREATE	 PROCEDURE [dbo].[spGetAll_Deal]
(
	@Id nvarchar(10) = '%',
	@InActive nvarchar(10) = '%'
)
AS
BEGIN

	select  dm.ID, DealName, DealDescription, DealPerson, Remarks, StartDate, EndDate, DealAmnt, InActive
	from DealMaster dm 
	where	convert(varchar, dm.ID) like @Id
	and convert(varchar, dm.InActive) like @InActive
	order by dm.ID DESC

	if(@ID <> '%')
	begin	

		select dd.ID, dd.DealID, dd.ItemID, ItemName, dd.DealQnty, dd.SalePrice, dd.DealPrice, dd.Tax_Perc, dd.Tax_Amnt, dd.DealAmnt
		from DealDetail dd 
		inner join ItemMaster im on dd.ItemID = im.ID		
		where DealID = @ID
	
	end
END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_ItemCategory]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
create PROCEDURE [dbo].[spGetAll_ItemCategory]
(
	@Id nvarchar(10) = '%',
	@CatgName nvarchar(100) = '%',
	@InActive nvarchar(10) = '%'
)
AS
BEGIN


	select  ID, CatgName, InActive
	from ItemCategory
	where convert(varchar, ID) like @Id
	and CatgName like @CatgName
	and convert(nvarchar, InActive) like @InActive
	order by ID DESC

END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_ItemMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
CREATE PROCEDURE [dbo].[spGetAll_ItemMaster]
(
	@Id nvarchar(10) = '%',
	@ShortName nvarchar(20) = '%',
	@ItemName nvarchar(150) = '%',
	@InActive nvarchar(10) = '%'
)
AS
BEGIN


	select  im.ID, ItemName, ShortName, CatgID, CatgName, CostPrice, SalePrice, Tax_Perc, im.InActive
	from ItemMaster im left join ItemCategory ic on im.CatgID = ic.ID
	where convert(varchar, im.ID) like @Id
	and ShortName like @ShortName
	and ItemName like @ItemName
	and convert(nvarchar, im.InActive) like @InActive
	order by im.ID DESC

END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_Sale]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
CREATE PROCEDURE [dbo].[spGetAll_Sale]
(
	@Id nvarchar(10) = '%', 
	@IsBilled nvarchar(10) = '%',
	@TableSetupID nvarchar(10) = '%'

)
AS
BEGIN


	if(@IsBilled = '0' and @TableSetupID <> '0' and @ID = '%')	
	begin
		select top 1 @Id = ID from SaleMaster where isnull(@IsBilled, 0) <> 1 and TableSetupID = @TableSetupID ORDER BY ID desc
	end


	select  sm.ID, SaleDate, SaleType, TableSetupID, Walk_Cust, sm.CellNo, sm.Remarks, DiscPerc, DiscAmnt, 
		AcctID, AcctName, AddOn, EditOn, IsBilled
	from SaleMaster sm left join TableSetup ts on sm.TableSetupID = ts.ID
	left join AccountMaster am on sm.AcctID = am.ID
	where	convert(varchar, sm.ID) like @Id
		and convert(varchar, isnull(IsBilled, 'False')) like @IsBilled
		and convert(varchar, sm.TableSetupID) like @TableSetupID
	order by sm.ID DESC

	if(@ID <> '%')
	begin

		select sd.ID, ItemID, sd.DealID, DealName, ItemName, 
				ItemName + case when sd.DealID <> 0 then '[' + DealName + ']' else '' end PrintItem,
				SaleQnty, sd.SalePrice, sd.Tax_Perc, sd.Tax_Amnt, sd.SaleAmnt
		from SaleDetail sd inner join ItemMaster im on sd.ItemID = im.ID		
		left join DealMaster dm on sd.DealID = dm.ID
		where SaleID = @ID
	
	end
END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_TableSetup]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Syed Danish Khawar>
-- Create date: <09 Apr 2020>
-- Description:	<Get All Tables >
-- =============================================
CREATE PROCEDURE [dbo].[spGetAll_TableSetup]
(
	@Id nvarchar(10) = '%',
	@TableDesc nvarchar(100) = '%',
	@InActive nvarchar(10) = '%'
)
AS
BEGIN


	select  ID, TableDesc, ShortName ,InActive
	from TableSetup
	where convert(varchar, ID) like @Id
	and TableDesc like @TableDesc
	and convert(nvarchar, InActive) like @InActive
	order by ID DESC

END


GO
/****** Object:  StoredProcedure [dbo].[spSaveAccountMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spSaveAccountMaster]
@TranID int,
@AcctName nvarchar (150),
@AcctType nvarchar(50),
@ContactPerson nvarchar(50),
@CellNo nvarchar (50) ,
@Remarks nvarchar (500),
@InActive bit

AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	
	if(@TranID <> 0)
		Begin
			update AccountMaster set
			AcctName = @AcctName,
			AcctType = @AcctType,
			ContactPerson=@ContactPerson,
			CellNo= @CellNo,
			Remarks = @Remarks,
			InActive = @InActive
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
		End
	Else
		Begin			
		if exists(SELECT AcctName FROM AccountMaster WHERE AcctName = @AcctName)
			BEGIN
				SELECT 'Duplicate', 'Account name must not be duplicate.'
			END
		ELSE
			begin
				insert into AccountMaster(AcctName, AcctType, ContactPerson, CellNo, Remarks, InActive)
				Values(@AcctName, @AcctType, @ContactPerson, @CellNo, @Remarks, @InActive)
			
				SELECT @TranID = IDENT_CURRENT('AccountMaster')
				SELECT @TranID
			end
	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;
	
END CATCH





GO
/****** Object:  StoredProcedure [dbo].[spSaveDeal]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSaveDeal]
	@TranID int,
	@DealName nvarchar (100),
	@DealDescription nvarchar (500) ,
	@DealPerson int ,
	@Remarks nvarchar (1000) null,
	@StartDate datetime  ,
	@EndDate datetime ,
	@DealAmnt float ,
	@InActive bit ,
	@typeDealDetail dbo.typeDealDetail READONLY
	
	
AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	begin
	if(@TranID <> 0)
		Begin

			--////	updating Master		///// -----
			
			update DealMaster set
			DealName = @DealName,
			DealDescription = @DealDescription,
			DealPerson = @DealPerson,
			Remarks = @Remarks,
			StartDate = @StartDate,
			EndDate = @EndDate,
			DealAmnt = @DealAmnt,
			InActive = @InActive
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
			--////	end updating Master		///// -----
		
		end
		else
		begin
			insert into DealMaster(DealName , DealDescription, DealPerson, Remarks, StartDate, EndDate, DealAmnt, InActive)
			values(@DealName , @DealDescription, @DealPerson, @Remarks, @StartDate, @EndDate, @DealAmnt, @InActive)
			
			SELECT @TranID = IDENT_CURRENT('DealMaster')
			SELECT @TranID

		end
			--////	insert / updating Detail		///// -----

			--==== deleting deleted records
			delete from DealDetail WHERE DealID = @TranID and ID not in (select ID FROM @typeDealDetail)
			--==== end deleting deleted records

			merge DealDetail tar
				using @typeDealDetail src on tar.ID = src.ID
			when matched then
				update set		
						tar.ItemID = src.ItemID,				tar.DealQnty = src.DealQnty,			
						tar.SalePrice = src.SalePrice,
						tar.DealPrice = src.DealPrice,			tar.Tax_Perc = src.Tax_Perc,			
						tar.Tax_Amnt = src.Tax_Amnt,			tar.DealAmnt = src.DealAmnt
			when not matched then 
				INSERT (DealID, ItemID, DealQnty, SalePrice, DealPrice, Tax_Perc, Tax_Amnt, DealAmnt)
				values(@TranID, ItemID, DealQnty, SalePrice, DealPrice, Tax_Perc, Tax_Amnt, DealAmnt);
			
			
			--////	end insert / updating Detail 	///// -----
		

	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;

END CATCH





GO
/****** Object:  StoredProcedure [dbo].[spSaveItemCategory]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spSaveItemCategory]
@TranID int,
@CatgName nvarchar(100),
@InActive bit

AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	
	if(@TranID <> 0)
		Begin
			update ItemCategory set
			CatgName = @CatgName,
			InActive = @InActive
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
		End
	Else
		Begin			
		if exists(SELECT CatgName FROM ItemCategory WHERE CatgName = @CatgName)
			BEGIN
				SELECT 'Duplicate', 'Item Category name must not be duplicate.'
			END
		ELSE
			begin
				insert into ItemCategory(CatgName, InActive)
				Values(@CatgName, @InActive)
			
				SELECT @TranID = IDENT_CURRENT('ItemCategory')
				SELECT @TranID
			end
	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;

END CATCH





GO
/****** Object:  StoredProcedure [dbo].[spSaveItemMaster]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSaveItemMaster]
@TranID int,
@ItemName nvarchar(150),
@ShortName nvarchar(20) ,
@CatgID int , 
@CostPrice float,
@SalePrice float,
@Tax_Perc float,
@InActive bit

AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	
	if(@TranID <> 0)
		Begin
			update ItemMaster set
			ItemName= @ItemName,
			ShortName = @ShortName,
			CatgID= @CatgID,
			CostPrice= @CostPrice,
			SalePrice= @SalePrice,
			Tax_Perc=@Tax_Perc,
			InActive = @InActive
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
		End
	Else
		Begin			
		if exists(SELECT ShortName FROM ItemMaster  WHERE ShortName = @ShortName)
			BEGIN
				SELECT 'Duplicate', 'Item short name must not be duplicate.'
			END
		ELSE
			begin
				insert into ItemMaster(ItemName, ShortName, CatgID, CostPrice, SalePrice, Tax_Perc, InActive)
				Values(@ItemName, @ShortName, @CatgID, @CostPrice, @SalePrice, @Tax_Perc, @InActive)
			
				SELECT @TranID = IDENT_CURRENT('ItemMaster')
				SELECT @TranID
			end
	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;

END CATCH





GO
/****** Object:  StoredProcedure [dbo].[spSaveSale]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSaveSale]
	@TranID int,
	@SaleDate date,
	@SaleType nvarchar(50),
	@AcctID int,
	@TableSetupID int, 
	@Walk_Cust nvarchar(150),
	@CellNo nvarchar(50),
	@Remarks nvarchar(500),
	@IsBilled bit,
	@DiscPerc float, 
	@DiscAmnt float,
	@typeSaleDetail dbo.typeSaleDetail READONLY
	
	
AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	begin
	if(@TranID <> 0)
		Begin

			--////	updating Master		///// -----
			
			update SaleMaster set
			SaleDate = @SaleDate,
			SaleType = @SaleType,
			TableSetupID = @TableSetupID,
			Walk_Cust = @Walk_Cust,
			CellNo = @CellNo ,
			AcctID = @AcctID,
			Remarks = @Remarks, 
			DiscPerc = @DiscPerc, 
			DiscAmnt = @DiscAmnt, 
			EditOn = GetDate(),
			IsBilled = @IsBilled
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
			--////	end updating Master		///// -----
		
		end
		else
		begin
			insert into SaleMaster(SaleDate, SaleType, TableSetupID, Walk_Cust ,CellNo, AcctID, Remarks, DiscPerc, DiscAmnt, IsBilled, AddOn)
			values (@SaleDate, @SaleType, @TableSetupID, @Walk_Cust ,@CellNo, @AcctID, @Remarks, @DiscPerc, @DiscAmnt, @IsBilled, GetDate())
						
			SELECT @TranID = IDENT_CURRENT('SaleMaster')
			SELECT @TranID

		end
			--////	insert / updating Detail		///// -----

			--==== deleting deleted records
			delete from SaleDetail WHERE SaleID = @TranID and ID not in (select ID FROM @typeSaleDetail)
			--==== end deleting deleted records

			merge SaleDetail tar
				using @typeSaleDetail src on tar.ID = src.ID
			when matched then
				update set		
						tar.ItemID = src.ItemID,				tar.SaleQnty = src.SaleQnty,			
						tar.SalePrice = src.SalePrice,			tar.Tax_Perc = src.Tax_Perc,			
						tar.Tax_Amnt = src.Tax_Amnt,			tar.SaleAmnt = src.SaleAmnt, 
						tar.DealID = src.DealID
			when not matched then 
				INSERT (SaleID, ItemID, SaleQnty, SalePrice, Tax_Perc, Tax_Amnt, SaleAmnt, DealID)
				values(@TranID, ItemID, SaleQnty, SalePrice, Tax_Perc, Tax_Amnt, SaleAmnt, DealID);
			
			
			--////	end insert / updating Detail 	///// -----
		

	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;

END CATCH





GO
/****** Object:  StoredProcedure [dbo].[spSaveTableSetup]    Script Date: 4/19/2020 1:05:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSaveTableSetup]
@TranID int,
@TableDesc nvarchar(100),
@ShortName nvarchar(20) ,
@InActive bit

AS
BEGIN TRY
    BEGIN TRANSACTION 
        
	SET NOCOUNT ON;

	
	if(@TranID <> 0)
		Begin
			update TableSetup set
			TableDesc = @TableDesc,
			ShortName = @ShortName,
			InActive = @InActive
			Where ID = @TranID
		
			SELECT @TranID, 'Update'
		End
	Else
		Begin			
		if exists(SELECT TableDesc FROM TableSetup WHERE ShortName = @ShortName)
			BEGIN
				SELECT 'Duplicate', 'Table Description name must not be duplicate.'
			END
		ELSE
			begin
				insert into TableSetup(TableDesc, ShortName, InActive)
				Values(@TableDesc, @ShortName, @InActive)
			
				SELECT @TranID = IDENT_CURRENT('TableSetup')
				SELECT @TranID
			end
	End    

	COMMIT TRANSACTION; 

END TRY
BEGIN CATCH

    SELECT '0' RecdStatus, ERROR_NUMBER() AS ErrorNumber
     ,ERROR_SEVERITY() AS ErrorSeverity
     ,ERROR_STATE() AS ErrorState
     ,ERROR_PROCEDURE() AS ErrorProcedure
     ,ERROR_LINE() AS ErrorLine
     ,ERROR_MESSAGE() AS ErrorMessage;
    ROLLBACK TRANSACTION;

END CATCH





GO
USE [master]
GO
ALTER DATABASE [CafeManagement] SET  READ_WRITE 
GO
