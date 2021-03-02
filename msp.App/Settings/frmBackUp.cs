using DevExpress.XtraEditors;
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