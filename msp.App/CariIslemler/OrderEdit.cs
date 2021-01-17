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
using Msp.Service.Repository;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models.Order;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.CurrentTransactions;
using Msp.Service.Service.App;
using Msp.Service.Service.Tanimlar;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Order;
using System.Globalization;
using msp.App;
using Msp.App.Tanimlar;

namespace Msp.App.CariIslemler
{
    public partial class OrderEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public OrderEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool MspTool = new MspTool();
        public FormOpenType _FormOpenType;
        public int RecId;
        public OrderType OrderType;

        public OrderOwnerDTO __orderOwner = new OrderOwnerDTO();
        public List<OrderTransDTO> __orderTrans = new List<OrderTransDTO>();

        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        #region Record
        public bool do_Validation()
        {
            bool _return = false;
            if (__orderTrans.Count == 0)
            {
                MessageBox.Show("Boş Satır Kaydedilemez...");
                _return = true;
            }
            if (__orderOwner.SiparisNo == "")
            {
                XtraMessageBox.Show("Sipariş No Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = false;
            }
            if (__orderOwner.CariRecId == 0)
            {
                XtraMessageBox.Show("Cari Hesap Seçimi yapmadınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = false;
            }
            if (__orderOwner.CompanyId == 0 || Convert.ToString(lc_Company.EditValue) == "")
            {
                XtraMessageBox.Show("İşyeri Seöimi yapmadınız..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = false;
            }
            return _return;
        }

        public void do_save()
        {
            try
            {
                bs_OrderOwner.EndEdit();
                bs_OrderTrans.EndEdit();

                if (do_Validation()) return;
                if (MspTool.get_Question("Kaydedilecektir Onaylıyor musunuz?"))
                {
                    var req = new OrderRequest()
                    {
                        OrderOwner = __orderOwner,
                        OrderTrans = __orderTrans
                    };
                    var response = _repository.Run<OrderService, ActionResponse<OrderRequest>>(x => x.Save_Orders(req));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "OrderList")
                            {
                                ((OrderList)item).do_refresh();
                            }
                        }
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void TopTotal()
        {

            decimal AraToplam = 0;
            decimal BirimFiyatToplam = Math.Round(Convert.ToDecimal(__orderTrans.Sum(x => x.Tutar)), 2);
            decimal Iskonto = Math.Round((BirimFiyatToplam * Convert.ToDecimal(__orderOwner.Iskonto)) / 100, 2);
            decimal TotalKDV = 0;
            if (Iskonto > 0)
            {
                AraToplam = BirimFiyatToplam - Iskonto;
            }
            else
            {
                AraToplam = BirimFiyatToplam;
            }

            foreach (var item in __orderTrans)
            {
                decimal Kdv = Math.Round(item.Tutar.GetValueOrDefault() * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)item.KDV).TaxOrani, 2);
                TotalKDV += Kdv;
            }
            __orderOwner.TotalToplam = BirimFiyatToplam;
            __orderOwner.TotalIskonto = Iskonto;
            __orderOwner.TotalAraToplam = AraToplam;
            __orderOwner.TotalKDV = TotalKDV;
            __orderOwner.TotalSiparis = AraToplam + TotalKDV;
            txtToplam.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", BirimFiyatToplam);
            txtIndirim.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", Iskonto);
            txtAraToplam.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", AraToplam);
            txtToplamKDV.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", TotalKDV);
            txtTotal.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", AraToplam + TotalKDV);

        }



        #endregion


        #region Form
        private void OrderEdit_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);
            switch (OrderType)
            {
                case OrderType.AlisSiparis:
                    this.Text = "Alış Sipariş";
                    break;
                case OrderType.SatisSiparis:
                    this.Text = "Satiş Sipariş";
                    break;
                case OrderType.AllSiparis:
                    break;
                case OrderType.BekleyenSiparis:
                    break;
                default:
                    break;
            }

            if (_FormOpenType == FormOpenType.New)
            {
                lc_Company.EditValue = AppMain.Company;
                __orderOwner.CompanyId = AppMain.CompanyRecId;
                __orderOwner.OrderType = (int)OrderType;
                __orderOwner.SiparisNo = "0";
                __orderOwner.TeklifSiparis = 0;
                lbl_Durum.Text = __orderOwner.Durum = "Bekliyor";

            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __orderOwner = _repository.Run<OrderService, OrderOwnerDTO>(x => x.Get_OrderOwner(RecId));
                __orderTrans = _repository.Run<OrderService, List<OrderTransDTO>>(x => x.Get_OrderTrans(RecId));
            }
            if (_FormOpenType == FormOpenType.View)
            {

            }
            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_Product.DataSource = _productlist;

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;

            _company = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            bs_company.DataSource = _company;

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;

            rp_KDV.DataSource = KdvOrani;
            rp_KDV.ValueMember = "Id";
            rp_KDV.DisplayMember = "Value";

            bs_OrderOwner.DataSource = __orderOwner;
            bs_OrderTrans.DataSource = __orderTrans;

        }

        private void OrderEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void OrderEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcv_OrderTrans.CloseEditor();
            do_save();
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcv_OrderTrans_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var _orderTrans = gcv_OrderTrans.GetRow(e.RowHandle) as OrderTransDTO;
            if (_orderTrans != null)
            {
                if (_orderTrans.StockId == null) return;

                var product = _productlist.FirstOrDefault(x => x.PID == _orderTrans.StockId);
                if (e.Column == colStockId)
                {
                    _orderTrans.BirimId = product.PUnitId;
                    _orderTrans.KDV = product.PTax;
                }
                if (e.Column == colMiktar)
                {

                }
                if (e.Column == colBirimFiyat)
                {

                }
                _orderTrans.Tutar = _orderTrans.Miktar * _orderTrans.BirimFiyat;
                TopTotal();
            }
        }

        private void txt_Iskonto_EditValueChanged(object sender, EventArgs e)
        {
            TopTotal();
        }

        private void grp_CariId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmCurrentTransactions frm = new frmCurrentTransactions();
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
    }
}