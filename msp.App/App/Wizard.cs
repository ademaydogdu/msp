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
using DevExpress.XtraWizard;
using System.IO;
using System.Data.SqlClient;
using System.Data.Common;
using Msp.Infrastructure.Extensions;
using Msp.Infrastructure;
using SKGL;

namespace Msp.App.App
{
    public partial class Wizard : DevExpress.XtraEditors.XtraForm
    {
        public Wizard()
        {
            InitializeComponent();
        }




        #region DescRiption

        private bool DataBaseControl;
        private string SqlConnectionString;
        private bool SqlLocal;

        private bool IsDemo;
        #endregion

        public DevExpress.XtraSplashScreen.SplashScreenManager Splash { get; set; }
        public System.Reflection.Assembly assembly { get; set; }
        public string Script { get; set; } = "";

        string Licence = "";

        private void do_LisansDemo()
        {
            if (rpLisans.Checked)
            {
                IsDemo = false;
                AppMain.IsDemo = false;
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("IsDemo", SecurityExtension.Sifrele("false"));
                Licence = txtUrunAnahtar.Text.Trim();
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("Licence", Licence);
                AppMain.Licence = Licence;

            }
            if (rpDeneme.Checked)
            {
                try
                {
                    //AdminDatabase Kayıt yapılacak
                    IsDemo = true;
                    AppMain.IsDemo = true;
                    if (Convert.ToString(txtPhone.EditValue) == "")
                    {
                        XtraMessageBox.Show("Telefon Numarası Giriniz.");
                        return;
                    }
                    if (Convert.ToString(txtEPosta.EditValue) == "")
                    {
                        XtraMessageBox.Show("E-Posta Adresi Giriniz.");
                        return;
                    }
                    string lice = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("Licence").ToString();
                    if (lice.ToString().Trim().Length == 0)
                    {
                        Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("IsDemo", SecurityExtension.Sifrele("true"));

                        Generate generate = new Generate();
                        generate.secretPhase = "c4e128b141aFb";
                        Licence = generate.doKey(int.Parse("15"));
                        Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("Licence", Licence);
                        AppMain.Licence = Licence;
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());
                }

            }
        }

        private void do_FirstRecord()
        {
            if (Convert.ToString(txtKullaniciAdi.EditValue) == "")
            {
                XtraMessageBox.Show("Kullanıcı Adı Giriniz.");
                return;
            }
            if (Convert.ToString(txtUserParola.EditValue) == "")
            {
                XtraMessageBox.Show("Parola Giriniz.");
                return;
            }
            if (Convert.ToString(txtSirketAdi.EditValue) == "")
            {
                XtraMessageBox.Show("Şirket Adı Giriniz.");
                return;
            }
            if (Convert.ToString(txtDepotAdi.EditValue) == "")
            {
                XtraMessageBox.Show("Depo Adı Giriniz.");
                return;
            }



            try
            {

                Splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Waiting.Wait), true, true);
                Splash.WaitForSplashFormClose();
                if (!Splash.IsSplashFormVisible)
                {
                    Splash.ShowWaitForm();
                }
                SqlCommand sCommand = SqlCreateCommandFront(SqlConnectionString);


                sCommand.CommandText = "SELECT  [TableName] = so.name FROM sysobjects so WHERE so.xtype = 'U' GROUP BY so.name ";
                DataTable tblTableList = ExecuteSelectCommand(sCommand);
                DataColumn[] KeysTableList = new DataColumn[1];
                KeysTableList[0] = tblTableList.Columns["TableName"];
                tblTableList.PrimaryKey = KeysTableList;


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
                        + " [ReportPrint][bit] NULL, "
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
                }

