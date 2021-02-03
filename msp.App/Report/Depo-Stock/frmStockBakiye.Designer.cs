namespace Msp.App.Report.Depo_Stock
{
    partial class frmStockBakiye
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dt_BeginDate = new DevExpress.XtraEditors.DateEdit();
            this.dt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.sic_img = new DevExpress.Utils.SvgImageCollection(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bs_StockBakiye = new System.Windows.Forms.BindingSource(this.components);
            this.colPDepotId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGiren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_Depot = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rp_Unit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_Unit = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Depot = new System.Windows.Forms.BindingSource(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_StockBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Depot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dt_BeginDate);
            this.layoutControl1.Controls.Add(this.dt_EndDate);
            this.layoutControl1.Controls.Add(this.btnListele);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(711, 463);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_StockBakiye;
            this.gridControl1.Location = new System.Drawing.Point(12, 129);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rp_Depot,
            this.rp_Unit});
            this.gridControl1.Size = new System.Drawing.Size(687, 322);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPName,
            this.colPDepotId,
            this.colPUnitId,
            this.colTGiren,
            this.colTCikis,
            this.colPTotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dt_BeginDate
            // 
            this.dt_BeginDate.EditValue = null;
            this.dt_BeginDate.Location = new System.Drawing.Point(102, 45);
            this.dt_BeginDate.Name = "dt_BeginDate";
            this.dt_BeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_BeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_BeginDate.Size = new System.Drawing.Size(149, 20);
            this.dt_BeginDate.StyleController = this.layoutControl1;
            this.dt_BeginDate.TabIndex = 5;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.EditValue = null;
            this.dt_EndDate.Location = new System.Drawing.Point(308, 45);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_EndDate.Size = new System.Drawing.Size(154, 20);
            this.dt_EndDate.StyleController = this.layoutControl1;
            this.dt_EndDate.TabIndex = 6;
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.ImageIndex = 2;
            this.btnListele.ImageOptions.ImageList = this.sic_img;
            this.btnListele.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnListele.Location = new System.Drawing.Point(24, 69);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(123, 44);
            this.btnListele.StyleController = this.layoutControl1;
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // sic_img
            // 
            this.sic_img.ImageSize = new System.Drawing.Size(26, 26);
            this.sic_img.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.sic_img.Add("del", "image://svgimages/diagramicons/del.svg");
            this.sic_img.Add("update", "image://svgimages/dashboards/update.svg");
            this.sic_img.Add("open2", "image://svgimages/actions/open2.svg");
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(711, 463);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(691, 326);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(691, 117);
            this.layoutControlGroup1.Text = "Filtre";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dt_BeginDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Başlangıç Tarihi";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dt_EndDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(231, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(211, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(211, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(211, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Bitiş Tarihi";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnListele;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(127, 48);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(127, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(127, 48);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(442, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(225, 72);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(127, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(315, 48);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            this.barManager1.Images = this.sic_img;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem1,
            this.barButtonItem3,
            this.barButtonItem4});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Uygula";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kapat";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(711, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 463);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 463);
            // 
            // bs_StockBakiye
            // 
            this.bs_StockBakiye.DataSource = typeof(Msp.Models.Models.Report.StockBakiyeReportDTO);
            // 
            // colPDepotId
            // 
            this.colPDepotId.Caption = "Depo Adı";
            this.colPDepotId.ColumnEdit = this.rp_Depot;
            this.colPDepotId.FieldName = "PDepotId";
            this.colPDepotId.Name = "colPDepotId";
            this.colPDepotId.Visible = true;
            this.colPDepotId.VisibleIndex = 1;
            // 
            // colPName
            // 
            this.colPName.Caption = "Ürün Adı";
            this.colPName.FieldName = "PName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 0;
            // 
            // colPTotal
            // 
            this.colPTotal.Caption = "Miktar";
            this.colPTotal.FieldName = "PTotal";
            this.colPTotal.Name = "colPTotal";
            this.colPTotal.Visible = true;
            this.colPTotal.VisibleIndex = 5;
            // 
            // colPUnitId
            // 
            this.colPUnitId.Caption = "Birim";
            this.colPUnitId.ColumnEdit = this.rp_Unit;
            this.colPUnitId.FieldName = "PUnitId";
            this.colPUnitId.Name = "colPUnitId";
            this.colPUnitId.Visible = true;
            this.colPUnitId.VisibleIndex = 2;
            // 
            // colTGiren
            // 
            this.colTGiren.Caption = "Toplam Giriş Tutar";
            this.colTGiren.DisplayFormat.FormatString = "n2";
            this.colTGiren.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTGiren.FieldName = "TGiren";
            this.colTGiren.Name = "colTGiren";
            this.colTGiren.Visible = true;
            this.colTGiren.VisibleIndex = 3;
            this.colTGiren.Width = 125;
            // 
            // colTCikis
            // 
            this.colTCikis.Caption = "Toplam Çıkış Tutar";
            this.colTCikis.DisplayFormat.FormatString = "n2";
            this.colTCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTCikis.FieldName = "TCikis";
            this.colTCikis.Name = "colTCikis";
            this.colTCikis.Visible = true;
            this.colTCikis.VisibleIndex = 4;
            this.colTCikis.Width = 135;
            // 
            // rp_Depot
            // 
            this.rp_Depot.AutoHeight = false;
            this.rp_Depot.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_Depot.DataSource = this.bs_Depot;
            this.rp_Depot.DisplayMember = "DepName";
            this.rp_Depot.Name = "rp_Depot";
            this.rp_Depot.NullText = "";
            this.rp_Depot.ValueMember = "DID";
            // 
            // rp_Unit
            // 
            this.rp_Unit.AutoHeight = false;
            this.rp_Unit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_Unit.DataSource = this.bs_Unit;
            this.rp_Unit.DisplayMember = "UName";
            this.rp_Unit.Name = "rp_Unit";
            this.rp_Unit.NullText = "";
            this.rp_Unit.ValueMember = "UID";
            // 
            // bs_Unit
            // 
            this.bs_Unit.DataSource = typeof(Msp.Models.Models.UnitsDTO);
            // 
            // bs_Depot
            // 
            this.bs_Depot.DataSource = typeof(Msp.Models.Models.DepotDTO);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Export";
            this.barSubItem1.Id = 2;
            this.barSubItem1.ImageOptions.ImageIndex = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Excel";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "PDF";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // frmStockBakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 499);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStockBakiye";
            this.Text = "Stock Bakiye Raporları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockBakiye_FormClosing);
            this.Load += new System.EventHandler(this.frmStockBakiye_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockBakiye_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_StockBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Depot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dt_BeginDate;
        private DevExpress.XtraEditors.DateEdit dt_EndDate;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection sic_img;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource bs_StockBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPDepotId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_Depot;
        private DevExpress.XtraGrid.Columns.GridColumn colPUnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn colTGiren;
        private DevExpress.XtraGrid.Columns.GridColumn colTCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colPTotal;
        private System.Windows.Forms.BindingSource bs_Depot;
        private System.Windows.Forms.BindingSource bs_Unit;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}