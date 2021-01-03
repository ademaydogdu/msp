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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;

namespace Msp.App.Depo_Stok
{
    public partial class frmStockMovement : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;

        public frmStockMovement()
        {
            InitializeComponent();
            _repository = new Repository();

        }

        public int PId { get; set; }

        MspTool mspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<ProductMovementDTO> __List_ProductMocemenet = new List<ProductMovementDTO>();

        private void frmStockMovement_Load(object sender, EventArgs e)
        {
            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;

            __List_ProductMocemenet = _repository.Run<DepotStockService, List<ProductMovementDTO>>(x => x.GetListProduct_Movement(PId));
            bs_ProductMovent.DataSource = __List_ProductMocemenet;


            mspTool.Get_Layout(this);
        }

        private void frmStockMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Get_Layout(this);
        }

        private void bbi_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("xls", gc_ProductMovement);
        }

        private void bbi_Pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("pdf", gc_ProductMovement);
        }
    }
}