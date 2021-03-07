using DevExpress.XtraEditors;
using Ionic.Zip;
using Microsoft.SqlServer.Management.Smo;
using Msp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Settings
{
    public partial class frmBackUp : DevExpress.XtraEditors.XtraForm
    {
        public frmBackUp()
        {
            InitializeComponent();
        }


        #region Record
        private void do_BackUp()
        {

            try
            {
                //Backup bkpDBFull = new Backup();
                //bkpDBFull.Action = BackupActionType.Database;
                //bkpDBFull.Database = AppMain.SqlConnection.Database;
                //bkpDBFull.Devices.AddDevice("@"+(string)btnPath.EditValue, DeviceType.File);
                //bkpDBFull.BackupSetName = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Millisecond);
                //bkpDBFull.BackupSetDescription = "MspDataBase";
                //bkpDBFull.Initialize = false;
                //Server server = new Server(AppMain.SqlConnection.Server);
                //bkpDBFull.SqlBackup(server);

                string filePath = BuildBackupPathWithFilename(AppMain.SqlConnection.Database);
                using (var connection = new SqlConnection(AppMain.SqlConnection.Connection()))
                {
                    var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", AppMain.SqlConnection.Database, filePath);
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    Thread thread = new Thread(t =>
                    {
                        using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                        {
                            FileInfo fi = new FileInfo(filePath);
                            System.IO.DirectoryInfo di = new DirectoryInfo(filePath);
                            zip.SaveProgress += Zip_SaveProgress;
                            zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, fi.Name));
                        }
                    })
                    { IsBackground = true };
                    thread.Start();


                    Log(AppMain.SqlConnection.Database + " veritabanı yedeklendi. \n");
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void Zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBarControl1.Invoke(new MethodInvoker(delegate
                {
                    progressBarControl1.Properties.Maximum = 100;
                    progressBarControl1.Properties.Step = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBarControl1.Update();
                }));
            }
        }

        //public void BackupAllUserDatabases()
        //{
        //    foreach (string databaseName in GetAllUserDatabases())
        //    {
        //        BackupDatabase(databaseName);
        //    }
        //    Log("Veritabanı yedekleme işlemi tamamlandı. \n");
        //}

        private string BuildBackupPathWithFilename(string databaseName)
        {
            string filename = string.Format("{0}_{1}_{2}.bak", databaseName, DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmm"));
            return Path.Combine(btnPath.Text.Trim(), filename);
        }
        private void Log(string text)
        {
            txtLog.Text += DateTime.Now.ToString("dd-MM-yyyy HH:mm") + @" - " + text;
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
            txtLog.Refresh();
        }
        #endregion


        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmBackUp_Load(object sender, EventArgs e)
        {
            Log("Veri Tabanı Yedekleme İşlemi");

            btnPath.EditValue = @"C:\Msp\BackUp";
        }

        private void bbi_Yedek_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(btnPath.Text))
            {
                XtraMessageBox.Show("Kaynak Yer Belirtiniz.");
                return;
            }
            do_BackUp();
        }

        private void btnPath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnPath.EditValue = folderBrowserDialog1.SelectedPath;
                }
            }
        }
    }
}