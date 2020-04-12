
USE [CafeManagement]
GO
/****** Object:  UserDefinedTableType [dbo].[typeSaleDetail]    Script Date: 4/12/2020 9:22:44 PM ******/
CREATE TYPE [dbo].[typeSaleDetail] AS TABLE(
	[ID] [int] NULL,
	[ItemID] [int] NULL,
	[SaleQnty] [int] NULL,
	[SalePrice] [float] NULL,
	[Tax_Perc] [float] NULL,
	[Tax_Amnt] [float] NULL,
	[SaleAmnt] [float] NULL
)
GO
/****** Object:  Table [dbo].[AccountMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  Table [dbo].[SaleDetail]    Script Date: 4/12/2020 9:22:44 PM ******/
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
	[SaleAmnt] [float] NULL DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  Table [dbo].[TableSetup]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetAll_AccountMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetAll_ItemCategory]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetAll_ItemMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetAll_Sale]    Script Date: 4/12/2020 9:22:44 PM ******/
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

		select sd.ID, ItemID, ItemName, SaleQnty, sd.SalePrice, sd.Tax_Perc, sd.Tax_Amnt, sd.SaleAmnt
		from SaleDetail sd inner join ItemMaster im on sd.ItemID = im.ID		
		where SaleID = @ID
	
	end
END


GO
/****** Object:  StoredProcedure [dbo].[spGetAll_TableSetup]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spSaveAccountMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spSaveItemCategory]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spSaveItemMaster]    Script Date: 4/12/2020 9:22:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spSaveSale]    Script Date: 4/12/2020 9:22:44 PM ******/
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
						tar.Tax_Amnt = src.Tax_Amnt,			tar.SaleAmnt = src.SaleAmnt
			when not matched then 
				INSERT (SaleID, ItemID, SaleQnty, SalePrice, Tax_Perc, Tax_Amnt, SaleAmnt)
				values(@TranID, ItemID, SaleQnty, SalePrice, Tax_Perc, Tax_Amnt, SaleAmnt);
			
			
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
/****** Object:  StoredProcedure [dbo].[spSaveTableSetup]    Script Date: 4/12/2020 9:22:44 PM ******/
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

