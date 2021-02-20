using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.SimleCurrent.Screen
{
    public partial class frmSimleCurrentDefinitionList : DevExpress.XtraEditors.XtraForm
    {
        public frmSimleCurrentDefinitionList()
        {
            InitializeComponent();
        }

        private void frmSimleCurrentDefinitionList_Load(object sender, EventArgs e)
        {

        }

        private void bbi_closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSimleCurrentDefinition frm = new frmSimleCurrentDefinition();
            frm.ShowDialog();
        }
    }
}