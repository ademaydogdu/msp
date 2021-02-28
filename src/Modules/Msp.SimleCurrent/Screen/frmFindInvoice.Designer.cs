
namespace Msp.SimleCurrent.Screen
{
    partial class frmFindInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gc_InvoiceList = new DevExpress.XtraGrid.GridControl();
            this.bs_Invoice = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_InvoiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_InvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_InvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_InvoiceList
            // 
            this.gc_InvoiceList.DataSource = this.bs_Invoice;
            this.gc_InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_InvoiceList.Location = new System.Drawing.Point(0, 0);
            this.gc_InvoiceList.MainView = this.gcv_InvoiceList;
            this.gc_InvoiceList.Name = "gc_InvoiceList";
            this.gc_InvoiceList.Size = new System.Drawing.Size(772, 470);
            this.gc_InvoiceList.TabIndex = 0;
            this.gc_InvoiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_InvoiceList});
            // 
            // bs_Invoice
            // 
            this.bs_Invoice.DataSource = typeof(Msp.Models.SimleCurrentModels.SimpleInvoiceOwnerDTO);
            // 
            // gcv_InvoiceList
            // 
            this.gcv_InvoiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCariId,
            this.colInvoiceDate,
            this.colInvoiceType,
            this.colInvoiceNo,
            this.colCurrencyId,
            this.colRemark,
            this.colVade,
            this.colBorc,
            this.colAlacak,
            this.colCurrencyBorc,
            this.colCurrencyAlacak,
            this.colIsDetail});
            this.gcv_InvoiceList.GridControl = this.gc_InvoiceList;
            this.gcv_InvoiceList.Name = "gcv_InvoiceList";
            this.gcv_InvoiceList.OptionsBehavior.Editable = false;
            this.gcv_InvoiceList.OptionsView.ColumnAutoWidth = false;
            this.gcv_InvoiceList.OptionsView.ShowGroupPanel = false;
            // 
            // colCariId
            // 
            this.colCariId.Caption = "Cari Kodu";
            this.colCariId.FieldName = "CariId";
            this.colCariId.Name = "colCariId";
            this.colCariId.Visible = true;
            this.colCariId.VisibleIndex = 0;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Fiş Tarihi";
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 1;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.Caption = "Fiş Tipi";
            this.colInvoiceType.FieldName = "InvoiceType";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 2;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Fiş No";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 3;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Açıklama";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            // 
            // colVade
            // 
            this.colVade.Caption = "Vade";
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.Visible = true;
            this.colVade.VisibleIndex = 5;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "Borç";
            this.colBorc.DisplayFormat.FormatString = "n2";
            this.colBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 6;
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "Alacak";
            this.colAlacak.DisplayFormat.FormatString = "n2";
            this.colAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 7;
            // 
            // colCurrencyBorc
            // 
            this.colCurrencyBorc.Caption = "Döviz Borç";
            this.colCurrencyBorc.DisplayFormat.FormatString = "n2";
            this.colCurrencyBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCurrencyBorc.FieldName = "CurrencyBorc";
            this.colCurrencyBorc.Name = "colCurrencyBorc";
            this.colCurrencyBorc.Visible = true;
            this.colCurrencyBorc.VisibleIndex = 8;
            // 
            // colCurrencyAlacak
            // 
            this.colCurrencyAlacak.Caption = "Döviz Alacak";
            this.colCurrencyAlacak.DisplayFormat.FormatString = "n2";
            this.colCurrencyAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCurrencyAlacak.FieldName = "CurrencyAlacak";
            this.colCurrencyAlacak.Name = "colCurrencyAlacak";
            this.colCurrencyAlacak.Visible = true;
            this.colCurrencyAlacak.VisibleIndex = 9;
            // 
            // colIsDetail
            // 
            this.colIsDetail.Caption = "Detaylı";
            this.colIsDetail.FieldName = "IsDetail";
            this.colIsDetail.Name = "colIsDetail";
            this.colIsDetail.Visible = true;
            this.colIsDetail.VisibleIndex = 10;
            // 
            // colCurrencyId
            // 
            this.colCurrencyId.Caption = "Döviz Türü";
            this.colCurrencyId.FieldName = "CurrencyId";
            this.colCurrencyId.Name = "colCurrencyId";
            this.colCurrencyId.Visible = true;
            this.colCurrencyId.VisibleIndex = 11;
            // 
            // frmFindInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 470);
            this.Controls.Add(this.gc_InvoiceList);
            this.Name = "frmFindInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ara";
            this.Load += new System.EventHandler(this.frmFindInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_InvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_InvoiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_InvoiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_InvoiceList;
        private System.Windows.Forms.BindingSource bs_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn colCariId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colVade;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
    }
}