                sCommand.CommandText = "INSERT INTO [dbo].[Users] "
+ "         ([username] "
+ "         ,[password] "
+ "         ,[date] "
+ "         ,[Active] "
+ "         ,[HaspPassword]) "
+ "   VALUES "
+ "         ('Admin' "
+ "         ,@Password "
+ "         ,@date "
+ "         ,'True' "
+ "         ,@HashPassword)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("Password", SqlDbType.NVarChar).Value = SecurityExtension.Sifrele("c4e128b141aFb");
                sCommand.Parameters.Add("date", SqlDbType.DateTime).Value = DateTime.Now;
                sCommand.Parameters.Add("HashPassword", SqlDbType.NVarChar).Value = SecurityExtension.ConvertStringToMD5("c4e128b141aFb");
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "INSERT INTO [dbo].[Users] "
       + "         ([username] "
       + "         ,[password] "
       + "         ,[date] "
       + "         ,[Active] "
       + "         ,[HaspPassword]) "
       + "   VALUES "
       + "         (@userName "
       + "         ,@Password "
       + "         ,@date "
       + "         ,'True' "
       + "         ,@HashPassword)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("userName", SqlDbType.NVarChar).Value = txtKullaniciAdi.EditValue;
                sCommand.Parameters.Add("Password", SqlDbType.NVarChar).Value = SecurityExtension.Sifrele(txtUserParola.EditValue.ToString());
                sCommand.Parameters.Add("date", SqlDbType.DateTime).Value = DateTime.Now;
                sCommand.Parameters.Add("HashPassword", SqlDbType.NVarChar).Value = SecurityExtension.ConvertStringToMD5(txtUserParola.EditValue.ToString());
                ExecuteNonQuery(sCommand);
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

                sCommand.CommandText = "INSERT INTO [dbo].[Company] ([CompanyCode], [CompanyName]) VALUES ('001', @companyName);SELECT SCOPE_IDENTITY();";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("companyName", SqlDbType.NVarChar).Value = txtSirketAdi.EditValue;
                int CompanyRecId = Convert.ToInt32(ExecuteScalar(sCommand));
                //ExecuteNonQuery(sCommand);
                #endregion

                #region Depo

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

                sCommand.CommandText = "INSERT INTO [dbo].[Depot] ([DepName],[CompanyRecId])  VALUES (@DepName, @CompanyRecId)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("DepName", SqlDbType.NVarChar).Value = txtDepotAdi.EditValue;
                sCommand.Parameters.Add("CompanyRecId", SqlDbType.Int).Value = CompanyRecId;
                ExecuteNonQuery(sCommand);
                #endregion

