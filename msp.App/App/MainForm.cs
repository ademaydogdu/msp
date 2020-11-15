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
using Msp.App.Islemler;
using Msp.App.Tool;
using DevExpress.LookAndFeel;
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;
using Msp.App.CariIslemler;

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
        MspTool tool = new MspTool();

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
            bbi_Version.Caption = Convert.ToString(AppMain.MspVersion);

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
                MessageBox.Show("Eski Versiyon.Programı Güncelleyiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "BeniHatirla")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("BeniHatirla", "False"); }


            varmi = false;
            for (int i = 0; i < lsKeys.Length; i++)
            {
                if (lsKeys[i].ToString().Trim() == "ParaUstu")
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == false)
            { OurKey.SetValue("ParaUstu", "True"); }

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

            Version oVersionFB = new Version(2, 1, 1, 2);
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

                UserLookAndFeel.Default.SetSkinStyle(AppMain.User.DefaultTheme, AppMain.User.DefaultTheme2);
            }
            else
            {
                Application.ExitThread();
            }
        }

        public void do_FormSecRight()
        {

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
            Dashboard frm = new Dashboard();
            frm.MdiParent = this;
            frm.Show();

        }





        private void btnDepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDepo frm = new frmDepo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSonKullanmaTar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExpDateProducts frm = new frmExpDateProducts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSpeedPrudctTanim_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpeedSaleProductTanim frm = new SpeedSaleProductTanim();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem63_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem70_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankEntry frm = new frmBankEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbi_Siparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOrderManagement frm = new frmOrderManagement();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem74_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu1.ShowPopup(new Point(100, 100));
        }

        private void btnSKTGecenUrun_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmoncomingProduct frm = new frmoncomingProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbi_kampanya_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKampanyalar frm = new frmKampanyalar();
            frm.MdiParent = this;
            frm.Show();
        }
        private void bbi_ParolaDegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            //frm.MdiParent = this;
            frm.ShowDialog();

        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (mesassizcik == false)
            //{
            if (MessageBox.Show("Programdan çıkışı onaylıyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            tool.do_save_User_Skin(AppMain.User.username, UserLookAndFeel.Default.ActiveSkinName, UserLookAndFeel.Default.ActiveSvgPaletteName, this.Name);
            //}
        }

        #region applicationMenu
        private void bbi_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bbi_AllFormClosed_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form oForm in this.MdiChildren)
            {
                if (!oForm.Focused)
                {
                    oForm.Close();
                }
            }
        }
        #endregion

        private void bbi_veresiye_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVeresiyeSatisList frm = new frmVeresiyeSatisList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem81_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEnvanterBilgiler frm = new frmEnvanterBilgiler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGrdiLayouytDeleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _repository.Run<SettingsService, ActionResponse<FormLayoutsDTO>>(x => x.DeleteAllFormLayoutsDTO());
            if (result.ResponseType != ResponseType.Ok)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlimFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.AlımFaturası;
            frm.Show();
        }
    }
}