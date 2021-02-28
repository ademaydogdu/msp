using DevExpress.XtraEditors;
using Msp.Models.SimleCurrentModels;
using Msp.Service.Repository;
using Msp.Service.Service.SimleCurrent;
using Msp.SimleCurrent.Models;
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
    public partial class InvoiceList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public InvoiceList()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        public InvoiceType invoice;

        List<SimpleInvoiceOwnerDTO> invoiceList = new List<SimpleInvoiceOwnerDTO>();

        #region Record

        public void do_refresh()
        {
            try
            {
                invoiceList = _repository.Run<SimleCurrentService, List<SimpleInvoiceOwnerDTO>>(x => x.GetList_Invoice((int)invoice));
                bs_Invoice.DataSource = invoiceList;
            }
            catch (Exception)
            {
            }
        }


        #endregion


        private void InvoiceList_Load(object sender, EventArgs e)
        {

            switch (invoice)
            {
                case InvoiceType.AlisFaturasi:
                    this.Text = "Alım Faturası";
                    break;
                case InvoiceType.SatisFaturasi:
                    this.Text = "Satış Faturası";
                    break;
                default:
                    break;
            }
            do_refresh();
        }
    }
}