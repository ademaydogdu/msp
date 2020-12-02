namespace Msp.App.Tanimlar
{
    partial class CurrencyTypeList
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
            this.bbi_save = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_InternetAl = new DevExpress.XtraBars.BarButtonItem();
            this.gc_DovizCinsi = new DevExpress.XtraGrid.GridControl();
            this.gcv_DovizCinsi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bs_CurrencyList = new System.Windows.Forms.BindingSource(this.components);
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DovizCinsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DovizCinsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CurrencyList)).BeginInit();
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
            this.bbi_save,
            this.bbi_Close,
            this.bbi_Delete,
            this.bbi_InternetAl,
            this.bbi_Refresh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh, true)});
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
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // bbi_Close
            // 
            this.bbi_Close.Caption = "Vazgeç";
            this.bbi_Close.Id = 1;
            this.bbi_Close.ImageOptions.ImageIndex = 0;
            this.bbi_Close.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Close.Name = "bbi_Close";
            this.bbi_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Close_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 40);
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
            this.barDockControlRight.Location = new System.Drawing.Point(784, 0);
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
            this.img_bar.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            // 
            // bbi_InternetAl
            // 
            this.bbi_InternetAl.Caption = "İnternetden Al";
            this.bbi_InternetAl.Id = 3;
            this.bbi_InternetAl.ImageOptions.ImageIndex = 5;
            this.bbi_InternetAl.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_InternetAl.Name = "bbi_InternetAl";
            // 
            // gc_DovizCinsi
            // 
            this.gc_DovizCinsi.DataSource = this.bs_CurrencyList;
            this.gc_DovizCinsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DovizCinsi.Location = new System.Drawing.Point(0, 0);
            this.gc_DovizCinsi.MainView = this.gcv_DovizCinsi;
            this.gc_DovizCinsi.MenuManager = this.barManager1;
            this.gc_DovizCinsi.Name = "gc_DovizCinsi";
            this.gc_DovizCinsi.Size = new System.Drawing.Size(784, 461);
            this.gc_DovizCinsi.TabIndex = 4;
            this.gc_DovizCinsi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_DovizCinsi});
            // 
            // gcv_DovizCinsi
            // 
            this.gcv_DovizCinsi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrencyCode,
            this.colRemark});
            this.gcv_DovizCinsi.GridControl = this.gc_DovizCinsi;
            this.gcv_DovizCinsi.Name = "gcv_DovizCinsi";
            this.gcv_DovizCinsi.OptionsView.ColumnAutoWidth = false;
            this.gcv_DovizCinsi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gcv_DovizCinsi.OptionsView.ShowGroupPanel = false;
            // 
            // bs_CurrencyList
            // 
            this.bs_CurrencyList.DataSource = typeof(Msp.Models.Models.CurrencyTypeDTO);
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "Kodu";
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 0;
            this.colCurrencyCode.Width = 134;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Adı";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 1;
            this.colRemark.Width = 147;
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 4;
            this.bbi_Refresh.ImageOptions.ImageIndex = 4;
            this.bbi_Refresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Refresh.Name = "bbi_Refresh";
            this.bbi_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Refresh_ItemClick);
            // 
            // CurrencyTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.gc_DovizCinsi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CurrencyTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Cinsi Tanımları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrencyTypeList_FormClosing);
            this.Load += new System.EventHandler(this.CurrencyTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DovizCinsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DovizCinsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CurrencyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_save;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_Close;
        private DevExpress.XtraBars.BarButtonItem bbi_InternetAl;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraGrid.GridControl gc_DovizCinsi;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_DovizCinsi;
        private System.Windows.Forms.BindingSource bs_CurrencyList;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
    }
}