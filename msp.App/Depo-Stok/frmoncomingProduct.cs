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
using Msp.App.Tool;

namespace Msp.App.Depo_Stok
{
    public partial class frmoncomingProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmoncomingProduct()
        {
            InitializeComponent();
        }
        MspTool mspTool = new MspTool();

        private void frmoncomingProduct_Load(object sender, EventArgs e)
        {

            mspTool.Get_GridControl(this.Name, gridControl1);

        }

        private void frmoncomingProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gridControl1);

        }
    }
}