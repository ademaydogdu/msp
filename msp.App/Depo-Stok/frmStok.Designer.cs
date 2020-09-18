namespace Msp.App.Depo_Stok
{
    partial class frmStok
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
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.bs_products = new System.Windows.Forms.BindingSource(this.components);
            this.gcvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFirstPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPVarDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSpecCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrandCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnProductsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnProTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnProQuickChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnProBarcodeLabel = new DevExpress.XtraBars.BarButtonItem();
            this.btnProClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.btnViewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bt = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcProducts);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 654);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcProducts
            // 
            this.gcProducts.DataSource = this.bs_products;
            this.gcProducts.Location = new System.Drawing.Point(12, 12);
            this.gcProducts.MainView = this.gcvProducts;
            this.gcProducts.MenuManager = this.barManager1;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcProducts.Size = new System.Drawing.Size(994, 630);
            this.gcProducts.TabIndex = 4;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcvProducts});
            // 
            // bs_products
            // 
            this.bs_products.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // gcvProducts
            // 
            this.gcvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colPName,
            this.colPBarcode,
            this.colPCategoryId,
            this.colPDate,
            this.colPFirstPrice,
            this.colPTotal,
            this.colPlastPrice,
            this.colPUnitId,
            this.colPVarDescription,
            this.colPSpecCode,
            this.colPBrandName,
            this.colPBrandCode,
            this.colPGroup,
            this.colPTax});
            this.gcvProducts.GridControl = this.gcProducts;
            this.gcvProducts.Name = "gcvProducts";
            // 
            // colPID
            // 
            this.colPID.FieldName = "PID";
            this.colPID.Name = "colPID";
            this.colPID.Visible = true;
            this.colPID.VisibleIndex = 0;
            // 
            // colPName
            // 
            this.colPName.Caption = "Ürün Adı";
            this.colPName.FieldName = "PName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 1;
            // 
            // colPBarcode
            // 
            this.colPBarcode.Caption = "Barkod";
            this.colPBarcode.FieldName = "PBarcode";
            this.colPBarcode.Name = "colPBarcode";
            this.colPBarcode.Visible = true;
            this.colPBarcode.VisibleIndex = 2;
            // 
            // colPCategoryId
            // 
            this.colPCategoryId.Caption = "Kategori ID";
            this.colPCategoryId.FieldName = "PCategoryId";
            this.colPCategoryId.Name = "colPCategoryId";
            this.colPCategoryId.Visible = true;
            this.colPCategoryId.VisibleIndex = 3;
            // 
            // colPDate
            // 
            this.colPDate.Caption = "Tarih";
            this.colPDate.FieldName = "PDate";
            this.colPDate.Name = "colPDate";
            this.colPDate.Visible = true;
            this.colPDate.VisibleIndex = 4;
            // 
            // colPFirstPrice
            // 
            this.colPFirstPrice.Caption = "İlk Fiyat";
            this.colPFirstPrice.FieldName = "PFirstPrice";
            this.colPFirstPrice.Name = "colPFirstPrice";
            this.colPFirstPrice.Visible = true;
            this.colPFirstPrice.VisibleIndex = 5;
            // 
            // colPTotal
            // 
            this.colPTotal.Caption = "Miktar";
            this.colPTotal.FieldName = "PTotal";
            this.colPTotal.Name = "colPTotal";
            this.colPTotal.Visible = true;
            this.colPTotal.VisibleIndex = 6;
            // 
            // colPlastPrice
            // 
            this.colPlastPrice.Caption = "Son Fiyat";
            this.colPlastPrice.FieldName = "PlastPrice";
            this.colPlastPrice.Name = "colPlastPrice";
            this.colPlastPrice.Visible = true;
            this.colPlastPrice.VisibleIndex = 7;
            // 
            // colPUnitId
            // 
            this.colPUnitId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colPUnitId.FieldName = "PUnitId";
            this.colPUnitId.Name = "colPUnitId";
            this.colPUnitId.Visible = true;
            this.colPUnitId.VisibleIndex = 8;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colPVarDescription
            // 
            this.colPVarDescription.Caption = "Çeşit Tanımı";
            this.colPVarDescription.FieldName = "PVarDescription";
            this.colPVarDescription.Name = "colPVarDescription";
            this.colPVarDescription.Visible = true;
            this.colPVarDescription.VisibleIndex = 9;
            // 
            // colPSpecCode
            // 
            this.colPSpecCode.Caption = "Özel Kodu";
            this.colPSpecCode.FieldName = "PSpecCode";
            this.colPSpecCode.Name = "colPSpecCode";
            this.colPSpecCode.Visible = true;
            this.colPSpecCode.VisibleIndex = 10;
            // 
            // colPBrandName
            // 
            this.colPBrandName.Caption = "Marka Adı";
            this.colPBrandName.FieldName = "PBrandName";
            this.colPBrandName.Name = "colPBrandName";
            this.colPBrandName.Visible = true;
            this.colPBrandName.VisibleIndex = 11;
            // 
            // colPBrandCode
            // 
            this.colPBrandCode.Caption = "Marka Kodu";
            this.colPBrandCode.FieldName = "PBrandCode";
            this.colPBrandCode.Name = "colPBrandCode";
            this.colPBrandCode.Visible = true;
            this.colPBrandCode.VisibleIndex = 12;
            // 
            // colPGroup
            // 
            this.colPGroup.Caption = "Ürün Grubu";
            this.colPGroup.FieldName = "PGroup";
            this.colPGroup.Name = "colPGroup";
            this.colPGroup.Visible = true;
            this.colPGroup.VisibleIndex = 13;
            // 
            // colPTax
            // 
            this.colPTax.Caption = "KDV";
            this.colPTax.Name = "colPTax";
            this.colPTax.Visible = true;
            this.colPTax.VisibleIndex = 14;
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
            this.btnProductsRefresh,
            this.btnAddNewProduct,
            this.btnEditProduct,
            this.btnViewProduct,
            this.btnRemProduct,
            this.bt,
            this.btnSeaProduct,
            this.btnProTransactions,
            this.btnProQuickChange,
            this.btnProBarcodeLabel,
            this.btnProClose,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProductsRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeaProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProTransactions),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProQuickChange),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProBarcodeLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnProductsRefresh
            // 
            this.btnProductsRefresh.Caption = "barButtonItem1";
            this.btnProductsRefresh.Id = 0;
            this.btnProductsRefresh.ImageOptions.ImageIndex = 11;
            this.btnProductsRefresh.Name = "btnProductsRefresh";
            this.btnProductsRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductsRefresh_ItemClick);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Caption = "Yeni Ürün";
            this.btnAddNewProduct.Id = 1;
            this.btnAddNewProduct.ImageOptions.Image = global::Msp.App.Properties.Resources.add_32x321;
            this.btnAddNewProduct.ImageOptions.ImageIndex = 1;
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewProduct_ItemClick);
            // 
            // btnRemProduct
            // 
            this.btnRemProduct.Caption = "Ürün Sil";
            this.btnRemProduct.Id = 4;
            this.btnRemProduct.ImageOptions.Image = global::Msp.App.Properties.Resources.remove_32x321;
            this.btnRemProduct.ImageOptions.ImageIndex = 4;
            this.btnRemProduct.Name = "btnRemProduct";
            this.btnRemProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemProduct_ItemClick);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Caption = "Düzelt";
            this.btnEditProduct.Id = 2;
            this.btnEditProduct.ImageOptions.Image = global::Msp.App.Properties.Resources.floatingobjectoutlinecolor_32x32;
            this.btnEditProduct.ImageOptions.ImageIndex = 2;
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditProduct_ItemClick);
            // 
            // btnSeaProduct
            // 
            this.btnSeaProduct.Caption = "Ürün Bul";
            this.btnSeaProduct.Id = 6;
            this.btnSeaProduct.ImageOptions.Image = global::Msp.App.Properties.Resources.marqueezoom_32x32;
            this.btnSeaProduct.ImageOptions.ImageIndex = 6;
            this.btnSeaProduct.Name = "btnSeaProduct";
            // 
            // btnProTransactions
            // 
            this.btnProTransactions.Caption = "Ürün Hareketleri";
            this.btnProTransactions.Id = 7;
            this.btnProTransactions.ImageOptions.Image = global::Msp.App.Properties.Resources.chart_32x32;
            this.btnProTransactions.ImageOptions.ImageIndex = 7;
            this.btnProTransactions.Name = "btnProTransactions";
            // 
            // btnProQuickChange
            // 
            this.btnProQuickChange.Caption = "Hızlı Değiştir";
            this.btnProQuickChange.Id = 8;
            this.btnProQuickChange.ImageOptions.Image = global::Msp.App.Properties.Resources.changedatasourcepivottable_32x32;
            this.btnProQuickChange.ImageOptions.ImageIndex = 8;
            this.btnProQuickChange.Name = "btnProQuickChange";
            // 
            // btnProBarcodeLabel
            // 
            this.btnProBarcodeLabel.Caption = "Barkod Etiket";
            this.btnProBarcodeLabel.Id = 9;
            this.btnProBarcodeLabel.ImageOptions.Image = global::Msp.App.Properties.Resources.barcode_32x32;
            this.btnProBarcodeLabel.ImageOptions.ImageIndex = 9;
            this.btnProBarcodeLabel.Name = "btnProBarcodeLabel";
            // 
            // btnProClose
            // 
            this.btnProClose.Caption = "Kapat";
            this.btnProClose.Id = 10;
            this.btnProClose.ImageOptions.Image = global::Msp.App.Properties.Resources.cancel_32x325;
            this.btnProClose.ImageOptions.ImageIndex = 10;
            this.btnProClose.Name = "btnProClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1018, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 654);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1018, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 654);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1018, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 654);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("bo_price", "image://svgimages/business objects/bo_price.svg");
            this.svgImageCollection1.Add("actions_add", "image://svgimages/icon builder/actions_add.svg");
            this.svgImageCollection1.Add("actions_edit", "image://svgimages/icon builder/actions_edit.svg");
            this.svgImageCollection1.Add("viewmergeddata", "image://svgimages/richedit/viewmergeddata.svg");
            this.svgImageCollection1.Add("actions_remove", "image://svgimages/icon builder/actions_remove.svg");
            this.svgImageCollection1.Add("del", "image://svgimages/diagramicons/del.svg");
            this.svgImageCollection1.Add("actions_zoom", "image://svgimages/icon builder/actions_zoom.svg");
            this.svgImageCollection1.Add("movechartnewsheet", "image://svgimages/spreadsheet/movechartnewsheet.svg");
            this.svgImageCollection1.Add("changedatasourcepivottable", "image://svgimages/spreadsheet/changedatasourcepivottable.svg");
            this.svgImageCollection1.Add("barcode", "image://svgimages/content/barcode.svg");
            this.svgImageCollection1.Add("saveandclose2", "image://svgimages/save/saveandclose2.svg");
            this.svgImageCollection1.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1018, 654);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcProducts;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(998, 634);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 696);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStok";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnProductsRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnAddNewProduct;
        private DevExpress.XtraBars.BarButtonItem btnEditProduct;
        private DevExpress.XtraBars.BarButtonItem btnViewProduct;
        private DevExpress.XtraBars.BarButtonItem btnRemProduct;
        private DevExpress.XtraBars.BarButtonItem btnSeaProduct;
        private DevExpress.XtraBars.BarButtonItem btnProTransactions;
        private DevExpress.XtraBars.BarButtonItem btnProQuickChange;
        private DevExpress.XtraBars.BarButtonItem bt;
        private DevExpress.XtraBars.BarButtonItem btnProBarcodeLabel;
        private DevExpress.XtraBars.BarButtonItem btnProClose;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bs_products;
        private DevExpress.XtraGrid.Views.Grid.GridView gcvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colPCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colPDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFirstPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPlastPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPVarDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPSpecCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrandCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colPTax;
    }
}