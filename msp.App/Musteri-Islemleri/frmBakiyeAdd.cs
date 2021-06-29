using DevExpress.XtraEditors;
using Msp.App.Musteri_Islemleri;
using Msp.Models.Models.Customer;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.CustomerTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Satis
{
    public partial class frmBakiyeAdd : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository = new Repository();

        public frmBakiyeAdd()
        {
            InitializeComponent();
        }

        public SaleOwnerDTO saleOwner { get; set; }

        private void frmBakiyeAdd_Load(object sender, EventArgs e)
        {


        }

        private void bbi_BakiyedenAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (string.IsNullOrEmpty(textEdit1.Text))
            {
                return;
            }
            if (Convert.ToDecimal(textEdit1.EditValue) <= 0)
            {
                return;
            }

            if (get_Question("Ek olarak Bakiye eklenecektir. Onaylıyor musunuz?"))
            {

                var result = new CustomerBakiyeAddFilter
                {
                    Amount = Convert.ToDecimal(textEdit1.EditValue),
                    _saleOwner = saleOwner
                };

                var response = _repository.Run<CustomerService, ActionResponse<SaleOwnerDTO>>(x => x.UpdateBakiyeAdd(result));
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

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmBakiyeAdd_KeyDown(object sender, KeyEventArgs e)
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


    }
}