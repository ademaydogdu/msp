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
using Msp.Infrastructure;
using Msp.App.Tool;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Models.Models.Invoice;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Invoice;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.CurrentTransactions;
using Msp.Service.Service.App;
using Msp.Models.Models.Order;
using System.Globalization;
using Msp.App.Tanimlar;
using Msp.Service.Service.Tanimlar;
using Msp.Service.Service.Depot;
using Msp.App.Depo_Stok;
using Msp.App.Islemler;

namespace Msp.App.CariIslemler
{
    public partial class InvoiceEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public InvoiceEdit()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        public InvoiceType invoice;
        public FormOpenType _FormOpenType;
        public int RecId;
        private bool _IsOrders = false;
        MspTool MspTool = new MspTool();
        InvoiceOwnerDTO __dll_InvoiceOwner = new InvoiceOwnerDTO();
        List<InvoiceTransDTO> __dll_List_InoviceTrans = new List<InvoiceTransDTO>();
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();
        List<DepotDTO> _depotList = new List<DepotDTO>();

        List<int> _deleteRow = new List<int>();

        private bool BirimFiyatChance = false;

        public int CariId = 0;

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        List<SelectIdValue> FaturaTuru = new List<SelectIdValue>
        {
            new SelectIdValue(1, "Alış Faturası"),
            new SelectIdValue(2, "İade Faturası"),
            new SelectIdValue(3, "Gider Faturası"),

        };

        #region Record

