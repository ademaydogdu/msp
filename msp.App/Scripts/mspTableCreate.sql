


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ApplicationDatabase' and xtype='U')
BEGIN

CREATE TABLE [dbo].[ApplicationDatabase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServerId] [int] NULL,
	[DatabaseName] [nvarchar](100) NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_ApplicationDatabase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

END

GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ApplicationServer' and xtype='U')
BEGIN
CREATE TABLE [dbo].[ApplicationServer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Server] [nvarchar](max) NULL,
	[ServerName] [nvarchar](max) NULL,
	[UserName] [nvarchar](200) NULL,
	[Password] [nvarchar](max) NULL,
	[DataBase] [nvarchar](50) NULL,
 CONSTRAINT [PK_ApplicationServer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

END

GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='BankEntry' and xtype='U')
Begin

CREATE TABLE [dbo].[BankEntry](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[docNo] [nvarchar](50) NULL,
	[bankID] [int] NULL,
	[description] [nvarchar](50) NULL,
	[amountDeposited] [bigint] NULL,
	[withdrawnDeposited] [bigint] NULL,
	[bDate] [datetime] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_BankEntry] PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

END

GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Banks' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Banks](
	[Bid] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](50) NULL,
	[BankBranch] [nvarchar](50) NULL,
	[BankBranchCode] [int] NULL,
	[BankAccountNumber] [nvarchar](50) NULL,
	[BankAccountName] [nvarchar](50) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_Banks] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CaseDefinition' and xtype='U')
BEGIN
CREATE TABLE [dbo].[CaseDefinition](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CaseName] [nvarchar](50) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_CaseDefinition] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Cashiers' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Cashiers](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[tcId] [nvarchar](50) NULL,
	[authority] [bit] NULL,
	[date] [datetime] NULL,
	[salary] [bigint] NULL,
	[userId] [int] NULL,
	[cashNo] [int] NULL,
 CONSTRAINT [PK_cashiers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CashPayGroupDef' and xtype='U')
BEGIN
CREATE TABLE [dbo].[CashPayGroupDef](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[ReCashPayGroupDef] [nvarchar](max) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_CashPayGroupDef] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Categories' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Categories](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Company' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Company](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyCode] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[Logo] [image] NULL,
	[Adress1] [nvarchar](50) NULL,
	[Adress2] [nvarchar](50) NULL,
	[BulvarCadde] [nvarchar](50) NULL,
	[TelNo] [int] NULL,
	[BinaAdi] [nvarchar](50) NULL,
	[BinaNo] [nvarchar](50) NULL,
	[MahalleSemt] [nvarchar](50) NULL,
	[Sehir] [nvarchar](50) NULL,
	[PostaKodu] [int] NULL,
	[Ulke] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


--IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CTransactions' and xtype='U')
--BEGIN
--CREATE TABLE [dbo].[CTransactions](
--	[CurID] [int] IDENTITY(1,1) NOT NULL,
--	[CurType] [nvarchar](50) NULL,
--	[CurCode] [bigint] NULL,
--	[CurAccountName] [nvarchar](50) NULL,
--	[CurAuthPersonName] [nvarchar](50) NULL,
--	[CurDiscount] [int] NULL,
--	[CurRiskLimit] [nvarchar](50) NULL,
--	[CurCity] [nvarchar](50) NULL,
--	[CurDistrict] [nvarchar](50) NULL,
--	[CurBalance] [bigint] NULL,
--	[CurCompanyType] [nvarchar](50) NULL,
--	[CurCreatedDate] [datetime] NULL,
--	[CurAdress] [nvarchar](50) NULL,
--	[CurAdressTwo] [nchar](10) NULL,
--	[CurCountryCode] [int] NULL,
--	[CurCountryName] [nvarchar](50) NULL,
--	[CurZipCode] [int] NULL,
--	[CurPhoneOne] [nvarchar](50) NULL,
--	[CurPhoneTwo] [nvarchar](50) NULL,
--	[CurFax] [nvarchar](50) NULL,
--	[CurEmail] [nvarchar](50) NULL,
--	[CurDescription] [nvarchar](50) NULL,
--	[CurTaxNo] [nvarchar](50) NULL,
--	[CurTaxOffice] [nvarchar](50) NULL,
--	[CurCardNo] [nvarchar](50) NULL,
--	[CurIdentNo] [nvarchar](50) NULL,
--	[CurTitle] [nvarchar](50) NULL,
--	[TaxOffice] [nvarchar](50) NULL,
--	[CurPhoneOneTwo] [nvarchar](50) NULL,
--	[CurSoleProp] [nvarchar](50) NULL,
--	[CurOnCredit] [nvarchar](50) NULL,
--	[CompanyRecId] [int] NULL,
-- CONSTRAINT [PK_CurrentTransactions] PRIMARY KEY CLUSTERED 
--(
--	[CurID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--END
--GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CurrencyType' and xtype='U')
BEGIN
CREATE TABLE [dbo].[CurrencyType](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyCode] [varchar](3) NOT NULL,
	[Remark] [varchar](50) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_CurrencyType] PRIMARY KEY CLUSTERED 
(
	[CurrencyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[active] [bit] NULL,
	[date] [datetime] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Depot' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Depot](
	[DID] [int] IDENTITY(1,1) NOT NULL,
	[DepName] [nvarchar](50) NULL,
	[DepAddress] [nvarchar](50) NULL,
	[DepDistrict] [nvarchar](50) NULL,
	[DepCity] [nvarchar](50) NULL,
	[DepAuthPerson] [nvarchar](50) NULL,
	[DepPhoneOne] [nvarchar](50) NULL,
	[DepPhoneTwo] [nvarchar](50) NULL,
	[DepTaxAdministration] [nvarchar](50) NULL,
	[DepTaxNo] [nvarchar](50) NULL,
	[DepActive] [bit] NULL,
	[DepDate] [datetime] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_Depot] PRIMARY KEY CLUSTERED 
(
	[DID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ExchangeRate' and xtype='U')
BEGIN
CREATE TABLE [dbo].[ExchangeRate](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CurrDate] [datetime] NOT NULL,
	[CurrencyCode] [varchar](3) NOT NULL,
	[Invoice] [numeric](18, 5) NULL,
	[Exchange] [numeric](18, 5) NULL,
	[Pos] [numeric](18, 5) NULL,
	[Buying] [numeric](18, 5) NULL,
	[Selling] [numeric](18, 5) NULL,
	[EffectiveBuying] [numeric](18, 5) NULL,
	[EffectiveSelling] [numeric](18, 5) NULL,
	[RecordUser] [varchar](10) NULL,
	[RecordDate] [datetime] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_ExchangeRate] PRIMARY KEY CLUSTERED 
(
	[CurrDate] ASC,
	[CurrencyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='FormLayouts' and xtype='U')
BEGIN
CREATE TABLE [dbo].[FormLayouts](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](20) NULL,
	[FormName] [varchar](50) NULL,
	[ControlName] [varchar](50) NULL,
	[XmlData] [varbinary](max) NULL,
	[ApplicationId] [int] NULL,
 CONSTRAINT [PK_GridSetting] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='InvoiceOwner' and xtype='U')
BEGIN
CREATE TABLE [dbo].[InvoiceOwner](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceType] [int] NULL,
	[FicDate] [datetime] NULL,
	[FicheType] [int] NULL,
	[FicheDocumentNo] [nvarchar](max) NULL,
	[FicheRemark] [nvarchar](max) NULL,
	[CariRecId] [int] NULL,
	[VadeTarih] [datetime] NULL,
	[DepoName] [int] NULL,
	[Indirim] [decimal](18, 2) NULL,
	[AraToplam] [decimal](18, 2) NULL,
	[ToplamKDV] [decimal](18, 2) NULL,
	[DigerMasraflar] [decimal](18, 2) NULL,
	[GenelToplam] [decimal](18, 2) NULL,
	[CompanyId] [int] NULL,
	[EFaturaNo] [nvarchar](50) NULL,
	[EIrsaliyeNo] [nvarchar](50) NULL,
	[InoviceCancel] [bit] NULL,
	[InvoicePrint] [bit] NULL,
	[VadeGun] [int] NULL,
	[VadeDate] [datetime] NULL,
	[IrsaliyeDate] [datetime] NULL,
	[IrsaliyeNo] [nvarchar](50) NULL,
	[DovizTuru] [int] NULL,
	[KDV] [nvarchar](50) NULL,
	[Iskonto] [int] NULL,
	[PaymentType] [nvarchar](50) NULL,
	[Deleted] [bit] NULL,
	[OrderId] [int] NULL,
	[IrsaliyeId] [int] NULL,
 CONSTRAINT [PK_InvoiceOwner] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='InvoiceTrans' and xtype='U')
BEGIN
CREATE TABLE [dbo].[InvoiceTrans](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceOwnerId] [int] NULL,
	[ProductId] [int] NULL,
	[Quentity] [int] NULL,
	[UnitID] [int] NULL,
	[KDV] [int] NULL,
	[Indirim] [int] NULL,
	[BirimFiyat] [decimal](18, 2) NULL,
	[Tutar] [decimal](18, 2) NULL,
	[SKT] [datetime] NULL,
	[AlisFiyati] [decimal](18, 2) NULL,
	[KarOrani] [int] NULL,
 CONSTRAINT [PK_InvoiceTrans] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LOG' and xtype='U')
BEGIN
CREATE TABLE [dbo].[LOG](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](10) NULL,
	[CompanyCode] [varchar](10) NULL,
	[FieldName] [varchar](30) NULL,
	[TableName] [varchar](30) NULL,
	[Old] [varchar](50) NULL,
	[New] [varchar](50) NULL,
	[PCName] [varchar](30) NULL,
	[FormName] [varchar](30) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_LOG] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OpenFormRights' and xtype='U')
BEGIN
CREATE TABLE [dbo].[OpenFormRights](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](10) NULL,
	[ActionName] [varchar](50) NULL,
	[OpenForm] [bit] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_OpenFormRights] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OrderManagement' and xtype='U')
BEGIN
CREATE TABLE [dbo].[OrderManagement](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[oType] [nvarchar](50) NULL,
	[oStatus] [nvarchar](50) NULL,
	[oDate] [datetime] NULL,
	[oNo] [int] NULL,
	[oAmount] [int] NULL,
	[oCTransactionNo] [int] NULL,
	[oCTransactionTitle] [nvarchar](50) NULL,
	[oDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_OrderManagement] PRIMARY KEY CLUSTERED 
(
	[oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OrderOwner' and xtype='U')
BEGIN
CREATE TABLE [dbo].[OrderOwner](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CariRecId] [int] NULL,
	[OrderType] [int] NULL,
	[CompanyId] [int] NULL,
	[SiparisNo] [nvarchar](50) NULL,
	[SiparisDate] [datetime] NULL,
	[SiparisTime] [varchar](15) NULL,
	[OzelKod] [nvarchar](50) NULL,
	[DovizId] [int] NULL,
	[Kdv] [nvarchar](50) NULL,
	[Iskonto] [int] NULL,
	[Durum] [nvarchar](50) NULL,
	[TeklifSiparis] [int] NULL,
	[Remark] [nvarchar](max) NULL,
	[TotalToplam] [decimal](18, 2) NULL,
	[TotalIskonto] [decimal](18, 2) NULL,
	[TotalKDV] [decimal](18, 2) NULL,
	[TotalSiparis] [decimal](18, 2) NULL,
	[Deleted] [bit] NULL,
	[IrsaliyeId] [int] NULL,
	[TotalAraToplam] [decimal](18, 2) NULL,
 CONSTRAINT [PK_OrderOwner] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OrderTrans' and xtype='U')
BEGIN
CREATE TABLE [dbo].[OrderTrans](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[OwnerId] [int] NULL,
	[StockId] [int] NULL,
	[Miktar] [int] NULL,
	[Sevk] [nvarchar](50) NULL,
	[Bekleyen] [nvarchar](50) NULL,
	[BirimId] [int] NULL,
	[BirimFiyat] [decimal](18, 2) NULL,
	[KDV] [int] NULL,
	[Tutar] [decimal](18, 2) NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrderTrans] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Parameters' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Parameters](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[NumaratorShow] [bit] NULL,
	[SaleApproval] [bit] NULL,
	[SaleOutOfStock] [bit] NULL,
	[SaleCahnge] [bit] NULL,
	[SaleInformationSlip] [bit] NULL,
	[MainSaleForm] [bit] NULL,
	[AutoCurrency] [bit] NULL,
	[UserRecordMy] [bit] NULL,
	[PaymentLock] [bit] NULL,
	[PaymentyForced] [bit] NULL,
	[SaleNewRecord] [bit] NULL,
	[SaleProductEndDate] [bit] NULL,
	[ProductEndDateDay] [int] NULL,
 CONSTRAINT [PK_Parameters] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Payments' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Payments](
	[id] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[date] [datetime] NULL,
	[invoiceNo] [bigint] NULL,
	[total] [bigint] NULL,
 CONSTRAINT [PK_payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PaymentType' and xtype='U')
BEGIN
CREATE TABLE [dbo].[PaymentType](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProductGroup' and xtype='U')
BEGIN
CREATE TABLE [dbo].[ProductGroup](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[Grouup] [nvarchar](50) NULL,
	[ReGroup] [nvarchar](max) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_ProductGroup] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProductMark' and xtype='U')
BEGIN
CREATE TABLE [dbo].[ProductMark](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[Mark] [nvarchar](50) NULL,
	[Remark] [nvarchar](max) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_ProductMark] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProductMovement' and xtype='U')
BEGIN
CREATE TABLE [dbo].[ProductMovement](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Durum] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[Date] [datetime] NULL,
	[Deleted] [bit] NULL,
	[DurumType] [int] NULL,
	[SaleOwnerId] [int] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_ProductMovement] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Products' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Products](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[PName] [nvarchar](max) NULL,
	[PBarcode] [nvarchar](50) NULL,
	[PCategoryId] [int] NULL,
	[PDate] [datetime] NULL,
	[PFirstPrice] [decimal](18, 2) NULL,
	[PTotal] [decimal](18, 2) NULL,
	[PLastPrice] [decimal](18, 2) NULL,
	[PUnitId] [int] NULL,
	[PTax] [int] NULL,
	[PVarDescription] [nvarchar](50) NULL,
	[PSpecCode] [nvarchar](50) NULL,
	[PBrandName] [nvarchar](50) NULL,
	[PBrandCode] [nvarchar](50) NULL,
	[PGroup] [int] NULL,
	[PImages] [varbinary](max) NULL,
	[PExpDate] [datetime] NULL,
	[PSalePrice] [decimal](18, 2) NULL,
	[PTaxType] [int] NULL,
	[PMalBedeli] [decimal](18, 2) NULL,
	[PPaxAmout] [decimal](18, 2) NULL,
	[PKdvIstisna] [bit] NULL,
	[PKarPrice] [decimal](18, 2) NULL,
	[PCode] [nvarchar](max) NULL,
	[PCompanyId] [int] NULL,
	[PDepotId] [int] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProgramsControl' and xtype='U')
BEGIN

CREATE TABLE [dbo].[ProgramsControl](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[MspVersion] [nvarchar](50) NULL,
	[Licence] [nvarchar](50) NULL,
	[FirstDate] [datetime] NULL,
	[MacAdress] [nvarchar](50) NULL,
	[IpAdress] [nvarchar](50) NULL,
	[LocalIpAdress] [nvarchar](50) NULL,
	[IsDemo] [bit] NULL, 
 CONSTRAINT [PK_ProgramsControl] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SaleOwner' and xtype='U')
BEGIN
CREATE TABLE [dbo].[SaleOwner](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[CustomerName] [nvarchar](50) NULL,
	[PaymentType] [int] NULL,
	[NetPrice] [decimal](18, 2) NULL,
	[NetPriceText] [nvarchar](50) NULL,
	[KDV] [decimal](18, 2) NULL,
	[DiscountPrice] [decimal](18, 2) NULL,
	[TotalPriceText] [nvarchar](50) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[ReceivedPrice] [decimal](18, 2) NULL,
	[Remark] [nvarchar](max) NULL,
	[Veresiye] [bit] NULL,
	[CompanyRecId] [int] NULL,
	[Deleted] [bit] NULL,
	[UserCode] [nvarchar](50) NULL,
	[AlinanPrice] [decimal](18, 2) NULL,
	[CaseId] [int] NULL,
	[VeresiyeClosedDate] [datetime] NULL,
	[DovizId] [int] NULL,
 CONSTRAINT [PK_SaleOwner] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SaleTrans' and xtype='U')
BEGIN
CREATE TABLE [dbo].[SaleTrans](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[SaleOwnerId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductBarcode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductQuantity] [int] NULL,
	[ProductPrice] [decimal](18, 2) NULL,
	[ProductAmount] [decimal](18, 2) NULL,
	[CompanyId] [int] NULL,
	[Deleted] [bit] NULL,
	[UnitId] [int] NULL,
	[Tax] [int] NULL,
	[TaxAmount] [decimal](18, 2) NULL,
	[ProductDate] [datetime] NULL,
	[CaseId] [int] NULL,
 CONSTRAINT [PK_SaleTrans] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SecRights' and xtype='U')
BEGIN
CREATE TABLE [dbo].[SecRights](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](10) NULL,
	[SecCode] [char](10) NULL,
	[SecPreview] [int] NULL,
	[SecUpdate] [int] NULL,
	[SecInsert] [int] NULL,
	[SecDelete] [int] NULL,
	[DocumentType] [int] NULL,
	[CompanyCode] [varchar](10) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_SecRights] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SpeedSaleProduct' and xtype='U')
BEGIN
CREATE TABLE [dbo].[SpeedSaleProduct](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[İmage] [nchar](10) NULL,
	[ButtonType] [int] NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_SpeedSaleProduct] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Units' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Units](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[UName] [nvarchar](50) NULL,
	[CompanyRecId] [int] NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' and xtype='U')
BEGIN
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[note] [text] NULL,
	[date] [datetime] NULL,
	[Active] [bit] NULL,
	[HaspPassword] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DefaultTheme] [nvarchar](max) NULL,
	[DefaultTheme2] [nvarchar](max) NULL,
	[AdminAuthority] [bit] NULL,
	[ReportPrint] [bit] NULL,
	[ExportExcelPdf] [bit] NULL,
	[DailyEndOperation] [bit] NULL,
	[EnvanterEntry] [bit] NULL,
	[VeresiyeDefterClosed] [bit] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CaseMovement' and xtype='U')
BEGIN
CREATE TABLE [dbo].[CaseMovement](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[CaseId] [int] NULL,
	[RecordDate] [datetime] NULL,
	[VadeDate] [datetime] NULL,
	[VadeMonth] [nchar](10) NULL,
	[EvrakNo] [nvarchar](50) NULL,
	[Doviz] [int] NULL,
	[IslemTuru] [int] NULL,
	[Tutar] [decimal](18, 2) NULL,
	[OdemeTuru] [int] NULL,
	[OdemeGrubu] [int] NULL,
	[Remark] [nvarchar](max) NULL,
	[CariId] [int] NULL,
	[Deleted] [bit] NULL,
	[CompanyRecId] [int] NULL,
	[RecordUser] [nvarchar](50) NULL,
	[SaleOwnerId] [int] NULL,
 CONSTRAINT [PK_CaseMovement] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO




