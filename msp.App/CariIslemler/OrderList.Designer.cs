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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(872, 534);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 576);
            this.Controls.Add(this.gridControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}