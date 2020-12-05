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
    public partial class frmEnvanterBilgiler : DevExpress.XtraEditors.XtraForm
    {
        public frmEnvanterBilgiler()
        {
            InitializeComponent();
        }
        MspTool MspTool = new MspTool();


        private void frmEnvanterBilgiler_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);

        }

        private void frmEnvanterBilgiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);

        }

        private void frmEnvanterBilgiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}