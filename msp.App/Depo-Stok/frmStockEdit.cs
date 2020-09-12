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

        public void Show(int id)
        {
            product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
            bs_StockEdit.DataSource = product;

            this.ShowDialog();       
        }

        private void frmStockEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
