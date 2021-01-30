namespace Msp.App.CariIslemler
{
    partial class FindInvoiceList
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_Closed = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_select = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bs_Invoice = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAraToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDigerMasraflar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEIrsaliyeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInoviceCancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicePrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeGun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIrsaliyeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIrsaliyeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDovizTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.img_bar;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_select,
            this.bbi_Closed,
            this.bbi_Delete});
            this.barManager1.LargeImages = this.img_bar;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Closed)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_Closed
            // 
            this.bbi_Closed.Caption = "Vazgeç";
            this.bbi_Closed.Id = 1;
            this.bbi_Closed.ImageOptions.ImageIndex = 0;
            this.bbi_Closed.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Closed.Name = "bbi_Closed";
            this.bbi_Closed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Closed_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(763, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 465);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(763, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 465);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(763, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 465);
            // 
            // img_bar
            // 
            this.img_bar.Add("delete", "image://svgimages/dashboards/delete.svg");
            this.img_bar.Add("save", "image://svgimages/outlook inspired/save.svg");
            this.img_bar.Add("charthorizontalaxis_logscale", "image://svgimages/spreadsheet/charthorizontalaxis_logscale.svg");
            this.img_bar.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.img_bar.Add("bo_validation", "image://svgimages/business objects/bo_validation.svg");
            // 
            // bbi_select
            // 
            this.bbi_select.Caption = "Kaydet";
            this.bbi_select.Id = 0;
            this.bbi_select.ImageOptions.ImageIndex = 5;
            this.bbi_select.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_select.Name = "bbi_select";
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(763, 465);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_Invoice;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(739, 441);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bs_Invoice
            // 
            this.bs_Invoice.DataSource = typeof(Msp.Models.Models.Invoice.InvoiceOwnerDTO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceType,
            this.colFicDate,
            this.colFicheType,
            this.colFicheDocumentNo,
            this.colFicheRemark,
            this.colCariRecId,
            this.colVadeTarih,
            this.colDepoName,
            this.colIndirim,
            this.colAraToplam,
            this.colToplamKDV,
            this.colDigerMasraflar,
            this.colGenelToplam,
            this.colCompanyId,
            this.colEFaturaNo,
            this.colEIrsaliyeNo,
            this.colInoviceCancel,
            this.colInvoicePrint,
            this.colVadeGun,
            this.colVadeDate,
            this.colIrsaliyeDate,
            this.colIrsaliyeNo,
            this.colDovizTuru,
            this.colKDV,
            this.colIskonto,
            this.colPaymentType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.FieldName = "InvoiceType";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 0;
            // 
            // colFicDate
            // 
            this.colFicDate.FieldName = "FicDate";
            this.colFicDate.Name = "colFicDate";
            this.colFicDate.Visible = true;
            this.colFicDate.VisibleIndex = 1;
            // 
            // colFicheType
            // 
            this.colFicheType.FieldName = "FicheType";
            this.colFicheType.Name = "colFicheType";
            this.colFicheType.Visible = true;
            this.colFicheType.VisibleIndex = 2;
            // 
            // colFicheDocumentNo
            // 
            this.colFicheDocumentNo.FieldName = "FicheDocumentNo";
            this.colFicheDocumentNo.Name = "colFicheDocumentNo";
            this.colFicheDocumentNo.Visible = true;
            this.colFicheDocumentNo.VisibleIndex = 3;
            // 
            // colFicheRemark
            // 
            this.colFicheRemark.FieldName = "FicheRemark";
            this.colFicheRemark.Name = "colFicheRemark";
            this.colFicheRemark.Visible = true;
            this.colFicheRemark.VisibleIndex = 4;
            // 
            // colCariRecId
            // 
            this.colCariRecId.FieldName = "CariRecId";
            this.colCariRecId.Name = "colCariRecId";
            this.colCariRecId.Visible = true;
            this.colCariRecId.VisibleIndex = 5;
            // 
            // colVadeTarih
            // 
            this.colVadeTarih.FieldName = "VadeTarih";
            this.colVadeTarih.Name = "colVadeTarih";
            this.colVadeTarih.Visible = true;
            this.colVadeTarih.VisibleIndex = 6;
            // 
            // colDepoName
            // 
            this.colDepoName.FieldName = "DepoName";
            this.colDepoName.Name = "colDepoName";
            this.colDepoName.Visible = true;
            this.colDepoName.VisibleIndex = 7;
            // 
            // colIndirim
            // 
            this.colIndirim.FieldName = "Indirim";
            this.colIndirim.Name = "colIndirim";
            this.colIndirim.Visible = true;
            this.colIndirim.VisibleIndex = 8;
            // 
            // colAraToplam
            // 
            this.colAraToplam.FieldName = "AraToplam";
            this.colAraToplam.Name = "colAraToplam";
            this.colAraToplam.Visible = true;
            this.colAraToplam.VisibleIndex = 9;
            // 
            // colToplamKDV
            // 
            this.colToplamKDV.FieldName = "ToplamKDV";
            this.colToplamKDV.Name = "colToplamKDV";
            this.colToplamKDV.Visible = true;
            this.colToplamKDV.VisibleIndex = 10;
            // 
            // colDigerMasraflar
            // 
            this.colDigerMasraflar.FieldName = "DigerMasraflar";
            this.colDigerMasraflar.Name = "colDigerMasraflar";
            this.colDigerMasraflar.Visible = true;
            this.colDigerMasraflar.VisibleIndex = 11;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.FieldName = "GenelToplam";
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 12;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 13;
            // 
            // colEFaturaNo
            // 
            this.colEFaturaNo.FieldName = "EFaturaNo";
            this.colEFaturaNo.Name = "colEFaturaNo";
            this.colEFaturaNo.Visible = true;
            this.colEFaturaNo.VisibleIndex = 14;
            // 
            // colEIrsaliyeNo
            // 
            this.colEIrsaliyeNo.FieldName = "EIrsaliyeNo";
            this.colEIrsaliyeNo.Name = "colEIrsaliyeNo";
            this.colEIrsaliyeNo.Visible = true;
            this.colEIrsaliyeNo.VisibleIndex = 15;
            // 
            // colInoviceCancel
            // 
            this.colInoviceCancel.FieldName = "InoviceCancel";
            this.colInoviceCancel.Name = "colInoviceCancel";
            this.colInoviceCancel.Visible = true;
            this.colInoviceCancel.VisibleIndex = 16;
            // 
            // colInvoicePrint
            // 
            this.colInvoicePrint.FieldName = "InvoicePrint";
            this.colInvoicePrint.Name = "colInvoicePrint";
            this.colInvoicePrint.Visible = true;
            this.colInvoicePrint.VisibleIndex = 17;
            // 
            // colVadeGun
            // 
            this.colVadeGun.FieldName = "VadeGun";
            this.colVadeGun.Name = "colVadeGun";
            this.colVadeGun.Visible = true;
            this.colVadeGun.VisibleIndex = 18;
            // 
            // colVadeDate
            // 
            this.colVadeDate.FieldName = "VadeDate";
            this.colVadeDate.Name = "colVadeDate";
            this.colVadeDate.Visible = true;
            this.colVadeDate.VisibleIndex = 19;
            // 
            // colIrsaliyeDate
            // 
            this.colIrsaliyeDate.FieldName = "IrsaliyeDate";
            this.colIrsaliyeDate.Name = "colIrsaliyeDate";
            this.colIrsaliyeDate.Visible = true;
            this.colIrsaliyeDate.VisibleIndex = 20;
            // 
            // colIrsaliyeNo
            // 
            this.colIrsaliyeNo.FieldName = "IrsaliyeNo";
            this.colIrsaliyeNo.Name = "colIrsaliyeNo";
            this.colIrsaliyeNo.Visible = true;
            this.colIrsaliyeNo.VisibleIndex = 21;
            // 
            // colDovizTuru
            // 
            this.colDovizTuru.FieldName = "DovizTuru";
            this.colDovizTuru.Name = "colDovizTuru";
            this.colDovizTuru.Visible = true;
            this.colDovizTuru.VisibleIndex = 22;
            // 
            // colKDV
            // 
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 23;
            // 
            // colIskonto
            // 
            this.colIskonto.FieldName = "Iskonto";
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.Visible = true;
            this.colIskonto.VisibleIndex = 24;
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 25;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(763, 465);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(743, 445);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FindInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 505);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FindInvoiceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ara";
            this.Load += new System.EventHandler(this.FindInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_Closed;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarButtonItem bbi_select;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bs_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colFicDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheType;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colCariRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoName;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colAraToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDigerMasraflar;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colEFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEIrsaliyeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInoviceCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicePrint;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeGun;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIrsaliyeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIrsaliyeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDovizTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
    }
}