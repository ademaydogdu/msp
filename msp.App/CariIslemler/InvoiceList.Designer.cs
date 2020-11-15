﻿namespace Msp.App.CariIslemler
{
    partial class InvoiceList
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
            this.btnNewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemAccount = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Document = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Print = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurTranClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegInfo = new DevExpress.XtraBars.BarButtonItem();
            this.gc_Invoice = new DevExpress.XtraGrid.GridControl();
            this.bs_Invoice = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_Invoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFicDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFichTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAraToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiğerMasraflar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Invoice)).BeginInit();
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
            this.barManager1.Images = this.img_sic;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnNewAccount,
            this.btnEditAccount,
            this.barButtonItem2,
            this.btnRemAccount,
            this.btnSeaAccount,
            this.btnAccountTransactions,
            this.btnCurTranClose,
            this.btnRegInfo,
            this.bbi_Refresh,
            this.bbi_Print,
            this.bbi_Document});
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Document),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCurTranClose, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Caption = "Yeni Hesap";
            this.btnNewAccount.Id = 1;
            this.btnNewAccount.ImageOptions.ImageIndex = 2;
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAccount_ItemClick);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Caption = "Hesap Düzelt";
            this.btnEditAccount.Id = 2;
            this.btnEditAccount.ImageOptions.ImageIndex = 6;
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAccount_ItemClick);
            // 
            // btnRemAccount
            // 
            this.btnRemAccount.Caption = "Hesap Sil";
            this.btnRemAccount.Id = 4;
            this.btnRemAccount.ImageOptions.ImageIndex = 5;
            this.btnRemAccount.Name = "btnRemAccount";
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 9;
            this.bbi_Refresh.ImageOptions.ImageIndex = 7;
            this.bbi_Refresh.Name = "bbi_Refresh";
            this.bbi_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Refresh_ItemClick);
            // 
            // bbi_Document
            // 
            this.bbi_Document.Caption = "Dosyalar";
            this.bbi_Document.Id = 11;
            this.bbi_Document.ImageOptions.ImageIndex = 9;
            this.bbi_Document.Name = "bbi_Document";
            // 
            // bbi_Print
            // 
            this.bbi_Print.Caption = "Yazdır";
            this.bbi_Print.Id = 10;
            this.bbi_Print.ImageOptions.ImageIndex = 8;
            this.bbi_Print.Name = "bbi_Print";
            // 
            // btnCurTranClose
            // 
            this.btnCurTranClose.Caption = "Kapat";
            this.btnCurTranClose.Id = 7;
            this.btnCurTranClose.ImageOptions.ImageIndex = 0;
            this.btnCurTranClose.Name = "btnCurTranClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // img_sic
            // 
            this.img_sic.ImageSize = new System.Drawing.Size(32, 32);
            this.img_sic.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.img_sic.Add("linecolor", "image://svgimages/spreadsheet/linecolor.svg");
            this.img_sic.Add("addfile", "image://svgimages/outlook inspired/addfile.svg");
            this.img_sic.Add("removedataitems", "image://svgimages/dashboards/removedataitems.svg");
            this.img_sic.Add("movechartnewsheet", "image://svgimages/spreadsheet/movechartnewsheet.svg");
            this.img_sic.Add("snapdeletelist", "image://svgimages/snap/snapdeletelist.svg");
            this.img_sic.Add("edit", "image://svgimages/dashboards/edit.svg");
            this.img_sic.Add("convertto", "image://svgimages/dashboards/convertto.svg");
            this.img_sic.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.img_sic.Add("open2", "image://svgimages/actions/open2.svg");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hesap İncele";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.ImageIndex = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSeaAccount
            // 
            this.btnSeaAccount.Caption = "Hesap Bul";
            this.btnSeaAccount.Id = 5;
            this.btnSeaAccount.ImageOptions.ImageIndex = 6;
            this.btnSeaAccount.Name = "btnSeaAccount";
            // 
            // btnAccountTransactions
            // 
            this.btnAccountTransactions.Caption = "Hesap Hareketleri";
            this.btnAccountTransactions.Id = 6;
            this.btnAccountTransactions.ImageOptions.ImageIndex = 4;
            this.btnAccountTransactions.Name = "btnAccountTransactions";
            // 
            // btnRegInfo
            // 
            this.btnRegInfo.Caption = "Kayıt Bilgisi";
            this.btnRegInfo.Id = 8;
            this.btnRegInfo.ImageOptions.ImageIndex = 11;
            this.btnRegInfo.Name = "btnRegInfo";
            // 
            // gc_Invoice
            // 
            this.gc_Invoice.DataSource = this.bs_Invoice;
            this.gc_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Invoice.Location = new System.Drawing.Point(0, 0);
            this.gc_Invoice.MainView = this.gcv_Invoice;
            this.gc_Invoice.MenuManager = this.barManager1;
            this.gc_Invoice.Name = "gc_Invoice";
            this.gc_Invoice.Size = new System.Drawing.Size(950, 536);
            this.gc_Invoice.TabIndex = 5;
            this.gc_Invoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_Invoice});
            // 
            // bs_Invoice
            // 
            this.bs_Invoice.DataSource = typeof(Msp.Models.Models.Invoice.InvoiceOwnerDTO);
            // 
            // gcv_Invoice
            // 
            this.gcv_Invoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFicDate,
            this.colFichTime,
            this.colFicheType,
            this.colFicheDocumentNo,
            this.colFicheRemark,
            this.colCariRecId,
            this.colVadeTarih,
            this.colDepoName,
            this.colIndirim,
            this.colAraToplam,
            this.colToplamKDV,
            this.colDiğerMasraflar,
            this.colGenelToplam});
            this.gcv_Invoice.GridControl = this.gc_Invoice;
            this.gcv_Invoice.Name = "gcv_Invoice";
            this.gcv_Invoice.OptionsBehavior.Editable = false;
            this.gcv_Invoice.OptionsView.ColumnAutoWidth = false;
            this.gcv_Invoice.OptionsView.ShowFooter = true;
            this.gcv_Invoice.OptionsView.ShowGroupPanel = false;
            // 
            // colFicDate
            // 
            this.colFicDate.Caption = "Fatura Tarihi";
            this.colFicDate.FieldName = "FicDate";
            this.colFicDate.Name = "colFicDate";
            this.colFicDate.Visible = true;
            this.colFicDate.VisibleIndex = 0;
            // 
            // colFichTime
            // 
            this.colFichTime.Caption = "Fatura Saat";
            this.colFichTime.FieldName = "FichTime";
            this.colFichTime.Name = "colFichTime";
            this.colFichTime.Visible = true;
            this.colFichTime.VisibleIndex = 1;
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
            this.colFicheDocumentNo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFicheDocumentNo.AppearanceCell.Options.UseFont = true;
            this.colFicheDocumentNo.Caption = "Fatura Belge No";
            this.colFicheDocumentNo.FieldName = "FicheDocumentNo";
            this.colFicheDocumentNo.Name = "colFicheDocumentNo";
            this.colFicheDocumentNo.Visible = true;
            this.colFicheDocumentNo.VisibleIndex = 3;
            // 
            // colFicheRemark
            // 
            this.colFicheRemark.Caption = "Fatura Açıklama";
            this.colFicheRemark.FieldName = "FicheRemark";
            this.colFicheRemark.Name = "colFicheRemark";
            this.colFicheRemark.Visible = true;
            this.colFicheRemark.VisibleIndex = 4;
            // 
            // colCariRecId
            // 
            this.colCariRecId.Caption = "Cari Hesap Adı";
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
            this.colDepoName.Caption = "Depo Adı";
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
            // colDiğerMasraflar
            // 
            this.colDiğerMasraflar.FieldName = "DiğerMasraflar";
            this.colDiğerMasraflar.Name = "colDiğerMasraflar";
            this.colDiğerMasraflar.Visible = true;
            this.colDiğerMasraflar.VisibleIndex = 11;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.FieldName = "GenelToplam";
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 12;
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 578);
            this.Controls.Add(this.gc_Invoice);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "InvoiceList";
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceList_FormClosing);
            this.Load += new System.EventHandler(this.InvoiceList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvoiceList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnNewAccount;
        private DevExpress.XtraBars.BarButtonItem btnRemAccount;
        private DevExpress.XtraBars.BarButtonItem btnEditAccount;
        private DevExpress.XtraBars.BarButtonItem btnCurTranClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSeaAccount;
        private DevExpress.XtraBars.BarButtonItem btnAccountTransactions;
        private DevExpress.XtraBars.BarButtonItem btnRegInfo;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraGrid.GridControl gc_Invoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_Invoice;
        private DevExpress.XtraBars.BarButtonItem bbi_Print;
        private DevExpress.XtraBars.BarButtonItem bbi_Document;
        private System.Windows.Forms.BindingSource bs_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn colFicDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFichTime;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheType;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colCariRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoName;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colAraToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiğerMasraflar;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
    }
}