                #region ApplicatonServer

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
                }



                string[] conArry;
                conArry = SqlConnectionString.Split(';');
                List<string> conn = new List<string>();
                foreach (var item in conArry)
                {
                    int position = item.IndexOf("=");
                    if (position < 0)
                        continue;
                    conn.Add(item.Substring(position + 1));
                }


                if (SqlLocal)
                {
                    sCommand.CommandText = "INSERT INTO [dbo].[ApplicationServer] "
                                        + "        ([Server] "
                                        + "        ,[ServerName] "
                                        + "        ,[UserName] "
                                        + "        ,[Password] "
                                        + "        ,[DataBase])"
                                        + "  VALUES "
                                        + "        (@server "
                                        + "        ,@serverName "
                                        + "        ,'' "
                                        + "        ,'' , @DataBase)";
                    sCommand.Parameters.Clear();
                    sCommand.Parameters.Add("server", SqlDbType.NVarChar).Value = "(localdb)\\MSSQLLocalDB";
                    sCommand.Parameters.Add("serverName", SqlDbType.NVarChar).Value = "SQLLocal";
                    sCommand.Parameters.Add("DataBase", SqlDbType.NVarChar).Value = "Msp";
                    ExecuteNonQuery(sCommand);
                }
                else
                {
                    //sCommand.CommandText = "INSERT INTO [dbo].[ApplicationServer] "
                    //                    + "        ([Server] "
                    //                    + "        ,[ServerName] "
                    //                    + "        ,[UserName] "
                    //                    + "        ,[Password] "
                    //                    + "        ,[DataBase])"
                    //                    + "  VALUES "
                    //                    + "        (@server "
                    //                    + "        ,@serverName "
                    //                    + "        ,'' "
                    //                    + "        ,'' , @DataBase)";
                    //sCommand.Parameters.Clear();
                    //sCommand.Parameters.Add("server", SqlDbType.NVarChar).Value = "(localdb)\\MSSQLLocalDB";
                    //sCommand.Parameters.Add("serverName", SqlDbType.NVarChar).Value = "SQLLocal";
                    //sCommand.Parameters.Add("DataBase", SqlDbType.NVarChar).Value = "Msp";
                    //ExecuteNonQuery(sCommand);
                }

                #endregion

                #region Parameter

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

                sCommand.CommandText = "INSERT INTO [dbo].[Parameters] "
                + "           ([NumaratorShow] "
                + "           ,[SaleApproval] "
                + "           ,[SaleOutOfStock] "
                + "           ,[SaleCahnge] "
                + "           ,[SaleInformationSlip] "
                + "           ,[MainSaleForm] "
                + "           ,[AutoCurrency] "
                + "           ,[UserRecordMy] "
                + "           ,[PaymentLock] "
                + "           ,[PaymentyForced] "
                + "           ,[SaleNewRecord] "
                + "           ,[SaleProductEndDate] "
                + "           ,[ProductEndDateDay]) "
                + "     VALUES "
                + "           ('True' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'False' "
                + "           ,'True' "
                + "           ,'True' "
                + "           ,'False' "
                + "           ,10)";
                sCommand.Parameters.Clear();
                ExecuteNonQuery(sCommand);
                #endregion

                #region Currency

                if (tblTableList.Rows.Contains("CurrencyType") == false)
                {
                    sCommand.CommandText = "CREATE TABLE [dbo].[CurrencyType]( "
                    + "    [RecId][int] IDENTITY(1, 1) NOT NULL, "
                    + "    [CurrencyCode] [varchar] (3) NOT NULL, "
                    + "     [Remark] [varchar] (50) NULL, "
                    + "	[CompanyRecId] [int] NULL, "
                    + " CONSTRAINT[PK_CurrencyType] PRIMARY KEY CLUSTERED "
                    + "( "
                    + "   [CurrencyCode] ASC "
                    + ")WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + ") ON[PRIMARY]";
                    ExecuteNonQuery(sCommand);

                }

                sCommand.CommandText = "INSERT INTO [dbo].[CurrencyType] ([CurrencyCode],[Remark],[CompanyRecId]) VALUES ('TL','TL',@CompanyRecId) ";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("CompanyRecId", SqlDbType.Int).Value = CompanyRecId;
                ExecuteNonQuery(sCommand);

                sCommand.CommandText = "INSERT INTO [dbo].[CurrencyType] ([CurrencyCode],[Remark],[CompanyRecId]) VALUES ('USD','USD',@CompanyRecId) ";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("CompanyRecId", SqlDbType.Int).Value = CompanyRecId;
                ExecuteNonQuery(sCommand);

                #endregion

                #region ProgramsControl

                if (tblTableList.Rows.Contains("ProgramsControl") == false)
                {
                    sCommand.CommandText = "CREATE TABLE [dbo].[ProgramsControl]( "
                                + "     [RecId][int] IDENTITY(1, 1) NOT NULL, "
                                + "     [MspVersion] [nvarchar] (50) NULL, "
                                + " 	[Licence] [nvarchar] (50) NULL, "
                                + " 	[FirstDate] [datetime] NULL, "
                                + " 	[MacAdress] [nvarchar] (50) NULL, "
                                + " 	[IpAdress] [nvarchar] (50) NULL, "
                                + " 	[LocalIpAdress] [nvarchar] (50) NULL, "
                                + "     [IsDemo] [bit] NULL, "
                                + "  CONSTRAINT[PK_ProgramsControl] PRIMARY KEY CLUSTERED "
                                + " ( "
                                + "    [RecId] ASC "
                                + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                                + " ) ON[PRIMARY]";
                    ExecuteNonQuery(sCommand);

                }


                sCommand.CommandText = "INSERT INTO [dbo].[ProgramsControl]([MspVersion],[Licence],[FirstDate],[IsDemo]) VALUES ('1.0.0.0','',@date,@Demo)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("Demo", SqlDbType.Bit).Value = IsDemo;
                sCommand.Parameters.Add("date", SqlDbType.DateTime).Value = dt_RecordDate.DateTime;
                //sCommand.Parameters.Add("MacAdress", SqlDbType.NVarChar).Value = AppMain.MAcAdress;
                //sCommand.Parameters.Add("IpAdress", SqlDbType.NVarChar).Value = AppMain.IpAdress;
                //sCommand.Parameters.Add("LocalIp", SqlDbType.NVarChar).Value = AppMain.LocalIpAdress;
                ExecuteNonQuery(sCommand);


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

                sCommand.CommandText = "INSERT INTO [dbo].[PaymentType] ([Remark]) VALUES ('Nakit')";
                sCommand.Parameters.Clear();
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[PaymentType] ([Remark]) VALUES ('Pos')";
                sCommand.Parameters.Clear();
                ExecuteNonQuery(sCommand);
                sCommand.CommandText = "INSERT INTO [dbo].[PaymentType] ([Remark]) VALUES ('Pos & Nakit')";
                sCommand.Parameters.Clear();
                ExecuteNonQuery(sCommand);


                #endregion


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                if (Splash.IsSplashFormVisible)
                {
                    Splash.CloseWaitForm();
                }
                string path = @"C:\Msp\ConnectString.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        string sifrele = SecurityExtension.Sifrele(SqlConnectionString);
                        sw.WriteLine(sifrele);
                    }
                }
                pageLisansDemo.AllowNext = true;
            }

        }

        private void do_SQLSettings()
        {
            if (chLocalDB.Checked)
            {
                AppMain.LocalConnect = true;
                SqlLocal = true;
                SqlConnectionString = @"data source=(localdb)\MSSQLLocalDB;initial catalog=Msp;Trusted_Connection=True;Integrated security=False;Connect Timeout=1000";
                //SqlConnectionString = "data source = DG; initial catalog = Msp; user id = sa; password = 123D654!; ";
                if (sqlKontrol(SqlConnectionString) == false)
                {
                    DataBaseControl = false;
                }
                else
                {
                    lblSqlDurumText.Text = "Veri Tabanı Mevcuttur. Yeniden Oluşturuluyor...";
                    DataBaseControl = true;
                }
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("SqlLocal", true);

            }
            if (chcSunucu.Checked)
            {
                SqlLocal = false;
                AppMain.LocalConnect = false;
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("SqlLocal", false);
                SqlConnectionString = $"data source={txtServer.Text.Trim().ToString()};initial catalog={txtdatabase.Text.Trim().ToString()};user id = {txtServerUser.Text.Trim().ToString()}; password = {txtServerPas.Text.Trim().ToString()}; ";
                if (sqlKontrol(SqlConnectionString) == false)
                {
                    DataBaseControl = false;
                }
                else
                {
                    lblSqlDurumText.Text = "Veri Tabanı Mevcuttur.";
                    DataBaseControl = true;
                }
            }
        }

        private void do_CreateDatabese()
        {
            bool x = false;
            var query = GetDbCreationQuery();
            var conn = new System.Data.SqlClient.SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated security=SSPI;");
            //var conn = new System.Data.SqlClient.SqlConnection(@"Server=.;Integrated security=SSPI;");
            var command = new System.Data.SqlClient.SqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                lblSqlDurumText.Text = "Data oluşturuldu.";
                x = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((conn.State == ConnectionState.Open))
                {
                    conn.Close();
                }
            }
            if (x)
            {
                do_CreateTable();

            }
        }

        static string GetDbCreationQuery()
        {
            string dbName = "Msp";
            string[] files = { System.IO.Path.Combine(@"C:\Msp\Database", dbName + ".mdf"),
                       System.IO.Path.Combine(@"C:\Msp\Database", dbName + ".ldf") };
            string query = "CREATE DATABASE " + dbName +
                " ON PRIMARY" +
                " (NAME = " + dbName + "_data," +
                " FILENAME = '" + files[0] + "'," +
                " SIZE = 3MB," +
                " MAXSIZE = 10MB," +
                " FILEGROWTH = 10%)" +

                " LOG ON" +
                " (NAME = " + dbName + "_log," +
                " FILENAME = '" + files[1] + "'," +
                " SIZE = 1MB," +
                " MAXSIZE = 5MB," +
                " FILEGROWTH = 10%)" +
                ";";

            //string _sqlquery = "IF EXISTS ( "
            //+ "      SELECT name FROM sys.databases "
            //+ "     WHERE name = N'" + dbName + "' ) "
            //+ " BEGIN "
            //+ "     Drop Database  " + dbName
            //+ "     " + query
            //+ " END "
            //+ " ELSE "
            //+ " BEGIN "
            //  + "     " + query
            //+ " END";


            return query;
        }

        private void do_CreateTable()
        {
            bool x = false;

            assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var resources = GetManifestResourceNames();

            resources.RemoveAll(r => !r.StartsWith("Msp.App.Scripts"));

            if (string.IsNullOrEmpty(Script))
            {
                var lastOne = resources.LastOrDefault();
                var lastDim = lastOne.Split('.');
                if (lastDim.Length > 1)
                {
                    Script = lastDim[lastDim.Length - 2];
                }
            }
            SqlCommand sCommand = SqlCreateCommandFront(SqlConnectionString);

            foreach (var item in resources)
            {
                StringBuilder strBuilder = new StringBuilder();
                using (Stream s = assembly.GetManifestResourceStream(item))
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string line = sr.ReadLine();
                            if (line.Trim() != "GO")
                            {
                                strBuilder.Append(line + Environment.NewLine);
                            }
                            if (line.Trim() == "GO")
                            {
                                sCommand.CommandText = strBuilder.ToString();
                                try
                                {
                                    ExecuteNonQuery(sCommand);
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show(ex.Message);
                                    x = false;
                                }
                                finally
                                {

                                }
                                strBuilder = new StringBuilder();
                                x = true;
                            }
                        }
                    }
                }
            }
            if (x) pageCreateDatabase.AllowNext = true;

        }
        public List<string> GetManifestResourceNames()
        {

            string[] resources = assembly.GetManifestResourceNames();
            return resources.ToList().OrderBy(r => r).ToList();

        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardLisansAnlasmasi)
            {
                string root = @"C:\Msp";
                if (!System.IO.Directory.Exists(root))
                {
                    System.IO.Directory.CreateDirectory(root);
                }
                string databasefolder = @"C:\Msp\Database";
                if (!System.IO.Directory.Exists(databasefolder))
                {
                    System.IO.Directory.CreateDirectory(databasefolder);
                }
            }
            if (e.Page == pageLisansDemo)
            {
                e.Page.AllowNext = false;
                if (!rpDeneme.Checked || !rpLisans.Checked)
                {
                    e.Page.AllowNext = false;
                }
                do_LisansDemo();

            }
            if (e.Page == pageSqlSettings)
            {
                //do_SQLSettings();
            }
            if (e.Page == pageRecordPage)
            {
                do_FirstRecord();
            }
        }

        private void Wizard_Load(object sender, EventArgs e)
        {

        }

        private void rpLisans_CheckedChanged(object sender, EventArgs e)
        {
            rpLisans.Visible = true;
            //rpDeneme.Visible = false;
            gc_Lisans.Visible = true;
            gc_Denme.Visible = false;
            pageLisansDemo.AllowNext = true;
        }

        private void rpDeneme_CheckedChanged(object sender, EventArgs e)
        {
            //rpLisans.Visible = false;
            rpDeneme.Visible = true;
            gc_Lisans.Visible = false;
            gc_Denme.Visible = true;
            pageLisansDemo.AllowNext = true;
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardLisansAnlasmasi)
            {
                if (!cb_LisansControl.Checked)
                    e.Page.AllowNext = false;
            }
            if (e.Page == pageSqlSettings)
            {
                if (chcSunucu.Checked == false && chLocalDB.Checked == false)
                    e.Page.AllowNext = false;
            }

            if (e.Page == pageLisansDemo)
            {
                e.Page.AllowBack = false;
                e.Page.AllowNext = false;
            }
        }

        private void cb_LisansControl_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_LisansControl.Checked)
            {
                wizardLisansAnlasmasi.AllowNext = true;
            }
            else
            {
                wizardLisansAnlasmasi.AllowNext = false;
            }
        }

        private void chLocalDB_CheckedChanged(object sender, EventArgs e)
        {
            if (chLocalDB.Checked)
            {
                chcSunucu.Checked = false;
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                pageSqlSettings.AllowNext = true;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                pageSqlSettings.AllowNext = false;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
        }

        private void chcSunucu_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSunucu.Checked)
            {
                chcSunucu.Checked = true;
                chLocalDB.Checked = false;
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
            else
            {
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
            pageSqlSettings.AllowNext = false;

        }

        public bool sqlKontrol(string connectionString)
        {
            bool donus = true;
            System.Data.SqlClient.SqlConnection sConn = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = sConn;
            try
            {
                cmd.Connection.Open();
            }
            catch
            {
                donus = false;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return donus;
        }

        private void wizardControl1_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == pageCreateDatabase)
            {
                Splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(Waiting.Wait), true, true);
                Splash.WaitForSplashFormClose();
                if (!Splash.IsSplashFormVisible)
                {
                    Splash.ShowWaitForm();
                }

                do_SQLSettings();
                if (DataBaseControl)
                {
                    e.Page.AllowNext = true;
                    do_CreateTable();
                    if (Splash.IsSplashFormVisible)
                    {
                        Splash.CloseWaitForm();
                    }
                }
                else
                {
                    e.Page.AllowNext = false;
                    do_CreateDatabese();

                    if (Splash.IsSplashFormVisible)
                    {
                        Splash.CloseWaitForm();
                    }
                }

            }
            if (e.Page == pageLisansDemo)
            {
                dt_RecordDate.EditValue = DateTime.Now;
            }
        }

        public static System.Data.SqlClient.SqlCommand SqlCreateCommandFront(string connectionString)
        {
            //string connectionString = "initial catalog=Msp"
            //    + ";data source=(localdb)\\MSSQLLocalDB"
            //    //+ ";user id=sa"
            //    //+ ";password=123D654!"
            //    + ";Packet Size=8000;Connect Timeout=120";

            ////if (SednaFBMain.user != null)
            ////{
            ////    connectionString += ";WSID=SEDNAFB|" + SednaFBMain.user;
            ////    connectionString += "|" + System.Environment.MachineName.ToString().Trim();
            ////}
            //AppMain.LcConnectionString = connectionString;
            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sConn;
            cmd.CommandTimeout = 0;
            return cmd;
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
        public static string ExecuteScalar(DbCommand command)
        {
            string value = string.Empty;
            try
            {
                command.Connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
            return value;
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

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void welcomeWizardPage1_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {

        }

        private void btnSqlControl_Click(object sender, EventArgs e)
        {
            SqlConnectionString = $"data source={txtServer.Text.Trim().ToString()};initial catalog={txtdatabase.Text.Trim().ToString()};user id = {txtServerUser.Text.Trim().ToString()}; password = {txtServerPas.Text.Trim().ToString()}; ";
            if (sqlKontrol(SqlConnectionString) == false)
            {
                XtraMessageBox.Show("Bağlantı Sağlanılamadı.");
            }
            else
            {
                XtraMessageBox.Show("Bağlandı.");
                pageSqlSettings.AllowNext = true;
            }
        }
    }
}