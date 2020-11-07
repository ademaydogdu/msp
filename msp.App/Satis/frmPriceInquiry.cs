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

namespace Msp.App.Satis
{
    public partial class frmPriceInquiry : DevExpress.XtraEditors.XtraForm
    {
        public frmPriceInquiry()
        {
            InitializeComponent();
        }
        MspTool mspTool = new MspTool();



        private void frmPriceInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_PriceInQuery);
        }

        private void frmPriceInquiry_Load(object sender, EventArgs e)
        {
            mspTool.Get_GridControl(this.Name, gc_PriceInQuery);
        }
    }
}