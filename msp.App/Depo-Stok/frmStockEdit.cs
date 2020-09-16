using DevExpress.XtraEditors;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.DepotStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Depo_Stok
{
    public partial class frmStockEdit : XtraForm
    {
        Repository _repository = new Repository();

        public frmStockEdit()
        {
            InitializeComponent();
        }

        public FormOpenType _FormOpenType;

        ProductDTO product = new ProductDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();

        public void Show(int id)
        {
            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;

            if (_FormOpenType == FormOpenType.New)
            {
                product = new ProductDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
                bs_StockEdit.DataSource = product;
            }

            this.ShowDialog();
        }

        private void frmStockEdit_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barcodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SpecialCodetextEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void productGroupTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lastPriceTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #region Record

        private void do_save()
        {
            if (get_Question("Kaydedilcektir Onaylıyor musunuz?"))
            {
                try
                {
                    var response = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.InsertProduct(product));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
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

        #endregion


        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}
