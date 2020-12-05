namespace Msp.App.CariIslemler
{
    partial class OrderList
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
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Document = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Print = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurTranClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bs_OrderList = new System.Windows.Forms.BindingSource(this.components);
            this.gc_OrderList = new DevExpress.XtraGrid.GridControl();
            this.gcv_OrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDovizId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifSiparis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSiparis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_OrderList)).BeginInit();
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
            this.barManager1.Images = this.img_sic;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnNew,
            this.btnEdit,
            this.barButtonItem2,
            this.btnDelete,
            this.btnSeaAccount,
            this.btnAccountTransactions,
            this.btnCurTranClose,
            this.btnRegInfo,
            this.bbi_Refresh,
            this.bbi_Print,
            this.bbi_Document});
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Document),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCurTranClose, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Yeni Hesap";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.ImageIndex = 2;
            this.btnNew.Name = "btnNew";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Hesap Düzelt";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.ImageIndex = 6;
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Hesap Sil";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.ImageIndex = 5;
            this.btnDelete.Name = "btnDelete";
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 9;
            this.bbi_Refresh.ImageOptions.ImageIndex = 7;
            this.bbi_Refresh.Name = "bbi_Refresh";
            // 
            // bbi_Document
            // 
            this.bbi_Document.Caption = "Dosyalar";
            this.bbi_Document.Id = 11;
            this.bbi_Document.ImageOptions.ImageIndex = 9;
            this.bbi_Document.Name = "bbi_Document";
            // 
            // bbi_Print
            // 
            this.bbi_Print.Caption = "Yazdır";
            this.bbi_Print.Id = 10;
            this.bbi_Print.ImageOptions.ImageIndex = 8;
            this.bbi_Print.Name = "bbi_Print";
            // 
            // btnCurTranClose
            // 
            this.btnCurTranClose.Caption = "Kapat";
            this.btnCurTranClose.Id = 7;
            this.btnCurTranClose.ImageOptions.ImageIndex = 0;
            this.btnCurTranClose.Name = "btnCurTranClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(872, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(872, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(872, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
            // 
            // img_sic
            // 
            this.img_sic.ImageSize = new System.Drawing.Size(32, 32);
            this.img_sic.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.img_sic.Add("linecolor", "image://svgimages/spreadsheet/linecolor.svg");
            this.img_sic.Add("addfile", "image://svgimages/outlook inspired/addfile.svg");
            this.img_sic.Add("removedataitems", "image://svgimages/dashboards/removedataitems.svg");
            this.img_sic.Add("movechartnewsheet", "image://svgimages/spreadsheet/movechartnewsheet.svg");
            this.img_sic.Add("snapdeletelist", "image://svgimages/snap/snapdeletelist.svg");
            this.img_sic.Add("edit", "image://svgimages/dashboards/edit.svg");
            this.img_sic.Add("convertto", "image://svgimages/dashboards/convertto.svg");
            this.img_sic.Add("printarea", "image://svgimages/spreadsheet/printarea.svg");
            this.img_sic.Add("open2", "image://svgimages/actions/open2.svg");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hesap İncele";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.ImageIndex = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSeaAccount
            // 
            this.btnSeaAccount.Caption = "Hesap Bul";
            this.btnSeaAccount.Id = 5;
            this.btnSeaAccount.ImageOptions.ImageIndex = 6;
            this.btnSeaAccount.Name = "btnSeaAccount";
            // 
            // btnAccountTransactions
            // 
            this.btnAccountTransactions.Caption = "Hesap Hareketleri";
            this.btnAccountTransactions.Id = 6;
            this.btnAccountTransactions.ImageOptions.ImageIndex = 4;
            this.btnAccountTransactions.Name = "btnAccountTransactions";
            // 
            // btnRegInfo
            // 
            this.btnRegInfo.Caption = "Kayıt Bilgisi";
            this.btnRegInfo.Id = 8;
            this.btnRegInfo.ImageOptions.ImageIndex = 11;
            this.btnRegInfo.Name = "btnRegInfo";
            // 
            // bs_OrderList
            // 
            this.bs_OrderList.DataSource = typeof(Msp.Models.Models.Order.OrderOwnerDTO);
            // 
            // gc_OrderList
            // 
            this.gc_OrderList.DataSource = this.bs_OrderList;
            this.gc_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_OrderList.Location = new System.Drawing.Point(0, 0);
            this.gc_OrderList.MainView = this.gcv_OrderList;
            this.gc_OrderList.MenuManager = this.barManager1;
            this.gc_OrderList.Name = "gc_OrderList";
            this.gc_OrderList.Size = new System.Drawing.Size(872, 534);
            this.gc_OrderList.TabIndex = 4;
            this.gc_OrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_OrderList});
            // 
            // gcv_OrderList
            // 
            this.gcv_OrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.colCariRecId,
            this.colOrderType,
            this.colCompanyId,
            this.colSiparisNo,
            this.colSiparisDate,
            this.colSiparisTime,
            this.colOzelKod,
            this.colDovizId,
            this.colKDVId,
            this.colIskonto,
            this.colDurum,
            this.colTeklifSiparis,
            this.colRemark,
            this.colTotalToplam,
            this.colTotalIskonto,
            this.colTotalKDV,
            this.colTotalSiparis,
            this.colDeleted});
            this.gcv_OrderList.GridControl = this.gc_OrderList;
            this.gcv_OrderList.Name = "gcv_OrderList";
            this.gcv_OrderList.OptionsView.ShowGroupPanel = false;
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            // 
            // colCariRecId
            // 
            this.colCariRecId.FieldName = "CariRecId";
            this.colCariRecId.Name = "colCariRecId";
            this.colCariRecId.Visible = true;
            this.colCariRecId.VisibleIndex = 0;
            this.colCariRecId.Width = 86;
            // 
            // colOrderType
            // 
            this.colOrderType.FieldName = "OrderType";
            this.colOrderType.Name = "colOrderType";
            this.colOrderType.Visible = true;
            this.colOrderType.VisibleIndex = 1;
            this.colOrderType.Width = 44;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 2;
            this.colCompanyId.Width = 44;
            // 
            // colSiparisNo
            // 
            this.colSiparisNo.FieldName = "SiparisNo";
            this.colSiparisNo.Name = "colSiparisNo";
            this.colSiparisNo.Visible = true;
            this.colSiparisNo.VisibleIndex = 3;
            this.colSiparisNo.Width = 44;
            // 
            // colSiparisDate
            // 
            this.colSiparisDate.FieldName = "SiparisDate";
            this.colSiparisDate.Name = "colSiparisDate";
            this.colSiparisDate.Visible = true;
            this.colSiparisDate.VisibleIndex = 4;
            this.colSiparisDate.Width = 44;
            // 
            // colSiparisTime
            // 
            this.colSiparisTime.FieldName = "SiparisTime";
            this.colSiparisTime.Name = "colSiparisTime";
            this.colSiparisTime.Visible = true;
            this.colSiparisTime.VisibleIndex = 5;
            this.colSiparisTime.Width = 44;
            // 
            // colOzelKod
            // 
            this.colOzelKod.FieldName = "OzelKod";
            this.colOzelKod.Name = "colOzelKod";
            this.colOzelKod.Visible = true;
            this.colOzelKod.VisibleIndex = 6;
            this.colOzelKod.Width = 44;
            // 
            // colDovizId
            // 
            this.colDovizId.FieldName = "DovizId";
            this.colDovizId.Name = "colDovizId";
            this.colDovizId.Visible = true;
            this.colDovizId.VisibleIndex = 7;
            this.colDovizId.Width = 44;
            // 
            // colKDVId
            // 
            this.colKDVId.FieldName = "KDVId";
            this.colKDVId.Name = "colKDVId";
            this.colKDVId.Visible = true;
            this.colKDVId.VisibleIndex = 8;
            this.colKDVId.Width = 44;
            // 
            // colIskonto
            // 
            this.colIskonto.FieldName = "Iskonto";
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.Visible = true;
            this.colIskonto.VisibleIndex = 9;
            this.colIskonto.Width = 44;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 10;
            this.colDurum.Width = 44;
            // 
            // colTeklifSiparis
            // 
            this.colTeklifSiparis.FieldName = "TeklifSiparis";
            this.colTeklifSiparis.Name = "colTeklifSiparis";
            this.colTeklifSiparis.Visible = true;
            this.colTeklifSiparis.VisibleIndex = 11;
            this.colTeklifSiparis.Width = 44;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 12;
            this.colRemark.Width = 44;
            // 
            // colTotalToplam
            // 
            this.colTotalToplam.FieldName = "TotalToplam";
            this.colTotalToplam.Name = "colTotalToplam";
            this.colTotalToplam.Visible = true;
            this.colTotalToplam.VisibleIndex = 13;
            this.colTotalToplam.Width = 44;
            // 
            // colTotalIskonto
            // 
            this.colTotalIskonto.FieldName = "TotalIskonto";
            this.colTotalIskonto.Name = "colTotalIskonto";
            this.colTotalIskonto.Visible = true;
            this.colTotalIskonto.VisibleIndex = 14;
            this.colTotalIskonto.Width = 44;
            // 
            // colTotalKDV
            // 
            this.colTotalKDV.FieldName = "TotalKDV";
            this.colTotalKDV.Name = "colTotalKDV";
            this.colTotalKDV.Visible = true;
            this.colTotalKDV.VisibleIndex = 15;
            this.colTotalKDV.Width = 44;
            // 
            // colTotalSiparis
            // 
            this.colTotalSiparis.FieldName = "TotalSiparis";
            this.colTotalSiparis.Name = "colTotalSiparis";
            this.colTotalSiparis.Visible = true;
            this.colTotalSiparis.VisibleIndex = 16;
            this.colTotalSiparis.Width = 44;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 17;
            this.colDeleted.Width = 57;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 576);
            this.Controls.Add(this.gc_OrderList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderList_FormClosing);
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraBars.BarButtonItem bbi_Document;
        private DevExpress.XtraBars.BarButtonItem bbi_Print;
        private DevExpress.XtraBars.BarButtonItem btnCurTranClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSeaAccount;
        private DevExpress.XtraBars.BarButtonItem btnAccountTransactions;
        private DevExpress.XtraBars.BarButtonItem btnRegInfo;
        private System.Windows.Forms.BindingSource bs_OrderList;
        private DevExpress.XtraGrid.GridControl gc_OrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_OrderList;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colCariRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderType;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisTime;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod;
        private DevExpress.XtraGrid.Columns.GridColumn colDovizId;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVId;
        private DevExpress.XtraGrid.Columns.GridColumn colIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifSiparis;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSiparis;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
    }
}