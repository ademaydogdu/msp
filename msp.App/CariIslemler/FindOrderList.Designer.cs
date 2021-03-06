﻿namespace Msp.App.CariIslemler
{
    partial class FindOrderList
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
            this.bbi_select = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.gc_OrderList = new DevExpress.XtraGrid.GridControl();
            this.bs_OrderList = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_OrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_CariHesap = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colOrderType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_OrderType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_Company = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDovizId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_Doviz = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colKDVId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifSiparis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_TeklifSiparis = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAraToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSiparis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIrsaliyeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bs_company = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CariHesap = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CurrencyType = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Unit = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_CariHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_OrderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Doviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_TeklifSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CariHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CurrencyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Unit)).BeginInit();
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
            this.barButtonItem2,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_select),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_select
            // 
            this.bbi_select.Caption = "Kaydet";
            this.bbi_select.Id = 0;
            this.bbi_select.ImageOptions.ImageIndex = 5;
            this.bbi_select.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_select.Name = "bbi_select";
            this.bbi_select.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_select_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Vazgeç";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 0;
            this.barButtonItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(792, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(792, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(792, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
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
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
            // 
            // gc_OrderList
            // 
            this.gc_OrderList.DataSource = this.bs_OrderList;
            this.gc_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_OrderList.Location = new System.Drawing.Point(0, 0);
            this.gc_OrderList.MainView = this.gcv_OrderList;
            this.gc_OrderList.MenuManager = this.barManager1;
            this.gc_OrderList.Name = "gc_OrderList";
            this.gc_OrderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rp_CariHesap,
            this.rp_OrderType,
            this.rp_Company,
            this.rp_Doviz,
            this.rp_TeklifSiparis});
            this.gc_OrderList.Size = new System.Drawing.Size(792, 438);
            this.gc_OrderList.TabIndex = 5;
            this.gc_OrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_OrderList});
            // 
            // bs_OrderList
            // 
            this.bs_OrderList.DataSource = typeof(Msp.Models.Models.Order.OrderOwnerDTO);
            // 
            // gcv_OrderList
            // 
            this.gcv_OrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.colCariRecId,
            this.colOrderType,
            this.colCompanyId,
            this.colSiparisNo,
            this.colSiparisDate,
            this.colSiparisTime,
            this.colOzelKod,
            this.colDovizId,
            this.colKDVId,
            this.colIskonto,
            this.colDurum,
            this.colTeklifSiparis,
            this.colRemark,
            this.colTotalToplam,
            this.colTotalIskonto,
            this.colTotalKDV,
            this.colTotalAraToplam,
            this.colTotalSiparis,
            this.colDeleted,
            this.colIrsaliyeId});
            this.gcv_OrderList.GridControl = this.gc_OrderList;
            this.gcv_OrderList.Name = "gcv_OrderList";
            this.gcv_OrderList.OptionsBehavior.Editable = false;
            this.gcv_OrderList.OptionsView.ColumnAutoWidth = false;
            this.gcv_OrderList.OptionsView.ShowAutoFilterRow = true;
            this.gcv_OrderList.OptionsView.ShowFooter = true;
            this.gcv_OrderList.OptionsView.ShowGroupPanel = false;
            this.gcv_OrderList.DoubleClick += new System.EventHandler(this.gcv_OrderList_DoubleClick);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            // 
            // colCariRecId
            // 
            this.colCariRecId.Caption = "Cari Hesap";
            this.colCariRecId.ColumnEdit = this.rp_CariHesap;
            this.colCariRecId.FieldName = "CariRecId";
            this.colCariRecId.Name = "colCariRecId";
            this.colCariRecId.Visible = true;
            this.colCariRecId.VisibleIndex = 0;
            this.colCariRecId.Width = 86;
            // 
            // rp_CariHesap
            // 
            this.rp_CariHesap.AutoHeight = false;
            this.rp_CariHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_CariHesap.DataSource = this.bs_CariHesap;
            this.rp_CariHesap.DisplayMember = "CurAccountName";
            this.rp_CariHesap.Name = "rp_CariHesap";
            this.rp_CariHesap.NullText = "";
            this.rp_CariHesap.ValueMember = "CurID";
            // 
            // colOrderType
            // 
            this.colOrderType.Caption = "Sipariş Tipi";
            this.colOrderType.ColumnEdit = this.rp_OrderType;
            this.colOrderType.FieldName = "OrderType";
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.Visible = true;
            this.colOrderType.VisibleIndex = 1;
            this.colOrderType.Width = 90;
            // 
            // rp_OrderType
            // 
            this.rp_OrderType.AutoHeight = false;
            this.rp_OrderType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_OrderType.Name = "rp_OrderType";
            this.rp_OrderType.NullText = "";
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "İşyeri";
            this.colCompanyId.ColumnEdit = this.rp_Company;
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 2;
            this.colCompanyId.Width = 45;
            // 
            // rp_Company
            // 
            this.rp_Company.AutoHeight = false;
            this.rp_Company.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_Company.DataSource = this.bs_company;
            this.rp_Company.DisplayMember = "CompanyName";
            this.rp_Company.Name = "rp_Company";
            this.rp_Company.ValueMember = "RecId";
            // 
            // colSiparisNo
            // 
            this.colSiparisNo.Caption = "Sipariş No";
            this.colSiparisNo.FieldName = "SiparisNo";
            this.colSiparisNo.Name = "colSiparisNo";
            this.colSiparisNo.Visible = true;
            this.colSiparisNo.VisibleIndex = 3;
            this.colSiparisNo.Width = 45;
            // 
            // colSiparisDate
            // 
            this.colSiparisDate.Caption = "Sipariş Tarihi";
            this.colSiparisDate.FieldName = "SiparisDate";
            this.colSiparisDate.Name = "colSiparisDate";
            this.colSiparisDate.Visible = true;
            this.colSiparisDate.VisibleIndex = 4;
            this.colSiparisDate.Width = 45;
            // 
            // colSiparisTime
            // 
            this.colSiparisTime.Caption = "Sipariş Saati";
            this.colSiparisTime.FieldName = "SiparisTime";
            this.colSiparisTime.Name = "colSiparisTime";
            this.colSiparisTime.Visible = true;
            this.colSiparisTime.VisibleIndex = 5;
            this.colSiparisTime.Width = 45;
            // 
            // colOzelKod
            // 
            this.colOzelKod.Caption = "Özel Kod";
            this.colOzelKod.FieldName = "OzelKod";
            this.colOzelKod.Name = "colOzelKod";
            this.colOzelKod.Visible = true;
            this.colOzelKod.VisibleIndex = 6;
            this.colOzelKod.Width = 45;
            // 
            // colDovizId
            // 
            this.colDovizId.Caption = "Döviz";
            this.colDovizId.ColumnEdit = this.rp_Doviz;
            this.colDovizId.FieldName = "DovizId";
            this.colDovizId.Name = "colDovizId";
            this.colDovizId.Visible = true;
            this.colDovizId.VisibleIndex = 7;
            this.colDovizId.Width = 45;
            // 
            // rp_Doviz
            // 
            this.rp_Doviz.AutoHeight = false;
            this.rp_Doviz.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_Doviz.DataSource = this.bs_CurrencyType;
            this.rp_Doviz.DisplayMember = "CurrencyCode";
            this.rp_Doviz.Name = "rp_Doviz";
            this.rp_Doviz.NullText = "";
            this.rp_Doviz.ValueMember = "RecId";
            // 
            // colKDVId
            // 
            this.colKDVId.Caption = "KDV";
            this.colKDVId.FieldName = "Kdv";
            this.colKDVId.Name = "colKDVId";
            this.colKDVId.Visible = true;
            this.colKDVId.VisibleIndex = 8;
            this.colKDVId.Width = 45;
            // 
            // colIskonto
            // 
            this.colIskonto.FieldName = "Iskonto";
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.Visible = true;
            this.colIskonto.VisibleIndex = 9;
            this.colIskonto.Width = 45;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 10;
            this.colDurum.Width = 45;
            // 
            // colTeklifSiparis
            // 
            this.colTeklifSiparis.Caption = "Türü";
            this.colTeklifSiparis.ColumnEdit = this.rp_TeklifSiparis;
            this.colTeklifSiparis.FieldName = "TeklifSiparis";
            this.colTeklifSiparis.Name = "colTeklifSiparis";
            this.colTeklifSiparis.Visible = true;
            this.colTeklifSiparis.VisibleIndex = 11;
            this.colTeklifSiparis.Width = 45;
            // 
            // rp_TeklifSiparis
            // 
            this.rp_TeklifSiparis.AutoHeight = false;
            this.rp_TeklifSiparis.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_TeklifSiparis.Name = "rp_TeklifSiparis";
            this.rp_TeklifSiparis.NullText = "";
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Açıklama";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 12;
            this.colRemark.Width = 45;
            // 
            // colTotalToplam
            // 
            this.colTotalToplam.DisplayFormat.FormatString = "n2";
            this.colTotalToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalToplam.FieldName = "TotalToplam";
            this.colTotalToplam.Name = "colTotalToplam";
            this.colTotalToplam.Visible = true;
            this.colTotalToplam.VisibleIndex = 13;
            this.colTotalToplam.Width = 45;
            // 
            // colTotalIskonto
            // 
            this.colTotalIskonto.DisplayFormat.FormatString = "n2";
            this.colTotalIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalIskonto.FieldName = "TotalIskonto";
            this.colTotalIskonto.Name = "colTotalIskonto";
            this.colTotalIskonto.Visible = true;
            this.colTotalIskonto.VisibleIndex = 14;
            this.colTotalIskonto.Width = 45;
            // 
            // colTotalKDV
            // 
            this.colTotalKDV.DisplayFormat.FormatString = "n2";
            this.colTotalKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalKDV.FieldName = "TotalKDV";
            this.colTotalKDV.Name = "colTotalKDV";
            this.colTotalKDV.Visible = true;
            this.colTotalKDV.VisibleIndex = 15;
            this.colTotalKDV.Width = 45;
            // 
            // colTotalAraToplam
            // 
            this.colTotalAraToplam.DisplayFormat.FormatString = "n2";
            this.colTotalAraToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAraToplam.FieldName = "TotalAraToplam";
            this.colTotalAraToplam.Name = "colTotalAraToplam";
            this.colTotalAraToplam.Visible = true;
            this.colTotalAraToplam.VisibleIndex = 18;
            // 
            // colTotalSiparis
            // 
            this.colTotalSiparis.DisplayFormat.FormatString = "n2";
            this.colTotalSiparis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSiparis.FieldName = "TotalSiparis";
            this.colTotalSiparis.Name = "colTotalSiparis";
            this.colTotalSiparis.Visible = true;
            this.colTotalSiparis.VisibleIndex = 19;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 16;
            this.colDeleted.Width = 82;
            // 
            // colIrsaliyeId
            // 
            this.colIrsaliyeId.FieldName = "IrsaliyeId";
            this.colIrsaliyeId.Name = "colIrsaliyeId";
            this.colIrsaliyeId.Visible = true;
            this.colIrsaliyeId.VisibleIndex = 17;
            // 
            // bs_company
            // 
            this.bs_company.DataSource = typeof(Msp.Models.Models.CompanyDTO);
            // 
            // bs_CariHesap
            // 
            this.bs_CariHesap.DataSource = typeof(Msp.Models.Models.CTransactionsDTO);
            // 
            // bs_CurrencyType
            // 
            this.bs_CurrencyType.DataSource = typeof(Msp.Models.Models.CurrencyTypeDTO);
            // 
            // bs_Unit
            // 
            this.bs_Unit.DataSource = typeof(Msp.Models.Models.UnitsDTO);
            // 
            // FindOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.gc_OrderList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FindOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Cağır";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindOrderList_FormClosing);
            this.Load += new System.EventHandler(this.FindOrderList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindOrderList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_CariHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_OrderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Doviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_TeklifSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CariHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CurrencyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_select;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraGrid.GridControl gc_OrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_OrderList;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colCariRecId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_CariHesap;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_OrderType;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_Company;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod;
        private DevExpress.XtraGrid.Columns.GridColumn colDovizId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_Doviz;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVId;
        private DevExpress.XtraGrid.Columns.GridColumn colIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifSiparis;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_TeklifSiparis;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAraToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSiparis;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colIrsaliyeId;
        private System.Windows.Forms.BindingSource bs_OrderList;
        private System.Windows.Forms.BindingSource bs_CariHesap;
        private System.Windows.Forms.BindingSource bs_company;
        private System.Windows.Forms.BindingSource bs_CurrencyType;
        private System.Windows.Forms.BindingSource bs_Unit;
    }
}