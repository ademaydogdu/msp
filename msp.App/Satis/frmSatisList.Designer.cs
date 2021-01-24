namespace Msp.App.Satis
{
    partial class frmSatisList
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
            this.gc_SiparisList = new DevExpress.XtraGrid.GridControl();
            this.bs_SaleOwner = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeresiyeClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeresiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_Report = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_exp = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_sig = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_Export = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dt_Date = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bs_SaleTrans = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SiparisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_SiparisList);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(895, 648);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_SiparisList
            // 
            this.gc_SiparisList.DataSource = this.bs_SaleOwner;
            this.gc_SiparisList.Location = new System.Drawing.Point(12, 62);
            this.gc_SiparisList.MainView = this.gridView1;
            this.gc_SiparisList.Name = "gc_SiparisList";
            this.gc_SiparisList.Size = new System.Drawing.Size(871, 574);
            this.gc_SiparisList.TabIndex = 0;
            this.gc_SiparisList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bs_SaleOwner
            // 
            this.bs_SaleOwner.DataSource = typeof(Msp.Models.Models.Sale.SaleOwnerDTO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.colDate,
            this.colTotalPriceText,
            this.colUserCode,
            this.colCustomerName,
            this.colPaymentType,
            this.colNetPrice,
            this.colKDV,
            this.colDiscountPrice,
            this.colTotalPrice,
            this.colReceivedPrice,
            this.colRemark,
            this.colVeresiyeClosedDate,
            this.colVeresiye});
            this.gridView1.GridControl = this.gc_SiparisList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colTotalPriceText
            // 
            this.colTotalPriceText.Caption = "Toplam Fiyat";
            this.colTotalPriceText.FieldName = "TotalPriceText";
            this.colTotalPriceText.Name = "colTotalPriceText";
            this.colTotalPriceText.Visible = true;
            this.colTotalPriceText.VisibleIndex = 2;
            // 
            // colUserCode
            // 
            this.colUserCode.Caption = "Kayıt Eden";
            this.colUserCode.FieldName = "UserCode";
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.Visible = true;
            this.colUserCode.VisibleIndex = 3;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Müşteri Adı";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Ödeme Tipi";
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 4;
            // 
            // colNetPrice
            // 
            this.colNetPrice.DisplayFormat.FormatString = "n2";
            this.colNetPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.Visible = true;
            this.colNetPrice.VisibleIndex = 5;
            // 
            // colKDV
            // 
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 6;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.DisplayFormat.FormatString = "n2";
            this.colDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 7;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Toplam Fiyat";
            this.colTotalPrice.DisplayFormat.FormatString = "n2";
            this.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPrice.FieldName = "TotalPriceText";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 8;
            // 
            // colReceivedPrice
            // 
            this.colReceivedPrice.Caption = "Alınan Para";
            this.colReceivedPrice.FieldName = "AlinanPrice";
            this.colReceivedPrice.Name = "colReceivedPrice";
            this.colReceivedPrice.Visible = true;
            this.colReceivedPrice.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "Açıklama";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
            // 
            // colVeresiyeClosedDate
            // 
            this.colVeresiyeClosedDate.FieldName = "VeresiyeClosedDate";
            this.colVeresiyeClosedDate.Name = "colVeresiyeClosedDate";
            // 
            // colVeresiye
            // 
            this.colVeresiye.FieldName = "Veresiye";
            this.colVeresiye.Name = "colVeresiye";
            this.colVeresiye.Visible = true;
            this.colVeresiye.VisibleIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.dt_Date);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 46);
            this.panelControl1.TabIndex = 4;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 0;
            this.radioGroup1.Location = new System.Drawing.Point(296, 6);
            this.radioGroup1.MenuManager = this.barManager1;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tümü")});
            this.radioGroup1.Size = new System.Drawing.Size(169, 35);
            this.radioGroup1.TabIndex = 2;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.bbi_Report,
            this.bbi_Delete});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_exp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Delete, true)});
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
            this.bbi_Report.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Report_ItemClick);
            // 
            // bbi_exp
            // 
            this.bbi_exp.Caption = "Export";
            this.bbi_exp.Id = 1;
            this.bbi_exp.ImageOptions.ImageIndex = 3;
            this.bbi_exp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bbi_exp.Name = "bbi_exp";
            this.bbi_exp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Excel";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.ImageIndex = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "PDF";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.ImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Sil";
            this.bbi_Delete.Id = 5;
            this.bbi_Delete.ImageOptions.ImageIndex = 5;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 648);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 648);
            // 
            // img_sig
            // 
            this.img_sig.ImageSize = new System.Drawing.Size(24, 24);
            this.img_sig.Add("rotateclockwise", "image://svgimages/pdf viewer/rotateclockwise.svg");
            this.img_sig.Add("exporttopdf", "image://svgimages/export/exporttopdf.svg");
            this.img_sig.Add("exporttoxls", "image://svgimages/export/exporttoxls.svg");
            this.img_sig.Add("open2", "image://svgimages/actions/open2.svg");
            this.img_sig.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.img_sig.Add("deletedatasource", "image://svgimages/dashboards/deletedatasource.svg");
            // 
            // bbi_Export
            // 
            this.bbi_Export.ActAsDropDown = true;
            this.bbi_Export.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbi_Export.Caption = "Export";
            this.bbi_Export.DropDownControl = this.popupMenu1;
            this.bbi_Export.Id = 0;
            this.bbi_Export.Name = "bbi_Export";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.ImageIndex = 0;
            this.btnRefresh.ImageOptions.ImageList = this.img_sig;
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(215, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dt_Date
            // 
            this.dt_Date.EditValue = null;
            this.dt_Date.Location = new System.Drawing.Point(26, 12);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Date.Size = new System.Drawing.Size(183, 20);
            this.dt_Date.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(895, 648);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(875, 50);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(875, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(875, 50);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gc_SiparisList;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(875, 578);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmSatisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 682);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatisList";
            this.Text = "Satış Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSatisList_FormClosing);
            this.Load += new System.EventHandler(this.frmSatisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SiparisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gc_SiparisList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dt_Date;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bs_SaleOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private System.Windows.Forms.BindingSource bs_SaleTrans;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.Utils.SvgImageCollection img_sig;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceText;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCode;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem bbi_exp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbi_Export;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbi_Report;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colVeresiyeClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVeresiye;
    }
}