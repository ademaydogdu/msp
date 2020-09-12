namespace msp.App
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfirstPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.collastPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnProductCards = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuickChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarcodeLabel = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 654);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(994, 630);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colname,
            this.colbarcode,
            this.coldate,
            this.colfirstPrice,
            this.coltotal,
            this.collastPrice});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colname);
            this.gridBand1.Columns.Add(this.colbarcode);
            this.gridBand1.Columns.Add(this.coldate);
            this.gridBand1.Columns.Add(this.colfirstPrice);
            this.gridBand1.Columns.Add(this.coltotal);
            this.gridBand1.Columns.Add(this.collastPrice);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 450;
            // 
            // colname
            // 
            this.colname.Caption = "Adı";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            // 
            // colbarcode
            // 
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            // 
            // coldate
            // 
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            // 
            // colfirstPrice
            // 
            this.colfirstPrice.FieldName = "firstPrice";
            this.colfirstPrice.Name = "colfirstPrice";
            this.colfirstPrice.Visible = true;
            // 
            // coltotal
            // 
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            // 
            // collastPrice
            // 
            this.collastPrice.FieldName = "lastPrice";
            this.collastPrice.Name = "collastPrice";
            this.collastPrice.Visible = true;
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
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(998, 634);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
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
            this.btnProductCards,
            this.btnAddNewProduct,
            this.btnEditProduct,
            this.btnViewProduct,
            this.btnRemProduct,
            this.bt,
            this.btnSeaProduct,
            this.btnTransactions,
            this.btnQuickChange,
            this.btnBarcodeLabel,
            this.btnClose,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProductCards),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeaProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTransactions),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuickChange),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBarcodeLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnProductCards
            // 
            this.btnProductCards.Caption = "barButtonItem1";
            this.btnProductCards.Id = 0;
            this.btnProductCards.ImageOptions.ImageIndex = 0;
            this.btnProductCards.Name = "btnProductCards";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Caption = "Yeni Ürün";
            this.btnAddNewProduct.Id = 1;
            this.btnAddNewProduct.ImageOptions.ImageIndex = 1;
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            // 
            // btnRemProduct
            // 
            this.btnRemProduct.Caption = "Ürün Sil";
            this.btnRemProduct.Id = 4;
            this.btnRemProduct.ImageOptions.ImageIndex = 4;
            this.btnRemProduct.Name = "btnRemProduct";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Caption = "Düzelt";
            this.btnEditProduct.Id = 2;
            this.btnEditProduct.ImageOptions.ImageIndex = 2;
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditProduct_ItemClick);
            // 
            // btnSeaProduct
            // 
            this.btnSeaProduct.Caption = "Ürün Bul";
            this.btnSeaProduct.Id = 6;
            this.btnSeaProduct.ImageOptions.ImageIndex = 6;
            this.btnSeaProduct.Name = "btnSeaProduct";
            // 
            // btnTransactions
            // 
            this.btnTransactions.Caption = "Ürün Hareketleri";
            this.btnTransactions.Id = 7;
            this.btnTransactions.ImageOptions.ImageIndex = 7;
            this.btnTransactions.Name = "btnTransactions";
            // 
            // btnQuickChange
            // 
            this.btnQuickChange.Caption = "Hızlı Değiştir";
            this.btnQuickChange.Id = 8;
            this.btnQuickChange.ImageOptions.ImageIndex = 8;
            this.btnQuickChange.Name = "btnQuickChange";
            // 
            // btnBarcodeLabel
            // 
            this.btnBarcodeLabel.Caption = "Barkod Etiket";
            this.btnBarcodeLabel.Id = 9;
            this.btnBarcodeLabel.ImageOptions.ImageIndex = 9;
            this.btnBarcodeLabel.Name = "btnBarcodeLabel";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Kapat";
            this.btnClose.Id = 10;
            this.btnClose.ImageOptions.ImageIndex = 10;
            this.btnClose.Name = "btnClose";
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
            this.Text = "frmStok";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.BindingSource productsBindingSource;
        
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbarcode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfirstPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltotal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn collastPrice;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnProductCards;
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
        private DevExpress.XtraBars.BarButtonItem btnTransactions;
        private DevExpress.XtraBars.BarButtonItem btnQuickChange;
        private DevExpress.XtraBars.BarButtonItem bt;
        private DevExpress.XtraBars.BarButtonItem btnBarcodeLabel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
    }
}