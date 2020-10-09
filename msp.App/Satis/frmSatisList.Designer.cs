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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bs_SaleOwner = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeresiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.dt_Date = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bs_SaleTrans = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(895, 682);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_SaleOwner;
            this.gridControl1.Location = new System.Drawing.Point(12, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(871, 608);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colCustomerName,
            this.colPaymentType,
            this.colNetPrice,
            this.colKDV,
            this.colDiscountPrice,
            this.colTotalPrice,
            this.colReceivedPrice,
            this.colRemark,
            this.colVeresiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 2;
            // 
            // colNetPrice
            // 
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.Visible = true;
            this.colNetPrice.VisibleIndex = 3;
            // 
            // colKDV
            // 
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 4;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 5;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 6;
            // 
            // colReceivedPrice
            // 
            this.colReceivedPrice.FieldName = "ReceivedPrice";
            this.colReceivedPrice.Name = "colReceivedPrice";
            this.colReceivedPrice.Visible = true;
            this.colReceivedPrice.VisibleIndex = 7;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 8;
            // 
            // colVeresiye
            // 
            this.colVeresiye.FieldName = "Veresiye";
            this.colVeresiye.Name = "colVeresiye";
            this.colVeresiye.Visible = true;
            this.colVeresiye.VisibleIndex = 9;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.dt_Date);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 46);
            this.panelControl1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 0;
            this.simpleButton1.ImageOptions.ImageList = this.svgImageCollection1;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(215, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 36);
            this.simpleButton1.TabIndex = 1;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(34, 34);
            this.svgImageCollection1.Add("rotateclockwise", "image://svgimages/pdf viewer/rotateclockwise.svg");
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
            this.Root.Size = new System.Drawing.Size(895, 682);
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
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(875, 612);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmSatisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 682);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmSatisList";
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.frmSatisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colVeresiye;
        private System.Windows.Forms.BindingSource bs_SaleTrans;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}