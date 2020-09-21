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
using Msp.Models.Models.Utilities;

namespace Msp.App.Depo_Stok
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

        public void do_refresh()
        {

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;
        }

        private void frmStok_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit1.DataSource = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            repositoryItemLookUpEdit1.ValueMember = "UID";
            repositoryItemLookUpEdit1.DisplayMember = "UName";


            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;

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

        #region Edit
        private void btnEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductDTO Orow = (ProductDTO)gcvProducts.GetFocusedRow();
            if (Orow != null)
            {
                frmStockEdit frm = new frmStockEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.PID);
            }
        }

        #endregion

        #region Add
        private void btnAddNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStockEdit frm = new frmStockEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }

        #endregion

        #region Delete

        private void btnRemProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductDTO oRow = (ProductDTO)gcvProducts.GetFocusedRow();

            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.DeleteProduct(oRow.PID));
                    do_refresh();
                }
            }

        }

        



        #endregion

        private void btnProductsRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}