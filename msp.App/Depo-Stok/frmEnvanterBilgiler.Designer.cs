namespace Msp.App.Depo_Stok
{
    partial class frmEnvanterBilgiler
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
            this.bbi_Print = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_InternetAl = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lc_Depot = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_Depot = new System.Windows.Forms.BindingSource(this.components);
            this.lc_Company = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_company = new System.Windows.Forms.BindingSource(this.components);
            this.lp_PRoductEnd = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_Product = new System.Windows.Forms.BindingSource(this.components);
            this.lp_PRoductBegin = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Depot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lp_PRoductEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lp_PRoductBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.bbi_Print,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Close)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_Print
            // 
            this.bbi_Print.Caption = "Kaydet";
            this.bbi_Print.Id = 0;
            this.bbi_Print.ImageOptions.ImageIndex = 6;
            this.bbi_Print.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Print.Name = "bbi_Print";
            this.bbi_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Print_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(361, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 366);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(361, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 366);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(361, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 366);
            // 
            // img_bar
            // 
            this.img_bar.Add("delete", "image://svgimages/dashboards/delete.svg");
            this.img_bar.Add("save", "image://svgimages/outlook inspired/save.svg");
            this.img_bar.Add("charthorizontalaxis_logscale", "image://svgimages/spreadsheet/charthorizontalaxis_logscale.svg");
            this.img_bar.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.img_bar.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            this.img_bar.Add("print", "image://svgimages/outlook inspired/print.svg");
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
            // 
            // bbi_InternetAl
            // 
            this.bbi_InternetAl.Caption = "İnternetden Al";
            this.bbi_InternetAl.Id = 3;
            this.bbi_InternetAl.ImageOptions.ImageIndex = 5;
            this.bbi_InternetAl.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_InternetAl.Name = "bbi_InternetAl";
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 4;
            this.bbi_Refresh.ImageOptions.ImageIndex = 4;
            this.bbi_Refresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Refresh.Name = "bbi_Refresh";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lc_Depot);
            this.layoutControl1.Controls.Add(this.lc_Company);
            this.layoutControl1.Controls.Add(this.lp_PRoductEnd);
            this.layoutControl1.Controls.Add(this.lp_PRoductBegin);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(361, 366);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lc_Depot
            // 
            this.lc_Depot.Location = new System.Drawing.Point(112, 77);
            this.lc_Depot.MenuManager = this.barManager1;
            this.lc_Depot.Name = "lc_Depot";
            this.lc_Depot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lc_Depot.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "Depo Adı")});
            this.lc_Depot.Properties.DataSource = this.bs_Depot;
            this.lc_Depot.Properties.DisplayMember = "DepName";
            this.lc_Depot.Properties.NullText = "";
            this.lc_Depot.Properties.ValueMember = "DID";
            this.lc_Depot.Size = new System.Drawing.Size(237, 20);
            this.lc_Depot.StyleController = this.layoutControl1;
            this.lc_Depot.TabIndex = 7;
            // 
            // bs_Depot
            // 
            this.bs_Depot.DataSource = typeof(Msp.Models.Models.DepotDTO);
            // 
            // lc_Company
            // 
            this.lc_Company.Location = new System.Drawing.Point(112, 53);
            this.lc_Company.MenuManager = this.barManager1;
            this.lc_Company.Name = "lc_Company";
            this.lc_Company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_Company.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "CompanyCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "CompanyName")});
            this.lc_Company.Properties.DataSource = this.bs_company;
            this.lc_Company.Properties.DisplayMember = "CompanyName";
            this.lc_Company.Properties.NullText = "";
            this.lc_Company.Properties.ValueMember = "RecId";
            this.lc_Company.Size = new System.Drawing.Size(237, 20);
            this.lc_Company.StyleController = this.layoutControl1;
            this.lc_Company.TabIndex = 6;
            // 
            // bs_company
            // 
            this.bs_company.DataSource = typeof(Msp.Models.Models.CompanyDTO);
            // 
            // lp_PRoductEnd
            // 
            this.lp_PRoductEnd.Location = new System.Drawing.Point(182, 29);
            this.lp_PRoductEnd.MenuManager = this.barManager1;
            this.lp_PRoductEnd.Name = "lp_PRoductEnd";
            this.lp_PRoductEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lp_PRoductEnd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PName", "Name")});
            this.lp_PRoductEnd.Properties.DataSource = this.bs_Product;
            this.lp_PRoductEnd.Properties.DisplayMember = "PName";
            this.lp_PRoductEnd.Properties.NullText = "";
            this.lp_PRoductEnd.Properties.ValueMember = "PID";
            this.lp_PRoductEnd.Size = new System.Drawing.Size(167, 20);
            this.lp_PRoductEnd.StyleController = this.layoutControl1;
            this.lp_PRoductEnd.TabIndex = 5;
            // 
            // bs_Product
            // 
            this.bs_Product.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // lp_PRoductBegin
            // 
            this.lp_PRoductBegin.Location = new System.Drawing.Point(12, 29);
            this.lp_PRoductBegin.MenuManager = this.barManager1;
            this.lp_PRoductBegin.Name = "lp_PRoductBegin";
            this.lp_PRoductBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lp_PRoductBegin.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PCode", "PCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PName", "Name")});
            this.lp_PRoductBegin.Properties.DataSource = this.bs_Product;
            this.lp_PRoductBegin.Properties.DisplayMember = "PName";
            this.lp_PRoductBegin.Properties.NullText = "";
            this.lp_PRoductBegin.Properties.ValueMember = "PID";
            this.lp_PRoductBegin.Size = new System.Drawing.Size(166, 20);
            this.lp_PRoductBegin.StyleController = this.layoutControl1;
            this.lp_PRoductBegin.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(361, 366);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lp_PRoductBegin;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 89);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(341, 257);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lp_PRoductEnd;
            this.layoutControlItem2.Location = new System.Drawing.Point(170, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(171, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(341, 17);
            this.simpleLabelItem1.Text = "Stok Başlangıç / Bitiş";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lc_Company;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem3.Text = "İşyeri";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lc_Depot;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem4.Text = "Depo";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(97, 13);
            // 
            // frmEnvanterBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 406);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEnvanterBilgiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Envanter Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnvanterBilgiler_FormClosing);
            this.Load += new System.EventHandler(this.frmEnvanterBilgiler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnvanterBilgiler_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Depot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lp_PRoductEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lp_PRoductBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_Print;
        private DevExpress.XtraBars.BarButtonItem bbi_Close;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_InternetAl;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit lp_PRoductEnd;
        private DevExpress.XtraEditors.LookUpEdit lp_PRoductBegin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.LookUpEdit lc_Company;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lc_Depot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bs_Depot;
        private System.Windows.Forms.BindingSource bs_Product;
        private System.Windows.Forms.BindingSource bs_company;
    }
}