using DevExpress.XtraEditors;
using Msp.Models.SimleCurrentModels;
using Msp.Service.Repository;
using Msp.Service.Service.SimleCurrent;
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
    public partial class frmFindInvoice : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmFindInvoice()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        List<SimpleInvoiceOwnerDTO> invoiceList = new List<SimpleInvoiceOwnerDTO>();

        #region Record

        public void do_refresh()
        {
            try
            {
                invoiceList = _repository.Run<SimleCurrentService, List<SimpleInvoiceOwnerDTO>>(x => x.GetList_Invoice(0));
                bs_Invoice.DataSource = invoiceList;
            }
            catch (Exception)
            {
            }
        }


        #endregion

        private void frmFindInvoice_Load(object sender, EventArgs e)
        {
            do_refresh();
        }
    }
}