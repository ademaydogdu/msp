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

namespace Msp.App.CariIslemler
{
    public partial class FindInvoiceList : DevExpress.XtraEditors.XtraForm
    {
        public FindInvoiceList()
        {
            InitializeComponent();
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FindInvoiceList_Load(object sender, EventArgs e)
        {

        }
    }
}