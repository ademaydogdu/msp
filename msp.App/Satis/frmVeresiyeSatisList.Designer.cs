namespace Msp.App.Satis
{
    partial class frmVeresiyeSatisList
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
            this.gc_SiparisList = new DevExpress.XtraGrid.GridControl();
            this.bs_SaleOwner = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.img_sig = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_Report = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_exp = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_VeresiyeKapat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbi_Export = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bs_SaleTrans = new System.Windows.Forms.BindingSource(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SiparisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_SiparisList
            // 
            this.gc_SiparisList.DataSource = this.bs_SaleOwner;
            this.gc_SiparisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SiparisList.Location = new System.Drawing.Point(0, 0);
            this.gc_SiparisList.MainView = this.gridView1;
            this.gc_SiparisList.Name = "gc_SiparisList";
            this.gc_SiparisList.Size = new System.Drawing.Size(754, 528);
            this.gc_SiparisList.TabIndex = 1;
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
            this.colNetPriceText,
            this.colCustomerName,
            this.colPaymentType,
            this.colNetPrice,
            this.colKDV,
            this.colDiscountPrice,
            this.colTotalPrice,
            this.colReceivedPrice,
            this.colRemark});
            this.gridView1.GridControl = this.gc_SiparisList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
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
            this.colDate.VisibleIndex = 1;
            // 
            // colTotalPriceText
            // 
            this.colTotalPriceText.FieldName = "TotalPriceText";
            this.colTotalPriceText.Name = "colTotalPriceText";
            this.colTotalPriceText.Visible = true;
            this.colTotalPriceText.VisibleIndex = 2;
            // 
            // colUserCode
            // 
            this.colUserCode.FieldName = "UserCode";
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.Visible = true;
            this.colUserCode.VisibleIndex = 3;
            // 
            // colNetPriceText
            // 
            this.colNetPriceText.FieldName = "NetPriceText";
            this.colNetPriceText.Name = "colNetPriceText";
            this.colNetPriceText.Visible = true;
            this.colNetPriceText.VisibleIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 5;
            // 
            // colNetPrice
            // 
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.Visible = true;
            this.colNetPrice.VisibleIndex = 6;
            // 
            // colKDV
            // 
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 7;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 8;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 9;
            // 
            // colReceivedPrice
            // 
            this.colReceivedPrice.FieldName = "ReceivedPrice";
            this.colReceivedPrice.Name = "colReceivedPrice";
            this.colReceivedPrice.Visible = true;
            this.colReceivedPrice.VisibleIndex = 10;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 11;
            // 
            // img_sig
            // 
            this.img_sig.ImageSize = new System.Drawing.Size(24, 24);
            this.img_sig.Add("rotateclockwise", "image://svgimages/pdf viewer/rotateclockwise.svg");
            this.img_sig.Add("exporttopdf", "image://svgimages/export/exporttopdf.svg");
            this.img_sig.Add("exporttoxls", "image://svgimages/export/exporttoxls.svg");
            this.img_sig.Add("open2", "image://svgimages/actions/open2.svg");
            this.img_sig.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.img_sig.Add("bo_security_permission_member", "image://svgimages/business objects/bo_security_permission_member.svg");
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
            this.barButtonItem3,
            this.bbi_VeresiyeKapat});
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_VeresiyeKapat, true)});
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
            // bbi_VeresiyeKapat
            // 
            this.bbi_VeresiyeKapat.Caption = "Veresiye Kapat";
            this.bbi_VeresiyeKapat.Id = 6;
            this.bbi_VeresiyeKapat.ImageOptions.ImageIndex = 5;
            this.bbi_VeresiyeKapat.Name = "bbi_VeresiyeKapat";
            this.bbi_VeresiyeKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_VeresiyeKapat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(754, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(754, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 528);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(754, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 528);
            // 
            // bbi_Export
            // 
            this.bbi_Export.ActAsDropDown = true;
            this.bbi_Export.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbi_Export.Caption = "Export";
            this.bbi_Export.Id = 0;
            this.bbi_Export.Name = "bbi_Export";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Veresiye Kapat";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.ImageIndex = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmVeresiyeSatisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 562);
            this.Controls.Add(this.gc_SiparisList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVeresiyeSatisList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye Satış Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVeresiyeSatisList_FormClosing);
            this.Load += new System.EventHandler(this.frmVeresiyeSatisList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVeresiyeSatisList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SiparisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_SiparisList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceText;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPriceText;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.Utils.SvgImageCollection img_sig;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_Report;
        private DevExpress.XtraBars.BarSubItem bbi_exp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Export;
        private System.Windows.Forms.BindingSource bs_SaleTrans;
        private System.Windows.Forms.BindingSource bs_SaleOwner;
        private DevExpress.XtraBars.BarButtonItem bbi_VeresiyeKapat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}