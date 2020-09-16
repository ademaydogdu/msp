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
using Msp.App.Depo_Stok;

namespace msp.App
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmStok()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<ProductDTO> _productlist = new List<ProductDTO>();

        private void frmStok_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit1.DataSource = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            repositoryItemLookUpEdit1.ValueMember = "UID";
            repositoryItemLookUpEdit1.DisplayMember = "UName";


            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            productsBindingSource.DataSource = _productlist;

        }

        private void btnEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = (ProductDTO)gridView1.GetFocusedRow();
            if (row != null)
            {
                frmStockEdit frm = new frmStockEdit();
                frm._FormOpenType = Msp.Infrastructure.FormOpenType.Edit;
                frm.Show(row.PID); 
            }
        }

        private void btnAddNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStockEdit frm = new frmStockEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }
    }
}