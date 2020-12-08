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
using Msp.Models.Models.Sale;
using DevExpress.XtraBars.Navigation;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.Sale;
using Msp.Models.Models.Utilities;
using System.Globalization;
using Msp.Service.Service.Tanimlar;
using System.IO;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Service.Service.Settings;

namespace Msp.App.Satis
{
    public partial class frmSpeedSatis : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;

        public frmSpeedSatis()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();

            Set_Form();
        }
        MspTool mspTool = new MspTool();

        List<ProductDTO> products = new List<ProductDTO>();
        List<SpeedSaleProductDTO> speedSaleProducts = new List<SpeedSaleProductDTO>();

        SaleOwnerDTO __dl_SaleOwner = new SaleOwnerDTO();
        List<SaleTransDTO> __dl_List_SaleTrans = new List<SaleTransDTO>();

        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();


        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };
        ProductDTO _product = new ProductDTO();



        private void do_refresh()
        {
            products = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            speedSaleProducts = _repository.Run<SaleService, List<SpeedSaleProductDTO>>(x => x.GetList_SpeedSaleProduct());
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
        }

        private void Set_Form()
        {
            do_refresh();
            TileBarGroup group1 = new TileBarGroup();
            tileControl1.Groups.Add(group1);
            group1.Text = "ÜRüNLER";

            foreach (var item in speedSaleProducts)
            {
                TileBarItem item1 = new TileBarItem();
                item1.ItemSize = (TileBarItemSize)item.ButtonType;
                item1.Text = products.Where(x => x.PID == item.ProductId).FirstOrDefault().PName;
                item1.Name = Convert.ToString(products.Where(x => x.PID == item.ProductId).FirstOrDefault().PID);
                if (products.Where(x => x.PID == item.ProductId).FirstOrDefault().PImages.Length > 0)
                {
                    item1.BackgroundImage = byteArrayToImage(products.Where(x => x.PID == item.ProductId).FirstOrDefault().PImages); // System.Text.Encoding.Default.GetString(products.Where(x => x.PID == item.ProductId).FirstOrDefault().PImages);
                    item1.BackgroundImageAlignment = TileItemContentAlignment.Default;
                    item1.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
                }
    
                item1.ImageToTextAlignment = TileControlImageToTextAlignment.Default;
                item1.BorderVisibility = TileItemBorderVisibility.Always;
                item1.AppearanceItem.Normal.ForeColor = Color.Black;
                item1.AppearanceItem.Normal.BorderColor = Color.Black;
                item1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 13F);
                group1.Items.Add(item1);
            }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void frmSpeedSatis_Load(object sender, EventArgs e)
        {
            __dl_SaleOwner.Date = DateTime.Now;
            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());

            rp_Unit.DataSource = _list_UnitsDTO;
            rp_KdvOran.DataSource = KdvOrani;

            mspTool.Get_Layout(this);
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {
        }

        private void do_AddPRoduct(int ProductId)
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
                    saleTrans.ProductPrice = _product.PMalBedeli;
                    saleTrans.UnitId = _product.PUnitId;
                    saleTrans.ProductQuantity = 1;
                    saleTrans.Deleted = false;
                    saleTrans.ProductAmount = Math.Round(saleTrans.ProductPrice.GetValueOrDefault() * saleTrans.ProductQuantity.GetValueOrDefault(), 5, MidpointRounding.ToEven);
                    saleTrans.Tax = _product.PTax;
                    saleTrans.TaxAmount = _product.PPaxAmout;
                    saleTrans.ProductDate = _product.PDate.GetValueOrDefault();
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
                var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount) + totalKdv;
                //var totalAmount = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                __dl_SaleOwner.NetPrice = __dl_List_SaleTrans.Sum(x => x.ProductAmount);
                __dl_SaleOwner.TotalPrice = totalAmount;
                __dl_SaleOwner.KDV = totalKdv;
                txt_NetFiyat.EditValue = __dl_SaleOwner.NetPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", __dl_List_SaleTrans.Sum(x => x.ProductAmount));
                txt_KDV.EditValue = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalKdv);
                txt_Total.EditValue = __dl_SaleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", totalAmount);

            }
        }

        private void tileControl1_ItemClick(object sender, TileItemEventArgs e)
        {
            string name = e.Item.Name;
            if (!string.IsNullOrEmpty(name))
            {
                do_AddPRoduct(Convert.ToInt32(name));
            }

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
                //if (txt_OdemeTipi.EditValue == "")
                //{
                //    MessageBox.Show("Ödeme Tipi Alanı Boş Bırakılmaz.");
                //    _return = true;
                //}
            }


            return _return;
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
                __dl_SaleOwner.UserCode = AppMain.User.username;
                __dl_SaleOwner.CompanyRecId = AppMain.CompanyRecId;
                var req = new SaleRequest
                {
                    List_SaleTrans = __dl_List_SaleTrans,
                    SaleOwnerDTO = __dl_SaleOwner
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
                        __dl_SaleOwner = new SaleOwnerDTO();
                        __dl_List_SaleTrans.Clear();
                        __dl_List_SaleTrans = new List<SaleTransDTO>();
                        //txt_CustomerName.Text = "";
                        txt_Total.EditValue = __dl_SaleOwner.TotalPriceText = "₺ 0.00";
                        //txt_OdemeTipi.EditValue = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            do_save();
        }

        private void frmSpeedSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSpeedSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void btnInsertQuantity_Click(object sender, EventArgs e)
        {
            var oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                oRow.ProductQuantity += 1;
                var ProductAmount = Math.Round(oRow.ProductPrice.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);
                oRow.ProductAmount = ProductAmount;
                oRow.TaxAmount = Math.Round(oRow.TaxAmount.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);

                gridControl1.RefreshDataSource();
                TopTotal();
            }
        }

        private void btnDeleteProducr_Click(object sender, EventArgs e)
        {
            var oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (oRow.ProductQuantity >= 1)
                {
                    oRow.ProductQuantity -= 1;
                    oRow.ProductAmount = Math.Round(oRow.ProductPrice.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);
                    oRow.TaxAmount = Math.Round(oRow.TaxAmount.GetValueOrDefault() * oRow.ProductQuantity.GetValueOrDefault(), 2);
                    gridControl1.RefreshDataSource();
                    TopTotal();
                }
            }
        }

        private void btnRowDeleted_Click(object sender, EventArgs e)
        {
            SaleTransDTO oRow = (SaleTransDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                __dl_List_SaleTrans.Remove(oRow);
                gridControl1.RefreshDataSource();
                TopTotal();
            }
        }

        private void btnTopluSil_Click(object sender, EventArgs e)
        {
            if (__dl_List_SaleTrans.Count > 0)
            {
                __dl_List_SaleTrans.Clear();
                __dl_SaleOwner.TotalPrice = 0;
                txt_Total.EditValue = __dl_SaleOwner.TotalPriceText = "₺ 0.00";
                gridControl1.RefreshDataSource();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}