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
using DevExpress.Spreadsheet.Export;
using DevExpress.XtraSpreadsheet;
using DevExpress.Spreadsheet;
using Msp.Models.Models;
using Msp.App.Report;
using Msp.Models.Models.SecRights;
using Msp.Service.Service.Admin;
using Msp.App.Contact;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using Msp.Service.Service.Sale;
using Msp.Models.Models.Sale;
using Msp.App.Report.Case;
using Msp.Service.Service.Report;
using Msp.Models.Models.Report;
using Msp.App.DailyEndOpertions;
using Msp.Infrastructure.Extensions;
using SKGL;
using Msp.App.Report.CariHesap;
using Msp.Service.Service.DepotStock;
using Msp.App.Report.Fatura;
using Msp.App.Report.Depo_Stock;
using System.Reflection;

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

        private bool formClosinMessegae = false;

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
            try
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
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
            }
        }
        private void CheckDb()
        {
            CheckDb oForm = new CheckDb();
            oForm.UpdateFromStart();

        }
        private void do_OpenFormAyarlari()
        {
            AppMain.OpenFormRights = _repository.Run<AuthorizationService, List<OpenFormRightsDTO>>(x => x.OpenFormRights(AppMain.User.username, AppMain.CompanyRecId));
            List<OpenFormRightsDTO> newFormRights = new List<OpenFormRightsDTO>();
            foreach (var form in AppMain.Forms)
            {
                var openFormRight = AppMain.OpenFormRights.Where(x => x.UserCode == AppMain.User.username && x.ActionName == form.Key).FirstOrDefault();
                if (openFormRight == null)
                {
                    newFormRights.Add(new OpenFormRightsDTO
                    {
                        UserCode = AppMain.User.username,
                        ActionName = form.Key,
                        OpenForm = true,
                        CompanyRecId = AppMain.CompanyRecId
                    });
                }
            }
            _repository.Run<AuthorizationService>(x => x.SaveOpenFormRights(newFormRights));

        }
        private void do_MenuyuControl()
        {
            foreach (var form in AppMain.Forms)
            {
                OpenFormRightsDTO openFormRight = AppMain.OpenFormRights.Where(x => x.UserCode == AppMain.User.username && x.ActionName == form.Key).FirstOrDefault();
                if (AppMain.User.username != "Admin" && openFormRight != null && form.Value != "X")
                {
                    ribbon.Items[form.Value].Visibility = openFormRight.OpenForm.GetValueOrDefault(true) == true ? BarItemVisibility.Always : BarItemVisibility.Never;
                }
            }

            if (AppMain.User.username == "Admin")
            {
                ripAdmin.Visible = true;
            }


        }
        public void do_FormSecRight()
        {
            AppMain.secRights = _repository.Run<AuthorizationService, List<SecRightsDTO>>(x => x.get_SecRights(AppMain.User.username, AppMain.CompanyRecId));
            List<SecRightsDTO> newSecRights = new List<SecRightsDTO>();
            foreach (DocumentType item in (DocumentType[])Enum.GetValues(typeof(DocumentType)))
            {
                var secRighdt = AppMain.secRights.Where(x => x.UserCode == AppMain.User.username && x.DocumentType == (int)item).FirstOrDefault();
                if (secRighdt == null)
                {
                    newSecRights.Add(new SecRightsDTO
                    {
                        UserCode = AppMain.User.username,
                        SecCode = AppMain.User.username,
                        DocumentType = (int)item,
                        SecDelete = 1,
                        SecInsert = 1,
                        SecPreview = 1,
                        SecUpdate = 1,
                        CompanyCode = AppMain.Company,
                        CompanyRecId = AppMain.CompanyRecId
                    });
                }
            }
            _repository.Run<AuthorizationService>(x => x.SaveSecRights(newSecRights));

        }
        private void do_OpenFormSale()
        {
            var param = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            if (param != null)
            {
                if (param.MainSaleForm.GetValueOrDefault())
                {
                    frmSatis frm = new frmSatis();
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
        }
        public string MACAdresiAl()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty) sMacAddress = adapter.GetPhysicalAddress().ToString();
                AppMain.MAcAdress = (sMacAddress);
            }
            return sMacAddress;

        }
        static string getIP()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }
            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);
            AppMain.IpAdress = address;
            return address;
        }
        private string GetLocalIPAddress()
        {
            string _LocalIP = "";
            var ni = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface item in ni)
            {
                if (item.OperationalStatus == OperationalStatus.Up) //&& item.NetworkInterfaceType == ?
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork & !IPAddress.IsLoopback(ip.Address))
                        {
                            _LocalIP = ip.Address.ToString();
                            AppMain.IpAdress = _LocalIP;
                        }
                    }
                }
            }
            return _LocalIP;
        }
        //private bool formAcikmi(string formAdi)
        //{

        //    bool formBulundu = false;
        //    foreach (Form ofrom in Application.OpenForms)
        //        if (ofrom.Name == formAdi)
        //        {

        //            formBulundu = true;
        //            ofrom.Activate();
        //            break;
        //        }
        //    return formBulundu;
        //}

        private async Task<bool> formAcikmi(string formAdi)
        {
            bool formBulundu = false;
            bool x = await CheckDefinatinAsync();

            foreach (Form ofrom in Application.OpenForms)
                if (ofrom.Name == formAdi)
                {
                    formBulundu = true;
                    ofrom.Activate();
                    break;
                }
            return formBulundu;
        }
        public void do_RefreshDefault()
        {
            AppMain._productsTask = _repository.RunAsync<Msp.Service.Service.DepotStock.DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
        }

        private async Task<bool> CheckDefinatinAsync()
        {
            if (AppMain.Products == null || !AppMain.Products.Any())
                AppMain.Products = await AppMain._productsTask;

            return true;

        }

        #endregion

        #region Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MACAdresiAl();
                if (IsConnected())
                {
                    getIP();
                }
                GetLocalIPAddress();

                #region Güncelleme Kontrol
                ApplicationDeployment ad;
                try
                {
                    if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                    {
                        ad = ApplicationDeployment.CurrentDeployment;
                        if (ad.CheckForUpdate())
                        {
                            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
                            UpdateProgress oForm = new UpdateProgress();
                            oForm.ShowDialog();
                            return;
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
                //ApiUrl
                //Registry.CurrentUser.CreateSubKey(@"Software\MSP");

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

                varmi = false;
                for (int i = 0; i < lsKeys.Length; i++)
                {
                    if (lsKeys[i].ToString().Trim() == "SqlLocal")
                    {
                        varmi = true;
                        break;
                    }
                }
                if (varmi == false)
                { OurKey.SetValue("SqlLocal", "False"); }

                varmi = false;
                for (int i = 0; i < lsKeys.Length; i++)
                {
                    if (lsKeys[i].ToString().Trim() == "Licence")
                    {
                        varmi = true;
                        break;
                    }
                }
                if (varmi == false)
                { OurKey.SetValue("Licence", ""); }

                varmi = false;
                for (int i = 0; i < lsKeys.Length; i++)
                {
                    if (lsKeys[i].ToString().Trim() == "IsDemo")
                    {
                        varmi = true;
                        break;
                    }
                }
                if (varmi == false)
                { OurKey.SetValue("IsDemo", SecurityExtension.Sifrele("false")); }

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

                Version oVersionFB = new Version(21, 1, 1, 20);
                AppMain.MspVersion = oVersionFB;

                string AppPath = @"C:\Msp\ConnectString.txt";
                if (!File.Exists(AppPath))
                {
                    Wizard frm = new Wizard();
                    frm.ShowDialog();
                    //Global.AppPath = SednaFBMain.KodAdmin.Service.AppPath;
                }
                else
                {
                    AppMain.LocalConnect = Convert.ToBoolean(Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("SqlLocal").ToString());
                    AppMain.IsDemo = Convert.ToBoolean(SecurityExtension.Sifre_Coz(Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("IsDemo").ToString()));
                    AppMain.Licence = Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("Licence").ToString();
                }



                if (AppMain.IsDemo)
                {
                    if (!IsConnected())
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Denem Sürümü Kullanıyorsunuz. İnternet Bağlantısı Zorunludur.");
                        Application.Exit();
                    }
                }

                if (AppMain.Licence.Length > 0)
                {
                    bi_Licence.Caption = AppMain.Licence;
                    Validate validate = new Validate();
                    validate.secretPhase = "c4e128b141aFb";
                    validate.Key = AppMain.Licence;
                    bbi_LicenceDay.Caption = Convert.ToString(validate.DaysLeft) + " Gün";
                    if (validate.DaysLeft == 0 || validate.DaysLeft < 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lisans süreniz dolmuştur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lisans Anahtarı Bulunulamadı. Lütfen Sistem Yüneticinize Başvurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }

                Login loForm = new Login();
                loForm.TopMost = true;
                loForm.ShowDialog();

                formClosinMessegae = true;
                if (AppMain.User != null)
                {
                    do_versionControl();
                    do_barDoldur();

                    do_OpenFormAyarlari();
                    do_MenuyuControl();
                    do_RefreshDefault();
                    do_FormSecRight();
                    do_OpenFormSale();
                    UserLookAndFeel.Default.SetSkinStyle(AppMain.User.DefaultTheme, AppMain.User.DefaultTheme2);
                }
                else
                {
                    Application.ExitThread();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }




        }




        #endregion

        #region Bar_Buton

        private async void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmSaleProductMovemnet");
            if (x)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Satış - Ürün Hareket Ekranı açık Lütfen Kapatınız...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool xy = await formAcikmi("frmCurrentTransactions");

            if (!xy)
            {
                frmSatis frm = new frmSatis();
                frm.MdiParent = this;
                frm.Show(0);
            }

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmStok");
            if (!x)
            {
                frmStok frm = new frmStok();
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmCurrentTransactions");
            if (!x)
            {
                frmCurrentTransactions frm = new frmCurrentTransactions();
                frm.MdiParent = this;
                frm.Show(); 
            }
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
        private async void btnSatisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmSatisList");
            if (!x)
            {
                frmSatisList frmSatis = new frmSatisList();
                frmSatis.MdiParent = this;
                frmSatis.Show(); 
            }
        }
        private async void btnSpeedSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmSpeedSatis");
            if (!x)
            {
                frmSpeedSatis frmSatis = new frmSpeedSatis();
                frmSatis.MdiParent = this;
                frmSatis.Show(); 
            }
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

        private async void tbnPriceInquiry_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmPriceInquiry");
            if (!x)
            {
                frmPriceInquiry frm = new frmPriceInquiry();
                frm.MdiParent = this;
                frm.Show(); 
            }
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
            frmCallerId frm = new frmCallerId();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem70_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankEntry frm = new frmBankEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbi_Siparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmOrderManagement frm = new frmOrderManagement();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void barButtonItem74_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu1.ShowPopup(new Point(100, 100));
            frmSatisBarkodIslem frm = new frmSatisBarkodIslem();
            frm.MdiParent = this;
            frm.Show();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //C_MemoryManagement.FlushMemory();

            if (formClosinMessegae)
            {
                if (MessageBox.Show("Programdan çıkışı onaylıyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                tool.do_save_User_Skin(AppMain.User.username, UserLookAndFeel.Default.ActiveSkinName, UserLookAndFeel.Default.ActiveSvgPaletteName, this.Name);
            }

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
            frm.ShowDialog();
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

        private async void btnAlimFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.AlımFaturası;
            frm.Show();
        }

        private void btnUrunMarka_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunTanimlari frm = new frmUrunTanimlari();
            frm.MdiParent = this;
            frm.Show();
        }

        private async void barButtonItem87_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.SatisFaturasi;
            frm.Show();
        }

        private async void btnFaturaAra_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.AllFatura;
            frm.Show();
        }

        private async void barButtonItem89_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.AlisIrsaliye;
            frm.Show();
        }

        private async void barButtonItem90_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.SatisIrsaliye;
            frm.Show();
        }

        private void bbi_DovizKurlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDovizKurlari frm = new frmDovizKurlari();
            frm.MdiParent = this;
            frm.Show();
        }

        private async void barButtonItem91_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.AllIrsaliye;
            frm.Show();
        }

        private void bbi_DovizCinsi_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrencyTypeList frm = new CurrencyTypeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBuyingOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderList frm = new OrderList();
            frm.MdiParent = this;
            frm.orderType = OrderType.AlisSiparis;
            frm.Show();
        }

        private void barButtonItem84_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderList frm = new OrderList();
            frm.MdiParent = this;
            frm.orderType = OrderType.SatisSiparis;
            frm.Show();
        }

        private void barButtonItem85_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderList frm = new OrderList();
            frm.MdiParent = this;
            frm.orderType = OrderType.AllSiparis;
            frm.Show();
        }

        private void barButtonItem86_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderList frm = new OrderList();
            frm.MdiParent = this;
            frm.orderType = OrderType.BekleyenSiparis;
            frm.Show();
        }


        #region Excel

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog odialog = new OpenFileDialog();
            odialog.Filter = "Excel Dosyaları .xls|*.xls;*.xlsx";
            odialog.FileName = "";
            odialog.ShowDialog();
            if (odialog.FileName != "")
            {
                MspTool.wshow();
                try
                {
                    SpreadsheetControl sp = new SpreadsheetControl();
                    sp.LoadDocument(odialog.FileName);

                    Worksheet worksheet = sp.Document.Worksheets[0];
                    var range = worksheet[0, 0].CurrentRegion;
                    DataTable dataTable = worksheet.CreateDataTable(range, true);
                    for (int col = 0; col < range.ColumnCount; col++)
                    {
                        CellValueType cellType = range[0, col].Value.Type;
                        for (int row = 1; row < range.RowCount; row++)
                        {
                            if (cellType != range[row, col].Value.Type)
                            {
                                dataTable.Columns[col].DataType = typeof(string);
                                break;
                            }
                        }
                    }

                    DataTableExporter exporter = worksheet.CreateDataTableExporter(range, dataTable, true);
                    exporter.CellValueConversionError += exporter_CellValueConversionError;

                    exporter.Export();

                    var units = _repository.Run<Msp.Service.Service.DepotStock.DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
                    foreach (DataRow oRow in dataTable.Rows)
                    {

                        //GetProduct_Code

                        string productCode = oRow[0].ToString();
                        string productName = oRow[1].ToString();
                        int miltar = Convert.ToInt32(oRow[2]);
                        string Birim = oRow[3].ToString();
                        decimal GirisFiyat = Convert.ToDecimal(oRow[4]);
                        decimal KarPrice = Convert.ToDecimal(oRow[5]);
                        int KDV = Convert.ToInt32(oRow[6]);
                        decimal kdvTutar = Math.Round(KarPrice * (decimal)KdvOrani.FirstOrDefault(x => x.Tax == (int)KDV).TaxOrani, 2);

                        var row = new Msp.Models.Models.ProductDTO
                        {
                            PID = 0,
                            PCode = productCode,
                            PName = productName,
                            PTotal = miltar,
                            PUnitId = units.Where(x => x.UName == Birim.Trim()).FirstOrDefault() != null ? units.Where(x => x.UName == Birim.Trim()).FirstOrDefault().UID : 0,
                            PFirstPrice = GirisFiyat,
                            PKarPrice = KarPrice,
                            PTax = KdvOrani.Where(x => x.Tax == KDV).FirstOrDefault().Id,
                            PSalePrice = KarPrice + kdvTutar
                        };
                        var response = _repository.Run<Msp.Service.Service.DepotStock.DepotStockService, ActionResponse<Msp.Models.Models.ProductDTO>>(x => x.SaveProduct(row));
                        if (response.ResponseType != ResponseType.Ok)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
                }
                finally
                {
                    MspTool.wclose();
                    DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamamlandı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void exporter_CellValueConversionError(object sender, CellValueConversionErrorEventArgs e)
        {
            MessageBox.Show("Error in cell " + e.Cell.GetReferenceA1());
            e.DataTableValue = null;
            e.Action = DataTableExporterAction.Continue;
        }
        #endregion

        #region Report


        private void bbi_CariHesapListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPrint frm = new frmPrint();
            var data = _repository.Run<Msp.Service.Service.CurrentTransactions.CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            frm.CariHesapListesi(data);
            frm.ShowDialog();
        }


        #endregion

        private async void barButtonItem119_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("CashPayGroupDef");
            if (!x)
            {
                CashPayGroupDef frm = new CashPayGroupDef();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private async void barButtonItem120_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmGroupDefinition");
            if (!x)
            {
                frmGroupDefinition frm = new frmGroupDefinition();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbi_KasaHareketi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaHareketList frm = new frmKasaHareketList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem126_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankDefinition frm = new frmBankDefinition();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem88_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hatirlatici frm = new Hatirlatici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbi_SayfaYetkileri_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOpenFormRights frm = new frmOpenFormRights();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbi_ReportStockList_ItemClick(object sender, ItemClickEventArgs e)
        {
            var _productlist = _repository.Run<Msp.Service.Service.DepotStock.DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            if (_productlist.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintProduct(_productlist);
                frm.ShowDialog();
            }
        }

        private void btnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            LogList frm = new LogList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmContact frm = new frmContact();
            frm.ShowDialog();
        }

        private void barButtonItem74_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmMailSend frm = new frmMailSend();
            frm.ShowDialog();
        }

        private void barButtonItem67_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCaseDefinition frm = new frmCaseDefinition();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbi_StockEnvanterRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEnvanterBilgiler frm = new frmEnvanterBilgiler();
            frm.ShowDialog();
        }

        private async void barButtonItem92_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(await formAcikmi("frmSatis"))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Satış Ekranı açık Lütfen Kapatınız...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSaleProductMovemnet frm = new frmSaleProductMovemnet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem127_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDeleteRecords frm = new frmDeleteRecords();
            frm.MdiParent = this;
            frm.Text = "Satış İşlemlerinde Silinen Kayıtlar";
            frm._formType = DeleteForm.SatisDeleted;
            frm.Show();
        }

        private void barButtonItem128_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDeleteRecords frm = new frmDeleteRecords();
            frm.MdiParent = this;
            frm.Text = "Silinen Ürün Kartları";
            frm._formType = DeleteForm.UrunKarti;
            frm.Show();
        }

        private void barButtonItem106_ItemClick(object sender, ItemClickEventArgs e)
        {
            var _saleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_VeresiyeSale());
            if (_saleOwner.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintSaleOwnersVeresiye(_saleOwner);
                frm.ShowDialog();
            }

        }

        private void barButtonItem104_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaReportFilter frm = new frmKasaReportFilter();
            frm.FormType = 1;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem105_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKasaReportFilter frm = new frmKasaReportFilter();
            frm.FormType = 2;
            frm.MdiParent = this;
            frm.Show();
        }

        private async void barButtonItem96_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmStockMovement");
            if (!x)
            {
                frmStockMovement frm = new frmStockMovement();
                frm.ShowDialog();
            }
        }

        private void barButtonItem99_ItemClick(object sender, ItemClickEventArgs e)
        {
            var _SumSaleProduct = _repository.Run<ReportService, List<SumSaleStockDTO>>(x => x.Get_List_SumSaleStock());
            if (_SumSaleProduct.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintSumSaleStock(_SumSaleProduct);
                frm.ShowDialog();
            }
        }

        private void barButtonItem73_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbi_GunSonuBaslat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDailyStart frm = new frmDailyStart();
            frm.ShowDialog();
        }

        private async void barButtonItem95_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmDailyEndOpeList");
            if (!x)
            {
                frmDailyEndOpeList frm = new frmDailyEndOpeList();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbi_CariHesapEkst_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCariHesapEkstreFilter frm = new frmCariHesapEkstreFilter();
            frm.ShowDialog();
        }

        private void bbi_MutabakatMektubu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMutabakatFilter frm = new frmMutabakatFilter();
            frm.ShowDialog();
        }

        private void barButtonItem82_ItemClick(object sender, ItemClickEventArgs e)
        {
            var _Product = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            if (_Product.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintProductBarcodeList(_Product);
                frm.ShowDialog();
            }
        }

        private void bbi_FaturaRaporlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            FaturaFilter frm = new FaturaFilter();
            frm.invoice = InvoiceType.AlımFaturası;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbi_IrsaliyeRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FaturaFilter frm = new FaturaFilter();
            frm.invoice = InvoiceType.AlisIrsaliye;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem109_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrdersFilter frm = new OrdersFilter();
            frm.MdiParent = this;
            frm.orderFilter = OrderFilter.Siparis;
            frm.Show();
        }

        private void barButtonItem110_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrdersFilter frm = new OrdersFilter();
            frm.MdiParent = this;
            frm.orderFilter = OrderFilter.SevkRapor;
            frm.Show();
        }

        private async void barButtonItem98_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmHareketGormeyenRecord");
            if (!x)
            {
                frmHareketGormeyenRecord frm = new frmHareketGormeyenRecord();
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

        private async void barButtonItem93_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmStockBakiye");

            if (!x)
            {
                frmStockBakiye frm = new frmStockBakiye();
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

        private async void bbi_cariHesapTanimlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("CurrentGroupDefinitions");
            if (!x)
            {
                CurrentGroupDefinitions frm = new CurrentGroupDefinitions();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private async void bbi_BekleyenIrsaliye_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await CheckDefinatinAsync();

            InvoiceList frm = new InvoiceList();
            frm.MdiParent = this;
            frm.invoice = InvoiceType.BekleyenIrsaliye;
            frm.Show();
        }

        private async void barButtonItem115_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("FaturaKDV");
            if (!x)
            {
                FaturaKDV frm = new FaturaKDV();
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

        private void barButtonItem71_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Assembly assembly = Assembly.LoadFile(@"C:\Msp\Moduls\Msp.EInvoice.dll");
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.Name == "Program")
                    {
                        MethodInfo V_Dll = type.GetMethod("Main");

                        V_Dll.Invoke(type, new object[] { AppMain.SqlConnection.Server, AppMain.SqlConnection.Database,AppMain.SqlConnection.UserId, AppMain.SqlConnection.Password, UserLookAndFeel.Default.ActiveSkinName });
                    }
                }
            }
            catch (Exception et)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error:Call Dll:" + et.ToString());
            }
        }

        private void barButtonItem131_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Assembly assembly = Assembly.LoadFile(@"C:\Msp\Moduls\Msp.SimleCurrent.dll");
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.Name == "Program")
                    {
                        MethodInfo V_Dll = type.GetMethod("Main");

                        V_Dll.Invoke(type, new object[] { AppMain.SqlConnection.Server, AppMain.SqlConnection.Database, AppMain.SqlConnection.UserId, AppMain.SqlConnection.Password, UserLookAndFeel.Default.ActiveSkinName });
                    }
                }
            }
            catch (Exception et)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error:Call Dll:" + et.ToString());
            }
        }

        private async void barButtonItem132_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool x = await formAcikmi("frmBackUp");
            if (!x)
            {
                frmBackUp frm = new frmBackUp();
                frm.ShowDialog(); 
            }
        }
    }
}