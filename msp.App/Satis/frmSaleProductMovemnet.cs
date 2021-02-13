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
using Msp.App.Depo_Stok;
using Msp.Models.Models;
using Msp.Models.Models.Sale;
using Msp.Service.Service.DepotStock;
using Msp.Infrastructure;
using System.Globalization;
using Msp.Service.Service.Tanimlar;
using Msp.Service.Service.Sale;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Settings;

namespace Msp.App.Satis
{
    public partial class frmSaleProductMovemnet : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;

        public frmSaleProductMovemnet()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        MspTool mspTool = new MspTool();
        private bool IsPosSale = false;
        ProductDTO _product = new ProductDTO();
        SaleOwnerDTO __dll_SaleOwner = new SaleOwnerDTO();
        List<SaleTransDTO> __dl_List_SaleTrans = new List<SaleTransDTO>();
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();
        List<CustomersDTO> _customerList = new List<CustomersDTO>();
        List<CaseDefinitionDTO> __List_CaseDef = new List<CaseDefinitionDTO>();
        decimal IskontoTutari = 0;
        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };
        List<ProductMovementDTO> __List_ProductMocemenet = new List<ProductMovementDTO>();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();



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
                    saleTrans.ProductDate = _product.PExpDate == null ? new DateTime(1900, 1, 1) : _product.PExpDate.GetValueOrDefault();
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

        public void TopTotal()
        {
            if (__dl_List_SaleTrans.Count > 0)
            {
                var totalKdv = __dl_List_SaleTrans.Sum(x => x.TaxAmount);
                var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
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

        public bool do_Validation()
        {
            bool _return = false;
            if (__dl_List_SaleTrans.Count == 0)
            {
                XtraMessageBox.Show("Ürün Kaydı olması gerekmektedir.");
                _return = true;
            }
            if (__dll_SaleOwner.CaseId == 0)
            {
                XtraMessageBox.Show("Kasa Girilmesi Zorunludur.");
                _return = true;
            }


            return _return;
        }
        public void do_save()
        {
            try
            {
                if (do_Validation()) return;

                bs_SaleOwner.EndEdit();
                bs_SaleTrans.EndEdit();
                __dl_List_SaleTrans.ForEach(x => x.CaseId = Convert.ToInt32(lc_CaseDef.EditValue));

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
                        //txt_CustomerName.Text = "";
                        txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = "₺ 0.00";
                        //txt_OdemeTipi.EditValue = "";
                        gridControl1.RefreshDataSource();
                        TopTotal();
                    }
                    daily_SaleProduct();

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        public void daily_SaleProduct()
        {
            __List_ProductMocemenet = _repository.Run<DepotStockService, List<ProductMovementDTO>>(x => x.GetListProduct_Movement_Daily());
            bs_ProductMovent.DataSource = __List_ProductMocemenet;
        }


        private void frmSaleProductMovemnet_Load(object sender, EventArgs e)
        {
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            __List_CaseDef = _repository.Run<DefinitionsService, List<CaseDefinitionDTO>>(x => x.Get_List_CaseDef(AppMain.CompanyRecId));
            bs_CaseList.DataSource = __List_CaseDef;
            if (__List_CaseDef.Count > 0)
            {
                lc_CaseDef.EditValue = __List_CaseDef.FirstOrDefault().RecId;
            }

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            rp_KdvOran.DataSource = KdvOrani;
            rp_KdvOran.DisplayMember = "Value";
            rp_KdvOran.ValueMember = "Id";

            __dll_SaleOwner = new SaleOwnerDTO();
            __dll_SaleOwner.Date = DateTime.Now;
            txt_Date.EditValue = DateTime.Now;

            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());
            bs_PaymentType.DataSource = _list_PaymnetType;


            daily_SaleProduct();
            mspTool.Get_Layout(this);
        }

        private void frmSaleProductMovemnet_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void frmSaleProductMovemnet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            frm.btnORderAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            frm.IsSale = true;
            frm.ShowDialog();
        }

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            if (_parameters.SaleApproval.GetValueOrDefault())
            {
                if (!mspTool.get_Question("Satış Sonlnadırılactır. Onaylıyor musunuz?")) return;
            }
            do_save();
        }

        private void bbi_MiktarAzalt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void bbi_SatırSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaleTransDTO oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                __dl_List_SaleTrans.Remove(oRow);
                gridControl1.RefreshDataSource();
                TopTotal();
            }
        }

        private void bbi_TopluSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (__dl_List_SaleTrans.Count > 0)
            {
                __dl_List_SaleTrans.Clear();
                __dll_SaleOwner.TotalPrice = 0;
                txt_Total.EditValue = __dll_SaleOwner.TotalPriceText = "₺ 0.00";
                gridControl1.RefreshDataSource();
            }
        }

        private void bbi_Nakit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                txt_OdemeTipi.EditValue = 1;
                if (_parameters.PaymentFisSave.GetValueOrDefault())
                {
                    do_save();
                }
            }
        }

        private void bbi_Pos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                txt_OdemeTipi.EditValue = 2;
                if (_parameters.PaymentFisSave.GetValueOrDefault())
                {
                    do_save();
                }
            }
        }

        private void bbi_PosNakit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_list_PaymnetType.Count > 0)
            {
                txt_OdemeTipi.EditValue = 3;
                if (_parameters.PaymentFisSave.GetValueOrDefault())
                {
                    do_save();
                }
            }
        }
    }
}