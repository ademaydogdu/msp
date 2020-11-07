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
                + ";data source=" + AppMain.SqlConnection.Server
                + ";user id=" + AppMain.SqlConnection.UserId
                + ";password=" + AppMain.SqlConnection.Password
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


            if (tblTableList.Rows.Contains("Users") == false)
            {
                sCommand.CommandText = " CREATE TABLE [dbo].[Users]( "
                        + "     [id][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [username] [nvarchar] (50) NOT NULL, "
                        + "     [password] [nvarchar] (50) NULL, "
                        + " 	[note] [text] NULL, "
                        + " 	[date] [datetime] NULL, "
                        + " 	[Active] [bit] NULL, "
                        + " 	[HaspPassword] [nvarchar] (50) NULL, "
                        + " 	[Email] [nvarchar] (50) NULL, "
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

            if (tblTableList.Rows.Contains("Company") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Company]( "
                    + "     [RecId][int] NOT NULL, "

                    + "    [CompanyCode] [nchar] (10) NULL, "
                    + " 	[CompanyName] [nchar] (10) NULL, "
                    + "  CONSTRAINT[PK_Company] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

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

            if (tblTableList.Rows.Contains("Parameters") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Parameters]( "
                    + "     [RecId][int] NULL, "
                    + "     [NumaratorShow] [bit] NULL "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Products") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[products]( "
                        + "    [PID][int] IDENTITY(1, 1) NOT NULL, "
                        + "    [PName] [nvarchar] (50) NULL, "
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
                        + "    [PExpDate] [datetime] NULL, "
                        + "	[PSalePrice] [decimal](18, 2) NULL, "
                        + "	[PTaxType] [int] NULL, "
                        + "	[PMalBedeli] [decimal](18, 2) NULL, "
                        + "	[PPaxAmout] [decimal](18, 2) NULL, "
                        + "	[PKdvIstisna] [bit] NULL, "
                        + "	[PKarPrice] [decimal](18, 2) NULL, "
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

            if (tblTableList.Rows.Contains("Banks") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Banks]( "
                        + "     [Bid][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [BankName] [nvarchar] (50) NULL, "
                        + " 	[BankBranch] [nvarchar] (50) NULL, "
                        + " 	[BankBranchCode] [int] NULL, "
                        + " 	[BankAccountNumber] [nvarchar] (50) NULL, "
                        + " 	[BankAccountName] [nvarchar] (50) NULL, "
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

            if (tblTableList.Rows.Contains("CTransactions") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[CTransactions]( "
                    + "     [CurID][int] IDENTITY(1, 1) NOT NULL, "
                    + "     [CurType] [nvarchar] (50) NULL, "
                    + " 	[CurCode] [bigint] NULL, "
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
                    + "  CONSTRAINT[PK_CurrentTransactions] PRIMARY KEY CLUSTERED     "
                    + " ( "
                    + "    [CurID] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

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