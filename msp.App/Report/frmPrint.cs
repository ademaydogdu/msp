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
using Msp.App.Report.Depo_Stock;
using Msp.App.Report.Case;
using Msp.Models.Models.Case;
using Msp.Models.Models.Report;
using Msp.App.Report.Daily;
using Msp.Models.Models.Daily;
using Msp.App.Report.Barcode;
using Msp.Models.Models.Invoice;
using Msp.App.Report.Fatura;

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


        public void PrintEnvanterBilgisi(List<ProductDTO> data)
        {
            EnvanterBilgileri report = new EnvanterBilgileri();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintSaleOwnersVeresiye(List<SaleOwnerDTO> data)
        {
            VeresiyeDefter report = new VeresiyeDefter();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintKasaHareketRaporu(List<CaseMovementDTO> data)
        {
            KasaHareketRapor report = new KasaHareketRapor();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintSumSaleStock(List<SumSaleStockDTO> data)
        {
            EnCokSatanUrunler report = new EnCokSatanUrunler();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintGunSonu(DailyOwnerDTO data)
        {
            GunSonuReport report = new GunSonuReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintBarcode_13(ProductDTO data)
        {
            UrunBarcode13 report = new UrunBarcode13();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintBarcode_8(ProductDTO data)
        {
            UrunBarcode8 report = new UrunBarcode8();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintProductBarcodeList(List<ProductDTO> data)
        {
            BarocedList report = new BarocedList();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintSaleBarcodCreate(List<SaleBarcodCreateDTO> data)
        {
            SaleBarcodCreate report = new SaleBarcodCreate();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintInvoiceReport(InvoiceOwnerDTO data)
        {
            InvoiceReport report = new InvoiceReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintCaseBakiye(List<CaseBakiyeReportDTO> data)
        {
            CaseBakiyeReport report = new CaseBakiyeReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

    }
}