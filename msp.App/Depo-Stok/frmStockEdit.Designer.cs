namespace Msp.App.Depo_Stok
{
    partial class frmStockEdit
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
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bs_StockEdit = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForname = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForbarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.categoryIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForcategoryId = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemFordate = new DevExpress.XtraLayout.LayoutControlItem();
            this.firstPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForfirstPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.totalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFortotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lastPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForlastPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.barcodeTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_StockEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForbarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfirstPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlastPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_StockEdit
            // 
            this.bs_StockEdit.DataSource = typeof(Msp.Models.Models.ProductDTO);
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
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
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
            this.barDockControlTop.Size = new System.Drawing.Size(708, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 349);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(708, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 349);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(708, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 349);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.nameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.categoryIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.firstPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.totalTextEdit);
            this.dataLayoutControl1.Controls.Add(this.lastPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.barcodeTextEdit);
            this.dataLayoutControl1.DataSource = this.bs_StockEdit;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(708, 349);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(708, 349);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForname,
            this.ItemForbarcode,
            this.ItemForcategoryId,
            this.ItemFordate,
            this.ItemForfirstPrice,
            this.ItemForlastPrice,
            this.ItemFortotal});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(688, 329);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(277, 12);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(419, 20);
            this.nameTextEdit.StyleController = this.dataLayoutControl1;
            this.nameTextEdit.TabIndex = 4;
            // 
            // ItemForname
            // 
            this.ItemForname.Control = this.nameTextEdit;
            this.ItemForname.Location = new System.Drawing.Point(197, 0);
            this.ItemForname.Name = "ItemForname";
            this.ItemForname.Size = new System.Drawing.Size(491, 24);
            this.ItemForname.Text = "name";
            this.ItemForname.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForbarcode
            // 
            this.ItemForbarcode.Control = this.barcodeTextEdit;
            this.ItemForbarcode.Location = new System.Drawing.Point(0, 24);
            this.ItemForbarcode.Name = "ItemForbarcode";
            this.ItemForbarcode.Size = new System.Drawing.Size(688, 24);
            this.ItemForbarcode.Text = "barcode";
            this.ItemForbarcode.TextSize = new System.Drawing.Size(56, 13);
            // 
            // categoryIdTextEdit
            // 
            this.categoryIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "categoryId", true));
            this.categoryIdTextEdit.Location = new System.Drawing.Point(80, 60);
            this.categoryIdTextEdit.MenuManager = this.barManager1;
            this.categoryIdTextEdit.Name = "categoryIdTextEdit";
            this.categoryIdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.categoryIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.categoryIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.categoryIdTextEdit.Properties.Mask.EditMask = "N0";
            this.categoryIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.categoryIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.categoryIdTextEdit.Size = new System.Drawing.Size(616, 20);
            this.categoryIdTextEdit.StyleController = this.dataLayoutControl1;
            this.categoryIdTextEdit.TabIndex = 6;
            // 
            // ItemForcategoryId
            // 
            this.ItemForcategoryId.Control = this.categoryIdTextEdit;
            this.ItemForcategoryId.Location = new System.Drawing.Point(0, 48);
            this.ItemForcategoryId.Name = "ItemForcategoryId";
            this.ItemForcategoryId.Size = new System.Drawing.Size(688, 24);
            this.ItemForcategoryId.Text = "category Id";
            this.ItemForcategoryId.TextSize = new System.Drawing.Size(56, 13);
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "date", true));
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(80, 84);
            this.dateDateEdit.MenuManager = this.barManager1;
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(616, 20);
            this.dateDateEdit.StyleController = this.dataLayoutControl1;
            this.dateDateEdit.TabIndex = 7;
            // 
            // ItemFordate
            // 
            this.ItemFordate.Control = this.dateDateEdit;
            this.ItemFordate.Location = new System.Drawing.Point(0, 72);
            this.ItemFordate.Name = "ItemFordate";
            this.ItemFordate.Size = new System.Drawing.Size(688, 24);
            this.ItemFordate.Text = "date";
            this.ItemFordate.TextSize = new System.Drawing.Size(56, 13);
            // 
            // firstPriceTextEdit
            // 
            this.firstPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "firstPrice", true));
            this.firstPriceTextEdit.Location = new System.Drawing.Point(80, 108);
            this.firstPriceTextEdit.MenuManager = this.barManager1;
            this.firstPriceTextEdit.Name = "firstPriceTextEdit";
            this.firstPriceTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.firstPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.firstPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.firstPriceTextEdit.Properties.Mask.EditMask = "N0";
            this.firstPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.firstPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.firstPriceTextEdit.Size = new System.Drawing.Size(616, 20);
            this.firstPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.firstPriceTextEdit.TabIndex = 8;
            // 
            // ItemForfirstPrice
            // 
            this.ItemForfirstPrice.Control = this.firstPriceTextEdit;
            this.ItemForfirstPrice.Location = new System.Drawing.Point(0, 96);
            this.ItemForfirstPrice.Name = "ItemForfirstPrice";
            this.ItemForfirstPrice.Size = new System.Drawing.Size(688, 24);
            this.ItemForfirstPrice.Text = "first Price";
            this.ItemForfirstPrice.TextSize = new System.Drawing.Size(56, 13);
            // 
            // totalTextEdit
            // 
            this.totalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "total", true));
            this.totalTextEdit.Location = new System.Drawing.Point(80, 12);
            this.totalTextEdit.MenuManager = this.barManager1;
            this.totalTextEdit.Name = "totalTextEdit";
            this.totalTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.totalTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.totalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.totalTextEdit.Properties.Mask.EditMask = "N0";
            this.totalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.totalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.totalTextEdit.Size = new System.Drawing.Size(125, 20);
            this.totalTextEdit.StyleController = this.dataLayoutControl1;
            this.totalTextEdit.TabIndex = 9;
            // 
            // ItemFortotal
            // 
            this.ItemFortotal.Control = this.totalTextEdit;
            this.ItemFortotal.Location = new System.Drawing.Point(0, 0);
            this.ItemFortotal.Name = "ItemFortotal";
            this.ItemFortotal.Size = new System.Drawing.Size(197, 24);
            this.ItemFortotal.Text = "total";
            this.ItemFortotal.TextSize = new System.Drawing.Size(56, 13);
            // 
            // lastPriceTextEdit
            // 
            this.lastPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "lastPrice", true));
            this.lastPriceTextEdit.Location = new System.Drawing.Point(80, 132);
            this.lastPriceTextEdit.MenuManager = this.barManager1;
            this.lastPriceTextEdit.Name = "lastPriceTextEdit";
            this.lastPriceTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lastPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.lastPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lastPriceTextEdit.Properties.Mask.EditMask = "N0";
            this.lastPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.lastPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.lastPriceTextEdit.Size = new System.Drawing.Size(616, 20);
            this.lastPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.lastPriceTextEdit.TabIndex = 10;
            // 
            // ItemForlastPrice
            // 
            this.ItemForlastPrice.Control = this.lastPriceTextEdit;
            this.ItemForlastPrice.Location = new System.Drawing.Point(0, 120);
            this.ItemForlastPrice.Name = "ItemForlastPrice";
            this.ItemForlastPrice.Size = new System.Drawing.Size(688, 209);
            this.ItemForlastPrice.Text = "last Price";
            this.ItemForlastPrice.TextSize = new System.Drawing.Size(56, 13);
            // 
            // barcodeTextEdit
            // 
            this.barcodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_StockEdit, "barcode", true));
            this.barcodeTextEdit.Location = new System.Drawing.Point(80, 36);
            this.barcodeTextEdit.MenuManager = this.barManager1;
            this.barcodeTextEdit.Name = "barcodeTextEdit";
            this.barcodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.barcodeTextEdit.Properties.NullText = "";
            this.barcodeTextEdit.Size = new System.Drawing.Size(616, 20);
            this.barcodeTextEdit.StyleController = this.dataLayoutControl1;
            this.barcodeTextEdit.TabIndex = 5;
            // 
            // frmStockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 369);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStockEdit";
            this.Text = "frmStockEdit";
            this.Load += new System.EventHandler(this.frmStockEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_StockEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForbarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfirstPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlastPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_StockEdit;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit categoryIdTextEdit;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        private DevExpress.XtraEditors.TextEdit firstPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit totalTextEdit;
        private DevExpress.XtraEditors.TextEdit lastPriceTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForbarcode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcategoryId;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfirstPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlastPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortotal;
        private DevExpress.XtraEditors.LookUpEdit barcodeTextEdit;
    }
}