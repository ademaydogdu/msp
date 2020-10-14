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

namespace Msp.App.Satis
{
    public partial class frmSpeedSatis : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository; 
        public frmSpeedSatis()
        {
            InitializeComponent();
            _repository = new Repository();
            Set_Form();
        }

        List<ProductDTO> products = new List<ProductDTO>();
        List<SpeedSaleProductDTO> speedSaleProducts = new List<SpeedSaleProductDTO>();

      
        private void do_refresh()
        {
            products = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            speedSaleProducts = _repository.Run<SaleService, List<SpeedSaleProductDTO>>(x => x.GetList_SpeedSaleProduct());
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
                group1.Items.Add(item1);
            }

        }


        private void frmSpeedSatis_Load(object sender, EventArgs e)
        {

   
    
        }




    }
}