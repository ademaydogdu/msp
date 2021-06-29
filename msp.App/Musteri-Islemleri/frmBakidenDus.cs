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
using Msp.Models.Models.Sale;
using Msp.Service.Service.CustomerTransactions;
using Msp.Service.Repository;
using Msp.Models.Models.Utilities;
using System.Globalization;

namespace Msp.App.Musteri_Islemleri
{
    public partial class frmBakidenDus : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository = new Repository();

        public frmBakidenDus()
        {
            InitializeComponent();
        }

        public SaleOwnerDTO _saleOwner;

        private void frmBakidenDus_Load(object sender, EventArgs e)
        {
            lblTutar.Text = _saleOwner.TotalPrice.GetValueOrDefault().ToString();
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmBakidenDus_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmBakidenDus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        private void bbi_BakiyedenDus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (_saleOwner.TotalPrice.GetValueOrDefault() < Convert.ToDecimal(txtTutar.EditValue))
            {
                XtraMessageBox.Show("Fazla Tutar Girişi Yaptınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (get_Question(txtTutar.Text + " tutar düşülecektir. Onaylıyor musunuz?"))
            {
                decimal kalanTutar = _saleOwner.TotalPrice.GetValueOrDefault() - Convert.ToDecimal(txtTutar.EditValue);
                _saleOwner.TotalPrice = kalanTutar;
                _saleOwner.NetPrice = kalanTutar;
                _saleOwner.NetPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", kalanTutar);
                _saleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", kalanTutar);

                var response = _repository.Run<CustomerService, ActionResponse<SaleOwnerDTO>>(x => x.Update_Veresiye(_saleOwner));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == "frmMusterVeresiyeDetail")
                        {
                            ((frmMusterVeresiyeDetail)item).do_refresh();
                        }
                    }
                    this.Close();
                }

            }
        }
    }
}