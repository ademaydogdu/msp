namespace Msp.App.CariIslemler
{
    partial class FindIrsaliyeList
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
            this.gc_FindIrsaliye = new DevExpress.XtraGrid.GridControl();
            this.bs_Invoice = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_FindIrsaliye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEIrsaliyeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_FindIrsaliye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_FindIrsaliye)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
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
            // gc_FindIrsaliye
            // 
            this.gc_FindIrsaliye.DataSource = this.bs_Invoice;
            this.gc_FindIrsaliye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_FindIrsaliye.Location = new System.Drawing.Point(0, 0);
            this.gc_FindIrsaliye.MainView = this.gcv_FindIrsaliye;
            this.gc_FindIrsaliye.MenuManager = this.barManager1;
            this.gc_FindIrsaliye.Name = "gc_FindIrsaliye";
            this.gc_FindIrsaliye.Size = new System.Drawing.Size(748, 461);
            this.gc_FindIrsaliye.TabIndex = 4;
            this.gc_FindIrsaliye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_FindIrsaliye});
            // 
            // bs_Invoice
            // 
            this.bs_Invoice.DataSource = typeof(Msp.Models.Models.Invoice.InvoiceOwnerDTO);
            // 
            // gcv_FindIrsaliye
            // 
            this.gcv_FindIrsaliye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceType,
            this.colFicDate,
            this.colFicheType,
            this.colEFaturaNo,
            this.colEIrsaliyeNo});
            this.gcv_FindIrsaliye.GridControl = this.gc_FindIrsaliye;
            this.gcv_FindIrsaliye.Name = "gcv_FindIrsaliye";
            this.gcv_FindIrsaliye.OptionsView.ColumnAutoWidth = false;
            this.gcv_FindIrsaliye.OptionsView.ShowAutoFilterRow = true;
            this.gcv_FindIrsaliye.OptionsView.ShowFooter = true;
            this.gcv_FindIrsaliye.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.FieldName = "InvoiceType";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 0;
            // 
            // colFicDate
            // 
            this.colFicDate.FieldName = "FicDate";
            this.colFicDate.Name = "colFicDate";
            this.colFicDate.Visible = true;
            this.colFicDate.VisibleIndex = 1;
            // 
            // colFicheType
            // 
            this.colFicheType.FieldName = "FicheType";
            this.colFicheType.Name = "colFicheType";
            this.colFicheType.Visible = true;
            this.colFicheType.VisibleIndex = 2;
            // 
            // colEFaturaNo
            // 
            this.colEFaturaNo.FieldName = "EFaturaNo";
            this.colEFaturaNo.Name = "colEFaturaNo";
            this.colEFaturaNo.Visible = true;
            this.colEFaturaNo.VisibleIndex = 3;
            // 
            // colEIrsaliyeNo
            // 
            this.colEIrsaliyeNo.FieldName = "EIrsaliyeNo";
            this.colEIrsaliyeNo.Name = "colEIrsaliyeNo";
            this.colEIrsaliyeNo.Visible = true;
            this.colEIrsaliyeNo.VisibleIndex = 4;
            // 
            // FindIrsaliyeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 501);
            this.Controls.Add(this.gc_FindIrsaliye);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FindIrsaliyeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İrsaliye Al";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindIrsaliyeList_FormClosing);
            this.Load += new System.EventHandler(this.FindIrsaliyeList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindIrsaliyeList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_FindIrsaliye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_FindIrsaliye)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gc_FindIrsaliye;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_FindIrsaliye;
        private System.Windows.Forms.BindingSource bs_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colFicDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheType;
        private DevExpress.XtraGrid.Columns.GridColumn colEFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEIrsaliyeNo;
    }
}