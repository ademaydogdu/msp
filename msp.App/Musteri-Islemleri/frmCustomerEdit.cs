using DevExpress.XtraEditors;
using Msp.Infrastructure;
using Msp.Models.Models;
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

namespace Msp.App.Musteri_Islemleri
{
    public partial class frmCustomerEdit : XtraForm
    {
        Repository _repository = new Repository();
        public frmCustomerEdit()
        {
            InitializeComponent();
        }

        public FormOpenType _FormOpenType;

        private CustomersDTO __customers = new CustomersDTO();
       
        public void Show(int id)
        {
           

            if (_FormOpenType == FormOpenType.New)
            {
                __customers = new CustomersDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __customers = _repository.Run<CustomerTransactionsService, CustomersDTO>(x => x.GetCustomer(id));
            }

            bs_CustomersEdit.DataSource = __customers;
            this.ShowDialog();
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

        #region Record
        private void do_save()

        {
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<CustomerTransactionsService, ActionResponse<CustomersDTO>>(x => x.SaveCustomers(__customers));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        private void btnSaveCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void btnCustomerClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }

  


}