        public bool do_Validation()
        {
            bool _return = false;
            if (__dll_List_InoviceTrans.Count == 0)
            {
                MessageBox.Show("Boş Satır Kaydedilemez...");
                _return = true;
            }
            if (invoice == InvoiceType.AlisIrsaliye)
            {
                if (__dll_InvoiceOwner.IrsaliyeNo == null || __dll_InvoiceOwner.IrsaliyeNo == "")
                {
                    XtraMessageBox.Show("İrsaliye No Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _return = true;
                } 
            }
            if (invoice == InvoiceType.SatisFaturasi || invoice == InvoiceType.AlımFaturası)
            {
                if (__dll_InvoiceOwner.EFaturaNo == null || __dll_InvoiceOwner.EFaturaNo == "")
                {
                    XtraMessageBox.Show("Fatura No Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _return = true;

                }
            }
            if (__dll_InvoiceOwner.DepoName == null)
            {
                XtraMessageBox.Show("Lütfen Depo Seçimi Yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            if(__dll_List_InoviceTrans.Any(x=>x.Quentity == 0))
            {
                XtraMessageBox.Show("Miktar Girilmeyen Satırlar Mevcuttur. Düzeltiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }

            return _return;
        }

        public void do_save()
        {
            try
            {
                bs_InvoiceOwner.EndEdit();
                bs_InvoiceTrans.EndEdit();

                if (do_Validation()) return;

                foreach (var item in __dll_List_InoviceTrans)
                {
                    if (_productlist.Where(x => x.PID == item.ProductId).FirstOrDefault().PFirstPrice.GetValueOrDefault() != item.BirimFiyat)
                    {
                        if(MspTool.get_Question("Birim Fiyatlarında Değişklikleri Mevcuttur. Değiştirilsin Mi?"))
                        {
                            BirimFiyatChance = true;
                        }
                    } 
                }

                if (MspTool.get_Question("Kaydedilecektir Onaylıyor musunuz?"))
                {
                    var req = new InvoiceSaveRequest()
                    {
                        InvoiceOwner = __dll_InvoiceOwner,
                        InvoiceTrans = __dll_List_InoviceTrans,
                        IsOrder = _IsOrders,
                        _invoiceType = (int)invoice,
                        BirimFiyatChance = BirimFiyatChance,                
                    };
                    var response = _repository.Run<InvoiceService, ActionResponse<InvoiceSaveRequest>>(x => x.Save_Inovice(req));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "InvoiceList")
                            {
                                ((InvoiceList)item).do_refresh();
                            }
                        }
                        this.Close();
                    }
                }

            }
            catch (Exception)
            {
            }

        }

        public void do_SiparisSec(int orderOwnerId)
        {
            try
            {
                if (orderOwnerId != 0)
                {
                    var _orderTrans = _repository.Run<InvoiceService, List<OrderTransDTO>>(x => x.Get_orderTrans_Invoice(orderOwnerId));
                    if (_orderTrans.Count > 0)
                    {
                        __dll_InvoiceOwner.OrderId = orderOwnerId;
                        foreach (var item in _orderTrans)
                        {
                            InvoiceTransDTO newTrans = new InvoiceTransDTO();
                            newTrans.ProductId = item.StockId;
                            newTrans.UnitID = item.BirimId;
                            newTrans.BirimFiyat = item.BirimFiyat;
                            newTrans.Tutar = item.Tutar;
                            newTrans.KDV = item.KDV;
                            newTrans.Quentity = item.Miktar;
                            __dll_List_InoviceTrans.Add(newTrans);
                        }
                        bs_InvoiceTrans.DataSource = __dll_List_InoviceTrans;
                        gc_invoiceTrans.RefreshDataSource();
                        _IsOrders = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }


        public void do_IrsaliyeSec(int InvoiceId, string _irsaliyeNo)
        {
            try
            {
                if (InvoiceId != 0)
                {
                    var _irsaliyeTrans = _repository.Run<InvoiceService, List<InvoiceTransDTO>>(x => x.Get_InovicerTranse(InvoiceId));
                    if (_irsaliyeTrans.Count > 0)
                    {
                        __dll_InvoiceOwner.IrsaliyeId = InvoiceId;
                        __dll_InvoiceOwner.IrsaliyeNo = _irsaliyeNo;
                        foreach (var item in _irsaliyeTrans)
                        {
                            InvoiceTransDTO newTrans = new InvoiceTransDTO();
                            newTrans.ProductId = item.ProductId;
                            newTrans.UnitID = item.UnitID;
                            newTrans.BirimFiyat = item.BirimFiyat;
                            __dll_List_InoviceTrans.Add(newTrans);
                        }
                        bs_InvoiceTrans.DataSource = __dll_List_InoviceTrans;
                        gc_invoiceTrans.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion


        #region Form

        private void InvoiceEdit_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);

            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Alım Faturası";
                    lytSatisFaturasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_IrsaliyeSaat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcgr_FatutaBilgisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_FaturaTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_VadeGun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_VadeTarih.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_OdemeTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    bbi_İrsaliyeCagir.Enabled = true;
                    bbi_Tahsilat.Caption = "Ödeme";
                    break;
                case InvoiceType.SatisFaturasi:
                    this.Text = "Satış Faturası";
                    lytSatisFaturasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_IrsaliyeSaat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcgr_FatutaBilgisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_FaturaTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_VadeGun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_VadeTarih.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_OdemeTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    bbi_İrsaliyeCagir.Enabled = true;
                    bbi_Tahsilat.Caption = "Tahsilat";
                    break;
                case InvoiceType.AlisIrsaliye:
                    this.Text = "Alış İrsaliyesi";
                    lc_IrsaliyeSaat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcgr_FatutaBilgisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_FaturaTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_VadeGun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_VadeTarih.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_OdemeTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    bbi_İrsaliyeCagir.Enabled = false;
                    bbi_Tahsilat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                case InvoiceType.SatisIrsaliye:
                    this.Text = "Satış İrsaliyesi";
                    lcgr_FatutaBilgisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_IrsaliyeSaat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lc_FaturaTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_VadeGun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_VadeTarih.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lc_OdemeTuru.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    bbi_İrsaliyeCagir.Enabled = false;
                    bbi_Tahsilat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                default:
                    break;
            }

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;

            _company = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            bs_company.DataSource = _company;

            if (_FormOpenType == FormOpenType.New)
            {
                __dll_InvoiceOwner = new InvoiceOwnerDTO();
                __dll_List_InoviceTrans = new List<InvoiceTransDTO>();
                __dll_InvoiceOwner.InvoiceType = (int)invoice;
                __dll_InvoiceOwner.FicDate = DateTime.Now;
                __dll_InvoiceOwner.VadeTarih = DateTime.Now;
                __dll_InvoiceOwner.VadeGun = 0;
                __dll_InvoiceOwner.KDV = "Dahil";
                __dll_InvoiceOwner.CompanyId = AppMain.CompanyRecId;
                lc_Company.EditValue = AppMain.Company;
                if (_currencyTypes.Count > 0)
                {
                    __dll_InvoiceOwner.DovizTuru = _currencyTypes.FirstOrDefault(x => x.Remark == "TL").RecId;
                    lc_DovizTuru.EditValue  = _currencyTypes.FirstOrDefault(x => x.Remark == "TL").Remark;
                }
                if (CariId != 0)
                {
                    txtCariHesapAdi.EditValue = CariId;
                }
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __dll_InvoiceOwner = _repository.Run<InvoiceService, InvoiceOwnerDTO>(x => x.Get_Invoice(RecId));
                __dll_List_InoviceTrans = _repository.Run<InvoiceService, List<InvoiceTransDTO>>(x => x.Get_Edit_List_Trans(RecId));
            }
            if (_FormOpenType == FormOpenType.View)
            {
                gc_invoiceTrans.Enabled = false;
                bbi_save.Enabled = false;
            }

            txtFaturaTipi.Properties.DataSource = FaturaTuru;
            txtFaturaTipi.Properties.ValueMember = "Id";
            txtFaturaTipi.Properties.DisplayMember = "Value";

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_Product.DataSource = _productlist;

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;


   

            _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_Depot.DataSource = _depotList;

            rp_KDV.DataSource = KdvOrani;
            rp_KDV.ValueMember = "Id";
            rp_KDV.DisplayMember = "Value";

            bs_InvoiceOwner.DataSource = __dll_InvoiceOwner;
            bs_InvoiceTrans.DataSource = __dll_List_InoviceTrans;

        }

        private void InvoiceEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InvoiceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }
        #endregion

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcv_invoiceTrans.CloseEditor();
            do_save();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_SiparisCagir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FindOrderList frm = new FindOrderList();
            frm.ShowDialog();
        }

        private void gcv_invoiceTrans_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            var oRow = (InvoiceTransDTO)gcv_invoiceTrans.GetFocusedRow();
            if (oRow != null)
            {
                if (oRow.ProductId == null) return;

                var product = _productlist.FirstOrDefault(x => x.PID == oRow.ProductId);

                if (e.Column == colProductId || e.Column == colProductBarcode)
                {
                    oRow.UnitID = product.PUnitId;
                    oRow.KDV = product.PTax;
                    oRow.BirimFiyat = product.PFirstPrice;
                }
                oRow.Tutar = oRow.Quentity * oRow.BirimFiyat;
                oRow.KDVPrice = Math.Round(oRow.Tutar.GetValueOrDefault() * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)oRow.KDV).TaxOrani, 2);
                TopTotal();
            }



        }


        private void TopTotal()
        {

            decimal AraToplam = 0;
            decimal BirimFiyatToplam = Math.Round(Convert.ToDecimal(__dll_List_InoviceTrans.Sum(x => x.BirimFiyat)), 2);
            decimal tutar = Math.Round(Convert.ToDecimal(__dll_List_InoviceTrans.Sum(x => x.Tutar)), 2);
            decimal Iskonto = Math.Round((tutar * Convert.ToDecimal(__dll_InvoiceOwner.Iskonto)) / 100, 2);
            decimal TotalKDV = 0;
            if (Iskonto > 0)
            {
                AraToplam = tutar - Iskonto;
            }
            else
            {
                AraToplam = tutar;
            }

            foreach (var item in __dll_List_InoviceTrans)
            {
                decimal Kdv = Math.Round(item.Tutar.GetValueOrDefault() * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)item.KDV).TaxOrani, 2);
                TotalKDV += Kdv;
            }


            //__dll_InvoiceOwner.topl = BirimFiyatToplam;
            __dll_InvoiceOwner.Indirim = Iskonto;
            __dll_InvoiceOwner.AraToplam = AraToplam;
            __dll_InvoiceOwner.ToplamKDV = TotalKDV;
            __dll_InvoiceOwner.GenelToplam = AraToplam + TotalKDV;
            txtToplam.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", BirimFiyatToplam);
            txtIndirim.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", Iskonto);
            txtAraToplam.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", AraToplam);
            txtToplamKDV.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", TotalKDV);
            txtTotal.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", AraToplam + TotalKDV);

        }

