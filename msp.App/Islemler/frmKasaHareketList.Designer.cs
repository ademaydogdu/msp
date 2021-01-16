namespace Msp.App.Islemler
{
    partial class frmKasaHareketList
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
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAddNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnViewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bt = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnProQuickChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnProBarcodeLabel = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bs_CaseMov = new System.Windows.Forms.BindingSource(this.components);
            this.colCaseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoviz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CaseMov)).BeginInit();
            this.SuspendLayout();
            // 
            // img_bar
            // 
            this.img_bar.ImageSize = new System.Drawing.Size(32, 32);
            this.img_bar.Add("bo_validation", "image://svgimages/business objects/bo_validation.svg");
            this.img_bar.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.img_bar.Add("bo_address", "image://svgimages/business objects/bo_address.svg");
            this.img_bar.Add("bo_contact", "image://svgimages/business objects/bo_contact.svg");
            this.img_bar.Add("bo_customer", "image://svgimages/business objects/bo_customer.svg");
            this.img_bar.Add("bo_department", "image://svgimages/business objects/bo_department.svg");
            this.img_bar.Add("bo_lead", "image://svgimages/business objects/bo_lead.svg");
            this.img_bar.Add("bo_mydetails", "image://svgimages/business objects/bo_mydetails.svg");
            this.img_bar.Add("bo_phone", "image://svgimages/business objects/bo_phone.svg");
            this.img_bar.Add("bo_position_v92", "image://svgimages/business objects/bo_position_v92.svg");
            this.img_bar.Add("bo_user", "image://svgimages/business objects/bo_user.svg");
            this.img_bar.Add("bo_validation_1", "image://svgimages/business objects/bo_validation.svg");
            this.img_bar.Add("shapelabels", "image://svgimages/dashboards/shapelabels.svg");
            this.img_bar.Add("about", "image://svgimages/outlook inspired/about.svg");
            this.img_bar.Add("clearformatting", "image://svgimages/outlook inspired/clearformatting.svg");
            this.img_bar.Add("costanalysis", "image://svgimages/outlook inspired/costanalysis.svg");
            this.img_bar.Add("fax", "image://svgimages/outlook inspired/fax.svg");
            this.img_bar.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.img_bar.Add("highimportance", "image://svgimages/outlook inspired/highimportance.svg");
            this.img_bar.Add("mapit", "image://svgimages/outlook inspired/mapit.svg");
            this.img_bar.Add("markcomplete", "image://svgimages/outlook inspired/markcomplete.svg");
            this.img_bar.Add("newcustomer", "image://svgimages/outlook inspired/newcustomer.svg");
            this.img_bar.Add("newemployee", "image://svgimages/outlook inspired/newemployee.svg");
            this.img_bar.Add("tabletoffice", "image://svgimages/outlook inspired/tabletoffice.svg");
            this.img_bar.Add("highlight", "image://svgimages/pdf viewer/highlight.svg");
            this.img_bar.Add("barcodeshowtext", "image://svgimages/reports/barcodeshowtext.svg");
            this.img_bar.Add("changetextcase", "image://svgimages/richedit/changetextcase.svg");
            this.img_bar.Add("general", "image://svgimages/spreadsheet/general.svg");
            this.img_bar.Add("warning", "image://svgimages/status/warning.svg");
            this.img_bar.Add("customerquicklocations", "image://svgimages/outlook inspired/customerquicklocations.svg");
            this.img_bar.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            this.img_bar.Add("insertbubblemap", "image://svgimages/dashboards/insertbubblemap.svg");
            this.img_bar.Add("insertpiemap", "image://svgimages/dashboards/insertpiemap.svg");
            this.img_bar.Add("highimportance_1", "image://svgimages/scheduling/highimportance.svg");
            this.img_bar.Add("timezones", "image://svgimages/scheduling/timezones.svg");
            this.img_bar.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg");
            this.img_bar.Add("bo_document", "image://svgimages/business objects/bo_document.svg");
            this.img_bar.Add("bo_attention", "image://svgimages/business objects/bo_attention.svg");
            this.img_bar.Add("percentstyle", "image://svgimages/spreadsheet/percentstyle.svg");
            this.img_bar.Add("bo_audit_changehistory", "image://svgimages/business objects/bo_audit_changehistory.svg");
            this.img_bar.Add("bottom10percent", "image://svgimages/spreadsheet/bottom10percent.svg");
            this.img_bar.Add("card", "image://svgimages/outlook inspired/card.svg");
            this.img_bar.Add("bo_contact_1", "image://svgimages/business objects/bo_contact.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.img_bar.Add("deletedatasource", "image://svgimages/dashboards/deletedatasource.svg");
            this.img_bar.Add("updatedataextract", "image://svgimages/dashboards/updatedataextract.svg");
            this.img_bar.Add("newdatasource", "image://svgimages/dashboards/newdatasource.svg");
            this.img_bar.Add("managedatasource", "image://svgimages/spreadsheet/managedatasource.svg");
            this.img_bar.Add("editdatasource", "image://svgimages/dashboards/editdatasource.svg");
            this.img_bar.Add("datasource", "image://svgimages/snap/datasource.svg");
            this.img_bar.Add("bo_attention_1", "image://svgimages/business objects/bo_attention.svg");
            this.img_bar.Add("bo_price", "image://svgimages/business objects/bo_price.svg");
            this.img_bar.Add("bo_price_item", "image://svgimages/business objects/bo_price_item.svg");
            this.img_bar.Add("buynow", "image://svgimages/outlook inspired/buynow.svg");
            this.img_bar.Add("categorize", "image://svgimages/outlook inspired/categorize.svg");
            this.img_bar.Add("group", "image://svgimages/dashboards/group.svg");
            this.img_bar.Add("bo_sale", "image://svgimages/business objects/bo_sale.svg");
            this.img_bar.Add("sales", "image://svgimages/outlook inspired/sales.svg");
            this.img_bar.Add("bo_sale_item", "image://svgimages/business objects/bo_sale_item.svg");
            this.img_bar.Add("weightedpies", "image://svgimages/dashboards/weightedpies.svg");
            this.img_bar.Add("bo_product", "image://svgimages/business objects/bo_product.svg");
            this.img_bar.Add("bo_product_group", "image://svgimages/business objects/bo_product_group.svg");
            this.img_bar.Add("shipmentreceived", "image://svgimages/outlook inspired/shipmentreceived.svg");
            this.img_bar.Add("bo_quote", "image://svgimages/business objects/bo_quote.svg");
            this.img_bar.Add("longdate", "image://svgimages/spreadsheet/longdate.svg");
            this.img_bar.Add("delete", "image://svgimages/scheduling/delete.svg");
            this.img_bar.Add("delete_1", "image://svgimages/scheduling/delete.svg");
            this.img_bar.Add("text", "image://svgimages/spreadsheet/text.svg");
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
            this.btnCustomerRefresh,
            this.btnAddNewCustomer,
            this.btnEditCustomer,
            this.btnViewProduct,
            this.btnRemCustomer,
            this.bt,
            this.btnSeaCustomer,
            this.btnCustomerTransactions,
            this.btnProQuickChange,
            this.btnProBarcodeLabel,
            this.btnCustomerClose,
            this.barToggleSwitchItem1,
            this.barHeaderItem1,
            this.barDockingMenuItem1,
            this.barToolbarsListItem1,
            this.barSubItem1,
            this.barEditItem1,
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 19;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerClose, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Caption = "Yeni Ürün";
            this.btnAddNewCustomer.Id = 1;
            this.btnAddNewCustomer.ImageOptions.ImageIndex = 46;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewCustomer_ItemClick);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Caption = "Düzelt";
            this.btnEditCustomer.Id = 2;
            this.btnEditCustomer.ImageOptions.ImageIndex = 48;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditCustomer_ItemClick);
            // 
            // btnRemCustomer
            // 
            this.btnRemCustomer.Caption = "Ürün Sil";
            this.btnRemCustomer.Id = 4;
            this.btnRemCustomer.ImageOptions.ImageIndex = 44;
            this.btnRemCustomer.Name = "btnRemCustomer";
            // 
            // btnCustomerRefresh
            // 
            this.btnCustomerRefresh.Caption = "Yenile";
            this.btnCustomerRefresh.Id = 0;
            this.btnCustomerRefresh.ImageOptions.ImageIndex = 43;
            this.btnCustomerRefresh.Name = "btnCustomerRefresh";
            this.btnCustomerRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerRefresh_ItemClick);
            // 
            // btnCustomerClose
            // 
            this.btnCustomerClose.Caption = "Kapat";
            this.btnCustomerClose.Id = 10;
            this.btnCustomerClose.ImageOptions.ImageIndex = 1;
            this.btnCustomerClose.Name = "btnCustomerClose";
            this.btnCustomerClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(713, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(713, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(713, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Caption = "Ürün İncele";
            this.btnViewProduct.Id = 3;
            this.btnViewProduct.ImageOptions.ImageIndex = 3;
            this.btnViewProduct.Name = "btnViewProduct";
            // 
            // bt
            // 
            this.bt.Caption = "Ürün Sil";
            this.bt.Id = 5;
            this.bt.ImageOptions.ImageIndex = 5;
            this.bt.Name = "bt";
            // 
            // btnSeaCustomer
            // 
            this.btnSeaCustomer.Caption = "Ürün Bul";
            this.btnSeaCustomer.Id = 6;
            this.btnSeaCustomer.ImageOptions.ImageIndex = 6;
            this.btnSeaCustomer.Name = "btnSeaCustomer";
            // 
            // btnCustomerTransactions
            // 
            this.btnCustomerTransactions.Caption = "Ürün Hareketleri";
            this.btnCustomerTransactions.Id = 7;
            this.btnCustomerTransactions.ImageOptions.ImageIndex = 7;
            this.btnCustomerTransactions.Name = "btnCustomerTransactions";
            // 
            // btnProQuickChange
            // 
            this.btnProQuickChange.Caption = "Hızlı Değiştir";
            this.btnProQuickChange.Id = 8;
            this.btnProQuickChange.ImageOptions.ImageIndex = 8;
            this.btnProQuickChange.Name = "btnProQuickChange";
            // 
            // btnProBarcodeLabel
            // 
            this.btnProBarcodeLabel.Caption = "Barkod Etiket";
            this.btnProBarcodeLabel.Id = 9;
            this.btnProBarcodeLabel.ImageOptions.ImageIndex = 9;
            this.btnProBarcodeLabel.Name = "btnProBarcodeLabel";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 11;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 12;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 13;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 14;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 15;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemMarqueeProgressBar1;
            this.barEditItem1.Id = 16;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Müşteri Veresiye Defteri";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.ImageOptions.ImageIndex = 67;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Yazdır";
            this.barButtonItem2.Id = 18;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_CaseMov;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(713, 454);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCaseId,
            this.colRecordDate,
            this.colVadeDate,
            this.colVadeMonth,
            this.colEvrakNo,
            this.colDoviz,
            this.colIslemTuru,
            this.colTutar,
            this.colOdemeTuru,
            this.colOdemeGrubu,
            this.colRemark,
            this.colCariId,
            this.colDeleted,
            this.colCompanyRecId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bs_CaseMov
            // 
            this.bs_CaseMov.DataSource = typeof(Msp.Models.Models.Case.CaseMovementDTO);
            // 
            // colCaseId
            // 
            this.colCaseId.FieldName = "CaseId";
            this.colCaseId.Name = "colCaseId";
            this.colCaseId.Visible = true;
            this.colCaseId.VisibleIndex = 0;
            // 
            // colRecordDate
            // 
            this.colRecordDate.FieldName = "RecordDate";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.Visible = true;
            this.colRecordDate.VisibleIndex = 1;
            // 
            // colVadeDate
            // 
            this.colVadeDate.FieldName = "VadeDate";
            this.colVadeDate.Name = "colVadeDate";
            this.colVadeDate.Visible = true;
            this.colVadeDate.VisibleIndex = 2;
            // 
            // colVadeMonth
            // 
            this.colVadeMonth.FieldName = "VadeMonth";
            this.colVadeMonth.Name = "colVadeMonth";
            this.colVadeMonth.Visible = true;
            this.colVadeMonth.VisibleIndex = 3;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 4;
            // 
            // colDoviz
            // 
            this.colDoviz.FieldName = "Doviz";
            this.colDoviz.Name = "colDoviz";
            this.colDoviz.Visible = true;
            this.colDoviz.VisibleIndex = 5;
            // 
            // colIslemTuru
            // 
            this.colIslemTuru.FieldName = "IslemTuru";
            this.colIslemTuru.Name = "colIslemTuru";
            this.colIslemTuru.Visible = true;
            this.colIslemTuru.VisibleIndex = 6;
            // 
            // colTutar
            // 
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.FieldName = "OdemeTuru";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 8;
            // 
            // colOdemeGrubu
            // 
            this.colOdemeGrubu.FieldName = "OdemeGrubu";
            this.colOdemeGrubu.Name = "colOdemeGrubu";
            this.colOdemeGrubu.Visible = true;
            this.colOdemeGrubu.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
            // 
            // colCariId
            // 
            this.colCariId.FieldName = "CariId";
            this.colCariId.Name = "colCariId";
            this.colCariId.Visible = true;
            this.colCariId.VisibleIndex = 11;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 12;
            // 
            // colCompanyRecId
            // 
            this.colCompanyRecId.FieldName = "CompanyRecId";
            this.colCompanyRecId.Name = "colCompanyRecId";
            this.colCompanyRecId.Visible = true;
            this.colCompanyRecId.VisibleIndex = 13;
            // 
            // frmKasaHareketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 496);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKasaHareketList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKasaHareketList_FormClosing);
            this.Load += new System.EventHandler(this.frmKasaHareketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CaseMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAddNewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnEditCustomer;
        private DevExpress.XtraBars.BarButtonItem btnRemCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCustomerRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCustomerClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnViewProduct;
        private DevExpress.XtraBars.BarButtonItem bt;
        private DevExpress.XtraBars.BarButtonItem btnSeaCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCustomerTransactions;
        private DevExpress.XtraBars.BarButtonItem btnProQuickChange;
        private DevExpress.XtraBars.BarButtonItem btnProBarcodeLabel;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bs_CaseMov;
        private DevExpress.XtraGrid.Columns.GridColumn colCaseId;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDoviz;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colCariId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyRecId;
    }
}