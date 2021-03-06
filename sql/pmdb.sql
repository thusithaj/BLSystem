USE [master]
GO
/****** Object:  Database [PM]    Script Date: 03/09/2020 10:38:10 AM ******/
CREATE DATABASE [PM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PM', FILENAME = N'D:\Data\PM.mdf' , SIZE = 64512KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PM_log', FILENAME = N'D:\Data\PM_log.ldf' , SIZE = 84416KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PM] SET ARITHABORT OFF 
GO
ALTER DATABASE [PM] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PM] SET  MULTI_USER 
GO
ALTER DATABASE [PM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PM]
GO
/****** Object:  Table [dbo].[AddressBook]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressBook](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FactoryId] [int] NULL,
	[AddressType] [int] NULL,
	[AddressName] [nchar](100) NULL,
	[AddressLine01] [nchar](100) NULL,
	[AddressLine02] [nchar](100) NULL,
	[City] [nchar](100) NULL,
	[TP01] [nchar](20) NULL,
	[TP02] [nchar](20) NULL,
	[Email] [nchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_AddressBook] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AddressBookType]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressBookType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NULL,
	[BookTypeName] [nchar](100) NULL,
	[Category01] [nchar](10) NULL,
	[Category02] [nchar](10) NULL,
	[Category03] [nchar](10) NULL,
	[Category04] [nchar](10) NULL,
	[Category05] [nchar](10) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_AddressBookType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collection_tbl]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection_tbl](
	[ind] [int] IDENTITY(1,1) NOT NULL,
	[trDay] [smallint] NOT NULL,
	[trMonth] [nvarchar](10) NULL,
	[trDate] [smalldatetime] NULL,
	[regNo] [int] NOT NULL,
	[Route] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Qty] [money] NOT NULL,
	[Vehicale] [nvarchar](50) NOT NULL,
	[trRate] [smallmoney] NOT NULL,
	[LeafType] [smallint] NOT NULL,
	[Ws] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nchar](100) NULL,
 CONSTRAINT [PK_CompanyMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FactoryMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FactoryMaster](
	[id] [int] NOT NULL,
	[CompanyId] [int] NULL,
	[FactoryName] [nchar](100) NULL,
 CONSTRAINT [PK_Factory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiscalPeriod]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalPeriod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FromDate] [date] NULL,
	[Todate] [date] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_FiscalPeriod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Main_Reg]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Main_Reg](
	[ind] [int] IDENTITY(1,1) NOT NULL,
	[regNo] [int] NOT NULL,
	[regName] [nvarchar](50) NULL,
	[rCode] [nvarchar](3) NOT NULL,
	[routeName] [nvarchar](50) NOT NULL,
	[NICno] [nvarchar](15) NOT NULL,
	[RegDate] [datetime] NULL,
	[LineManager] [bit] NOT NULL,
	[LineID] [int] NOT NULL,
	[SpLine] [bit] NOT NULL,
	[DyNo] [int] NOT NULL,
	[BankFK] [int] NULL,
	[NameAcHold] [nvarchar](50) NULL,
	[AcNumber] [nvarchar](18) NULL,
	[Address] [nvarchar](100) NULL,
	[PayMode] [nvarchar](25) NOT NULL,
	[WelfareReg] [nvarchar](3) NOT NULL,
	[WelfareBAL] [money] NOT NULL,
	[SavingReg] [bit] NOT NULL,
	[SavingRate] [money] NOT NULL,
	[SavingAMT] [money] NOT NULL,
	[AddRate] [smallmoney] NOT NULL,
	[xAmount] [money] NOT NULL,
	[GrosKG] [money] NOT NULL,
	[DdRate] [smallmoney] NOT NULL,
	[DdKG] [money] NOT NULL,
	[TotKg] [money] NOT NULL,
	[TotKgSL] [money] NOT NULL,
	[blRate] [money] NOT NULL,
	[blRateSL] [money] NOT NULL,
	[trRate] [money] NOT NULL,
	[TempGross] [money] NOT NULL,
	[Gross] [money] NOT NULL,
	[GrossSL] [money] NOT NULL,
	[AddPay] [money] NOT NULL,
	[AddRange] [money] NOT NULL,
	[Incentive] [numeric](18, 2) NOT NULL,
	[IncRate] [money] NOT NULL,
	[prCoins] [money] NOT NULL,
	[LMB] [money] NOT NULL,
	[FertLMB] [money] NOT NULL,
	[Transport] [money] NOT NULL,
	[Tea] [money] NOT NULL,
	[Fertilizer] [money] NOT NULL,
	[CashAdv] [money] NOT NULL,
	[FunaralReg] [bit] NOT NULL,
	[FunaralRegFee] [smallmoney] NOT NULL,
	[Funaral] [money] NOT NULL,
	[Loan] [money] NOT NULL,
	[LoanInterest] [money] NOT NULL,
	[OtherDeduction] [money] NOT NULL,
	[Stamp] [money] NOT NULL,
	[TotalDeduction] [money] NOT NULL,
	[tempBal] [money] NOT NULL,
	[crCoins] [money] NOT NULL,
	[Balance] [money] NOT NULL,
	[FertNMB] [money] NOT NULL,
	[NMB] [money] NOT NULL,
	[LoanBalance] [money] NOT NULL,
	[FuPrv] [smallint] NOT NULL,
	[FuNext] [smallint] NOT NULL,
	[CouponPrv] [money] NOT NULL,
	[CouponNext] [money] NOT NULL,
	[ChequePrinted] [bit] NOT NULL,
	[xBal] [money] NOT NULL,
	[xDebt] [money] NOT NULL,
	[xCoins] [money] NOT NULL,
	[VoucherNo] [nvarchar](12) NOT NULL,
	[ChequeNo] [int] NOT NULL,
	[ChequeDate] [datetime] NULL,
	[LastSupDate] [smalldatetime] NULL,
	[LoanArreares] [money] NOT NULL,
	[AdvBook] [bit] NOT NULL,
	[AdvPayTMP] [money] NOT NULL,
	[AdvRate] [money] NOT NULL,
	[SavingBAL] [money] NOT NULL,
	[SavingSupplier] [money] NOT NULL,
	[SavingFactory] [money] NOT NULL,
	[SavingPAID] [money] NOT NULL,
	[TPno] [nvarchar](12) NULL,
	[savingPrvCoin] [money] NULL,
	[isActive] [bit] NULL,
	[DeductionRate] [decimal](18, 2) NULL,
	[isBogus] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Main_Reg_2020_Jul]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Main_Reg_2020_Jul](
	[ind] [int] IDENTITY(1,1) NOT NULL,
	[regNo] [int] NOT NULL,
	[regName] [nvarchar](50) NULL,
	[rCode] [nvarchar](3) NOT NULL,
	[routeName] [nvarchar](50) NOT NULL,
	[NICno] [nvarchar](15) NOT NULL,
	[RegDate] [datetime] NULL,
	[LineManager] [bit] NOT NULL,
	[LineID] [int] NOT NULL,
	[SpLine] [bit] NOT NULL,
	[DyNo] [int] NOT NULL,
	[BankFK] [int] NULL,
	[NameAcHold] [nvarchar](50) NULL,
	[AcNumber] [nvarchar](18) NULL,
	[Address] [nvarchar](100) NULL,
	[PayMode] [nvarchar](25) NOT NULL,
	[WelfareReg] [nvarchar](3) NOT NULL,
	[WelfareBAL] [money] NOT NULL,
	[SavingReg] [bit] NOT NULL,
	[SavingRate] [money] NOT NULL,
	[SavingAMT] [money] NOT NULL,
	[AddRate] [smallmoney] NOT NULL,
	[xAmount] [money] NOT NULL,
	[GrosKG] [money] NOT NULL,
	[DdRate] [smallmoney] NOT NULL,
	[DdKG] [money] NOT NULL,
	[TotKg] [money] NOT NULL,
	[TotKgSL] [money] NOT NULL,
	[blRate] [money] NOT NULL,
	[blRateSL] [money] NOT NULL,
	[trRate] [money] NOT NULL,
	[TempGross] [money] NOT NULL,
	[Gross] [money] NOT NULL,
	[GrossSL] [money] NOT NULL,
	[AddPay] [money] NOT NULL,
	[AddRange] [money] NOT NULL,
	[Incentive] [numeric](18, 2) NOT NULL,
	[IncRate] [money] NOT NULL,
	[prCoins] [money] NOT NULL,
	[LMB] [money] NOT NULL,
	[FertLMB] [money] NOT NULL,
	[Transport] [money] NOT NULL,
	[Tea] [money] NOT NULL,
	[Fertilizer] [money] NOT NULL,
	[CashAdv] [money] NOT NULL,
	[FunaralReg] [bit] NOT NULL,
	[FunaralRegFee] [smallmoney] NOT NULL,
	[Funaral] [money] NOT NULL,
	[Loan] [money] NOT NULL,
	[LoanInterest] [money] NOT NULL,
	[OtherDeduction] [money] NOT NULL,
	[Stamp] [money] NOT NULL,
	[TotalDeduction] [money] NOT NULL,
	[tempBal] [money] NOT NULL,
	[crCoins] [money] NOT NULL,
	[Balance] [money] NOT NULL,
	[FertNMB] [money] NOT NULL,
	[NMB] [money] NOT NULL,
	[LoanBalance] [money] NOT NULL,
	[FuPrv] [smallint] NOT NULL,
	[FuNext] [smallint] NOT NULL,
	[CouponPrv] [money] NOT NULL,
	[CouponNext] [money] NOT NULL,
	[ChequePrinted] [bit] NOT NULL,
	[xBal] [money] NOT NULL,
	[xDebt] [money] NOT NULL,
	[xCoins] [money] NOT NULL,
	[VoucherNo] [nvarchar](12) NOT NULL,
	[ChequeNo] [int] NOT NULL,
	[ChequeDate] [datetime] NULL,
	[LastSupDate] [smalldatetime] NULL,
	[LoanArreares] [money] NOT NULL,
	[AdvBook] [bit] NOT NULL,
	[AdvPayTMP] [money] NOT NULL,
	[AdvRate] [money] NOT NULL,
	[SavingBAL] [money] NOT NULL,
	[SavingSupplier] [money] NOT NULL,
	[SavingFactory] [money] NOT NULL,
	[SavingPAID] [money] NOT NULL,
	[TPno] [nvarchar](12) NULL,
	[savingPrvCoin] [money] NULL,
	[isActive] [bit] NULL,
	[DeductionRate] [decimal](18, 2) NULL,
	[isBogus] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentDetail]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentId] [int] NULL,
	[ProductId] [int] NULL,
	[CostPrice] [decimal](18, 2) NULL,
	[CostQty] [decimal](18, 2) NULL,
	[TotalCost] [decimal](18, 2) NULL,
	[SoldPrice] [decimal](18, 2) NULL,
	[SoldQty] [decimal](18, 2) NULL,
	[SoldAmount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AddressId] [int] NULL,
	[TrnDate] [date] NULL,
	[RefNo] [nchar](10) NULL,
	[Remarks] [nchar](100) NULL,
	[Amount] [decimal](18, 2) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[BalanceAmt] [decimal](18, 2) NULL,
	[SettledFlag] [int] NULL,
	[CreatedBy] [int] NULL,
	[Createddate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Modifieddate] [datetime] NULL,
 CONSTRAINT [PK_PaymentMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceList]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PriceListType] [int] NULL,
	[ProductId] [int] NULL,
	[PartnerId] [int] NULL,
	[Price] [money] NULL,
	[EffectFrom] [date] NULL,
	[EffectTo] [date] NULL,
	[Status] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_PriceList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceListType]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceListType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ListTypeName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PriceListType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FactoryId] [int] NULL,
	[ProductName] [nchar](100) NOT NULL,
	[TransactionType] [nchar](10) NULL,
	[UOM1] [nchar](10) NULL,
	[UOM2] [nchar](10) NULL,
	[Conversion] [decimal](18, 3) NULL,
	[PrintOrder] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RouteMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RouteMaster](
	[ind] [int] IDENTITY(1,1) NOT NULL,
	[rCode] [nvarchar](3) NOT NULL,
	[rName] [nvarchar](50) NOT NULL,
	[trRate] [money] NOT NULL,
	[blRate] [money] NOT NULL,
	[newBlRate] [money] NOT NULL,
	[Incentive] [money] NOT NULL,
	[blRateSL] [money] NOT NULL,
	[newBlRateSL] [money] NOT NULL,
	[Target] [money] NOT NULL,
	[trActive] [bit] NOT NULL,
	[DdRate] [money] NOT NULL,
	[ExtraRate] [money] NOT NULL,
	[RouteID] [int] NULL,
	[AreaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ind] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RouteQty]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RouteQty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RouteId] [int] NULL,
	[SupplierID] [int] NULL,
	[Trndate] [date] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[GrossAmt] [decimal](18, 2) NULL,
	[DeductAmt] [decimal](18, 2) NULL,
	[BalanceAmt] [decimal](18, 2) NULL,
	[ProductId] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Modifieddate] [datetime] NULL,
 CONSTRAINT [PK_RouteQty] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierLedger]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierLedger](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RouteId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[RelatedFactory] [int] NULL,
	[TrnDate] [date] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[ExtraId] [int] NULL,
	[Ref01] [nchar](50) NULL,
	[Ref02] [nchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_SupplierLedger] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FactoryId] [int] NULL,
	[RouteId] [int] NULL,
	[RegNo] [int] NOT NULL,
	[RegDate] [date] NULL,
	[AddressBookId] [int] NULL,
	[WelfareRegistered] [int] NULL,
	[WelfareId] [nchar](10) NULL,
	[WelfareRegDate] [date] NULL,
	[SavingRegistered] [int] NULL,
	[SavingRegDate] [date] NULL,
	[LastLeafDate] [date] NULL,
	[Status] [int] NULL,
	[Balance] [decimal](18, 2) NULL,
	[Deleted] [int] NULL,
	[PayMode] [nchar](10) NULL,
	[BankAccount] [nchar](20) NULL,
	[BankId] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_SupplierMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[WorkCenterid] [int] NULL,
	[TeamName] [nchar](100) NULL,
 CONSTRAINT [PK_TeamMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkCenterMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCenterMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FactoryId] [int] NULL,
	[WorkSection] [nchar](100) NULL,
 CONSTRAINT [PK_WorkCenterMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewPartnerLedger]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewPartnerLedger]
AS
SELECT dbo.SupplierMaster.RegNo, dbo.RouteQty.Quantity, dbo.RouteQty.GrossAmt, dbo.RouteQty.DeductAmt, dbo.RouteQty.BalanceAmt, dbo.Products.ProductName, dbo.Products.TransactionType, dbo.SupplierLedger.TrnDate, 
                  dbo.SupplierLedger.Quantity AS Expr1, dbo.SupplierLedger.UnitPrice, dbo.SupplierLedger.Ref01, dbo.SupplierLedger.Ref02, dbo.AddressBook.AddressName, dbo.SupplierLedger.RouteId
FROM     dbo.SupplierLedger INNER JOIN
                  dbo.AddressBook ON dbo.SupplierLedger.RouteId = dbo.AddressBook.id INNER JOIN
                  dbo.SupplierMaster ON dbo.SupplierLedger.SupplierId = dbo.SupplierMaster.id LEFT OUTER JOIN
                  dbo.RouteQty ON dbo.SupplierLedger.ExtraId = dbo.RouteQty.id INNER JOIN
                  dbo.Products ON dbo.SupplierLedger.ProductId = dbo.Products.id INNER JOIN
                  dbo.AddressBook AS AddressBook_1 ON dbo.SupplierMaster.RouteId = AddressBook_1.id
GO
/****** Object:  Index [IX_SupplierMaster]    Script Date: 03/09/2020 10:38:11 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SupplierMaster] ON [dbo].[SupplierMaster]
(
	[RegNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_trDay]  DEFAULT ((0)) FOR [trDay]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_regNo]  DEFAULT ((0)) FOR [regNo]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_Vehicale]  DEFAULT ('None') FOR [Vehicale]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_trRate]  DEFAULT ((0)) FOR [trRate]
GO
ALTER TABLE [dbo].[Collection_tbl] ADD  CONSTRAINT [DF_Collection_tbl_LeafType]  DEFAULT ((1)) FOR [LeafType]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_regNo]  DEFAULT ((0)) FOR [regNo]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_rCode]  DEFAULT ('NNN') FOR [rCode]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_routeName]  DEFAULT ('Na') FOR [routeName]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_NICno]  DEFAULT ('....') FOR [NICno]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_LineManager]  DEFAULT ((0)) FOR [LineManager]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_LineFK]  DEFAULT ((0)) FOR [LineID]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_SpLine]  DEFAULT ((0)) FOR [SpLine]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_DyNo]  DEFAULT ((0)) FOR [DyNo]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_PayMode]  DEFAULT ('Cash') FOR [PayMode]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_WelfareDeg]  DEFAULT ('No') FOR [WelfareReg]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_WelfareBAL]  DEFAULT ((0)) FOR [WelfareBAL]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_SavingReg]  DEFAULT ((0)) FOR [SavingReg]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_SavingRate]  DEFAULT ((0)) FOR [SavingRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_SavingAMT]  DEFAULT ((0)) FOR [SavingAMT]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AddRate]  DEFAULT ((0)) FOR [AddRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_Arrears]  DEFAULT ((0)) FOR [xAmount]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_GrosKG]  DEFAULT ((0)) FOR [GrosKG]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_DdRate]  DEFAULT ((0)) FOR [DdRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_DDkg]  DEFAULT ((0)) FOR [DdKG]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_TotKg]  DEFAULT ((0)) FOR [TotKg]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_TotKgSL]  DEFAULT ((0)) FOR [TotKgSL]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_blRate]  DEFAULT ((0)) FOR [blRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_blRate1]  DEFAULT ((0)) FOR [blRateSL]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_trRate]  DEFAULT ((0)) FOR [trRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_TempGross]  DEFAULT ((0)) FOR [TempGross]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Gross]  DEFAULT ((0)) FOR [Gross]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_Gross1]  DEFAULT ((0)) FOR [GrossSL]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AddPay]  DEFAULT ((0)) FOR [AddPay]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AddRange]  DEFAULT ((0)) FOR [AddRange]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_Incentive]  DEFAULT ((0)) FOR [Incentive]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_IncRate]  DEFAULT ((0)) FOR [IncRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_prCoins]  DEFAULT ((0)) FOR [prCoins]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_LMB]  DEFAULT ((0)) FOR [LMB]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_FertLMB]  DEFAULT ((0)) FOR [FertLMB]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Transport]  DEFAULT ((0)) FOR [Transport]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Tea]  DEFAULT ((0)) FOR [Tea]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Fertilizer]  DEFAULT ((0)) FOR [Fertilizer]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_CashAdv]  DEFAULT ((0)) FOR [CashAdv]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_FunaralReg]  DEFAULT ((0)) FOR [FunaralReg]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_FunaralRegFee]  DEFAULT ((0)) FOR [FunaralRegFee]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_Funaral]  DEFAULT ((0)) FOR [Funaral]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Loan]  DEFAULT ((0)) FOR [Loan]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_LoanInterest]  DEFAULT ((0)) FOR [LoanInterest]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_OtherDeduction]  DEFAULT ((0)) FOR [OtherDeduction]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_TotalDeduction]  DEFAULT ((0)) FOR [TotalDeduction]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_tempBal]  DEFAULT ((0)) FOR [tempBal]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_crCoins]  DEFAULT ((0)) FOR [crCoins]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_Balance]  DEFAULT ((0)) FOR [Balance]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_FertNMB]  DEFAULT ((0)) FOR [FertNMB]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_NMB]  DEFAULT ((0)) FOR [NMB]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_O_LoanBalance]  DEFAULT ((0)) FOR [LoanBalance]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_FuPrv]  DEFAULT ((0)) FOR [FuPrv]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_FuNext]  DEFAULT ((0)) FOR [FuNext]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_CouponPrv]  DEFAULT ((0)) FOR [CouponPrv]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_CouponNext]  DEFAULT ((0)) FOR [CouponNext]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_ChequePrinted]  DEFAULT ((0)) FOR [ChequePrinted]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_xBal]  DEFAULT ((0)) FOR [xBal]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_xDebt]  DEFAULT ((0)) FOR [xDebt]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_xCoins]  DEFAULT ((0)) FOR [xCoins]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_VoucherNo]  DEFAULT ('N/a') FOR [VoucherNo]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_ChequeNo]  DEFAULT ((0)) FOR [ChequeNo]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_LoanArreares]  DEFAULT ((0)) FOR [LoanArreares]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AdvBook]  DEFAULT ((0)) FOR [AdvBook]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AdvPayTMP]  DEFAULT ((0)) FOR [AdvPayTMP]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_AdvRate]  DEFAULT ((0)) FOR [AdvRate]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_SavingBAL]  DEFAULT ((0)) FOR [SavingBAL]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_MR_SavingSupplier]  DEFAULT ((0)) FOR [SavingSupplier]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_MR_SavingFactory]  DEFAULT ((0)) FOR [SavingFactory]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_MR_SavingPAID]  DEFAULT ((0)) FOR [SavingPAID]
GO
ALTER TABLE [dbo].[Main_Reg] ADD  CONSTRAINT [DF_Main_Reg_DeductionRate]  DEFAULT ((0.00)) FOR [DeductionRate]
GO
ALTER TABLE [dbo].[PriceList] ADD  CONSTRAINT [DF_PriceList_Price]  DEFAULT ((0.00)) FOR [Price]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_rCode]  DEFAULT ('NNN') FOR [rCode]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_trRate]  DEFAULT ((0)) FOR [trRate]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_blRate]  DEFAULT ((0)) FOR [blRate]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_newBlRate]  DEFAULT ((0)) FOR [newBlRate]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_Incentive]  DEFAULT ((0)) FOR [Incentive]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_blRate1]  DEFAULT ((0)) FOR [blRateSL]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_newBlRate1]  DEFAULT ((0)) FOR [newBlRateSL]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_Target]  DEFAULT ((0)) FOR [Target]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_trActive]  DEFAULT ((0)) FOR [trActive]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_DdRate]  DEFAULT ((0)) FOR [DdRate]
GO
ALTER TABLE [dbo].[RouteMaster] ADD  CONSTRAINT [DF_RouteMaster_ExtraRate]  DEFAULT ((0)) FOR [ExtraRate]
GO
ALTER TABLE [dbo].[SupplierLedger] ADD  CONSTRAINT [DF_SupplierLedger_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
ALTER TABLE [dbo].[AddressBook]  WITH CHECK ADD  CONSTRAINT [FK_AddressBook_AddressBookType] FOREIGN KEY([AddressType])
REFERENCES [dbo].[AddressBookType] ([id])
GO
ALTER TABLE [dbo].[AddressBook] CHECK CONSTRAINT [FK_AddressBook_AddressBookType]
GO
ALTER TABLE [dbo].[AddressBook]  WITH CHECK ADD  CONSTRAINT [FK_AddressBook_Factory] FOREIGN KEY([FactoryId])
REFERENCES [dbo].[FactoryMaster] ([id])
GO
ALTER TABLE [dbo].[AddressBook] CHECK CONSTRAINT [FK_AddressBook_Factory]
GO
ALTER TABLE [dbo].[AddressBookType]  WITH CHECK ADD  CONSTRAINT [FK_AddressBookType_CompanyMaster] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyMaster] ([id])
GO
ALTER TABLE [dbo].[AddressBookType] CHECK CONSTRAINT [FK_AddressBookType_CompanyMaster]
GO
ALTER TABLE [dbo].[FactoryMaster]  WITH CHECK ADD  CONSTRAINT [FK_Factory_Factory] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyMaster] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FactoryMaster] CHECK CONSTRAINT [FK_Factory_Factory]
GO
ALTER TABLE [dbo].[PaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetail_PaymentMaster] FOREIGN KEY([PaymentId])
REFERENCES [dbo].[PaymentMaster] ([id])
GO
ALTER TABLE [dbo].[PaymentDetail] CHECK CONSTRAINT [FK_PaymentDetail_PaymentMaster]
GO
ALTER TABLE [dbo].[PaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetail_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([id])
GO
ALTER TABLE [dbo].[PaymentDetail] CHECK CONSTRAINT [FK_PaymentDetail_Products]
GO
ALTER TABLE [dbo].[PaymentMaster]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMaster_AddressBook] FOREIGN KEY([AddressId])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[PaymentMaster] CHECK CONSTRAINT [FK_PaymentMaster_AddressBook]
GO
ALTER TABLE [dbo].[PriceList]  WITH CHECK ADD  CONSTRAINT [FK_PriceList_AddressBook] FOREIGN KEY([PartnerId])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[PriceList] CHECK CONSTRAINT [FK_PriceList_AddressBook]
GO
ALTER TABLE [dbo].[PriceList]  WITH CHECK ADD  CONSTRAINT [FK_PriceList_PriceListType] FOREIGN KEY([PriceListType])
REFERENCES [dbo].[PriceListType] ([id])
GO
ALTER TABLE [dbo].[PriceList] CHECK CONSTRAINT [FK_PriceList_PriceListType]
GO
ALTER TABLE [dbo].[PriceList]  WITH CHECK ADD  CONSTRAINT [FK_PriceList_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([id])
GO
ALTER TABLE [dbo].[PriceList] CHECK CONSTRAINT [FK_PriceList_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Factory] FOREIGN KEY([FactoryId])
REFERENCES [dbo].[FactoryMaster] ([id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Factory]
GO
ALTER TABLE [dbo].[RouteQty]  WITH CHECK ADD  CONSTRAINT [FK_RouteQty_SupplierMaster] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[SupplierMaster] ([id])
GO
ALTER TABLE [dbo].[RouteQty] CHECK CONSTRAINT [FK_RouteQty_SupplierMaster]
GO
ALTER TABLE [dbo].[SupplierLedger]  WITH CHECK ADD  CONSTRAINT [FK_SupplierLedger_AddressBook] FOREIGN KEY([RouteId])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[SupplierLedger] CHECK CONSTRAINT [FK_SupplierLedger_AddressBook]
GO
ALTER TABLE [dbo].[SupplierLedger]  WITH CHECK ADD  CONSTRAINT [FK_SupplierLedger_AddressBook1] FOREIGN KEY([RelatedFactory])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[SupplierLedger] CHECK CONSTRAINT [FK_SupplierLedger_AddressBook1]
GO
ALTER TABLE [dbo].[SupplierLedger]  WITH CHECK ADD  CONSTRAINT [FK_SupplierLedger_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([id])
GO
ALTER TABLE [dbo].[SupplierLedger] CHECK CONSTRAINT [FK_SupplierLedger_Products]
GO
ALTER TABLE [dbo].[SupplierLedger]  WITH CHECK ADD  CONSTRAINT [FK_SupplierLedger_RouteQty] FOREIGN KEY([ExtraId])
REFERENCES [dbo].[RouteQty] ([id])
GO
ALTER TABLE [dbo].[SupplierLedger] CHECK CONSTRAINT [FK_SupplierLedger_RouteQty]
GO
ALTER TABLE [dbo].[SupplierLedger]  WITH CHECK ADD  CONSTRAINT [FK_SupplierLedger_SupplierMaster] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[SupplierMaster] ([id])
GO
ALTER TABLE [dbo].[SupplierLedger] CHECK CONSTRAINT [FK_SupplierLedger_SupplierMaster]
GO
ALTER TABLE [dbo].[SupplierMaster]  WITH CHECK ADD  CONSTRAINT [FK_SupplierMaster_AddressBook] FOREIGN KEY([AddressBookId])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[SupplierMaster] CHECK CONSTRAINT [FK_SupplierMaster_AddressBook]
GO
ALTER TABLE [dbo].[SupplierMaster]  WITH CHECK ADD  CONSTRAINT [FK_SupplierMaster_AddressBook1] FOREIGN KEY([RouteId])
REFERENCES [dbo].[AddressBook] ([id])
GO
ALTER TABLE [dbo].[SupplierMaster] CHECK CONSTRAINT [FK_SupplierMaster_AddressBook1]
GO
ALTER TABLE [dbo].[SupplierMaster]  WITH CHECK ADD  CONSTRAINT [FK_SupplierMaster_Factory] FOREIGN KEY([FactoryId])
REFERENCES [dbo].[FactoryMaster] ([id])
GO
ALTER TABLE [dbo].[SupplierMaster] CHECK CONSTRAINT [FK_SupplierMaster_Factory]
GO
ALTER TABLE [dbo].[TeamMaster]  WITH CHECK ADD  CONSTRAINT [FK_TeamMaster_WorkCenterMaster] FOREIGN KEY([WorkCenterid])
REFERENCES [dbo].[WorkCenterMaster] ([id])
GO
ALTER TABLE [dbo].[TeamMaster] CHECK CONSTRAINT [FK_TeamMaster_WorkCenterMaster]
GO
ALTER TABLE [dbo].[WorkCenterMaster]  WITH CHECK ADD  CONSTRAINT [FK_WorkCenterMaster_Factory] FOREIGN KEY([FactoryId])
REFERENCES [dbo].[FactoryMaster] ([id])
GO
ALTER TABLE [dbo].[WorkCenterMaster] CHECK CONSTRAINT [FK_WorkCenterMaster_Factory]
GO
/****** Object:  StoredProcedure [dbo].[PartnerLedger]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		GT Jayawickrama
-- Create date: 2020-08-19
-- Description:	Partner Ledger 
-- Test PartnerLedger 8, 5116
-- =============================================
CREATE PROCEDURE [dbo].[PartnerLedger] 
	-- Add the parameters for the stored procedure here
	@vMonthValue INT,
	@vPartnerNo INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	If (@vPartnerNo = -1)
	Begin
		Select q.RouteId,a.AddressName RouteName, m.id PartnerId, b.AddressName PartnerName ,
		q.GrossAmt, q.Quantity, Isnull(Q.DeductAmt,0) TotalDeduction, 
		l.TrnDate,p.id,p.ProductName,  l.Quantity DayQty, l.UnitPrice, l.TotalPrice DayAmount,
		p.PrintOrder,p.TransactionType , l.Ref01
		From SupplierLedger l INNER JOIN
                  AddressBook a ON l.RouteId = a.id INNER JOIN
                  SupplierMaster m ON l.SupplierId = m.id LEFT OUTER JOIN
                  RouteQty q ON l.ExtraId = q.id INNER JOIN
                  Products P ON l.ProductId = p.id INNER JOIN
                  dbo.AddressBook AS b ON m.AddressBookId = b.id
		Where MONTH(l.TrnDate) = @vMonthValue
	End
	If (@vPartnerNo > 1)
	Begin
		Select q.RouteId,a.AddressName RouteName, m.id PartnerId, b.AddressName PartnerName ,
		q.GrossAmt, q.Quantity, Isnull(Q.DeductAmt,0) TotalDeduction, 
		l.TrnDate,p.id,p.ProductName,  l.Quantity DayQty, l.UnitPrice, l.TotalPrice DayAmount,
		p.PrintOrder,p.TransactionType ,l.Ref01
		From SupplierLedger l INNER JOIN
                  AddressBook a ON l.RouteId = a.id INNER JOIN
                  SupplierMaster m ON l.SupplierId = m.id LEFT OUTER JOIN
                  RouteQty q ON l.ExtraId = q.id INNER JOIN
                  Products P ON l.ProductId = p.id INNER JOIN
                  dbo.AddressBook AS b ON m.AddressBookId = b.id
		Where MONTH(l.TrnDate) = @vMonthValue And m.id = @vPartnerNo
	End
END
GO
/****** Object:  StoredProcedure [dbo].[ProcessCostandPrice]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		G T Jayawickrama
-- Create date: 2020-08-17
-- Description:	Process the ledger with specific cost and price
-- ProcessCostandPrice 8
-- =============================================
CREATE PROCEDURE [dbo].[ProcessCostandPrice] 
	-- Add the parameters for the stored procedure here
	@MonthValue int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @vProductId Int
	Declare @vPartnerId Int
	Declare @vEffectFrom date
	Declare @vEffectTo Date
	Declare @vPrice Money
	
    -- Sales Prices Updating
	Declare salePriceCur Cursor For
	SELECT ProductId,Isnull(PartnerId,0),EffectFrom,EffectTo,Price From PriceList l inner join PriceListType t
		on l.PriceListType = t.id  Where Month(EffectFrom) = @MonthValue and Status = 1 and 
		ListTypeName = 'Sales'

	Open salePriceCur
	Fetch Next From salePriceCur Into @vProductId, @vPartnerId, @vEffectFrom, @vEffectTo,@vPrice 
	While @@Fetch_Status = 0
	Begin
		if (@vPartnerId = 0)
		Begin
			Update SupplierLedger Set TotalPrice = Quantity * @vPrice,  UnitPrice = @vPrice Where Trndate Between @vEffectFrom and @vEffectTo
			 And Ref01 Like 'Sales%'
		End
		Else
		Begin
			Update SupplierLedger Set TotalPrice = Quantity * @vPrice, UnitPrice = @vPrice Where Trndate Between @vEffectFrom and @vEffectTo
			 And Ref01 Like 'Sales%' and SupplierId= @vPartnerId
		End
		Fetch Next From salePriceCur Into @vProductId, @vPartnerId, @vEffectFrom, @vEffectTo,@vPrice

	End
	Close salePriceCur
	Deallocate salePriceCur
	-- Purchase Cost updating
	Declare purchPriceCur Cursor For
	SELECT ProductId,Isnull(PartnerId,0),EffectFrom,EffectTo,Price From PriceList l inner join PriceListType t
		on l.PriceListType = t.id  Where Month(EffectFrom) = @MonthValue and Status = 1 and 
		ListTypeName = 'Purchase'
	Open purchPriceCur
	Fetch Next From purchPriceCur Into @vProductId, @vPartnerId, @vEffectFrom, @vEffectTo,@vPrice 
	While @@Fetch_Status = 0
	Begin
		if (@vPartnerId = 0)
		Begin
			Update SupplierLedger Set TotalPrice = Quantity * @vPrice, UnitPrice= @vPrice Where Trndate Between @vEffectFrom and @vEffectTo
			 And Ref01 Like 'Purchase%'
		End
		Else
		Begin
			Update SupplierLedger Set TotalPrice = Quantity * @vPrice, UnitPrice= @vPrice Where Trndate Between @vEffectFrom and @vEffectTo
			 And Ref01 Like 'Purchase%' and SupplierId= @vPartnerId
		End
		Fetch Next From purchPriceCur Into @vProductId, @vPartnerId, @vEffectFrom, @vEffectTo,@vPrice

	End
	Close purchPriceCur
	Deallocate purchPriceCur

	Select ExtraId from RouteQty r inner join SupplierLedger l
	On r.id = l.ExtraId
	Where Month(l.Trndate) = @MonthValue

	If @@ROWCOUNT = 0
	Begin

		Insert Into RouteQty (RouteId,SupplierId,TrnDate,Quantity,GrossAmt,CreatedBy, CreatedDate)
			Select RouteID,SupplierId,@vEffectFrom,Sum(Quantity) Quantity, Sum(TotalPrice) GrossAmt,1,GetDate()
				From SupplierLedger 
				Where Month(Trndate) = Month(@vEffectFrom) and Ref01 Like 'Purchase%'
				Group By RouteID,SupplierId
		Update SupplierLedger Set ExtraId = RouteQty.id From RouteQty 
		Where SupplierLedger.RouteId= RouteQty.RouteId and SupplierLedger.SupplierId= RouteQty.SupplierId
		And Month(SupplierLedger.Trndate) = Month(@vEffectFrom) and Month(RouteQty.TrnDate) = @MonthValue
	End
	If @@ROWCOUNT > 0
	Begin
		Update RouteQty Set Quantity = q.Quantity, GrossAmt=q.GrossAmt , 
		ModifiedBy = q.ModifiedBy, Modifieddate= q.ModifiedDate From 
		(Select  l.RouteID,l.SupplierId,Sum(l.Quantity) Quantity, Sum(TotalPrice) GrossAmt,1 ModifiedBy,GetDate() ModifiedDate
				From SupplierLedger l inner join RouteQty r on l.ExtraId = r.id 
				Where Month(l.Trndate) = Month(@vEffectFrom) and Ref01 Like 'Purchase%'
				Group By l.RouteID,l.SupplierId) q
		where RouteQty.RouteId= q.RouteId and RouteQty.SupplierID = q.SupplierId 
		And Month(RouteQty.TrnDate) = @MonthValue
	End

	-- Calculate Deduction and Balance
	Update RouteQty Set DeductAmt = q.DeductAmt, BalanceAmt = GrossAmt - q.DeductAmt
	From 
	 (Select  l.RouteID,l.SupplierId, Sum(TotalPrice) DeductAmt
				From SupplierLedger l inner join RouteQty r on l.ExtraId = r.id 
				Inner Join Products p on l.ProductId = p.id 
				Where Month(l.Trndate) = Month(@vEffectFrom) and p.TransactionType = 'CREDIT'
				Group By l.RouteID,l.SupplierId) q
		where RouteQty.RouteId= q.RouteId and RouteQty.SupplierID = q.SupplierId 
		And Month(RouteQty.TrnDate) = @MonthValue
	Update SupplierLedger Set ExtraId = RouteQty.id From RouteQty 
		Where SupplierLedger.RouteId= RouteQty.RouteId and SupplierLedger.SupplierId= RouteQty.SupplierId
		And Month(SupplierLedger.Trndate) = Month(@vEffectFrom) and Month(RouteQty.TrnDate) = @MonthValue
END
GO
/****** Object:  StoredProcedure [dbo].[ProcessFinancials]    Script Date: 03/09/2020 10:38:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		GT Jayawickrama
-- Create date: <Create Date,,>
-- Description:	Process Financials
-- =============================================
CREATE PROCEDURE [dbo].[ProcessFinancials]
	-- Add the parameters for the stored procedure here
	@MonthValue Int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Calculate Deduction and Balance
	Update RouteQty Set DeductAmt = q.DeductAmt, BalanceAmt = GrossAmt + q.DeductAmt
	From 
	 (Select  l.RouteID,l.SupplierId, Sum(TotalPrice) DeductAmt
				From SupplierLedger l inner join RouteQty r on l.ExtraId = r.id 
				Inner Join Products p on l.ProductId = p.id 
				Where Month(l.Trndate) = Month(@MonthValue) and p.TransactionType = 'CREDIT'
				Group By l.RouteID,l.SupplierId) q
		where RouteQty.RouteId= q.RouteId and RouteQty.SupplierID = q.SupplierId 
		And Month(RouteQty.TrnDate) = @MonthValue

	Update SupplierLedger Set ExtraId = RouteQty.id From RouteQty 
		Where SupplierLedger.RouteId= RouteQty.RouteId and SupplierLedger.SupplierId= RouteQty.SupplierId
		And Month(SupplierLedger.Trndate) = Month(@MonthValue) and Month(RouteQty.TrnDate) = @MonthValue
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SupplierLedger"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "RouteQty"
            Begin Extent = 
               Top = 161
               Left = 317
               Bottom = 324
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "AddressBook"
            Begin Extent = 
               Top = 71
               Left = 471
               Bottom = 234
               Right = 665
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SupplierMaster"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 170
               Right = 992
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Products"
            Begin Extent = 
               Top = 0
               Left = 1080
               Bottom = 163
               Right = 1283
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AddressBook_1"
            Begin Extent = 
               Top = 159
               Left = 1099
               Bottom = 322
               Right = 1293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1200' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewPartnerLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewPartnerLedger'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewPartnerLedger'
GO
USE [master]
GO
ALTER DATABASE [PM] SET  READ_WRITE 
GO
