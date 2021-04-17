namespace Msp.App.Musteri_Islemleri
{
    partial class frmCustomer
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.bs_Customers = new System.Windows.Forms.BindingSource(this.components);
            this.gcvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.svgImageCollection2 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAddNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_VeresiyeDefter = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdCustomers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.svgImageCollection2;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdCustomers
            // 
            this.grdCustomers.DataSource = this.bs_Customers;
            this.grdCustomers.Location = new System.Drawing.Point(12, 12);
            this.grdCustomers.MainView = this.gcvCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(776, 384);
            this.grdCustomers.TabIndex = 4;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcvCustomers});
            // 
            // bs_Customers
            // 
            this.bs_Customers.DataSource = typeof(Msp.Models.Models.CustomersDTO);
            // 
            // gcvCustomers
            // 
            this.gcvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colsurname,
            this.coladdress,
            this.colphone,
            this.colactive,
            this.coldate});
            this.gcvCustomers.GridControl = this.grdCustomers;
            this.gcvCustomers.Name = "gcvCustomers";
            this.gcvCustomers.OptionsBehavior.Editable = false;
            this.gcvCustomers.OptionsView.ColumnAutoWidth = false;
            this.gcvCustomers.OptionsView.ShowAutoFilterRow = true;
            this.gcvCustomers.OptionsView.ShowGroupPanel = false;
            this.gcvCustomers.DoubleClick += new System.EventHandler(this.gcvCustomers_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "Ad";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colsurname
            // 
            this.colsurname.Caption = "Soyad";
            this.colsurname.FieldName = "surname";
            this.colsurname.Name = "colsurname";
            this.colsurname.Visible = true;
            this.colsurname.VisibleIndex = 1;
            // 
            // coladdress
            // 
            this.coladdress.Caption = "Adres";
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 2;
            // 
            // colphone
            // 
            this.colphone.Caption = "Telefon";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 3;
            // 
            // colactive
            // 
            this.colactive.Caption = "Aktiflik Durumu";
            this.colactive.FieldName = "active";
            this.colactive.Name = "colactive";
            this.colactive.Visible = true;
            this.colactive.VisibleIndex = 4;
            // 
            // coldate
            // 
            this.coldate.Caption = "Tarih";
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 5;
            // 
            // svgImageCollection2
            // 
            this.svgImageCollection2.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection2.Add("bo_validation", "image://svgimages/business objects/bo_validation.svg");
            this.svgImageCollection2.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.svgImageCollection2.Add("bo_address", "image://svgimages/business objects/bo_address.svg");
            this.svgImageCollection2.Add("bo_contact", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection2.Add("bo_customer", "image://svgimages/business objects/bo_customer.svg");
            this.svgImageCollection2.Add("bo_department", "image://svgimages/business objects/bo_department.svg");
            this.svgImageCollection2.Add("bo_lead", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection2.Add("bo_mydetails", "image://svgimages/business objects/bo_mydetails.svg");
            this.svgImageCollection2.Add("bo_phone", "image://svgimages/business objects/bo_phone.svg");
            this.svgImageCollection2.Add("bo_position_v92", "image://svgimages/business objects/bo_position_v92.svg");
            this.svgImageCollection2.Add("bo_user", "image://svgimages/business objects/bo_user.svg");
            this.svgImageCollection2.Add("bo_validation_1", "image://svgimages/business objects/bo_validation.svg");
            this.svgImageCollection2.Add("shapelabels", "image://svgimages/dashboards/shapelabels.svg");
            this.svgImageCollection2.Add("about", "image://svgimages/outlook inspired/about.svg");
            this.svgImageCollection2.Add("clearformatting", "image://svgimages/outlook inspired/clearformatting.svg");
            this.svgImageCollection2.Add("costanalysis", "image://svgimages/outlook inspired/costanalysis.svg");
            this.svgImageCollection2.Add("fax", "image://svgimages/outlook inspired/fax.svg");
            this.svgImageCollection2.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.svgImageCollection2.Add("highimportance", "image://svgimages/outlook inspired/highimportance.svg");
            this.svgImageCollection2.Add("mapit", "image://svgimages/outlook inspired/mapit.svg");
            this.svgImageCollection2.Add("markcomplete", "image://svgimages/outlook inspired/markcomplete.svg");
            this.svgImageCollection2.Add("newcustomer", "image://svgimages/outlook inspired/newcustomer.svg");
            this.svgImageCollection2.Add("newemployee", "image://svgimages/outlook inspired/newemployee.svg");
            this.svgImageCollection2.Add("tabletoffice", "image://svgimages/outlook inspired/tabletoffice.svg");
            this.svgImageCollection2.Add("highlight", "image://svgimages/pdf viewer/highlight.svg");
            this.svgImageCollection2.Add("barcodeshowtext", "image://svgimages/reports/barcodeshowtext.svg");
            this.svgImageCollection2.Add("changetextcase", "image://svgimages/richedit/changetextcase.svg");
            this.svgImageCollection2.Add("general", "image://svgimages/spreadsheet/general.svg");
            this.svgImageCollection2.Add("warning", "image://svgimages/status/warning.svg");
            this.svgImageCollection2.Add("customerquicklocations", "image://svgimages/outlook inspired/customerquicklocations.svg");
            this.svgImageCollection2.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            this.svgImageCollection2.Add("insertbubblemap", "image://svgimages/dashboards/insertbubblemap.svg");
            this.svgImageCollection2.Add("insertpiemap", "image://svgimages/dashboards/insertpiemap.svg");
            this.svgImageCollection2.Add("highimportance_1", "image://svgimages/scheduling/highimportance.svg");
            this.svgImageCollection2.Add("timezones", "image://svgimages/scheduling/timezones.svg");
            this.svgImageCollection2.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg");
            this.svgImageCollection2.Add("bo_document", "image://svgimages/business objects/bo_document.svg");
            this.svgImageCollection2.Add("bo_attention", "image://svgimages/business objects/bo_attention.svg");
            this.svgImageCollection2.Add("percentstyle", "image://svgimages/spreadsheet/percentstyle.svg");
            this.svgImageCollection2.Add("bo_audit_changehistory", "image://svgimages/business objects/bo_audit_changehistory.svg");
            this.svgImageCollection2.Add("bottom10percent", "image://svgimages/spreadsheet/bottom10percent.svg");
            this.svgImageCollection2.Add("card", "image://svgimages/outlook inspired/card.svg");
            this.svgImageCollection2.Add("bo_contact_1", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection2.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.svgImageCollection2.Add("deletedatasource", "image://svgimages/dashboards/deletedatasource.svg");
            this.svgImageCollection2.Add("updatedataextract", "image://svgimages/dashboards/updatedataextract.svg");
            this.svgImageCollection2.Add("newdatasource", "image://svgimages/dashboards/newdatasource.svg");
            this.svgImageCollection2.Add("managedatasource", "image://svgimages/spreadsheet/managedatasource.svg");
            this.svgImageCollection2.Add("editdatasource", "image://svgimages/dashboards/editdatasource.svg");
            this.svgImageCollection2.Add("datasource", "image://svgimages/snap/datasource.svg");
            this.svgImageCollection2.Add("bo_attention_1", "image://svgimages/business objects/bo_attention.svg");
            this.svgImageCollection2.Add("bo_price", "image://svgimages/business objects/bo_price.svg");
            this.svgImageCollection2.Add("bo_price_item", "image://svgimages/business objects/bo_price_item.svg");
            this.svgImageCollection2.Add("buynow", "image://svgimages/outlook inspired/buynow.svg");
            this.svgImageCollection2.Add("categorize", "image://svgimages/outlook inspired/categorize.svg");
            this.svgImageCollection2.Add("group", "image://svgimages/dashboards/group.svg");
            this.svgImageCollection2.Add("bo_sale", "image://svgimages/business objects/bo_sale.svg");
            this.svgImageCollection2.Add("sales", "image://svgimages/outlook inspired/sales.svg");
            this.svgImageCollection2.Add("bo_sale_item", "image://svgimages/business objects/bo_sale_item.svg");
            this.svgImageCollection2.Add("weightedpies", "image://svgimages/dashboards/weightedpies.svg");
            this.svgImageCollection2.Add("bo_product", "image://svgimages/business objects/bo_product.svg");
            this.svgImageCollection2.Add("bo_product_group", "image://svgimages/business objects/bo_product_group.svg");
            this.svgImageCollection2.Add("shipmentreceived", "image://svgimages/outlook inspired/shipmentreceived.svg");
            this.svgImageCollection2.Add("bo_quote", "image://svgimages/business objects/bo_quote.svg");
            this.svgImageCollection2.Add("longdate", "image://svgimages/spreadsheet/longdate.svg");
            this.svgImageCollection2.Add("delete", "image://svgimages/scheduling/delete.svg");
            this.svgImageCollection2.Add("delete_1", "image://svgimages/scheduling/delete.svg");
            this.svgImageCollection2.Add("text", "image://svgimages/spreadsheet/text.svg");
            this.svgImageCollection2.Add("print", "image://svgimages/dashboards/print.svg");
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 408);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCustomers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 388);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.barManager1.Images = this.svgImageCollection2;
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
            this.bbi_VeresiyeDefter,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerClose, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_VeresiyeDefter, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Caption = "Yeni Müşteri";
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
            this.btnRemCustomer.Caption = "Müşteri Sil";
            this.btnRemCustomer.Id = 4;
            this.btnRemCustomer.ImageOptions.ImageIndex = 44;
            this.btnRemCustomer.Name = "btnRemCustomer";
            this.btnRemCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemCustomer_ItemClick);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Yazdır";
            this.barButtonItem2.Id = 18;
            this.barButtonItem2.ImageOptions.ImageIndex = 68;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bbi_VeresiyeDefter
            // 
            this.bbi_VeresiyeDefter.Caption = "Müşteri Veresiye Defteri";
            this.bbi_VeresiyeDefter.Id = 17;
            this.bbi_VeresiyeDefter.ImageOptions.ImageIndex = 67;
            this.bbi_VeresiyeDefter.Name = "bbi_VeresiyeDefter";
            this.bbi_VeresiyeDefter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_VeresiyeDefter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_VeresiyeDefter_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
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
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gcvCustomers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bs_Customers;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colsurname;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn colactive;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnCustomerRefresh;
        private DevExpress.XtraBars.BarButtonItem btnAddNewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnRemCustomer;
        private DevExpress.XtraBars.BarButtonItem btnEditCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSeaCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCustomerTransactions;
        private DevExpress.XtraBars.BarButtonItem btnCustomerClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnViewProduct;
        private DevExpress.XtraBars.BarButtonItem bt;
        private DevExpress.XtraBars.BarButtonItem btnProQuickChange;
        private DevExpress.XtraBars.BarButtonItem btnProBarcodeLabel;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection2;
        private DevExpress.XtraBars.BarButtonItem bbi_VeresiyeDefter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}