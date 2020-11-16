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

namespace Msp.App.Satis
{
    public partial class frmIskonto : DevExpress.XtraEditors.XtraForm
    {
        public frmIskonto()
        {
            InitializeComponent();
        }
        public decimal TotalPrice;

        public void Show(decimal _totalPrice)
        {
            TotalPrice = _totalPrice;
            txtOranTotalTutar.EditValue = _totalPrice;
            txtTLTotalTutar.EditValue = _totalPrice;
            this.ShowDialog();
        }

        private void frmIskonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                do_indirimUygula();
            }
        }

        public void do_indirimUygula()
        {

        }

        private void bbi_Hesapla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_indirimUygula();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)radioGroup1.EditValue == 0)
            {
                layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if ((int)radioGroup1.EditValue == 1)
            {
                layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void txtIndirimOrani_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIndirimOrani_Leave(object sender, EventArgs e)
        {
            if (TotalPrice > 0)
            {
                decimal indirimTutar = Math.Round((TotalPrice * Convert.ToDecimal(txtIndirimOrani.EditValue)) / 100, 2);
                lblIndirimTutar.Text = Convert.ToString(indirimTutar);
                lblTotalDiscount.Text = Convert.ToString(Math.Round(TotalPrice - indirimTutar, 2));
            }
        }
    }
}