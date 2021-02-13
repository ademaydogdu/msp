namespace Msp.App.Report.Fatura
{
    partial class FaturaKDV
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
            this.bbi_Report = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sic_img = new DevExpress.Utils.SvgImageCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dt_EndDate = new DevExpress.XtraEditors.DateEdit();
            this.dt_Begindate = new DevExpress.XtraEditors.DateEdit();
            this.btnReportGetir = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.bs_KDVReport = new System.Windows.Forms.BindingSource(this.components);
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisMatrah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisMatrah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rp_KDV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Begindate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Begindate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KDVReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_KDV)).BeginInit();
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
            this.barManager1.Images = this.sic_img;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Report,
            this.bbi_Close});
            this.barManager1.MaxItemId = 2;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Close)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_Report
            // 
            this.bbi_Report.Caption = "Uygula";
            this.bbi_Report.Id = 0;
            this.bbi_Report.ImageOptions.ImageIndex = 0;
            this.bbi_Report.Name = "bbi_Report";
            // 
            // bbi_Close
            // 
            this.bbi_Close.Caption = "Kapat";
            this.bbi_Close.Id = 1;
            this.bbi_Close.ImageOptions.ImageIndex = 1;
            this.bbi_Close.Name = "bbi_Close";
            this.bbi_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Close_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(741, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 431);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(741, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(741, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // sic_img
            // 
            this.sic_img.ImageSize = new System.Drawing.Size(32, 32);
            this.sic_img.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.sic_img.Add("del", "image://svgimages/diagramicons/del.svg");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dt_EndDate);
            this.layoutControl1.Controls.Add(this.dt_Begindate);
            this.layoutControl1.Controls.Add(this.btnReportGetir);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(741, 431);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_KDVReport;
            this.gridControl1.Location = new System.Drawing.Point(12, 131);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rp_KDV});
            this.gridControl1.Size = new System.Drawing.Size(717, 288);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKDV,
            this.colAlisMatrah,
            this.colSatisMatrah,
            this.colAlisKDV,
            this.colSatisKDV,
            this.colFarki});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.EditValue = null;
            this.dt_EndDate.Location = new System.Drawing.Point(100, 69);
            this.dt_EndDate.MenuManager = this.barManager1;
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_EndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_EndDate.Size = new System.Drawing.Size(169, 20);
            this.dt_EndDate.StyleController = this.layoutControl1;
            this.dt_EndDate.TabIndex = 4;
            // 
            // dt_Begindate
            // 
            this.dt_Begindate.EditValue = null;
            this.dt_Begindate.Location = new System.Drawing.Point(100, 45);
            this.dt_Begindate.MenuManager = this.barManager1;
            this.dt_Begindate.Name = "dt_Begindate";
            this.dt_Begindate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Begindate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Begindate.Size = new System.Drawing.Size(169, 20);
            this.dt_Begindate.StyleController = this.layoutControl1;
            this.dt_Begindate.TabIndex = 5;
            // 
            // btnReportGetir
            // 
            this.btnReportGetir.Location = new System.Drawing.Point(24, 93);
            this.btnReportGetir.Name = "btnReportGetir";
            this.btnReportGetir.Size = new System.Drawing.Size(245, 22);
            this.btnReportGetir.StyleController = this.layoutControl1;
            this.btnReportGetir.TabIndex = 6;
            this.btnReportGetir.Text = "Getir";
            this.btnReportGetir.Click += new System.EventHandler(this.btnReportGetir_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(741, 431);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(721, 119);
            this.layoutControlGroup1.Text = "Filter";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnReportGetir;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(249, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dt_EndDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Bitiş Tarihi";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dt_Begindate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(249, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(249, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Başlangıç Tarihi";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(249, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(448, 74);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(721, 292);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Uygula";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kapat";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(741, 0);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Size = new System.Drawing.Size(0, 431);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Uygula";
            this.barButtonItem3.Id = 0;
            this.barButtonItem3.ImageOptions.ImageIndex = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Kapat";
            this.barButtonItem4.Id = 1;
            this.barButtonItem4.ImageOptions.ImageIndex = 1;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl9.Location = new System.Drawing.Point(741, 0);
            this.barDockControl9.Manager = null;
            this.barDockControl9.Size = new System.Drawing.Size(0, 431);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Uygula";
            this.barButtonItem5.Id = 0;
            this.barButtonItem5.ImageOptions.ImageIndex = 0;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Kapat";
            this.barButtonItem6.Id = 1;
            this.barButtonItem6.ImageOptions.ImageIndex = 1;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(741, 0);
            this.barDockControl5.Manager = null;
            this.barDockControl5.Size = new System.Drawing.Size(0, 431);
            // 
            // bs_KDVReport
            // 
            this.bs_KDVReport.DataSource = typeof(Msp.Models.Models.Report.KDVReportDto);
            // 
            // colKDV
            // 
            this.colKDV.Caption = "KDV";
            this.colKDV.ColumnEdit = this.rp_KDV;
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 0;
            // 
            // colAlisMatrah
            // 
            this.colAlisMatrah.Caption = "Alış Matrah";
            this.colAlisMatrah.DisplayFormat.FormatString = "n2";
            this.colAlisMatrah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisMatrah.FieldName = "AlisMatrah";
            this.colAlisMatrah.Name = "colAlisMatrah";
            this.colAlisMatrah.Visible = true;
            this.colAlisMatrah.VisibleIndex = 1;
            // 
            // colSatisMatrah
            // 
            this.colSatisMatrah.Caption = "Satış Matrah";
            this.colSatisMatrah.DisplayFormat.FormatString = "n2";
            this.colSatisMatrah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisMatrah.FieldName = "SatisMatrah";
            this.colSatisMatrah.Name = "colSatisMatrah";
            this.colSatisMatrah.Visible = true;
            this.colSatisMatrah.VisibleIndex = 2;
            // 
            // colAlisKDV
            // 
            this.colAlisKDV.Caption = "Alış KDV";
            this.colAlisKDV.DisplayFormat.FormatString = "n2";
            this.colAlisKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisKDV.FieldName = "AlisKDV";
            this.colAlisKDV.Name = "colAlisKDV";
            this.colAlisKDV.Visible = true;
            this.colAlisKDV.VisibleIndex = 3;
            // 
            // colSatisKDV
            // 
            this.colSatisKDV.Caption = "Satış KDV";
            this.colSatisKDV.DisplayFormat.FormatString = "n2";
            this.colSatisKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisKDV.FieldName = "SatisKDV";
            this.colSatisKDV.Name = "colSatisKDV";
            this.colSatisKDV.Visible = true;
            this.colSatisKDV.VisibleIndex = 4;
            // 
            // colFarki
            // 
            this.colFarki.Caption = "KDV Farkı";
            this.colFarki.DisplayFormat.FormatString = "n2";
            this.colFarki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFarki.FieldName = "Farki";
            this.colFarki.Name = "colFarki";
            this.colFarki.Visible = true;
            this.colFarki.VisibleIndex = 5;
            // 
            // rp_KDV
            // 
            this.rp_KDV.AutoHeight = false;
            this.rp_KDV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rp_KDV.Name = "rp_KDV";
            this.rp_KDV.NullText = "";
            // 
            // FaturaKDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 473);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl9);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FaturaKDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KDV Raporu";
            this.Load += new System.EventHandler(this.FaturaKDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_EndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Begindate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Begindate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KDVReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_KDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_Report;
        private DevExpress.XtraBars.BarButtonItem bbi_Close;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection sic_img;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dt_EndDate;
        private DevExpress.XtraEditors.DateEdit dt_Begindate;
        private DevExpress.XtraEditors.SimpleButton btnReportGetir;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bs_KDVReport;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisMatrah;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisMatrah;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colFarki;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rp_KDV;
    }
}