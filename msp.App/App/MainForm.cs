using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Msp.App.App;
using Msp.Infrastructure;
using System.Deployment.Application;
using Msp.Service.Repository;
using Msp.Service.Service.App;
using Msp.Models.Models.App;
using Msp.App.Settings;
using Microsoft.Win32;
using Msp.App.Depo_Stok;
using Msp.App.Satis;
using Msp.App.Tanimlar;
using Msp.App.Musteri_Islemleri;

namespace msp.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Repository _repository;
        public MainForm()
        {
            InitializeComponent();
            _repository = new Repository();

            this.ribbon.Minimized = true;
        }

        #region Method
        public bool IsConnected()
        {
            System.Uri Url = new System.Uri("http://www.google.com");
            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);
            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                return true;
            }
            catch
            {
                WebReq = null;
                return false;
            }
        }

        public void do_barDoldur()
        {
            bbi_UserName.Caption = AppMain.User.username;
            bbi_Connect.Caption = IsConnected() == true ? "Connected" : "Not connected";
            bbi_Company.Caption = AppMain.Company;
        }

        private void do_versionControl()
        {
            var dataVersion = _repository.Run<StartUp, ProgramsControlsDTO>(x => x.CheckVersion());
            string[] lsDataVersionFB = dataVersion.MspVersion.Split('.');
            Version sqlVersionFB = new Version(Convert.ToInt32(lsDataVersionFB[0])
                , Convert.ToInt32(lsDataVersionFB[1])
                , Convert.ToInt32(lsDataVersionFB[2])
                , Convert.ToInt32(lsDataVersionFB[3]));

            if (sqlVersionFB.CompareTo(AppMain.MspVersion) < 0)
            {
                this.CheckDb();
            }
            if (sqlVersionFB.CompareTo(AppMain.MspVersion) > 0)
            {
                MessageBox.Show("Eski Versiyon.Programı Güncelleyiniz...","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
        private void CheckDb()
        {
            CheckDb oForm = new CheckDb();
            oForm.UpdateFromStart();

        }

        #endregion

        #region Form

        private void MainForm_Load(object sender, EventArgs e)
        {


            #region Güncelleme Kontrol
            ApplicationDeployment ad;
            try
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    ad = ApplicationDeployment.CurrentDeployment;
                    if (ad.CheckForUpdate())
                    {
                        //this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
                        //UpdateProgress oForm = new UpdateProgress();
                        //oForm.ShowDialog();
                        //return;
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama güncellestirirken hata olustu." + ex.Message);
            }

            #endregion


            #region Regedit
            //string message = Msp.App.Tool.MspTool.CreateNewRegistry();
            //if (!string.IsNullOrEmpty(message))
            //{
            //    MessageBox.Show(message);
            //}

            Registry.CurrentUser.CreateSubKey(@"Software\MSP");

            RegistryKey OurKey = Registry.CurrentUser;
            OurKey = OurKey.OpenSubKey(@"Software\MSP", true);
            string[] lsKeys = OurKey.GetSubKeyNames();
            bool varmi = false;

            OurKey = Registry.CurrentUser.OpenSubKey(@"Software\MSP", true);
            lsKeys = OurKey.GetValueNames();
            varmi = false;

            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "LastServer")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("LastServer", ""); }

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "MspLogo")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("MspLogo", ""); }

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "LastDatabase")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("LastDatabase", ""); }

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "LastUser")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("LastUser", ""); }

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "LastServerId")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("LastServerId", ""); }

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "Company")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("Company", ""); }
            #endregion



            //if (Global.RegistryDbSettings.Count > 0)
            //{
            //    SednaFBMain.userName = Global.RegistryDbSettings[0].Username;
            //    Global.SqlConnection = new SednaAccounting.Infrastructure.DbConnectionModel.ConnectionDTO
            //    {
            //        Server = Global.RegistryDbSettings[0].Server,
            //        Database = Global.RegistryDbSettings[0].Database1,
            //        UserId = Global.RegistryDbSettings[0].Username,
            //        Password = Global.RegistryDbSettings[0].Mask == "1" ? Global.RegistryDbSettings[0].PasswordMsk.SifreCoz() : Global.RegistryDbSettings[0].Password
            //    };
            //}

            Version oVersionFB = new Version(1, 0, 0, 1);
            AppMain.MspVersion = oVersionFB;

            //if (Global.RunningLocal && (string.IsNullOrEmpty(Global.AppPath) || !Directory.Exists(Global.AppPath)))
            //{
            //    SednaFBMain.KodAdmin.OpenWizard();
            //    Global.AppPath = SednaFBMain.KodAdmin.Service.AppPath;
            //}

            Login loForm = new Login();
            loForm.TopMost = true;
            loForm.ShowDialog();

            if (AppMain.User != null)
            {
                do_versionControl();
                do_barDoldur();
            }
            else
            {
                Application.ExitThread();
            }
        }

        #endregion

        #region Bar_Buton



        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatis frm = new frmSatis();
            frm.MdiParent = this;
            frm.Show(0);

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStok frm = new frmStok();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCurrentTransactions frm = new frmCurrentTransactions();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnParameters_ItemClick(object sender, ItemClickEventArgs e)
        {
            Parameters frm = new Parameters();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_KuallaniciTanim_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullaniciTanim frm = new frmKullaniciTanim();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_isyeri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCompany frm = new FrmCompany();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnSatisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatisList frmSatis = new frmSatisList();
            frmSatis.MdiParent = this;
            frmSatis.Show();
        }
        private void btnSpeedSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpeedSatis frmSatis = new frmSpeedSatis();
            frmSatis.MdiParent = this;
            frmSatis.Show();
        }

        private void btn_BirimTanimlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBirimTanim frm = new frmBirimTanim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_PaymentType_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPaymnetList frm = new frmPaymnetList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tbnPriceInquiry_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPriceInquiry frm = new frmPriceInquiry();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


        #endregion


        private void btnDepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDepo frm = new frmDepo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}