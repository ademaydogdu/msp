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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Repository;
using Msp.App.Tool;

namespace Msp.App.Depo_Stok
{
    public partial class frmExpDateProducts : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmExpDateProducts()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<ProductDTO>__listExpDateProducts = new List<ProductDTO>();
        MspTool mspTool = new MspTool();

        private void do_refresh() 
        {
            __listExpDateProducts = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListExpDateProducts());
            bs_ExpDateProd.DataSource = __listExpDateProducts;
        }

        private void btnExpDateRefr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frmExpDateProducts_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_GridControl(this.Name, gridControl1);

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void gcv_ExpDateProd_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DateTime date = Convert.ToDateTime(gcv_ExpDateProd.GetRowCellValue(e.RowHandle, colPExpDate));
            if (date != null)
            {
                if (date == DateTime.Now)
                {
                    e.Appearance.BackColor = Color.DarkSalmon;
                }
                else
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }

            }
        }

        private void frmExpDateProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gridControl1);

        }
    }
}