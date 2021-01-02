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
using Msp.App.Tool;

namespace Msp.App.Depo_Stok
{
    public partial class frmStockMovement : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;

        public frmStockMovement()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();

        private void frmStockMovement_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);
        }

        private void frmStockMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Get_Layout(this);
        }
    }
}