        private void bbi_İrsaliyeCagir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FindIrsaliyeList frm = new FindIrsaliyeList();
            frm.invoice = InvoiceType.AlisIrsaliye;
            frm.ShowDialog();
        }

        private void txtCariHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    msp.App.frmCurrentTransactions frm = new msp.App.frmCurrentTransactions();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
                    bs_CariHesap.DataSource = _currentTransactionsList;
                }
            }
        }

        private void lc_DovizTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    CurrencyTypeList frm = new CurrencyTypeList();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
                    bs_CurrencyType.DataSource = _currencyTypes;
                }
            }
        }

        private void txtDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmDepo frm = new frmDepo();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
                    bs_Depot.DataSource = _depotList;
                }
            }
        }

        private void bbi_FaturaAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FindInvoiceList frm = new FindInvoiceList();
            frm.ShowDialog();
        }

        private void bbi_DeleteRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (InvoiceTransDTO)gcv_invoiceTrans.GetFocusedRow();
            if (oRow != null)
            {
                if (oRow.RecId == 0)
                {
                    __dll_List_InoviceTrans.Remove(oRow);
                    gc_invoiceTrans.RefreshDataSource();
                }
                else
                {
                    _deleteRow.Add(oRow.RecId);
                    __dll_List_InoviceTrans.Remove(oRow);
                    gc_invoiceTrans.RefreshDataSource();
                }
                TopTotal();
            }
        }

        private void bbi_Tahsilat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaHareketi frm = new frmKasaHareketi();
            frm.ShowDialog();
        }

        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void txtCariHesapAdi_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(txtCariHesapAdi.EditValue)))
            {
                var cariHesap = _currentTransactionsList.FirstOrDefault(x => x.CurID == Convert.ToInt32(txtCariHesapAdi.EditValue));
                if (cariHesap != null)
                {
                    txtAdress.Text = cariHesap.CurAdress;
                }
            }
        }
    }
}