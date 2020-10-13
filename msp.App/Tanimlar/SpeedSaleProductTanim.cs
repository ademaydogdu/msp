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
                _speedSaleProduct.Remove(speedSaleProduct);
            }
            gc_SpeedSaleProduct.RefreshDataSource();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}