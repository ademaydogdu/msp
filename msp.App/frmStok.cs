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

namespace msp.App
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mspDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mspDataSet.products);

        }
    }
}