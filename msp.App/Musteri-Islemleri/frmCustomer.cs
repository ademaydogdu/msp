using DevExpress.XtraEditors;
using msp.App;
using Msp.App.Tool;
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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmCustomer()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool mspTool = new MspTool();
        public bool SatisSale = false;
        List<CustomersDTO> _customerList = new List<CustomersDTO>();

        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        #region Edit
        public void do_Edit()
        {
            CustomersDTO Orow = (CustomersDTO)gcvCustomers.GetFocusedRow();
            if (Orow != null)
            {
                frmCustomerEdit frm = new frmCustomerEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.id);

            }




        }

        #endregion


        #region Add
        private void btnAddNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            frmCustomerEdit frm = new frmCustomerEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }



        #endregion


        public void do_refresh()
        {

            _customerList = _repository.Run<CustomerTransactionsService, List<CustomersDTO>>(x => x.GetListCustomer());
            bs_Customers.DataSource = _customerList;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_GridControl(this.Name, grdCustomers);
        }

        #region Edit
        private void btnEditCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }
        #endregion

        private void btnCustomerClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        #region Delete
        private void btnRemCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomersDTO oRow = (CustomersDTO)gcvCustomers.GetFocusedRow();

            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<CustomerTransactionsService, ActionResponse<CustomersDTO>>(x => x.DeleteCostumers(oRow.id));
                    do_refresh();
                }
            }
        }
        #endregion

        private void btnCustomerRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, grdCustomers);
        }

        private void gcvCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (SatisSale)
            {
                MusteriSec();
            }
            else
            {
                do_Edit();
            }
        }

        private void do_Form(CustomersDTO Customers)
        {
            Form _Form = MspTool.get_OpenForm("frmSatis");
            if (_Form != null)
            {
                ((frmSatis)_Form).CustomerSelect(Customers);
            }
            _Form = null;
        }

        public void MusteriSec()
        {
            CustomersDTO Orow = (CustomersDTO)gcvCustomers.GetFocusedRow();
            if (Orow != null)
            {
                do_Form(Orow);
                this.Close();
            }
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (SatisSale)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MusteriSec();
                }
            }
            
        }

        private void bbi_VeresiyeDefter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
