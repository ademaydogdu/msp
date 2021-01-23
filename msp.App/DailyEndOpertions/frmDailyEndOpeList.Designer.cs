namespace Msp.App.DailyEndOpertions
{
    partial class frmDailyEndOpeList
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
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_Print = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Closed = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gc_DailyOwner = new DevExpress.XtraGrid.GridControl();
            this.bs_DailyOwner = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_DailyOwner = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSaleCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSaleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbi_Deleted = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DailyOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DailyOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DailyOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_sic
            // 
            this.img_sic.ImageSize = new System.Drawing.Size(26, 26);
            this.img_sic.Add("del", "image://svgimages/diagramicons/del.svg");
            this.img_sic.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.img_sic.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
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
            this.bbi_Print,
            this.bbi_Closed,
            this.bbi_Deleted});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Deleted, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Closed)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_Print
            // 
            this.bbi_Print.Caption = "Rapor";
            this.bbi_Print.Id = 0;
            this.bbi_Print.ImageOptions.ImageIndex = 1;
            this.bbi_Print.Name = "bbi_Print";
            this.bbi_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Print_ItemClick);
            // 
            // bbi_Closed
            // 
            this.bbi_Closed.Caption = "Vazgeç";
            this.bbi_Closed.Id = 1;
            this.bbi_Closed.ImageOptions.ImageIndex = 0;
            this.bbi_Closed.Name = "bbi_Closed";
            this.bbi_Closed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Closed_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(949, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 467);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(949, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 467);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_DailyOwner);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(949, 467);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_DailyOwner
            // 
            this.gc_DailyOwner.DataSource = this.bs_DailyOwner;
            this.gc_DailyOwner.Location = new System.Drawing.Point(12, 12);
            this.gc_DailyOwner.MainView = this.gcv_DailyOwner;
            this.gc_DailyOwner.MenuManager = this.barManager1;
            this.gc_DailyOwner.Name = "gc_DailyOwner";
            this.gc_DailyOwner.Size = new System.Drawing.Size(925, 443);
            this.gc_DailyOwner.TabIndex = 4;
            this.gc_DailyOwner.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_DailyOwner});
            // 
            // bs_DailyOwner
            // 
            this.bs_DailyOwner.DataSource = typeof(Msp.Models.Models.Daily.DailyOwnerDTO);
            // 
            // gcv_DailyOwner
            // 
            this.gcv_DailyOwner.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colAmount,
            this.colSaleAmount,
            this.colCashAmount,
            this.colCardAmount,
            this.colTotalProduct,
            this.colRemark,
            this.colRetailSaleCount,
            this.colRetailSaleAmount,
            this.colRevenue,
            this.colExpense});
            this.gcv_DailyOwner.GridControl = this.gc_DailyOwner;
            this.gcv_DailyOwner.Name = "gcv_DailyOwner";
            this.gcv_DailyOwner.OptionsBehavior.Editable = false;
            this.gcv_DailyOwner.OptionsView.ColumnAutoWidth = false;
            this.gcv_DailyOwner.OptionsView.ShowAutoFilterRow = true;
            this.gcv_DailyOwner.OptionsView.ShowFooter = true;
            this.gcv_DailyOwner.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Toplam Tutar";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // colSaleAmount
            // 
            this.colSaleAmount.Caption = "Satış Tutarı";
            this.colSaleAmount.DisplayFormat.FormatString = "n2";
            this.colSaleAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleAmount.FieldName = "SaleAmount";
            this.colSaleAmount.Name = "colSaleAmount";
            this.colSaleAmount.Visible = true;
            this.colSaleAmount.VisibleIndex = 2;
            // 
            // colCashAmount
            // 
            this.colCashAmount.Caption = "Nakit Girişi";
            this.colCashAmount.DisplayFormat.FormatString = "n2";
            this.colCashAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCashAmount.FieldName = "CashAmount";
            this.colCashAmount.Name = "colCashAmount";
            this.colCashAmount.Visible = true;
            this.colCashAmount.VisibleIndex = 3;
            // 
            // colCardAmount
            // 
            this.colCardAmount.Caption = "Kredi Kartı";
            this.colCardAmount.DisplayFormat.FormatString = "n2";
            this.colCardAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCardAmount.FieldName = "CardAmount";
            this.colCardAmount.Name = "colCardAmount";
            this.colCardAmount.Visible = true;
            this.colCardAmount.VisibleIndex = 4;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "Satılan Ürün";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 5;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Açıklama";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 6;
            // 
            // colRetailSaleCount
            // 
            this.colRetailSaleCount.Caption = "Satış Sayısı";
            this.colRetailSaleCount.FieldName = "RetailSaleCount";
            this.colRetailSaleCount.Name = "colRetailSaleCount";
            this.colRetailSaleCount.Visible = true;
            this.colRetailSaleCount.VisibleIndex = 7;
            // 
            // colRetailSaleAmount
            // 
            this.colRetailSaleAmount.Caption = "Satış Fiyatı";
            this.colRetailSaleAmount.DisplayFormat.FormatString = "n2";
            this.colRetailSaleAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRetailSaleAmount.FieldName = "RetailSaleAmount";
            this.colRetailSaleAmount.Name = "colRetailSaleAmount";
            this.colRetailSaleAmount.Visible = true;
            this.colRetailSaleAmount.VisibleIndex = 8;
            // 
            // colRevenue
            // 
            this.colRevenue.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colRevenue.AppearanceCell.Options.UseForeColor = true;
            this.colRevenue.Caption = "Gelir Tutarı";
            this.colRevenue.DisplayFormat.FormatString = "n2";
            this.colRevenue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRevenue.FieldName = "Revenue";
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.Visible = true;
            this.colRevenue.VisibleIndex = 9;
            // 
            // colExpense
            // 
            this.colExpense.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colExpense.AppearanceCell.Options.UseForeColor = true;
            this.colExpense.Caption = "Gider Tutarı";
            this.colExpense.DisplayFormat.FormatString = "n2";
            this.colExpense.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExpense.FieldName = "Expense";
            this.colExpense.Name = "colExpense";
            this.colExpense.Visible = true;
            this.colExpense.VisibleIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(949, 467);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_DailyOwner;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(929, 447);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bbi_Deleted
            // 
            this.bbi_Deleted.Caption = "Sil";
            this.bbi_Deleted.Id = 2;
            this.bbi_Deleted.ImageOptions.ImageIndex = 2;
            this.bbi_Deleted.Name = "bbi_Deleted";
            this.bbi_Deleted.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Deleted_ItemClick);
            // 
            // frmDailyEndOpeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 503);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDailyEndOpeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Sonu İşlem Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDailyEndOpeList_FormClosing);
            this.Load += new System.EventHandler(this.frmDailyEndOpeList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDailyEndOpeList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DailyOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DailyOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DailyOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_DailyOwner;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_DailyOwner;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bs_DailyOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCashAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCardAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSaleCount;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSaleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn colExpense;
        private DevExpress.XtraBars.BarButtonItem bbi_Print;
        private DevExpress.XtraBars.BarButtonItem bbi_Closed;
        private DevExpress.XtraBars.BarButtonItem bbi_Deleted;
    }
}