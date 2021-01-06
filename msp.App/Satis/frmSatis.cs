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
using DevExpress.XtraLayout;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.Settings;
using Msp.App.Depo_Stok;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Sale;
using System.Globalization;
using Msp.Infrastructure;
using Msp.Service.Service.Tanimlar;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Sale;
using Msp.App.Tanimlar;
using Msp.App.Musteri_Islemleri;
using Msp.App.Satis;
using Msp.App.Tool;
using Msp.Service.Service.CustomerTransactions;
using Microsoft.Win32;

namespace msp.App
{
    public partial class frmSatis : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public frmSatis()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        MspTool MspTool = new MspTool();


        #region Descriptons

        ProductDTO _product = new ProductDTO();
        SaleOwnerDTO __dll_SaleOwner = new SaleOwnerDTO();
        List<SaleTransDTO> __dl_List_SaleTrans = new List<SaleTransDTO>();
        int RecId;
        public FormOpenType _FormOpenType;
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();
        List<CustomersDTO> _customerList = new List<CustomersDTO>();

        decimal IskontoTutari = 0;

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };


        #endregion

        #region Record

        public void Insert_Product(int ProductId)
        {
            try
            {
                _product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(ProductId));
                if (_product == null) return;
                var _varmi = __dl_List_SaleTrans.Where(x => x.ProductId == _product.PID).FirstOrDefault();
                if (_varmi != null)
                {
                    _varmi.ProductQuantity += 1;
                    var ProductAmount = Math.Round(_varmi.ProductPrice.GetValueOrDefault() * _varmi.ProductQuantity.GetValueOrDefault(), 2);
                    _varmi.ProductAmount = ProductAmount;
                    _varmi.TaxAmount = Math.Round((decimal)KdvOrani.Where(x => x.Id == _varmi.Tax.GetValueOrDefault()).FirstOrDefault().TaxOrani * _varmi.ProductQuantity.GetValueOrDefault(), 2);
                }
                else
                {
                    SaleTransDTO saleTrans = new SaleTransDTO();
                    saleTrans.ProductId = _product.PID;
                    saleTrans.ProductName = _product.PName;
                    saleTrans.ProductBarcode = _product.PBarcode;
                    saleTrans.ProductPrice = _product.PSalePrice.GetValueOrDefault(); //_product.PMalBedeli;
                    saleTrans.UnitId = _product.PUnitId;
                    saleTrans.ProductQuantity = 1;
                    saleTrans.Deleted = false;
                    saleTrans.ProductAmount = Math.Round(saleTrans.ProductPrice.GetValueOrDefault() * saleTrans.ProductQuantity.GetValueOrDefault(), 5, MidpointRounding.ToEven);
                    saleTrans.Tax = _product.PTax;
                    saleTrans.TaxAmount = _product.PPaxAmout;
                    saleTrans.ProductDate = _product.PExpDate == null ? new DateTime(1900,1,1) : _product.PExpDate.GetValueOrDefault();
                    saleTrans.CompanyId = AppMain.CompanyRecId;
                    __dl_List_SaleTrans.Add(saleTrans);
                }
                TopTotal();
                bs_SaleTrans.DataSource = __dl_List_SaleTrans;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        #endregion

        #region FORM

        public void Show(int _recId)
        {
            RecId = _recId;
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            if (_parameters != null)
            {
                if (_parameters.NumaratorShow == true) lyt_NumaratorControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; else lyt_NumaratorControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                if (_parameters.PaymentLock == true) txt_OdemeTipi.Enabled = true; else txt_OdemeTipi.Enabled = false;
            }

            if (_FormOpenType == FormOpenType.New)
            {
                __dll_SaleOwner = new SaleOwnerDTO();
                __dll_SaleOwner.Date = DateTime.Now;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __dll_SaleOwner = _repository.Run<SaleService, SaleOwnerDTO>(x => x.Get_SaleOwner(RecId));
                __dl_List_SaleTrans = _repository.Run<SaleService, List<SaleTransDTO>>(x => x.Get_List_SaleOwner(RecId));
            }

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());

            rp_KdvOran.DataSource = KdvOrani;
            rp_KdvOran.DisplayMember = "Value";
            rp_KdvOran.ValueMember = "Id";
            bs_Unit.DataSource = _list_UnitsDTO;
            bs_PaymentType.DataSource = _list_PaymnetType;
            bs_SaleOwner.DataSource = __dll_SaleOwner;
            bs_SaleTrans.DataSource = __dl_List_SaleTrans;
            this.Show();
        }


        private void frmSatis_Load(object sender, EventArgs e)
        {
            btn_N0.AutoWidthInLayoutControl = true;
            MspTool.Get_Layout(this);
            toggleSwitch1.IsOn = Convert.ToBoolean(Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("ParaUstu").ToString());
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            frm.btnORderAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            frm.IsSale = true;
            frm.ShowDialog();

        }

        public void TopTotal()
        {
            if (__dl_List_SaleTrans.Count > 0)
            {
                var totalKdv = __dl_List_SaleTrans.Sum(x => x.TaxAmount);
                var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                //var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                __dll_SaleOwner.NetPrice = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                __dll_SaleOwner.TotalPrice = totalAmount;

                if (IskontoTutari != 0) __dll_SaleOwner.TotalPrice = totalAmount - IskontoTutari;
                __dll_SaleOwner.KDV = totalKdv;
                txt_NetFiyat.EditValue = __dll_SaleOwner.NetPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", __dl_List_SaleTrans.Sum(x => x.ProductAmount));
                txt_KDV.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalKdv);
                txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", (IskontoTutari != 0 ? totalAmount - IskontoTutari : totalAmount));

            }
            else
            {
                var totalKdv = 0;
                var totalAmount = 0;
                __dll_SaleOwner.NetPrice = 0;
                __dll_SaleOwner.TotalPrice = 0;
                __dll_SaleOwner.KDV = 0;
                txt_NetFiyat.EditValue = __dll_SaleOwner.NetPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", __dl_List_SaleTrans.Sum(x => x.ProductAmount));
                txt_KDV.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalKdv);
                txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalAmount);
            }
        }

        #endregion

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        private void btn_NakitSatış_Click(object sender, EventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                //__dll_SaleOwner.PaymentType = 1;
                txt_OdemeTipi.EditValue = 1;
            }
        }

        private void btn_PosSatis_Click(object sender, EventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                //__dll_SaleOwner.PaymentType = 2;
                txt_OdemeTipi.EditValue = 2;
            }
        }

        private void btn_PosNakitSatis_Click(object sender, EventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                //__dll_SaleOwner.PaymentType = 2;
                txt_OdemeTipi.EditValue = 3;
            }
        }

        public bool do_Validation()
        {
            bool _return = false;
            if (__dl_List_SaleTrans.Count == 0)
            {
                MessageBox.Show("Ürün Kaydı olması gerekmektedir.");
                _return = true;
            }
            if (_parameters.PaymentyForced.GetValueOrDefault())
            {
                if (txt_OdemeTipi.EditValue == "")
                {
                    MessageBox.Show("Ödeme Tipi Alanı Boş Bırakılmaz.");
                    _return = true;
                }
            }


            return _return;
        }

        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        public void do_save()
        {
            try
            {
                if (do_Validation()) return;
                if (_parameters.SaleProductEndDate.GetValueOrDefault())
                {
                    foreach (var item in __dl_List_SaleTrans)
                    {
                        if (item.ProductDate == DateTime.Now)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Son Kullanma Tarihi Geçmiş Ürün " + item.ProductName, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                __dll_SaleOwner.UserCode = AppMain.User.username;
                __dll_SaleOwner.CompanyRecId = AppMain.CompanyRecId;
                var req = new SaleRequest
                {
                    List_SaleTrans = __dl_List_SaleTrans,
                    SaleOwnerDTO = __dll_SaleOwner
                };
                var response = _repository.Run<SaleService, ActionResponse<SaleRequest>>(x => x.Save_Sale(req));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (_parameters.SaleNewRecord.GetValueOrDefault())
                    {
                        __dll_SaleOwner = new SaleOwnerDTO();
                        __dll_SaleOwner.Date = DateTime.Now;
                        __dl_List_SaleTrans.Clear();
                        __dl_List_SaleTrans = new List<SaleTransDTO>();
                        txt_CustomerName.Text = "";
                        txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = "₺ 0.00";
                        txt_OdemeTipi.EditValue = "";
                        gridControl1.RefreshDataSource();
                        TopTotal();
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (_parameters.SaleApproval.GetValueOrDefault())
            {
                if (!get_Question("Satış Sonlnadırılactır. Onaylıyor musunuz?")) return;
            }
            do_save();
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region AddIntersentRemovwAt
        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            if (__dl_List_SaleTrans.Count > 0)
            {
                __dl_List_SaleTrans.Clear();
                __dll_SaleOwner.TotalPrice = 0;
                txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = "₺ 0.00";
                gridControl1.RefreshDataSource();
            }
        }

        private void btn_QuantityAdd_Click(object sender, EventArgs e)
        {
            var oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                oRow.ProductQuantity += 1;
                var ProductAmount = Math.Round(oRow.ProductPrice.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);
                oRow.ProductAmount = ProductAmount;
                oRow.TaxAmount = Math.Round((decimal)KdvOrani.Where(x => x.Id == oRow.Tax.GetValueOrDefault()).FirstOrDefault().TaxOrani * oRow.ProductQuantity.GetValueOrDefault(), 2);

                gridControl1.RefreshDataSource();
                TopTotal();
            }
        }

        private void btn_Quantityinterest_Click(object sender, EventArgs e)
        {
            var oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (oRow.ProductQuantity >= 1)
                {
                    oRow.ProductQuantity -= 1;
                    oRow.ProductAmount = Math.Round(oRow.ProductPrice.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);
                    oRow.TaxAmount = Math.Round((decimal)KdvOrani.Where(x => x.Id == oRow.Tax.GetValueOrDefault()).FirstOrDefault().TaxOrani * oRow.ProductQuantity.GetValueOrDefault(), 2);
                    gridControl1.RefreshDataSource();
                    TopTotal();
                }
            }
        }
        #endregion

        private void txt_OdemeTipi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmPaymnetList frm = new frmPaymnetList();
                frm.ShowDialog();
                _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());

                bs_PaymentType.DataSource = _list_PaymnetType;

            }
        }

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
            if ((bool)toggleSwitch1.EditValue)
            {
                lyc_ParaUstu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lyc_ParaUstu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("ParaUstu", toggleSwitch1.EditValue);

        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.SatisSale = true;
            frm.ShowDialog();
        }
        public void CustomerSelect(CustomersDTO customers)
        {
            if (customers != null)
            {
                txt_CustomerName.EditValue = __dll_SaleOwner.CustomerName = customers.name;
            }
        }

        private void btnVeresiyeSatis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CustomerName.Text))
            {
                XtraMessageBox.Show("Müşteri Adı Giriniz...");
                return;
            }
            __dll_SaleOwner.Veresiye = true;
            do_save();
        }

        private void btn_NewProcess_Click(object sender, EventArgs e)
        {
            __dll_SaleOwner = new SaleOwnerDTO();
            __dl_List_SaleTrans.Clear();
            __dl_List_SaleTrans = new List<SaleTransDTO>();
            __dll_SaleOwner.AlinanPrice = 0;
            txtParaUstu.Text = "0";
            txt_CustomerName.Text = "";
            txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = "₺ 0.00";
            txt_OdemeTipi.EditValue = "";
            gridControl1.RefreshDataSource();
        }

        private void btnIskonto_Click(object sender, EventArgs e)
        {
            frmIskonto frm = new frmIskonto();
            frm.Show(__dll_SaleOwner.TotalPrice.GetValueOrDefault());
        }

        public void IskontoUygula(decimal _indirimTutari)
        {
            IskontoTutari = _indirimTutari;
            var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
            txt_İndirimTutar.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", IskontoTutari);
            __dll_SaleOwner.TotalPrice = totalAmount - IskontoTutari;
            txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalAmount - IskontoTutari);
        }


        private void txtParaUstu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var totalKdv = __dl_List_SaleTrans.Sum(x => x.TaxAmount);
            var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount) + totalKdv;
            frmChangeMoney frm = new frmChangeMoney();
            frm.Show(Convert.ToDecimal(totalAmount), Convert.ToDecimal(txtParaUstu.EditValue));
        }

        private void frmSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            SaleTransDTO oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                __dl_List_SaleTrans.Remove(oRow);
                gridControl1.RefreshDataSource();
                TopTotal();
            }
        }

        private void btnIskontoIptal_Click(object sender, EventArgs e)
        {
            if (IskontoTutari != 0)
            {
                IskontoTutari = 0;
                var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                txt_İndirimTutar.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", IskontoTutari);
                txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalAmount);
            }
        }

        #region Numarator
        SimpleButton clickbutton = null;
        MemoEdit SelectedTextBox = null;
        SpinEdit SelectedSpinEdit = null;
        private void txt_Barcode_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as MemoEdit;
        }
        private void txtParaUstu_Click(object sender, EventArgs e)
        {
            SelectedSpinEdit = sender as SpinEdit;
        }
        private void btn_N1_Click(object sender, EventArgs e)
        {
            clickbutton = sender as SimpleButton;
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text += clickbutton.Text;
            }
            if (SelectedSpinEdit != null)
            {
                SelectedSpinEdit.Text += clickbutton.Text;
            }
        }

        private void btn_allClear_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = "";
            }
            if (SelectedSpinEdit != null)
            {
                SelectedSpinEdit.Text = "0";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Substring(0, sorun.Length - 1);
            if (SelectedTextBox != null)
            {
                string txt = SelectedTextBox.Text;
                SelectedTextBox.Text = txt.Substring(0, txt.Length - 1);
            }
            if (SelectedSpinEdit != null)
            {
                string txt = SelectedSpinEdit.Text;
                SelectedSpinEdit.Text = txt.Substring(0, txt.Length - 1);
            }
        }



        #endregion


    }
}