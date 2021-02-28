using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Common;
using Msp.Infrastructure;

namespace Msp.App.App
{
    public partial class CheckDb : DevExpress.XtraEditors.XtraForm
    {
        public CheckDb()
        {
            InitializeComponent();
        }

        public static SqlCommand SqlCreateCommandFront()
        {
            string connectionString = "initial catalog=" + AppMain.SqlConnection.Database
                + ";data source=" + AppMain.SqlConnection.Server + (AppMain.LocalConnect == false ? ";user id=" + AppMain.SqlConnection.UserId + ";password=" + AppMain.SqlConnection.Password : "")
                + ";Packet Size=8000;Connect Timeout=120";
            //if (SednaFBMain.user != null)
            //{
            //    connectionString += ";WSID=SEDNAFB|" + SednaFBMain.user;
            //    connectionString += "|" + System.Environment.MachineName.ToString().Trim();
            //}
            AppMain.LcConnectionString = connectionString;
            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sConn;
            cmd.CommandTimeout = 0;
            return cmd;
        }

        public static DataTable ExecuteSelectCommand(DbCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection.Open();
                DbDataReader reader = command.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
            return table;
        }

        public static int ExecuteNonQuery(DbCommand command)
        {
            int affectRows = -1;
            try
            {
                command.Connection.Open();
                affectRows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
            return affectRows;
        }

        public void UpdateFromStart()
        {
            CheckForIllegalCrossThreadCalls = false;
            int maximum = 1500;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.PercentView = true;
            this.progressBarControl1.Properties.Maximum = maximum;
            this.progressBarControl1.Properties.Minimum = 0;

            System.Threading.Thread t1 = new System.Threading.Thread(UpdateDatabaseStartEvent);
            t1.Start();
            this.ShowDialog();
        }


        public void UpdateDatabaseStartEvent()
        {
            //this.Show();
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.PercentView = true;
            this.progressBarControl1.Properties.Maximum = 691;
            this.progressBarControl1.Properties.Minimum = 0;

            SqlCommand sCommand = SqlCreateCommandFront();

            #region - CreateTable
            sCommand.CommandText = "SELECT  [TableName] = so.name FROM sysobjects so WHERE so.xtype = 'U' GROUP BY so.name ";
            DataTable tblTableList = ExecuteSelectCommand(sCommand);
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            DataColumn[] KeysTableList = new DataColumn[1];
            KeysTableList[0] = tblTableList.Columns["TableName"];
            tblTableList.PrimaryKey = KeysTableList;

            #region ApplicationServer
            if (tblTableList.Rows.Contains("ApplicationServer") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ApplicationServer]( "
                        + "     [Id][int] IDENTITY(1, 1) NOT NULL, "
                        + "  "
                        + "     [Server] [nvarchar] "
                        + "         (max) NULL, "
                        + "  "
                        + "     [ServerName] [nvarchar] "
                        + "         (max) NULL, "
                        + "  "
                        + "     [UserName] [nvarchar] (200) NULL, "
                        + " 	[Password] "
                        + "         [nvarchar] "
                        + "         (max) NULL, "
                        + "  "
                        + "     [DataBase] [nvarchar] (50) NULL, "
                        + "  CONSTRAINT[PK_ApplicationServer] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [Id] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
                //sCommand.CommandText = "INSERT INTO FBAccIntParameter (IntType,DocumentTypeCode,PayType)  VALUES(5,1,'0')";
                //ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region Users
            if (tblTableList.Rows.Contains("Users") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Users]( "
                        + "     [id][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [username] [nvarchar] (50) NOT NULL, "
                        + "     [password] [nvarchar] (50) NULL, "
                        + " 	[note] [text] NULL, "
                        + " 	[date] [datetime] NULL, "
                        + " 	[Active] [bit] NULL, "
                        + " 	[HaspPassword] [nvarchar] (50) NULL, "
                        + " 	[Email] [nvarchar] (50) NULL, "
                        + " 	[DefaultTheme] "
                        + "         [nvarchar] "
                        + "         (max) NULL, "
                        + "     [DefaultTheme2] [nvarchar] "
                        + "         (max) NULL, "
                        + "     [AdminAuthority] [bit] NULL, "
                        + "                         [ReportPrint][bit] NULL, "
                        + " [ExportExcelPdf] [bit] NULL, "
                        + " [DailyEndOperation] [bit] NULL, "
                        + " [EnvanterEntry] [bit] NULL, "
                        + " [VeresiyeDefterClosed] [bit] NULL, "
                        + "  CONSTRAINT[PK_users] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [username] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
                //sCommand.CommandText = "INSERT INTO FBAccIntParameter (IntType,DocumentTypeCode,PayType)  VALUES(5,1,'0')";
                //ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Cashiers
            if (tblTableList.Rows.Contains("Cashiers") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Cashiers]( "
                        + "     [id][int] NOT NULL, "
                        + "    [name] [nvarchar] (50) NULL, "
                        + " 	[surname] [nvarchar] (50) NULL, "
                        + " 	[address] [nvarchar] (50) NULL, "
                        + " 	[phone] [nvarchar] (50) NULL, "
                        + " 	[tcId] [nvarchar] (50) NULL, "
                        + " 	[authority] [bit] NULL, "
                        + " 	[date] [datetime] NULL, "
                        + " 	[salary] [bigint] NULL, "
                        + " 	[userId] [int] NULL, "
                        + " 	[cashNo] [int] NULL, "
                        + "  CONSTRAINT[PK_cashiers] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [id] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Categories
            if (tblTableList.Rows.Contains("Categories") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Categories]( "
                    + "     [id][int] NOT NULL, "
                    + "    [name] [nvarchar] (50) NULL, "
                    + " 	[type] [nvarchar] (50) NULL, "
                    + "  CONSTRAINT[PK_categories] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [id] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Company
            if (tblTableList.Rows.Contains("Company") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Company]( "
                            + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                            + "     [CompanyCode] [nvarchar] (50) NULL, "
                            + " 	[CompanyName] [nvarchar] (50) NULL, "
                            + " 	[Logo] [image] NULL, "
                            + " 	[Adress1] [nvarchar] (50) NULL, "
                            + " 	[Adress2] [nvarchar] (50) NULL, "
                            + " 	[BulvarCadde] [nvarchar] (50) NULL, "
                            + " 	[TelNo] [int] NULL, "
                            + " 	[BinaAdi] [nvarchar] (50) NULL, "
                            + " 	[BinaNo] [nvarchar] (50) NULL, "
                            + " 	[MahalleSemt] [nvarchar] (50) NULL, "
                            + " 	[Sehir] [nvarchar] (50) NULL, "
                            + " 	[PostaKodu] [int] NULL, "
                            + " 	[Ulke] [nvarchar] (50) NULL, "
                            + "  CONSTRAINT[PK_Company] PRIMARY KEY CLUSTERED "
                            + " ( "
                            + "    [RecId] ASC "
                            + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                            + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Customers
            if (tblTableList.Rows.Contains("Customers") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Customers]( "
                    + "     [id][int] NOT NULL, "
                    + "    [name] [nvarchar] (50) NULL, "
                    + " 	[surname] [nvarchar] (50) NULL, "
                    + " 	[address] [nvarchar] (50) NULL, "
                    + " 	[phone] [nvarchar] (50) NULL, "
                    + " 	[active] [bit] NULL, "
                    + " 	[date] [datetime] NULL, "
                    + "     [CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_customers] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [id] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Parameters
            if (tblTableList.Rows.Contains("Parameters") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Parameters]( "
                            + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                            + "     [NumaratorShow] [bit] NULL, "
                            + " 	[SaleApproval] [bit] NULL, "
                            + " 	[SaleOutOfStock] [bit] NULL, "
                            + " 	[SaleCahnge] [bit] NULL, "
                            + " 	[SaleInformationSlip] [bit] NULL, "
                            + " 	[MainSaleForm] [bit] NULL, "
                            + " 	[AutoCurrency] [bit] NULL, "
                            + " 	[UserRecordMy] [bit] NULL, "
                            + " 	[PaymentLock] [bit] NULL, "
                            + " 	[PaymentyForced] [bit] NULL, "
                            + " 	[SaleNewRecord] [bit] NULL, "
                            + " 	[SaleProductEndDate] [bit] NULL, "
                            + " 	[ProductEndDateDay] [int] NULL, "
                            + "  CONSTRAINT[PK_Parameters] PRIMARY KEY CLUSTERED "
                            + " ( "
                            + "    [RecId] ASC "
                            + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                            + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Products
            if (tblTableList.Rows.Contains("Products") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Products]( "
                        + "    [PID][int] IDENTITY(1, 1) NOT NULL, "
                        + "    [PName] [nvarchar] (max) NULL, "
                        + "	[PBarcode] [nvarchar] (50) NULL, "
                        + "	[PCategoryId] [int] NULL, "
                        + "	[PDate] [datetime] NULL, "
                        + "	[PFirstPrice] [decimal](18, 2) NULL, "
                        + "	[PTotal] [decimal](18, 2) NULL, "
                        + "	[PLastPrice] [decimal](18, 2) NULL, "
                        + "	[PUnitId] [int] NULL, "
                        + "	[PTax] [int] NULL, "
                        + "	[PVarDescription] [nvarchar] (50) NULL, "
                        + "	[PSpecCode] [nvarchar] (50) NULL, "
                        + "	[PBrandName] [nvarchar] (50) NULL, "
                        + "	[PBrandCode] [nvarchar] (50) NULL, "
                        + "	[PGroup] [nvarchar] (50) NULL, "
                        + "	[PImages] [varbinary] (max) NULL, "
                        + " [PExpDate] [datetime] NULL, "
                        + "	[PSalePrice] [decimal](18, 2) NULL, "
                        + "	[PTaxType] [int] NULL, "
                        + "	[PMalBedeli] [decimal](18, 2) NULL, "
                        + "	[PPaxAmout] [decimal](18, 2) NULL, "
                        + "	[PKdvIstisna] [bit] NULL, "
                        + "	[PKarPrice] [decimal](18, 2) NULL, "
                        + " [PCode] [nvarchar] (max) NULL, "
                        + " [PCompanyId] [int] NULL, "
                        + " [PDepotId] [int] NULL, "
                        + " [Deleted] [bit] NULL, "
                        + " CONSTRAINT[PK_products] PRIMARY KEY CLUSTERED "
                        + "( "
                        + "   [PID] ASC "
                        + ")WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + ") ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region BankEntry
            if (tblTableList.Rows.Contains("BankEntry") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[BankEntry]( "
                + "     [bid][int] IDENTITY(1, 1) NOT NULL, "
                + "     [docNo] [nvarchar] (50) NULL, "
                + " 	[bankID] [int] NULL, "
                + " 	[description] [nvarchar] (50) NULL, "
                + " 	[amountDeposited] [bigint] NULL, "
                + " 	[withdrawnDeposited] [bigint] NULL, "
                + " 	[bDate] [datetime] NULL, "
                + "     [CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_BankEntry] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [bid] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Banks
            if (tblTableList.Rows.Contains("Banks") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Banks]( "
                        + "     [Bid][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [BankName] [nvarchar] (50) NULL, "
                        + " 	[BankBranch] [nvarchar] (50) NULL, "
                        + " 	[BankBranchCode] [int] NULL, "
                        + " 	[BankAccountNumber] [nvarchar] (50) NULL, "
                        + " 	[BankAccountName] [nvarchar] (50) NULL, "
                        + "      [CompanyRecId] [int] NULL, "
                        + "  CONSTRAINT[PK_Banks] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [Bid] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region OrderManagement
            if (tblTableList.Rows.Contains("OrderManagement") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[OrderManagement]( "
                    + "     [oid][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [oType] [nvarchar] (50) NULL, "
                    + " 	[oStatus] [nvarchar] (50) NULL, "
                    + " 	[oDate] [datetime] NULL, "
                    + " 	[oNo] [int] NULL, "
                    + " 	[oAmount] [int] NULL, "
                    + " 	[oCTransactionNo] [int] NULL, "
                    + " 	[oCTransactionTitle] [nvarchar] (50) NULL, "
                    + " 	[oDescription] [nvarchar] (50) NULL, "
                    + "  CONSTRAINT[PK_OrderManagement] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [oid] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region CTransactions
            if (tblTableList.Rows.Contains("CTransactions") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CTransactions]( "
                    + "     [CurID][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [CurType] [nvarchar] (50) NULL, "
                    + " 	[CurCode] [nvarchar](50) NULL, "
                    + " 	[CurAccountName] [nvarchar] (50) NULL, "
                    + " 	[CurAuthPersonName] [nvarchar] (50) NULL, "
                    + " 	[CurDiscount] [int] NULL, "
                    + " 	[CurRiskLimit] [nvarchar] (50) NULL,                      "
                    + " 	[CurCity] [nvarchar] (50) NULL,                           "
                    + " 	[CurDistrict] [nvarchar] (50) NULL,                       "
                    + " 	[CurBalance] [bigint] NULL,                               "
                    + " 	[CurCompanyType] [nvarchar] (50) NULL,                    "
                    + " 	[CurCreatedDate] [datetime] NULL,                         "
                    + " 	[CurAdress] [nvarchar] (50) NULL,                         "
                    + " 	[CurAdressTwo] [nchar] (10) NULL,                         "
                    + " 	[CurCountryCode] [int] NULL,                              "
                    + " 	[CurCountryName] [nvarchar] (50) NULL,                    "
                    + " 	[CurZipCode] [int] NULL,                                  "
                    + " 	[CurPhoneOne] [nvarchar] (50) NULL,                       "
                    + " 	[CurPhoneTwo] [nvarchar] (50) NULL,                       "
                    + " 	[CurFax] [nvarchar] (50) NULL,                            "
                    + " 	[CurEmail] [nvarchar] (50) NULL,                          "
                    + " 	[CurDescription] [nvarchar] (50) NULL,                    "
                    + " 	[CurTaxNo] [nvarchar] (50) NULL,                          "
                    + " 	[CurTaxOffice] [nvarchar] (50) NULL,                      "
                    + " 	[CurCardNo] [nvarchar] (50) NULL,                         "
                    + " 	[CurIdentNo] [nvarchar] (50) NULL,                        "
                    + " 	[CurTitle] [nvarchar] (50) NULL,                          "
                    + "     [CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_CurrentTransactions] PRIMARY KEY CLUSTERED     "
                    + " ( "
                    + "    [CurID] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "INSERT INTO CTransactions (CurCode,CurAccountName,CurCreatedDate) VALUES ('PERAKENDE', 'PERAKENDE SATIS', GETDATE())";
                ExecuteNonQuery(sCommand);


            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region FormLayouts
            if (tblTableList.Rows.Contains("FormLayouts") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[FormLayouts](  "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "  "
                    + "     [UserCode] [varchar] (20) NULL, "
                    + " 	[FormName] [varchar] (50) NULL, "
                    + " 	[ControlName] [varchar] (50) NULL, "
                    + " 	[XmlData] "
                    + "         [varbinary] "
                    + "         (max) NULL, "
                    + "  "
                    + "     [ApplicationId] [int] NULL, "
                    + "  CONSTRAINT[PK_GridSetting] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region InvoiceOwner
            if (tblTableList.Rows.Contains("InvoiceOwner") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[InvoiceOwner]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [InvoiceType] [int] NULL, "
                    + " 	[FicDate] [datetime] NULL, "
                    + " 	[FichTime] [time] (7) NULL, "
                    + " 	[FicheType] [int] NULL, "
                    + " 	[FicheDocumentNo] "
                    + "         [nvarchar] "
                    + "         (max) NULL, "
                    + "     [FicheRemark] [nvarchar] (max) NULL, "
                    + "     [CariRecId] [int] NULL, "
                    + " 	[VadeTarih] [datetime] NULL, "
                    + " 	[DepoName] [int] NULL, "
                    + " 	[Indirim] [decimal](18, 2) NULL, "
                    + " 	[AraToplam] [decimal](18, 2) NULL, "
                    + " 	[ToplamKDV] [decimal](18, 2) NULL, "
                    + " 	[DigerMasraflar] [decimal](18, 2) NULL, "
                    + " 	[GenelToplam] [decimal](18, 2) NULL, "
                    + "     [CompanyId][int] NULL, "
                    + "     [EFaturaNo] [nvarchar] (50) NULL, "
                    + "     [EIrsaliyeNo] [nvarchar] (50) NULL, "
                    + "     [InoviceCancel] [bit] NULL, "
                    + "     [InvoicePrint] [bit] NULL, "
                    + "     [VadeGun] [int] NULL, "
                    + "     [VadeDate] [datetime] NULL, "
                    + "     [IrsaliyeDate] [datetime] NULL, "
                    + "     [IrsaliyeNo] [nvarchar] (50) NULL, "
                    + "     [DovizTuru] [int] NULL, "
                    + "     [KDV] [nvarchar] (50) NULL, "
                    + "     [Iskonto] [int] NULL, "
                    + "     [PaymentType] [nvarchar] (50) NULL, "
                    + "     [Deleted] [bit] NULL, "
                    + "     [OrderId] [int] NULL, "
                    + "     [IrsaliyeId] [int] NULL, "
                    + "  CONSTRAINT[PK_InvoiceOwner] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region InvoiceTrans
            if (tblTableList.Rows.Contains("InvoiceTrans") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[InvoiceTrans]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [InvoiceOwnerId] [int] NULL, "
                + " 	[ProductId] [int] NULL, "
                + " 	[Quentity] [int] NULL, "
                + " 	[UnitID] [int] NULL, "
                + " 	[KDV] [int] NULL, "
                + " 	[Indirim] [int] NULL, "
                + " 	[BirimFiyat] [decimal](18, 2) NULL, "
                + " 	[Tutar] [decimal](18, 2) NULL, "
                + " 	[SKT] [datetime] NULL, "
                + " 	[AlisFiyati] [decimal](18, 2) NULL, "
                + " 	[KarOrani] [int] NULL, "
                + "  CONSTRAINT[PK_InvoiceTrans] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region OrderOwner
            if (tblTableList.Rows.Contains("OrderOwner") == false)
            {
                sCommand.CommandText = "CREATE TABLE[dbo].[OrderOwner]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [CariRecId] [int] NULL, "
                + " 	[OrderType] [int] NULL, "
                + " 	[CompanyId] [int] NULL, "
                + " 	[SiparisNo] [nvarchar] (50) NULL, "
                + " 	[SiparisDate] [datetime] NULL, "
                + " [SiparisTime] [varchar](15) NULL,"
                + " [OzelKod] [nvarchar] (50) NULL, "
                + " 	[DovizId] [int] NULL, "
                + " 	[Kdv] [nvarchar] (50) NULL, "
                + " 	[Iskonto] [int] NULL, "
                + " 	[Durum] [nvarchar] (50) NULL, "
                + " 	[TeklifSiparis] [int] NULL, "
                + " 	[Remark] [nvarchar](max) NULL, "
                + "  [TotalToplam] [decimal](18, 2) NULL, "
                + " 	[TotalIskonto] [decimal](18, 2) NULL, "
                + " 	[TotalKDV] [decimal](18, 2) NULL, "
                + " 	[TotalSiparis] [decimal](18, 2) NULL, "
                + "     [TotalAraToplam] [decimal](18,2) NULL, "
                + " 	[Deleted] [bit] NULL, "
                + "  [IrsaliyeId] [int] NULL, "
                + "  CONSTRAINT[PK_OrderOwner] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region OrderTrans
            if (tblTableList.Rows.Contains("OrderTrans") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[OrderTrans]( "
            + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
            + "     [OwnerId] [int] NULL, "
            + " 	[StockId] [int] NULL, "
            + " 	[Miktar] [int] NULL, "
            + " 	[Sevk] [nvarchar] (50) NULL, "
            + " 	[Bekleyen] [nvarchar] (50) NULL, "
            + " 	[BirimId] [int] NULL, "
            + " 	[BirimFiyat] [decimal](18, 2) NULL, "
            + " 	[KDV] [int] NULL, "
            + " 	[Tutar] [decimal](18, 2) NULL, "
            + " 	[Remark] "
            + "         [nvarchar] "
            + "         (max) NULL, "
            + "  CONSTRAINT[PK_OrderTrans] PRIMARY KEY CLUSTERED "
            + " ( "
            + "    [RecId] ASC "
            + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
            + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region Depot
            if (tblTableList.Rows.Contains("Depot") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Depot]( "
                            + "     [DID][int] IDENTITY(1, 1) NOT NULL, "
                            + "     [DepName] [nvarchar] (50) NULL, "
                            + " 	[DepAddress] [nvarchar] (50) NULL, "
                            + " 	[DepDistrict] [nvarchar] (50) NULL, "
                            + " 	[DepCity] [nvarchar] (50) NULL, "
                            + " 	[DepAuthPerson] [nvarchar] (50) NULL, "
                            + " 	[DepPhoneOne] [nvarchar] (50) NULL, "
                            + " 	[DepPhoneTwo] [nvarchar] (50) NULL, "
                            + " 	[DepTaxAdministration] [nvarchar] (50) NULL, "
                            + " 	[DepTaxNo] [nvarchar] (50) NULL, "
                            + " 	[DepActive] [bit] NULL, "
                            + " 	[DepDate] [datetime] NULL, "
                            + " 	[CompanyRecId] [int] NULL, "
                            + "  CONSTRAINT[PK_Depot] PRIMARY KEY CLUSTERED "
                            + " ( "
                            + "    [DID] ASC "
                            + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                            + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region LOG
            if (tblTableList.Rows.Contains("LOG") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[LOG]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [UserCode] [varchar] (10) NULL, "
                    + " 	[CompanyCode] [varchar] (10) NULL, "
                    + " 	[FieldName] [varchar] (30) NULL, "
                    + " 	[TableName] [varchar] (30) NULL, "
                    + " 	[Old] [varchar] (50) NULL, "
                    + " 	[New] [varchar] (50) NULL, "
                    + " 	[PCName] [varchar] (30) NULL, "
                    + " 	[FormName] [varchar] (30) NULL, "
                    + " 	[CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_LOG] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region SecRights
            if (tblTableList.Rows.Contains("SecRights") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[SecRights]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [UserCode] [varchar] (10) NULL, "
                    + " 	[SecCode] [char](10) NULL, "
                    + " 	[SecPreview] [int] NULL, "
                    + " 	[SecUpdate] [int] NULL, "
                    + " 	[SecInsert] [int] NULL, "
                    + " 	[SecDelete] [int] NULL, "
                    + " 	[DocumentType] [int] NULL, "
                    + " 	[CompanyCode] [varchar] (10) NULL, "
                    + " 	[CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_SecRights] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region CaseDefinition

            if (tblTableList.Rows.Contains("CaseDefinition") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CaseDefinition]( "
                        + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [CaseName] [nvarchar] (50) NULL, "
                        + " 	[CompanyRecId] [int] NULL, "
                        + "  CONSTRAINT[PK_CaseDefinition] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [RecId] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region CaseMovement
            if (tblTableList.Rows.Contains("CaseMovement") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CaseMovement]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [CaseId] [int] NULL, "
                + " 	[RecordDate] [datetime] NULL, "
                + " 	[VadeDate] [datetime] NULL, "
                + " 	[VadeMonth] [nchar] (10) NULL, "
                + " 	[EvrakNo] [nvarchar] (50) NULL, "
                + " 	[Doviz] [int] NULL, "
                + " 	[IslemTuru] [int] NULL, "
                + " 	[Tutar] [decimal](18, 2) NULL, "
                + " 	[OdemeTuru] [int] NULL, "
                + " 	[OdemeGrubu] [int] NULL, "
                + " 	[Remark] [nvarchar] (max) NULL, "
                + "     [CariId] [int] NULL, "
                + " 	[Deleted] [bit] NULL, "
                + " 	[CompanyRecId] [int] NULL, "
                + " 	[RecordUser] [nvarchar] (50) NULL, "
                + "     [SaleOwnerId] [int] NULL, "
                + "  CONSTRAINT[PK_CaseMovement] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region CashPayGroupDef

            if (tblTableList.Rows.Contains("CashPayGroupDef") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CashPayGroupDef]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [ReCashPayGroupDef] [nvarchar] "
                    + "         (max) NULL, "
                    + "     [CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_CashPayGroupDef] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region CurrencyType

            if (tblTableList.Rows.Contains("CurrencyType") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CurrencyType]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [CurrencyCode] [varchar] (3) NOT NULL, "
                    + "      [Remark] [varchar] (50) NULL, "
                    + " 	[CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_CurrencyType] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [CurrencyCode] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region ExchangeRate
            if (tblTableList.Rows.Contains("ExchangeRate") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ExchangeRate]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [CurrDate] [datetime] "
                + "         NOT NULL, "
                + "     [CurrencyCode] [varchar] (3) NOT NULL, "
                + "      [Invoice] [numeric] (18, 5) NULL, "
                + " 	[Exchange] [numeric] (18, 5) NULL, "
                + " 	[Pos] [numeric] (18, 5) NULL, "
                + " 	[Buying] [numeric] (18, 5) NULL, "
                + " 	[Selling] [numeric] (18, 5) NULL, "
                + " 	[EffectiveBuying] [numeric] (18, 5) NULL, "
                + " 	[EffectiveSelling] [numeric] (18, 5) NULL, "
                + " 	[RecordUser] [varchar] (10) NULL, "
                + " 	[RecordDate] [datetime] NULL, "
                + "     [CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_ExchangeRate] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [CurrDate] ASC, "
                + "    [CurrencyCode] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region OpenFormRights
            if (tblTableList.Rows.Contains("OpenFormRights") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[OpenFormRights]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [UserCode] [varchar] (10) NULL, "
                + " 	[ActionName] [varchar] (50) NULL, "
                + " 	[OpenForm] [bit] NULL, "
                + " 	[CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_OpenFormRights] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region PaymentType
            if (tblTableList.Rows.Contains("PaymentType") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[PaymentType]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [Remark] [nvarchar] (50) NULL, "
                    + "  CONSTRAINT[PK_PaymentType] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region ProductGroup

            if (tblTableList.Rows.Contains("ProductGroup") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ProductGroup]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [Grouup] [nvarchar] (50) NULL, "
                + " 	[ReGroup] "
                + "         [nvarchar] "
                + "         (max) NULL, "
                + "     [CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_ProductGroup] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region ProductMark
            if (tblTableList.Rows.Contains("ProductMark") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ProductMark]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [Mark] [nvarchar] (50) NULL, "
                + " 	[Remark] "
                + "         [nvarchar] "
                + "         (max) NULL, "
                + "     [CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_ProductMark] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region ProductMovement
            if (tblTableList.Rows.Contains("ProductMovement") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ProductMovement]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [ProductId] [int] NULL, "
                    + " 	[Durum] [nvarchar] (50) NULL, "
                    + " 	[Quantity] [int] NULL, "
                    + " 	[Amount] [decimal](18, 2) NULL, "
                    + " 	[Date] [datetime] NULL, "
                    + " 	[Deleted] [bit] NULL, "
                    + " 	[DurumType] [int] NULL, "
                    + " 	[SaleOwnerId] [int] NULL, "
                    + "     [CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_ProductMovement] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region SaleOwner
            if (tblTableList.Rows.Contains("SaleOwner") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[SaleOwner]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [Date] [datetime] NULL, "
                + " 	[CustomerName] [nvarchar] (50) NULL, "
                + " 	[PaymentType] [int] NULL, "
                + " 	[NetPrice] [decimal](18, 2) NULL, "
                + " 	[NetPriceText] [nvarchar] (50) NULL,        "
                + " 	[KDV] [decimal](18, 2) NULL,                "
                + " 	[DiscountPrice] [decimal](18, 2) NULL,      "
                + " 	[TotalPriceText] [nvarchar] (50) NULL,      "
                + " 	[TotalPrice] [decimal](18, 2) NULL,         "
                + " 	[ReceivedPrice] [decimal](18, 2) NULL,      "
                + " 	[Remark]                                    "
                + "         [nvarchar]                              "
                + "         (max) NULL,                             "
                + "                                                 "
                + "     [Veresiye] [bit] NULL,                      "
                + " 	[CompanyRecId] [int] NULL,                  "
                + " 	[Deleted] [bit] NULL,                       "
                + " 	[UserCode] [nvarchar] (50) NULL,            "
                + " 	[AlinanPrice] [decimal](18, 2) NULL,        "
                + " 	[CaseId] [int] NULL,                        "
                + " 	[VeresiyeClosedDate] [datetime] NULL,       "
                + " 	[DovizId] [int] NULL,                       "
                + "  CONSTRAINT[PK_SaleOwner] PRIMARY KEY CLUSTERED "
                + " (                                               "
                + "    [RecId] ASC                                  "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region SaleTrans

            if (tblTableList.Rows.Contains("SaleTrans") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[SaleTrans]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL,  "
                    + "     [SaleOwnerId] [int] NULL, "
                    + " 	[ProductId] [int] NULL, "
                    + " 	[ProductBarcode] [nvarchar] (50) NULL, "
                    + " 	[ProductName] [nvarchar] (50) NULL, "
                    + " 	[ProductQuantity] [int] NULL, "
                    + " 	[ProductPrice] [decimal](18, 2) NULL, "
                    + " 	[ProductAmount] [decimal](18, 2) NULL, "
                    + " 	[CompanyId] [int] NULL, "
                    + " 	[Deleted] [bit] NULL, "
                    + " 	[UnitId] [int] NULL, "
                    + " 	[Tax] [int] NULL, "
                    + " 	[TaxAmount] [decimal](18, 2) NULL, "
                    + " 	[ProductDate] [datetime] NULL, "
                    + " 	[CaseId] [int] NULL, "
                    + "  CONSTRAINT[PK_SaleTrans] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region SpeedSaleProduct

            if (tblTableList.Rows.Contains("SpeedSaleProduct") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[SpeedSaleProduct]( "
                        + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [ProductId] [int] NULL, "
                        + " 	[İmage] [nchar] (10) NULL, "
                        + " 	[ButtonType] [int] NULL, "
                        + "     [CompanyRecId] [int] NULL, "
                        + "  CONSTRAINT[PK_SpeedSaleProduct] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [RecId] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();


            #endregion

            #region Units

            if (tblTableList.Rows.Contains("Units") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Units]( "
                    + "     [UID][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [UName] [nvarchar] (50) NULL, "
                    + "     [CompanyRecId] [int] NULL, "
                    + "  CONSTRAINT[PK_Units] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [UID] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region ProductBarCode

            if (tblTableList.Rows.Contains("ProductBarCode") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ProductBarCode]( "
               + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
               + "     [ProductId] [int] NULL, "
               + " 	[Barcode] [varchar] (50) NULL, "
               + " 	[Remark] [varchar] (255) NULL, "
               + " 	[CompanyRecId] [int] NULL, "
               + "  CONSTRAINT[PK_ProductBarCode] PRIMARY KEY CLUSTERED "
               + " ( "
               + "    [RecId] ASC "
               + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON[PRIMARY] "
               + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();


            #endregion

            #region DailyOwner

            if (tblTableList.Rows.Contains("DailyOwner") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[DailyOwner]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [Date] [datetime] NULL, "
                + " 	[Amount] [decimal](18, 2) NULL, "
                + " 	[SaleAmount] [decimal](18, 2) NULL, "
                + " 	[CashAmount] [decimal](18, 2) NULL, "
                + " 	[CardAmount] [decimal](18, 2) NULL, "
                + " 	[TotalProduct] [int] NULL, "
                + " 	[Remark] [nvarchar] (50) NULL, "
                + " 	[RetailSaleCount] [int] NULL, "
                + " 	[RetailSaleAmount] [decimal](18, 2) NULL, "
                + " 	[Revenue] [decimal](18, 2) NULL, "
                + " 	[Expense] [decimal](18, 2) NULL, "
                + " 	[CompanyRecId] [int] NULL, "
                + " 	[Deleted] [bit] NULL, "
                + "  CONSTRAINT[PK_DailyOwner] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region DailyTrans

            if (tblTableList.Rows.Contains("DailyTrans") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[DailyTrans]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [OwnerId] [int] NULL, "
                + " 	[SaleTransId] [int] NULL, "
                + " 	[CaseOwnerId] [int] NULL, "
                + " 	[Quantity] [int] NULL, "
                + " 	[Amount] [decimal](18, 2) NULL, "
                + " 	[Type] [int] NULL, "
                + " 	[Date] [datetime] NULL, "
                + " 	[CompanyRecId] [int] NULL, "
                + "  CONSTRAINT[PK_DailyTrans] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();



            #endregion

            #region SaleBarcodCreate
            if (tblTableList.Rows.Contains("SaleBarcodCreate") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[SaleBarcodCreate]( "
                        + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [Type] [int] NULL, "
                        + " 	[Barcode] [nvarchar] (50) NULL, "
                        + "  CONSTRAINT[PK_SaleBarcodCreate] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [RecId] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[SaleBarcodCreate]([Type],[Barcode]) VALUES (1,'00000001')";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();
            #endregion

            #region CurrentGroupDefinitions
            if (tblTableList.Rows.Contains("CurrentGroupDefinitions") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CurrentGroupDefinitions]( "
                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                + "     [Remark] [nvarchar] (50) NULL, "
                + "  CONSTRAINT[PK_CurrentGroupDefinitions] PRIMARY KEY CLUSTERED "
                + " ( "
                + "    [RecId] ASC "
                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[CurrentGroupDefinitions]([Remark]) VALUES ('Bayi')";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[CurrentGroupDefinitions]([Remark]) VALUES ('Müşteri')";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[CurrentGroupDefinitions]([Remark]) VALUES ('Tedarikçi')";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[CurrentGroupDefinitions]([Remark]) VALUES ('Personel')";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #region ShippingInformation

            if (tblTableList.Rows.Contains("ShippingInformation") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[ShippingInformation]( "
                    + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [AccId] [int] NULL, "
                    + " 	[AdressDefinition] [nvarchar] (50) NULL, "
                    + " 	[Adress] "
                    + "         [nvarchar] "
                    + "         (max) NULL, "
                    + "     [County] [nvarchar] (50) NULL, "
                    + " 	[District] [nvarchar] (50) NULL, "
                    + " 	[Country] [nvarchar] (50) NULL, "
                    + " 	[Phone] [nvarchar] (50) NULL, "
                    + " 	[Authorized] [nvarchar] (50) NULL, "
                    + " 	[CompanyId] [int] NULL, "
                    + "  CONSTRAINT[PK_ShippingInformation] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            #endregion

            #endregion

            #region CreateColumn


            #region Excemple
            //sCommand.CommandText = "Select top 1 * from Products  WITH (nolock) ";
            //DataTable tblProductionMeans = ExecuteSelectCommand(sCommand);
            //if (tblProductionMeans.Columns.Contains("PKarPrice") == false)
            //{
            //    sCommand.CommandText = "ALTER TABLE Products ADD PKarPrice [decimal](18, 2) NULL";
            //    ExecuteNonQuery(sCommand);
            //}
            //progressBarControl1.PerformStep();
            //progressBarControl1.Update(); Application.DoEvents();


            sCommand.CommandText = "Select top 1 * from Users  WITH (nolock) ";
            DataTable tblProductionMeans = ExecuteSelectCommand(sCommand);
            if (tblProductionMeans.Columns.Contains("DefaultTheme") == false)
            {
                sCommand.CommandText = "ALTER TABLE Users ADD DefaultTheme nvarchar(max) NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            if (tblProductionMeans.Columns.Contains("DefaultTheme2") == false)
            {
                sCommand.CommandText = "ALTER TABLE Users ADD DefaultTheme2 nvarchar(max) NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.Update(); Application.DoEvents();
            progressBarControl1.PerformStep();

            sCommand.CommandText = "Select top 1 * from products  WITH (nolock) ";
            DataTable tblProduct = ExecuteSelectCommand(sCommand);

            if (tblProduct.Columns.Contains("PCode") == false)
            {
                sCommand.CommandText = "ALTER TABLE products ADD PCode nvarchar(max) NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region Product

            sCommand.CommandText = "Select top 1 * from Products  WITH (nolock) ";
            DataTable tblPRoduct = ExecuteSelectCommand(sCommand);
            if (tblPRoduct.Columns.Contains("PCompanyId") == false)
            {
                sCommand.CommandText = "ALTER TABLE Products ADD PCompanyId bit";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            if (tblPRoduct.Columns.Contains("PBarcodeType") == false)
            {
                sCommand.CommandText = "ALTER TABLE Products ADD PBarcodeType int";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            #endregion

            #region SaleOwner
            sCommand.CommandText = "Select top 1 * from SaleOwner  WITH (nolock) ";
            DataTable tblSaleOwner = ExecuteSelectCommand(sCommand);
            if (tblSaleOwner.Columns.Contains("CaseId") == false)
            {
                sCommand.CommandText = "ALTER TABLE SaleOwner ADD CaseId int";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            if (tblSaleOwner.Columns.Contains("DovizId") == false)
            {
                sCommand.CommandText = "ALTER TABLE SaleOwner ADD DovizId int";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region SaleTrans
            sCommand.CommandText = "Select top 1 * from SaleTrans  WITH (nolock) ";
            DataTable tblSaleTrans = ExecuteSelectCommand(sCommand);
            if (tblSaleTrans.Columns.Contains("CaseId") == false)
            {
                sCommand.CommandText = "ALTER TABLE SaleTrans ADD CaseId int";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region Units
            sCommand.CommandText = "Select top 1 * from Units  WITH (nolock) ";
            DataTable tblUnits = ExecuteSelectCommand(sCommand);
            if (tblUnits.Columns.Contains("CompanyRecId") == false)
            {
                sCommand.CommandText = "ALTER TABLE Units ADD CompanyRecId int NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            #endregion

            #region CTransactions
            sCommand.CommandText = "Select top 1 * from CTransactions  WITH (nolock) ";
            DataTable tblCTransactions = ExecuteSelectCommand(sCommand);
            if (tblCTransactions.Columns.Contains("GroupId") == false)
            {
                sCommand.CommandText = "ALTER TABLE CTransactions ADD GroupId int NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            if (tblCTransactions.Columns.Contains("SevkId") == false)
            {
                sCommand.CommandText = "ALTER TABLE CTransactions ADD SevkId int NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region Users
            sCommand.CommandText = "Select top 1 * from Users  WITH (nolock) ";
            DataTable tblUsers = ExecuteSelectCommand(sCommand);
            if (tblUsers.Columns.Contains("ReportPrint") == false)
            {
                sCommand.CommandText = "ALTER TABLE Users ADD ReportPrint bit";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Users set ReportPrint = 1";
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "ALTER TABLE Users ADD ExportExcelPdf bit";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Users set ExportExcelPdf = 1";
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "ALTER TABLE Users ADD DailyEndOperation bit";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Users set DailyEndOperation = 1";
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "ALTER TABLE Users ADD EnvanterEntry bit";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Users set EnvanterEntry = 1";
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "ALTER TABLE Users ADD VeresiyeDefterClosed bit";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Users set VeresiyeDefterClosed = 1";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region OrderOwner
            sCommand.CommandText = "Select top 1 * from OrderOwner  WITH (nolock) ";
            DataTable tblOrderOwner = ExecuteSelectCommand(sCommand);
            if (tblOrderOwner.Columns.Contains("TotalAraToplam") == false)
            {
                sCommand.CommandText = "ALTER TABLE OrderOwner ADD TotalAraToplam decimal(18,2) NULL";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            #endregion

            #region Parameters
            sCommand.CommandText = "Select top 1 * from Parameters  WITH (nolock) ";
            DataTable tblParameters = ExecuteSelectCommand(sCommand);
            if (tblParameters.Columns.Contains("PaymentFisSave") == false)
            {
                sCommand.CommandText = "ALTER TABLE Parameters ADD PaymentFisSave bit NULL";
                ExecuteNonQuery(sCommand);
            }
            if (tblParameters.Columns.Contains("IsBarcode") == false)
            {
                sCommand.CommandText = "ALTER TABLE Parameters ADD IsBarcode bit NULL";
                ExecuteNonQuery(sCommand);
            }
            if (tblParameters.Columns.Contains("BorcodeCOM") == false)
            {
                sCommand.CommandText = "ALTER TABLE Parameters ADD BorcodeCOM nchar(10) NULL";
                ExecuteNonQuery(sCommand);
            }
            if (tblParameters.Columns.Contains("ReportType") == false)
            {
                sCommand.CommandText = "ALTER TABLE Parameters ADD ReportType int NULL";
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "Update Parameters set ReportType = 0";
                ExecuteNonQuery(sCommand);

            }

            #endregion

            #endregion



            sCommand.Parameters.Clear();
            sCommand.CommandText = "Update ProgramsControl set MspVersion=@MspVersion ";
            sCommand.Parameters.Add("MspVersion", SqlDbType.VarChar).Value = AppMain.MspVersion.ToString().Trim();
            ExecuteNonQuery(sCommand);
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            this.Close();



        }


    }
}