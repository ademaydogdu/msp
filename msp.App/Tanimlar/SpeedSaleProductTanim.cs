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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Sale;
using Msp.Service.Service.Sale;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;

namespace Msp.App.Tanimlar
{
    public partial class SpeedSaleProductTanim : DevExpress.XtraEditors.XtraForm
    {

        Repository _repository;

        public SpeedSaleProductTanim()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<SpeedSaleProductDTO> _speedSaleProduct = new List<SpeedSaleProductDTO>();

        private void SpeedSaleProductTanim_Load(object sender, EventArgs e)
        {
            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;

            _speedSaleProduct = _repository.Run<SaleService, List<SpeedSaleProductDTO>>(x => x.GetList_SpeedSaleProduct());
            bs_SpeedSaleProduct.DataSource = _speedSaleProduct;
        }

        private void btnSpeedNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductDTO oRow = (ProductDTO)gcv_Product.GetFocusedRow();
            if (oRow != null)
            {
                if (_speedSaleProduct.Any(x => x.ProductId == oRow.PID))
                {
                    XtraMessageBox.Show("Aynı Ürün Mevcuttur");
                    return;
                }
                SpeedSaleProductDTO speedSaleProduct = new SpeedSaleProductDTO();
                speedSaleProduct.ProductId = oRow.PID;
                _speedSaleProduct.Add(speedSaleProduct);
                gc_SpeedSaleProduct.RefreshDataSource();
            }
        }

        private void btnSpeedProductRetrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SpeedSaleProductDTO speedSaleProduct = (SpeedSaleProductDTO)gcv_SpeedSaleProduct.GetFocusedRow();
            if (speedSaleProduct != null)
            {
                if (speedSaleProduct.RecId == 0)
                {
                    _speedSaleProduct.Remove(speedSaleProduct);
                }
                else
                {
                    if (mspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                    {
                        var result = _repository.Run<SaleService, ActionResponse<SpeedSaleProductDTO>>(x => x.DeleteSpeedSaleProduct(speedSaleProduct.RecId));
                        _speedSaleProduct.Remove(speedSaleProduct);
                        gc_SpeedSaleProduct.RefreshDataSource();
                    }
                }
            }
            gc_SpeedSaleProduct.RefreshDataSource();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mspTool.get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
            {
                gcv_SpeedSaleProduct.CloseEditor();
                try
                {
                    var response = _repository.Run<SaleService, ActionResponse<List<SpeedSaleProductDTO>>>(x => x.SaveSpeedSaleProduct(_speedSaleProduct));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}