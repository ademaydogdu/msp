using DevExpress.XtraEditors;
using Msp.Models.Models;
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

        ProductDTO product = new ProductDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();

        public void Show(int id)
        {

            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;

            product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
            bs_StockEdit.DataSource = product;

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

        private void BrandCodetextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
