using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace Msp.App.Tanimlar
{
    partial class SpeedSaleProductTanim
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
            this.bbi_save = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSpeedNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnSpeedProductRetrun = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gc_SpeedSaleProduct = new DevExpress.XtraGrid.GridControl();
            this.bs_SpeedSaleProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_SpeedSaleProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_products = new System.Windows.Forms.BindingSource(this.components);
            this.colİmage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButtonType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Product = new DevExpress.XtraGrid.GridControl();
            this.gcv_Product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SpeedSaleProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SpeedSaleProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_SpeedSaleProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // img_bar
            // 
            this.img_bar.Add("delete", "image://svgimages/dashboards/delete.svg");
            this.img_bar.Add("save", "image://svgimages/outlook inspired/save.svg");
            this.img_bar.Add("charthorizontalaxis_logscale", "image://svgimages/spreadsheet/charthorizontalaxis_logscale.svg");
            this.img_bar.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.img_bar.Add("trackingchanges_next", "image://svgimages/richedit/trackingchanges_next.svg");
            this.img_bar.Add("trackingchanges_previous", "image://svgimages/richedit/trackingchanges_previous.svg");
            this.img_bar.Add("trackingchanges_reject", "image://svgimages/richedit/trackingchanges_reject.svg");
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
            this.bbi_save,
            this.barButtonItem2,
            this.bbi_Delete,
            this.btnSpeedNext,
            this.btnSpeedProductRetrun});
            this.barManager1.LargeImages = this.img_bar;
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSpeedNext, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSpeedProductRetrun)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_save
            // 
            this.bbi_save.Caption = "Kaydet";
            this.bbi_save.Id = 0;
            this.bbi_save.ImageOptions.ImageIndex = 1;
            this.bbi_save.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_save.Name = "bbi_save";
            this.bbi_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_save_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
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
            // btnSpeedNext
            // 
            this.btnSpeedNext.Caption = "barButtonItem1";
            this.btnSpeedNext.Id = 3;
            this.btnSpeedNext.ImageOptions.ImageIndex = 5;
            this.btnSpeedNext.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnSpeedNext.Name = "btnSpeedNext";
            this.btnSpeedNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSpeedNext_ItemClick);
            // 
            // btnSpeedProductRetrun
            // 
            this.btnSpeedProductRetrun.Caption = "barButtonItem3";
            this.btnSpeedProductRetrun.Id = 4;
            this.btnSpeedProductRetrun.ImageOptions.ImageIndex = 6;
            this.btnSpeedProductRetrun.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnSpeedProductRetrun.Name = "btnSpeedProductRetrun";
            this.btnSpeedProductRetrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSpeedProductRetrun_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 599);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(791, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 599);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(791, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 599);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_SpeedSaleProduct);
            this.layoutControl1.Controls.Add(this.gc_Product);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(791, 599);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_SpeedSaleProduct
            // 
            this.gc_SpeedSaleProduct.DataSource = this.bs_SpeedSaleProduct;
            this.gc_SpeedSaleProduct.Location = new System.Drawing.Point(364, 12);
            this.gc_SpeedSaleProduct.MainView = this.gcv_SpeedSaleProduct;
            this.gc_SpeedSaleProduct.MenuManager = this.barManager1;
            this.gc_SpeedSaleProduct.Name = "gc_SpeedSaleProduct";
            this.gc_SpeedSaleProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gc_SpeedSaleProduct.Size = new System.Drawing.Size(415, 575);
            this.gc_SpeedSaleProduct.TabIndex = 5;
            this.gc_SpeedSaleProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_SpeedSaleProduct});
            // 
            // bs_SpeedSaleProduct
            // 
            this.bs_SpeedSaleProduct.DataSource = typeof(Msp.Models.Models.Sale.SpeedSaleProductDTO);
            // 
            // gcv_SpeedSaleProduct
            // 
            this.gcv_SpeedSaleProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.colProductId,
            this.colİmage,
            this.colButtonType});
            this.gcv_SpeedSaleProduct.GridControl = this.gc_SpeedSaleProduct;
            this.gcv_SpeedSaleProduct.Name = "gcv_SpeedSaleProduct";
            this.gcv_SpeedSaleProduct.OptionsView.ShowAutoFilterRow = true;
            this.gcv_SpeedSaleProduct.OptionsView.ShowGroupPanel = false;
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Ürün Adı";
            this.colProductId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.OptionsColumn.AllowEdit = false;
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bs_products;
            this.repositoryItemLookUpEdit1.DisplayMember = "PName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "PID";
            // 
            // bs_products
            // 
            this.bs_products.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // colİmage
            // 
            this.colİmage.FieldName = "İmage";
            this.colİmage.Name = "colİmage";
            this.colİmage.Visible = true;
            this.colİmage.VisibleIndex = 1;
            // 
            // colButtonType
            // 
            this.colButtonType.FieldName = "ButtonType";
            this.colButtonType.Name = "colButtonType";
            this.colButtonType.Visible = true;
            this.colButtonType.VisibleIndex = 2;
            // 
            // gc_Product
            // 
            this.gc_Product.DataSource = this.bs_products;
            this.gc_Product.Location = new System.Drawing.Point(12, 12);
            this.gc_Product.MainView = this.gcv_Product;
            this.gc_Product.MenuManager = this.barManager1;
            this.gc_Product.Name = "gc_Product";
            this.gc_Product.Size = new System.Drawing.Size(338, 575);
            this.gc_Product.TabIndex = 4;
            this.gc_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_Product});
            // 
            // gcv_Product
            // 
            this.gcv_Product.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPName});
            this.gcv_Product.GridControl = this.gc_Product;
            this.gcv_Product.Name = "gcv_Product";
            this.gcv_Product.OptionsView.ShowAutoFilterRow = true;
            this.gcv_Product.OptionsView.ShowGroupPanel = false;
            // 
            // colPName
            // 
            this.colPName.Caption = "Ürün Adı";
            this.colPName.FieldName = "PName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.splitterItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(791, 599);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_Product;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 579);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(342, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 579);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gc_SpeedSaleProduct;
            this.layoutControlItem2.Location = new System.Drawing.Point(352, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(419, 579);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // SpeedSaleProductTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 639);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SpeedSaleProductTanim";
            this.Text = "Hızlı Satış Ekranı Ürün Tanım";
            this.Load += new System.EventHandler(this.SpeedSaleProductTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SpeedSaleProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SpeedSaleProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_SpeedSaleProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_save;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private GridControl gc_SpeedSaleProduct;
        private GridView gcv_SpeedSaleProduct;
        private GridControl gc_Product;
        private GridView gcv_Product;
        private LayoutControlItem layoutControlItem1;
        private SplitterItem splitterItem1;
        private LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem btnSpeedNext;
        private DevExpress.XtraBars.BarButtonItem btnSpeedProductRetrun;
        private System.Windows.Forms.BindingSource bs_products;
        private System.Windows.Forms.BindingSource bs_SpeedSaleProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colİmage;
        private DevExpress.XtraGrid.Columns.GridColumn colButtonType;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}