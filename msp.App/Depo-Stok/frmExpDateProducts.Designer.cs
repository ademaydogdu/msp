namespace Msp.App.Depo_Stok
{
    partial class frmExpDateProducts
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
            this.bs_ExpDateProd = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_ExpDateProd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFirstPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnExpDateRefr = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.btnExpDateRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ExpDateProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_ExpDateProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.svgImageCollection1;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(955, 455);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_ExpDateProd;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gcv_ExpDateProd;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(931, 431);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_ExpDateProd});
            // 
            // bs_ExpDateProd
            // 
            this.bs_ExpDateProd.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // gcv_ExpDateProd
            // 
            this.gcv_ExpDateProd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPExpDate,
            this.colPName,
            this.colPCategoryId,
            this.colPDate,
            this.colPFirstPrice,
            this.colPUnitId,
            this.colPTax,
            this.colPBrandName});
            this.gcv_ExpDateProd.GridControl = this.gridControl1;
            this.gcv_ExpDateProd.Name = "gcv_ExpDateProd";
            this.gcv_ExpDateProd.OptionsView.ShowAutoFilterRow = true;
            this.gcv_ExpDateProd.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gcv_ExpDateProd_CustomDrawCell);
            // 
            // colPExpDate
            // 
            this.colPExpDate.Caption = "S.K.T";
            this.colPExpDate.FieldName = "PExpDate";
            this.colPExpDate.Name = "colPExpDate";
            this.colPExpDate.Visible = true;
            this.colPExpDate.VisibleIndex = 7;
            // 
            // colPName
            // 
            this.colPName.Caption = "Ürün Adı";
            this.colPName.FieldName = "PName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 0;
            // 
            // colPCategoryId
            // 
            this.colPCategoryId.Caption = "Kat.ID";
            this.colPCategoryId.FieldName = "PCategoryId";
            this.colPCategoryId.Name = "colPCategoryId";
            this.colPCategoryId.Visible = true;
            this.colPCategoryId.VisibleIndex = 1;
            // 
            // colPDate
            // 
            this.colPDate.Caption = "Kayıt Tarih";
            this.colPDate.FieldName = "PDate";
            this.colPDate.Name = "colPDate";
            this.colPDate.Visible = true;
            this.colPDate.VisibleIndex = 2;
            // 
            // colPFirstPrice
            // 
            this.colPFirstPrice.Caption = "Geliş Fiyatı";
            this.colPFirstPrice.FieldName = "PFirstPrice";
            this.colPFirstPrice.Name = "colPFirstPrice";
            this.colPFirstPrice.Visible = true;
            this.colPFirstPrice.VisibleIndex = 3;
            // 
            // colPUnitId
            // 
            this.colPUnitId.Caption = "Birim";
            this.colPUnitId.FieldName = "PUnitId";
            this.colPUnitId.Name = "colPUnitId";
            this.colPUnitId.Visible = true;
            this.colPUnitId.VisibleIndex = 4;
            // 
            // colPTax
            // 
            this.colPTax.Caption = "KDV";
            this.colPTax.FieldName = "PTax";
            this.colPTax.Name = "colPTax";
            this.colPTax.Visible = true;
            this.colPTax.VisibleIndex = 5;
            // 
            // colPBrandName
            // 
            this.colPBrandName.Caption = "Marka";
            this.colPBrandName.FieldName = "PBrandName";
            this.colPBrandName.Name = "colPBrandName";
            this.colPBrandName.Visible = true;
            this.colPBrandName.VisibleIndex = 6;
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
            this.barManager1.Images = this.svgImageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExpDateRefresh,
            this.barButtonItem2,
            this.btnExpDateRefr,
            this.barButtonItem1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExpDateRefr),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnExpDateRefr
            // 
            this.btnExpDateRefr.Caption = "Yenile";
            this.btnExpDateRefr.Id = 2;
            this.btnExpDateRefr.ImageOptions.ImageIndex = 50;
            this.btnExpDateRefr.Name = "btnExpDateRefr";
            this.btnExpDateRefr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpDateRefr_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kapat";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 1;
            this.barButtonItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yenile";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.ImageIndex = 43;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(955, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 455);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(955, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 455);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(955, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 455);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("bo_validation", "image://svgimages/business objects/bo_validation.svg");
            this.svgImageCollection1.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.svgImageCollection1.Add("bo_address", "image://svgimages/business objects/bo_address.svg");
            this.svgImageCollection1.Add("bo_contact", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection1.Add("bo_customer", "image://svgimages/business objects/bo_customer.svg");
            this.svgImageCollection1.Add("bo_department", "image://svgimages/business objects/bo_department.svg");
            this.svgImageCollection1.Add("bo_lead", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection1.Add("bo_mydetails", "image://svgimages/business objects/bo_mydetails.svg");
            this.svgImageCollection1.Add("bo_phone", "image://svgimages/business objects/bo_phone.svg");
            this.svgImageCollection1.Add("bo_position_v92", "image://svgimages/business objects/bo_position_v92.svg");
            this.svgImageCollection1.Add("bo_user", "image://svgimages/business objects/bo_user.svg");
            this.svgImageCollection1.Add("bo_validation_1", "image://svgimages/business objects/bo_validation.svg");
            this.svgImageCollection1.Add("shapelabels", "image://svgimages/dashboards/shapelabels.svg");
            this.svgImageCollection1.Add("about", "image://svgimages/outlook inspired/about.svg");
            this.svgImageCollection1.Add("clearformatting", "image://svgimages/outlook inspired/clearformatting.svg");
            this.svgImageCollection1.Add("costanalysis", "image://svgimages/outlook inspired/costanalysis.svg");
            this.svgImageCollection1.Add("fax", "image://svgimages/outlook inspired/fax.svg");
            this.svgImageCollection1.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.svgImageCollection1.Add("highimportance", "image://svgimages/outlook inspired/highimportance.svg");
            this.svgImageCollection1.Add("mapit", "image://svgimages/outlook inspired/mapit.svg");
            this.svgImageCollection1.Add("markcomplete", "image://svgimages/outlook inspired/markcomplete.svg");
            this.svgImageCollection1.Add("newcustomer", "image://svgimages/outlook inspired/newcustomer.svg");
            this.svgImageCollection1.Add("newemployee", "image://svgimages/outlook inspired/newemployee.svg");
            this.svgImageCollection1.Add("tabletoffice", "image://svgimages/outlook inspired/tabletoffice.svg");
            this.svgImageCollection1.Add("highlight", "image://svgimages/pdf viewer/highlight.svg");
            this.svgImageCollection1.Add("barcodeshowtext", "image://svgimages/reports/barcodeshowtext.svg");
            this.svgImageCollection1.Add("changetextcase", "image://svgimages/richedit/changetextcase.svg");
            this.svgImageCollection1.Add("general", "image://svgimages/spreadsheet/general.svg");
            this.svgImageCollection1.Add("warning", "image://svgimages/status/warning.svg");
            this.svgImageCollection1.Add("customerquicklocations", "image://svgimages/outlook inspired/customerquicklocations.svg");
            this.svgImageCollection1.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            this.svgImageCollection1.Add("insertbubblemap", "image://svgimages/dashboards/insertbubblemap.svg");
            this.svgImageCollection1.Add("insertpiemap", "image://svgimages/dashboards/insertpiemap.svg");
            this.svgImageCollection1.Add("highimportance_1", "image://svgimages/scheduling/highimportance.svg");
            this.svgImageCollection1.Add("timezones", "image://svgimages/scheduling/timezones.svg");
            this.svgImageCollection1.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg");
            this.svgImageCollection1.Add("bo_document", "image://svgimages/business objects/bo_document.svg");
            this.svgImageCollection1.Add("bo_attention", "image://svgimages/business objects/bo_attention.svg");
            this.svgImageCollection1.Add("percentstyle", "image://svgimages/spreadsheet/percentstyle.svg");
            this.svgImageCollection1.Add("bo_audit_changehistory", "image://svgimages/business objects/bo_audit_changehistory.svg");
            this.svgImageCollection1.Add("bottom10percent", "image://svgimages/spreadsheet/bottom10percent.svg");
            this.svgImageCollection1.Add("card", "image://svgimages/outlook inspired/card.svg");
            this.svgImageCollection1.Add("bo_contact_1", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection1.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            this.svgImageCollection1.Add("deletedatasource", "image://svgimages/dashboards/deletedatasource.svg");
            this.svgImageCollection1.Add("updatedataextract", "image://svgimages/dashboards/updatedataextract.svg");
            this.svgImageCollection1.Add("newdatasource", "image://svgimages/dashboards/newdatasource.svg");
            this.svgImageCollection1.Add("managedatasource", "image://svgimages/spreadsheet/managedatasource.svg");
            this.svgImageCollection1.Add("editdatasource", "image://svgimages/dashboards/editdatasource.svg");
            this.svgImageCollection1.Add("datasource", "image://svgimages/snap/datasource.svg");
            this.svgImageCollection1.Add("print", "image://svgimages/dashboards/print.svg");
            // 
            // btnExpDateRefresh
            // 
            this.btnExpDateRefresh.Caption = "Yenile";
            this.btnExpDateRefresh.Id = 0;
            this.btnExpDateRefresh.ImageOptions.ImageIndex = 0;
            this.btnExpDateRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnExpDateRefresh.Name = "btnExpDateRefresh";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(955, 455);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(935, 435);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmExpDateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 497);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmExpDateProducts";
            this.Text = "Son Kullanma Tarihi Kontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExpDateProducts_FormClosing);
            this.Load += new System.EventHandler(this.frmExpDateProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ExpDateProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_ExpDateProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_ExpDateProd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bs_ExpDateProd;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colPDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFirstPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPTax;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colPExpDate;
        private DevExpress.XtraBars.BarButtonItem btnExpDateRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnExpDateRefr;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}