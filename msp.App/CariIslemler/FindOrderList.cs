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
using Msp.Models.Models.Order;
using Msp.Service.Service.Invoice;
using Msp.App.Tool;
using Msp.Models.Models;
using Msp.Service.Service.App;
using Msp.Service.Service.CurrentTransactions;

namespace Msp.App.CariIslemler
{
    public partial class FindOrderList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FindOrderList()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<OrderOwnerDTO> _orderOwners;

        List<CompanyDTO> companies = new List<CompanyDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();


        MspTool otool = new MspTool();
        #region Record

        public void do_refresh()
        {
            _orderOwners = _repository.Run<InvoiceService, List<OrderOwnerDTO>>(x => x.GetList_OrderWait());
            bs_OrderList.DataSource = _orderOwners;


        }

        public void do_select()
        {
            try
            {
                var oRow = (OrderOwnerDTO)gcv_OrderList.GetFocusedRow();
                Form _Form = MspTool.get_OpenForm("InvoiceEdit");
                if (_Form != null)
                {
                    ((InvoiceEdit)_Form).do_SiparisSec(oRow.RecId);
                }
                _Form = null;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        #endregion


        #region FORM
        private void FindOrderList_Load(object sender, EventArgs e)
        {
            do_refresh();

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;

            companies = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            bs_company.DataSource = companies;

            otool.Get_Layout(this);
        }

        private void FindOrderList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FindOrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            otool.do_Save_Layout(this);

        }
        #endregion

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_select_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_select();
        }

        private void gcv_OrderList_DoubleClick(object sender, EventArgs e)
        {
            do_select();
        }
    }
}