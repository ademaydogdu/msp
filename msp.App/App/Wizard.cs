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

        #endregion

        public DevExpress.XtraSplashScreen.SplashScreenManager Splash { get; set; }
        public System.Reflection.Assembly assembly { get; set; }
        public string Script { get; set; } = "";


        private void do_LisansDemo()
        {
            if (rpLisans.Checked)
            {

            }
            if (rpDeneme.Checked)
            {
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
                //AdminDatabase Kayıt yapılacak
            }
        }

        private void do_SqlConnect()
        {

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
                SqlCommand sCommand = SqlCreateCommandFront();
                #region Users
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
                sCommand.CommandText = "INSERT INTO [dbo].[Company] ([CompanyCode], [CompanyName]) VALUES ('001', @companyName)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("companyName", SqlDbType.NVarChar).Value = txtSirketAdi.EditValue;
                ExecuteNonQuery(sCommand);
                #endregion

                #region Depo
                sCommand.CommandText = "INSERT INTO [dbo].[Depot] ([DepName])  VALUES (@DepName)";
                sCommand.Parameters.Clear();
                sCommand.Parameters.Add("DepName", SqlDbType.NVarChar).Value = txtDepotAdi.EditValue;
                ExecuteNonQuery(sCommand);
                #endregion

                #region ApplicatonServer

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


                sCommand.CommandText = "INSERT INTO [dbo].[ApplicationServer] "
                + "        ([Server] "
                + "        ,[ServerName] "
                + "        ,[UserName] "
                + "        ,[Password]) "
                + "  VALUES "
                + "        ('' "
                + "        ,'' "
                + "        ,'' "
                + "        ,'' )";
                sCommand.Parameters.Clear();

                #endregion

            }
            catch (Exception ex)
            {
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
                SqlLocal = true;
                //SqlConnectionString = "data source=.;initial catalog=msp2;Trusted_Connection=True;Integrated security=SSPI;Connect Timeout=1000";
                SqlConnectionString = "data source = DG; initial catalog = msp2; user id = sa; password = 123D654!; ";
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
            if (chcSunucu.Checked)
            {
                SqlLocal = false;


            }
        }

        private void do_CreateDatabese()
        {
            bool x = false;
            var query = GetDbCreationQuery();
            var conn = new System.Data.SqlClient.SqlConnection("Server=.;Integrated security=SSPI;database=master");
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
            string dbName = "msp2";
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
            SqlCommand sCommand = SqlCreateCommandFront();

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


        public static System.Data.SqlClient.SqlCommand SqlCreateCommandFront()
        {
            string connectionString = "initial catalog=msp2"
                + ";data source=."
                + ";user id=sa"
                + ";password=123D654!"
                + ";Packet Size=8000;Connect Timeout=120";
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

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}