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
using Msp.App.Tool;
using msp.App;
using Msp.App.Report;
using Msp.Infrastructure;
using Msp.App.Satis;

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

        public bool IsSale = false;
        MspTool mspTool = new MspTool();
        private ProductDTO __product = new ProductDTO();
        List<ProductDTO> _productlist = new List<ProductDTO>();

        public void do_refresh()
        {
            try
            {
                _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
                bs_products.DataSource = _productlist;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void frmStok_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit1.DataSource = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            repositoryItemLookUpEdit1.ValueMember = "UID";
            repositoryItemLookUpEdit1.DisplayMember = "UName";

            do_refresh();
            mspTool.Get_GridControl(this.Name, gcProducts);
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
        public void do_Edit()
        {
            ProductDTO Orow = (ProductDTO)gcvProducts.GetFocusedRow();
            if (Orow != null)
            {
                frmStockEdit frm = new frmStockEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.PID);

            }




        }
        private void btnEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }
        #endregion

        #region Add
        private void btnAddNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Insert, (int)DocumentType.StockList, AppMain.CompanyRecId))
            {
                return;
            }
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

        #region Sale
        private void do_Form(int RecId)
        {

            Form _Form_Satis = MspTool.get_OpenForm("frmSatis");
            if (_Form_Satis != null)
            {
                ((frmSatis)_Form_Satis).Insert_Product(RecId);
            }

            Form _Form_Satis_ProducM = MspTool.get_OpenForm("frmSaleProductMovemnet");
            if (_Form_Satis_ProducM != null)
            {
                ((frmSaleProductMovemnet)_Form_Satis_ProducM).Insert_Product(RecId);
            }

            _Form_Satis_ProducM = null;
            _Form_Satis = null;
        }
        public void SaleInsert()
        {
            if (IsSale)
            {
                ProductDTO Orow = (ProductDTO)gcvProducts.GetFocusedRow();
                if (Orow != null)
                {
                    if (Orow.PTotal == 0 || Orow.PTotal <= 0)
                    {
                        XtraMessageBox.Show("Ürün Stok'da kalmamıştır.", "Uyarı");
                        return;
                    }
                    do_Form(Orow.PID);
                    this.Close();
                }
            }
        }
        private void btnORderAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaleInsert();
        }
        #endregion

        private void gcvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (IsSale)
            {
                SaleInsert();
            }
            else
            {
                do_Edit();
            }
        }
        private void frmStok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                SaleInsert();
            }
        }

        private void frmStok_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gcProducts);
        }

        private void btnProClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productlist.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintProduct(_productlist);
                frm.ShowDialog();
            }
        }

        private void btnProTransactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductDTO Orow = (ProductDTO)gcvProducts.GetFocusedRow();
            if (Orow != null)
            {
                frmStockMovement frm = new frmStockMovement();
                frm.PId = Orow.PID;
                frm.ShowDialog();
            }
        }

        private void bbi_EnvanterGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_productlist.Count > 0)
            {
                frmProductEnvanter frm = new frmProductEnvanter();
                frm.ShowDialog();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEnvanterBilgiler frm = new frmEnvanterBilgiler();
            frm.ShowDialog();
        }
    }
}