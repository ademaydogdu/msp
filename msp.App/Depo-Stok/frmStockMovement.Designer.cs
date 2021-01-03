namespace Msp.App.Depo_Stok
{
    partial class frmStockMovement
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
            this.img_sig = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_Report = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_exp = new DevExpress.XtraBars.BarSubItem();
            this.bbi_excel = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Pdf = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbi_Export = new DevExpress.XtraBars.BarButtonItem();
            this.gc_ProductMovement = new DevExpress.XtraGrid.GridControl();
            this.bs_ProductMovent = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_Product = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_products = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ProductMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProductMovent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).BeginInit();
            this.SuspendLayout();
            // 
            // img_sig
            // 
            this.img_sig.ImageSize = new System.Drawing.Size(24, 24);
            this.img_sig.Add("rotateclockwise", "image://svgimages/pdf viewer/rotateclockwise.svg");
            this.img_sig.Add("exporttopdf", "image://svgimages/export/exporttopdf.svg");
            this.img_sig.Add("exporttoxls", "image://svgimages/export/exporttoxls.svg");
            this.img_sig.Add("open2", "image://svgimages/actions/open2.svg");
            this.img_sig.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
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
            this.barManager1.Images = this.img_sig;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Export,
            this.bbi_exp,
            this.bbi_excel,
            this.bbi_Pdf,
            this.bbi_Report});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Report),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_exp, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_Report
            // 
            this.bbi_Report.Caption = "Rapor";
            this.bbi_Report.Id = 4;
            this.bbi_Report.ImageOptions.ImageIndex = 4;
            this.bbi_Report.Name = "bbi_Report";
            // 
            // bbi_exp
            // 
            this.bbi_exp.Caption = "Export";
            this.bbi_exp.Id = 1;
            this.bbi_exp.ImageOptions.ImageIndex = 3;
            this.bbi_exp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_excel),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Pdf)});
            this.bbi_exp.Name = "bbi_exp";
            this.bbi_exp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbi_excel
            // 
            this.bbi_excel.Caption = "Excel";
            this.bbi_excel.Id = 2;
            this.bbi_excel.ImageOptions.ImageIndex = 2;
            this.bbi_excel.Name = "bbi_excel";
            this.bbi_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_excel_ItemClick);
            // 
            // bbi_Pdf
            // 
            this.bbi_Pdf.Caption = "PDF";
            this.bbi_Pdf.Id = 3;
            this.bbi_Pdf.ImageOptions.ImageIndex = 1;
            this.bbi_Pdf.Name = "bbi_Pdf";
            this.bbi_Pdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Pdf_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(512, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(512, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(512, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // bbi_Export
            // 
            this.bbi_Export.ActAsDropDown = true;
            this.bbi_Export.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbi_Export.Caption = "Export";
            this.bbi_Export.Id = 0;
            this.bbi_Export.Name = "bbi_Export";
            // 
            // gc_ProductMovement
            // 
            this.gc_ProductMovement.DataSource = this.bs_ProductMovent;
            this.gc_ProductMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ProductMovement.Location = new System.Drawing.Point(0, 0);
            this.gc_ProductMovement.MainView = this.gridView1;
            this.gc_ProductMovement.MenuManager = this.barManager1;
            this.gc_ProductMovement.Name = "gc_ProductMovement";
            this.gc_ProductMovement.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rp_Product});
            this.gc_ProductMovement.Size = new System.Drawing.Size(512, 523);
            this.gc_ProductMovement.TabIndex = 4;
            this.gc_ProductMovement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bs_ProductMovent
            // 
            this.bs_ProductMovent.DataSource = typeof(Msp.Models.Models.ProductMovementDTO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colQuantity,
            this.colAmount,
            this.colDurum,
            this.colDate,
            this.colDeleted});
            this.gridView1.GridControl = this.gc_ProductMovement;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Ürün";
            this.colProductId.ColumnEdit = this.rp_Product;
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            // 
            // rp_Product
            // 
            this.rp_Product.AutoHeight = false;
            this.rp_Product.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_Product.DataSource = this.bs_products;
            this.rp_Product.DisplayMember = "PName";
            this.rp_Product.Name = "rp_Product";
            this.rp_Product.NullText = "";
            this.rp_Product.ValueMember = "PID";
            // 
            // bs_products
            // 
            this.bs_products.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.Caption = "Miktar";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Satış Fiyatı";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colDurum
            // 
            this.colDurum.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDurum.AppearanceCell.Options.UseFont = true;
            this.colDurum.Caption = "İşlem";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 4;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            // 
            // frmStockMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 557);
            this.Controls.Add(this.gc_ProductMovement);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStockMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Hareket Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockMovement_FormClosing);
            this.Load += new System.EventHandler(this.frmStockMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ProductMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProductMovent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.SvgImageCollection img_sig;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_Report;
        private DevExpress.XtraBars.BarSubItem bbi_exp;
        private DevExpress.XtraBars.BarButtonItem bbi_excel;
        private DevExpress.XtraBars.BarButtonItem bbi_Pdf;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Export;
        private DevExpress.XtraGrid.GridControl gc_ProductMovement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bs_ProductMovent;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_Product;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private System.Windows.Forms.BindingSource bs_products;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
    }
}