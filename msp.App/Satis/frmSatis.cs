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


        #region Descriptons

        ProductDTO _product = new ProductDTO();
        SaleOwnerDTO __dll_SaleOwner = new SaleOwnerDTO();
        List<SaleTransDTO> __dl_List_SaleTrans = new List<SaleTransDTO>();
        int RecId;
        public FormOpenType _FormOpenType;
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();
        //GetListPayments
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
                    _varmi.ProductAmount = Math.Round(_varmi.ProductPrice.GetValueOrDefault() * _varmi.ProductQuantity.GetValueOrDefault(), 2);
                }
                else
                {
                    SaleTransDTO saleTrans = new SaleTransDTO();
                    saleTrans.ProductId = _product.PID;
                    saleTrans.ProductName = _product.PName;
                    saleTrans.ProductBarcode = _product.PBarcode;
                    saleTrans.ProductPrice = _product.PFirstPrice;
                    saleTrans.UnitId = _product.PUnitId;
                    saleTrans.ProductQuantity = 1;
                    saleTrans.Deleted = false;
                    saleTrans.ProductAmount = Math.Round(saleTrans.ProductPrice.GetValueOrDefault() * saleTrans.ProductQuantity.GetValueOrDefault(), 5, MidpointRounding.ToEven);
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
            }

            if (_FormOpenType == FormOpenType.New)
            {
                __dll_SaleOwner = new SaleOwnerDTO();
                __dll_SaleOwner.Date = DateTime.Now;

            }
            if (_FormOpenType == FormOpenType.Edit)
            {

            }

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());

            bs_Unit.DataSource = _list_UnitsDTO;
            bs_PaymentType.DataSource = _list_PaymnetType;
            bs_SaleOwner.DataSource = __dll_SaleOwner;
            bs_SaleTrans.DataSource = __dl_List_SaleTrans;
            this.Show();
        }


        private void frmSatis_Load(object sender, EventArgs e)
        {
            btn_N0.AutoWidthInLayoutControl = true;
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
                //txt_Total.EditValue = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                txt_Total.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", __dl_List_SaleTrans.Sum(x => x.ProductAmount));
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
    }
}