namespace Msp.App.Musteri_Islemleri
{
    partial class frmMusterVeresiyeDetail
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaseId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bs_SaleOwner = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPriceText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeresiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlinanPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeresiyeClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_VeresiyeKapat = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_BakiyedenDus = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBakiyeAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Closed = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bs_SaleTrans = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductBarcode,
            this.colProductName,
            this.colProductQuantity,
            this.colProductPrice,
            this.colProductAmount,
            this.colUnitId,
            this.colCaseId1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colProductBarcode
            // 
            this.colProductBarcode.Caption = "Ürün Barkodu";
            this.colProductBarcode.FieldName = "ProductBarcode";
            this.colProductBarcode.Name = "colProductBarcode";
            this.colProductBarcode.Visible = true;
            this.colProductBarcode.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colProductQuantity
            // 
            this.colProductQuantity.Caption = "Ürün Adeti";
            this.colProductQuantity.FieldName = "ProductQuantity";
            this.colProductQuantity.Name = "colProductQuantity";
            this.colProductQuantity.Visible = true;
            this.colProductQuantity.VisibleIndex = 2;
            // 
            // colProductPrice
            // 
            this.colProductPrice.Caption = "Ürün Fiyatı";
            this.colProductPrice.FieldName = "ProductPrice";
            this.colProductPrice.Name = "colProductPrice";
            this.colProductPrice.Visible = true;
            this.colProductPrice.VisibleIndex = 3;
            // 
            // colProductAmount
            // 
            this.colProductAmount.Caption = "Ürün Toplam Fiyat";
            this.colProductAmount.FieldName = "ProductAmount";
            this.colProductAmount.Name = "colProductAmount";
            this.colProductAmount.Visible = true;
            this.colProductAmount.VisibleIndex = 4;
            // 
            // colUnitId
            // 
            this.colUnitId.Caption = "Birim";
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 5;
            // 
            // colCaseId1
            // 
            this.colCaseId1.Caption = "Kasa";
            this.colCaseId1.FieldName = "CaseId";
            this.colCaseId1.Name = "colCaseId1";
            this.colCaseId1.Visible = true;
            this.colCaseId1.VisibleIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_SaleOwner;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "_SaleTrans";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 515);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
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
            this.colNetPriceText,
            this.colKDV,
            this.colDiscountPrice,
            this.colTotalPriceText,
            this.colTotalPrice,
            this.colReceivedPrice,
            this.colRemark,
            this.colVeresiye,
            this.colCompanyRecId,
            this.colDeleted,
            this.colUserCode,
            this.colAlinanPrice,
            this.colCaseId,
            this.colVeresiyeClosedDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            this.colRecId.Visible = true;
            this.colRecId.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 3;
            // 
            // colNetPrice
            // 
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            this.colNetPrice.Visible = true;
            this.colNetPrice.VisibleIndex = 4;
            // 
            // colNetPriceText
            // 
            this.colNetPriceText.FieldName = "NetPriceText";
            this.colNetPriceText.Name = "colNetPriceText";
            this.colNetPriceText.Visible = true;
            this.colNetPriceText.VisibleIndex = 5;
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
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 7;
            // 
            // colTotalPriceText
            // 
            this.colTotalPriceText.FieldName = "TotalPriceText";
            this.colTotalPriceText.Name = "colTotalPriceText";
            this.colTotalPriceText.Visible = true;
            this.colTotalPriceText.VisibleIndex = 8;
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
            // colVeresiye
            // 
            this.colVeresiye.FieldName = "Veresiye";
            this.colVeresiye.Name = "colVeresiye";
            this.colVeresiye.Visible = true;
            this.colVeresiye.VisibleIndex = 12;
            // 
            // colCompanyRecId
            // 
            this.colCompanyRecId.FieldName = "CompanyRecId";
            this.colCompanyRecId.Name = "colCompanyRecId";
            this.colCompanyRecId.Visible = true;
            this.colCompanyRecId.VisibleIndex = 13;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 14;
            // 
            // colUserCode
            // 
            this.colUserCode.FieldName = "UserCode";
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.Visible = true;
            this.colUserCode.VisibleIndex = 15;
            // 
            // colAlinanPrice
            // 
            this.colAlinanPrice.FieldName = "AlinanPrice";
            this.colAlinanPrice.Name = "colAlinanPrice";
            this.colAlinanPrice.Visible = true;
            this.colAlinanPrice.VisibleIndex = 16;
            // 
            // colCaseId
            // 
            this.colCaseId.FieldName = "CaseId";
            this.colCaseId.Name = "colCaseId";
            this.colCaseId.Visible = true;
            this.colCaseId.VisibleIndex = 17;
            // 
            // colVeresiyeClosedDate
            // 
            this.colVeresiyeClosedDate.FieldName = "VeresiyeClosedDate";
            this.colVeresiyeClosedDate.Name = "colVeresiyeClosedDate";
            this.colVeresiyeClosedDate.Visible = true;
            this.colVeresiyeClosedDate.VisibleIndex = 18;
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
            this.bbi_VeresiyeKapat,
            this.bbi_Closed,
            this.bbi_BakiyedenDus,
            this.bbiBakiyeAdd});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_VeresiyeKapat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_BakiyedenDus),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBakiyeAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Closed, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_VeresiyeKapat
            // 
            this.bbi_VeresiyeKapat.Caption = "Veresiye Kapat";
            this.bbi_VeresiyeKapat.Id = 0;
            this.bbi_VeresiyeKapat.ImageOptions.ImageIndex = 0;
            this.bbi_VeresiyeKapat.Name = "bbi_VeresiyeKapat";
            this.bbi_VeresiyeKapat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_VeresiyeKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_VeresiyeKapat_ItemClick);
            // 
            // bbi_BakiyedenDus
            // 
            this.bbi_BakiyedenDus.Caption = "Bakiyeden Düş";
            this.bbi_BakiyedenDus.Id = 2;
            this.bbi_BakiyedenDus.ImageOptions.ImageIndex = 1;
            this.bbi_BakiyedenDus.Name = "bbi_BakiyedenDus";
            this.bbi_BakiyedenDus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_BakiyedenDus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_BakiyedenDus_ItemClick);
            // 
            // bbiBakiyeAdd
            // 
            this.bbiBakiyeAdd.Caption = "Baki/Elden Ekle";
            this.bbiBakiyeAdd.Id = 3;
            this.bbiBakiyeAdd.ImageOptions.ImageIndex = 3;
            this.bbiBakiyeAdd.Name = "bbiBakiyeAdd";
            this.bbiBakiyeAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiBakiyeAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBakiyeAdd_ItemClick);
            // 
            // bbi_Closed
            // 
            this.bbi_Closed.Caption = "Vazgeç";
            this.bbi_Closed.Id = 1;
            this.bbi_Closed.ImageOptions.ImageIndex = 2;
            this.bbi_Closed.Name = "bbi_Closed";
            this.bbi_Closed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Closed_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 515);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(790, 36);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // img_bar
            // 
            this.img_bar.ImageSize = new System.Drawing.Size(26, 26);
            this.img_bar.Add("saveandclose", "image://svgimages/outlook inspired/saveandclose.svg");
            this.img_bar.Add("bottom10items", "image://svgimages/spreadsheet/bottom10items.svg");
            this.img_bar.Add("del", "image://svgimages/diagramicons/del.svg");
            this.img_bar.Add("above average", "image://svgimages/spreadsheet/above average.svg");
            // 
            // frmMusterVeresiyeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 551);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMusterVeresiyeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Veresiye Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMusterVeresiyeDetail_FormClosing);
            this.Load += new System.EventHandler(this.frmMusterVeresiyeDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMusterVeresiyeDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SaleTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarButtonItem bbi_VeresiyeKapat;
        private DevExpress.XtraBars.BarButtonItem bbi_BakiyedenDus;
        private DevExpress.XtraBars.BarButtonItem bbi_Closed;
        private System.Windows.Forms.BindingSource bs_SaleOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPriceText;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPriceText;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colVeresiye;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAlinanPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCaseId;
        private DevExpress.XtraGrid.Columns.GridColumn colVeresiyeClosedDate;
        private System.Windows.Forms.BindingSource bs_SaleTrans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colCaseId1;
        private DevExpress.XtraBars.BarButtonItem bbiBakiyeAdd;
    }
}