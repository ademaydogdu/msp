namespace Msp.App.Depo_Stok
{
    partial class ExpDateProducts
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
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFirstPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVarDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSpecCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrandCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPImages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExpDateRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ExpDateProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_ExpDateProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 41);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(955, 414);
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
            this.gridControl1.Size = new System.Drawing.Size(931, 390);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_ExpDateProd});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // bs_ExpDateProd
            // 
            this.bs_ExpDateProd.DataSource = typeof(Msp.Models.Models.ProductDTO);
            // 
            // gcv_ExpDateProd
            // 
            this.gcv_ExpDateProd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colPName,
            this.colPBarcode,
            this.colPCategoryId,
            this.colPDate,
            this.colPFirstPrice,
            this.colPTotal,
            this.colPLastPrice,
            this.colPUnitId,
            this.colPTax,
            this.colPVarDescription,
            this.colPSpecCode,
            this.colPBrandName,
            this.colPBrandCode,
            this.colPGroup,
            this.colPImages,
            this.colPExpDate});
            this.gcv_ExpDateProd.GridControl = this.gridControl1;
            this.gcv_ExpDateProd.Name = "gcv_ExpDateProd";
            // 
            // colPID
            // 
            this.colPID.FieldName = "ID";
            this.colPID.Name = "colPID";
            this.colPID.Visible = true;
            this.colPID.VisibleIndex = 0;
            // 
            // colPName
            // 
            this.colPName.FieldName = "Ürün Adı";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 1;
            // 
            // colPBarcode
            // 
            this.colPBarcode.FieldName = "Barkod";
            this.colPBarcode.Name = "colPBarcode";
            this.colPBarcode.Visible = true;
            this.colPBarcode.VisibleIndex = 2;
            // 
            // colPCategoryId
            // 
            this.colPCategoryId.FieldName = "Kat.ID";
            this.colPCategoryId.Name = "colPCategoryId";
            this.colPCategoryId.Visible = true;
            this.colPCategoryId.VisibleIndex = 3;
            // 
            // colPDate
            // 
            this.colPDate.FieldName = "Tarih";
            this.colPDate.Name = "colPDate";
            this.colPDate.Visible = true;
            this.colPDate.VisibleIndex = 4;
            // 
            // colPFirstPrice
            // 
            this.colPFirstPrice.FieldName = "Geliş Fiyatı";
            this.colPFirstPrice.Name = "colPFirstPrice";
            this.colPFirstPrice.Visible = true;
            this.colPFirstPrice.VisibleIndex = 5;
            // 
            // colPTotal
            // 
            this.colPTotal.FieldName = "Stok";
            this.colPTotal.Name = "colPTotal";
            this.colPTotal.Visible = true;
            this.colPTotal.VisibleIndex = 6;
            // 
            // colPLastPrice
            // 
            this.colPLastPrice.FieldName = "Satış Fiyatı";
            this.colPLastPrice.Name = "colPLastPrice";
            this.colPLastPrice.Visible = true;
            this.colPLastPrice.VisibleIndex = 7;
            // 
            // colPUnitId
            // 
            this.colPUnitId.FieldName = "Birim";
            this.colPUnitId.Name = "colPUnitId";
            this.colPUnitId.Visible = true;
            this.colPUnitId.VisibleIndex = 8;
            // 
            // colPTax
            // 
            this.colPTax.FieldName = "KDV";
            this.colPTax.Name = "colPTax";
            this.colPTax.Visible = true;
            this.colPTax.VisibleIndex = 9;
            // 
            // colPVarDescription
            // 
            this.colPVarDescription.FieldName = "PVarDescription";
            this.colPVarDescription.Name = "colPVarDescription";
            this.colPVarDescription.Visible = true;
            this.colPVarDescription.VisibleIndex = 10;
            // 
            // colPSpecCode
            // 
            this.colPSpecCode.FieldName = "Özel Kodu";
            this.colPSpecCode.Name = "colPSpecCode";
            this.colPSpecCode.Visible = true;
            this.colPSpecCode.VisibleIndex = 11;
            // 
            // colPBrandName
            // 
            this.colPBrandName.FieldName = "Marka";
            this.colPBrandName.Name = "colPBrandName";
            this.colPBrandName.Visible = true;
            this.colPBrandName.VisibleIndex = 12;
            // 
            // colPBrandCode
            // 
            this.colPBrandCode.FieldName = "Marka Kodu";
            this.colPBrandCode.Name = "colPBrandCode";
            this.colPBrandCode.Visible = true;
            this.colPBrandCode.VisibleIndex = 13;
            // 
            // colPGroup
            // 
            this.colPGroup.FieldName = "Grup";
            this.colPGroup.Name = "colPGroup";
            this.colPGroup.Visible = true;
            this.colPGroup.VisibleIndex = 14;
            // 
            // colPImages
            // 
            this.colPImages.FieldName = "Fotoğraf";
            this.colPImages.Name = "colPImages";
            this.colPImages.Visible = true;
            this.colPImages.VisibleIndex = 15;
            // 
            // colPExpDate
            // 
            this.colPExpDate.FieldName = "S.K.T";
            this.colPExpDate.Name = "colPExpDate";
            this.colPExpDate.Visible = true;
            this.colPExpDate.VisibleIndex = 16;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.svgImageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExpDateRefresh,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExpDateRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(955, 41);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(955, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(955, 414);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(935, 394);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnExpDateRefresh
            // 
            this.btnExpDateRefresh.Caption = "Yenile";
            this.btnExpDateRefresh.Id = 0;
            this.btnExpDateRefresh.ImageOptions.ImageIndex = 0;
            this.btnExpDateRefresh.Name = "btnExpDateRefresh";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kapat";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
          //  this.svgImageCollection1.Add("view-refresh", "view_refresh", typeof(Msp.App.Properties.Resources));
            //this.svgImageCollection1.Add("error-button", "error_button", typeof(Msp.App.Properties.Resources));
          //  this.svgImageCollection1.Add("molumen_red_round_error_warning_icon", "molumen_red_round_error_warning_icon", typeof(Msp.App.Properties.Resources));
            // 
            // ExpDateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 497);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ExpDateProducts";
            this.Text = "ExpDateProducts";
            this.Load += new System.EventHandler(this.ExpDateProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ExpDateProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_ExpDateProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_ExpDateProd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bs_ExpDateProd;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colPCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colPDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPFirstPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPLastPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPTax;
        private DevExpress.XtraGrid.Columns.GridColumn colPVarDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPSpecCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrandCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colPImages;
        private DevExpress.XtraGrid.Columns.GridColumn colPExpDate;
        private DevExpress.XtraBars.BarButtonItem btnExpDateRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}