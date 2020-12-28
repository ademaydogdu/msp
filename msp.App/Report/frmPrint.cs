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
using Msp.Models.Models;
using Msp.Models.Models.Sale;
using Msp.App.Report.Satis;
using Msp.App.Report.CariHesap;

namespace Msp.App.Report
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        public void PrintProduct(List<ProductDTO> data)
        {
            ProductList report = new ProductList();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void DailySaleOwner(List<SaleOwnerDTO> data)
        {
            GunlukSatisReport report = new GunlukSatisReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void CariHesapListesi(List<CTransactionsDTO> data)
        {
            CariHesapListesi report = new CariHesapListesi();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }





    }
}