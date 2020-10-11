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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnCustomerRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnViewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bt = new DevExpress.XtraBars.BarButtonItem();
            this.btnProQuickChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnProBarcodeLabel = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdCustomers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gcvCustomers.OptionsView.ShowAutoFilterRow = true;
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
            this.barManager1.Images = this.svgImageCollection1;
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
            this.barEditItem1});
            this.barManager1.MaxItemId = 17;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnCustomerRefresh
            // 
            this.btnCustomerRefresh.Caption = "Yenile";
            this.btnCustomerRefresh.Id = 0;
            this.btnCustomerRefresh.ImageOptions.ImageIndex = 34;
            this.btnCustomerRefresh.Name = "btnCustomerRefresh";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Caption = "Yeni Ürün";
            this.btnAddNewCustomer.Id = 1;
            this.btnAddNewCustomer.ImageOptions.ImageIndex = 31;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            // 
            // btnRemCustomer
            // 
            this.btnRemCustomer.Caption = "Ürün Sil";
            this.btnRemCustomer.Id = 4;
            this.btnRemCustomer.ImageOptions.ImageIndex = 11;
            this.btnRemCustomer.Name = "btnRemCustomer";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Caption = "Düzelt";
            this.btnEditCustomer.Id = 2;
            this.btnEditCustomer.ImageOptions.ImageIndex = 10;
            this.btnEditCustomer.Name = "btnEditCustomer";
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
            // btnCustomerClose
            // 
            this.btnCustomerClose.Caption = "Kapat";
            this.btnCustomerClose.Id = 10;
            this.btnCustomerClose.ImageOptions.ImageIndex = 18;
            this.btnCustomerClose.Name = "btnCustomerClose";
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
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("statistics-document-svgrepo-com", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.statistics-document-svgrepo-com"))));
            this.svgImageCollection1.Add("alcaline_spiral_calendar", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.alcaline_spiral_calendar"))));
            this.svgImageCollection1.Add("primary-percent", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-percent"))));
            this.svgImageCollection1.Add("ftpercent", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.ftpercent"))));
            this.svgImageCollection1.Add("Architetto----Calcolatrice", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Architetto----Calcolatrice"))));
            this.svgImageCollection1.Add("calculator", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.calculator"))));
            this.svgImageCollection1.Add("kuba-icon-delete", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.kuba-icon-delete"))));
            this.svgImageCollection1.Add("1550775830", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1550775830"))));
            this.svgImageCollection1.Add("tag (1)", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tag (1)"))));
            this.svgImageCollection1.Add("1307548250", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1307548250"))));
            this.svgImageCollection1.Add("1298512738", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1298512738"))));
            this.svgImageCollection1.Add("Remove-349235435", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Remove-349235435"))));
            this.svgImageCollection1.Add("tag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tag"))));
            this.svgImageCollection1.Add("eastshores_Warning_Notification", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.eastshores_Warning_Notification"))));
            this.svgImageCollection1.Add("Warning", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Warning"))));
            this.svgImageCollection1.Add("warning-17", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.warning-17"))));
            this.svgImageCollection1.Add("tasto-8-architetto-franc-01", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tasto-8-architetto-franc-01"))));
            this.svgImageCollection1.Add("jean_victor_balin_cross", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.jean_victor_balin_cross"))));
            this.svgImageCollection1.Add("molumen_red_round_error_warning_icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.molumen_red_round_error_warning_icon"))));
            this.svgImageCollection1.Add("error-button", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.error-button"))));
            this.svgImageCollection1.Add("map-pin", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.map-pin"))));
            this.svgImageCollection1.Add("color-icons-green-home", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.color-icons-green-home"))));
            this.svgImageCollection1.Add("1392496432", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1392496432"))));
            this.svgImageCollection1.Add("green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.green"))));
            this.svgImageCollection1.Add("location_icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.location_icon"))));
            this.svgImageCollection1.Add("1328388231", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1328388231"))));
            this.svgImageCollection1.Add("Android-Phone-1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Android-Phone-1"))));
            this.svgImageCollection1.Add("matt-icons_contact-add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.matt-icons_contact-add"))));
            this.svgImageCollection1.Add("Planned-obsolescence-barcode-in-squarre---French", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Planned-obsolescence-barcode-in-squarre---French"))));
            this.svgImageCollection1.Add("rodentia-icons_ok", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.rodentia-icons_ok"))));
            this.svgImageCollection1.Add("primary-apply", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-apply"))));
            this.svgImageCollection1.Add("jean_victor_balin_add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.jean_victor_balin_add"))));
            this.svgImageCollection1.Add("primary-tab-new", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-tab-new"))));
            this.svgImageCollection1.Add("positive", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.positive"))));
            this.svgImageCollection1.Add("view-refresh", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.view-refresh"))));
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
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
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}