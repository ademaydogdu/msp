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
using Msp.App.Tool;
using Msp.Models.Models.Invoice;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;

namespace Msp.App.Report.Fatura
{
    public partial class FaturaFilter : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FaturaFilter()
        {
            InitializeComponent();
            _repository = new Repository();

        }

        MspTool MspTool = new MspTool();
        List<InvoiceOwnerDTO> invoiceList = new List<InvoiceOwnerDTO>();

        List<SelectIdValue> IceType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alım Faturası"),
            new SelectIdValue(2, "Satış Faturasi"),
            new SelectIdValue(4, "Alım İrsaliyesi"),
            new SelectIdValue(5, "Satış İrsaliyesi"),
        };
        public InvoiceType invoice;


        private void FaturaFilter_Load(object sender, EventArgs e)
        {
            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Fatura Rapor";
                    break;
                case InvoiceType.SatisFaturasi:
                    this.Text = "Fatura Rapor";
                    break;
                case InvoiceType.AlisIrsaliye:
                    this.Text = "Irsaliye Rapor";
                    break;
                case InvoiceType.SatisIrsaliye:
                    this.Text = "Irsaliye Rapor";
                    break;
                default:
                    break;
            }

        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}