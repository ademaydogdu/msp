namespace Msp.App.Islemler
{
    partial class frmDovizKurlari
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
            this.gc_DovizKurlari = new DevExpress.XtraGrid.GridControl();
            this.gcv_DovizKurlari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bbi_InternetAl = new DevExpress.XtraBars.BarButtonItem();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DovizKurlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DovizKurlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.bbi_InternetAl});
            this.barManager1.LargeImages = this.img_bar;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_InternetAl, true)});
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
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
            // 
            // bbi_Close
            // 
            this.bbi_Close.Caption = "Vazgeç";
            this.bbi_Close.Id = 1;
            this.bbi_Close.ImageOptions.ImageIndex = 0;
            this.bbi_Close.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Close.Name = "bbi_Close";
            this.bbi_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(717, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 465);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(717, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 465);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(717, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 465);
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
            // gc_DovizKurlari
            // 
            this.gc_DovizKurlari.Location = new System.Drawing.Point(12, 36);
            this.gc_DovizKurlari.MainView = this.gcv_DovizKurlari;
            this.gc_DovizKurlari.MenuManager = this.barManager1;
            this.gc_DovizKurlari.Name = "gc_DovizKurlari";
            this.gc_DovizKurlari.Size = new System.Drawing.Size(693, 417);
            this.gc_DovizKurlari.TabIndex = 2;
            this.gc_DovizKurlari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_DovizKurlari});
            // 
            // gcv_DovizKurlari
            // 
            this.gcv_DovizKurlari.GridControl = this.gc_DovizKurlari;
            this.gcv_DovizKurlari.Name = "gcv_DovizKurlari";
            this.gcv_DovizKurlari.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gcv_DovizKurlari.OptionsView.ShowGroupPanel = false;
            // 
            // bbi_InternetAl
            // 
            this.bbi_InternetAl.Caption = "İnternetden Al";
            this.bbi_InternetAl.Id = 3;
            this.bbi_InternetAl.ImageOptions.ImageIndex = 5;
            this.bbi_InternetAl.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_InternetAl.Name = "bbi_InternetAl";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(48, 12);
            this.dateEdit1.MenuManager = this.barManager1;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(308, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_DovizKurlari);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(717, 465);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(717, 465);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem1.Text = "Tarih";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gc_DovizKurlari;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(697, 421);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(348, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(349, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 505);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDovizKurlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Kurları";
            this.Load += new System.EventHandler(this.frmDovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DovizKurlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_DovizKurlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_save;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_Close;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraGrid.GridControl gc_DovizKurlari;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_DovizKurlari;
        private DevExpress.XtraBars.BarButtonItem bbi_InternetAl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}