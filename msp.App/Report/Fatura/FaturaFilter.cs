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
using Msp.Models.Models;
using Msp.Service.Service.Tanimlar;
using Msp.Service.Service.Report;
using Msp.Models.Models.Report;

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
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();

        List<SelectIdValue> IceType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alım Faturası"),
            new SelectIdValue(2, "Satış Faturasi"),
            new SelectIdValue(4, "Alım İrsaliyesi"),
            new SelectIdValue(5, "Satış İrsaliyesi"),
        };
        public InvoiceType invoice;

        #region Record

        private void do_report(bool report)
        {
            //if (invoice == InvoiceType.AlımFaturası || invoice == InvoiceType.SatisFaturasi)
            //{
            //}
            //if (invoice == InvoiceType.SatisIrsaliye || invoice == InvoiceType.AlisIrsaliye)
            //{
            //}
            var req = new InvoiceRequest
            {
                InvoiceType = (int)invoice,
                BeginDate = dt_BeginDate.DateTime,
                EndDate = new DateTime(dt_EndDate.DateTime.Year, dt_EndDate.DateTime.Month, dt_EndDate.DateTime.Day, 23, 59, 00),
                DovizTuru = Convert.ToInt32(dt_Currencies.EditValue)
            };
            invoiceList = _repository.Run<ReportService, List<InvoiceOwnerDTO>>(x => x.GetList_Invoice(req));

            if (invoiceList.Count > 0)
            {
                gridControl1.DataSource = invoiceList;
                if (report)
                {

                }
            }
            else
            {
                XtraMessageBox.Show("Kayıt Bulunamadı...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        #endregion


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

            dt_BeginDate.DateTime = DateTime.Today;
            dt_EndDate.DateTime = DateTime.Today;

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;
            if (_currencyTypes.Count > 0)
            {

            }
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            do_report(false);
        }
    }
}