namespace msp.App
{
    partial class frmCurrentTransactions
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
            this.gcvCurTransaction = new DevExpress.XtraGrid.GridControl();
            this.CurTranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurTransactionGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAuthPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurRiskLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCompanyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnNewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurTranClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCurTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcvCurTransaction);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcvCurTransaction
            // 
            this.gcvCurTransaction.DataSource = this.CurTranBindingSource;
            this.gcvCurTransaction.Location = new System.Drawing.Point(12, 12);
            this.gcvCurTransaction.MainView = this.CurTransactionGrid;
            this.gcvCurTransaction.MenuManager = this.barManager1;
            this.gcvCurTransaction.Name = "gcvCurTransaction";
            this.gcvCurTransaction.Size = new System.Drawing.Size(776, 384);
            this.gcvCurTransaction.TabIndex = 4;
            this.gcvCurTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CurTransactionGrid});
            // 
            // CurTranBindingSource
            // 
            this.CurTranBindingSource.DataSource = typeof(Msp.Models.Models.CTransactionsDTO);
            // 
            // CurTransactionGrid
            // 
            this.CurTransactionGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurId,
            this.colCurType,
            this.colCurCode,
            this.colCurAccountName,
            this.colCurAuthPersonName,
            this.colCurDiscount,
            this.colCurRiskLimit,
            this.colCurCity,
            this.colCurBalance,
            this.colCurCompanyType,
            this.colCurDate,
            this.colCurCreatedDate});
            this.CurTransactionGrid.GridControl = this.gcvCurTransaction;
            this.CurTransactionGrid.Name = "CurTransactionGrid";
            // 
            // colCurId
            // 
            this.colCurId.FieldName = "ID";
            this.colCurId.Name = "colCurId";
            this.colCurId.Visible = true;
            this.colCurId.VisibleIndex = 0;
            // 
            // colCurType
            // 
            this.colCurType.FieldName = "Cari Tipi";
            this.colCurType.Name = "colCurType";
            this.colCurType.Visible = true;
            this.colCurType.VisibleIndex = 1;
            // 
            // colCurCode
            // 
            this.colCurCode.FieldName = "Cari Kodu";
            this.colCurCode.Name = "colCurCode";
            this.colCurCode.Visible = true;
            this.colCurCode.VisibleIndex = 2;
            // 
            // colCurAccountName
            // 
            this.colCurAccountName.FieldName = "Cari Hesap Adı";
            this.colCurAccountName.Name = "colCurAccountName";
            this.colCurAccountName.Visible = true;
            this.colCurAccountName.VisibleIndex = 3;
            // 
            // colCurAuthPersonName
            // 
            this.colCurAuthPersonName.FieldName = "Yetkili Kişi";
            this.colCurAuthPersonName.Name = "colCurAuthPersonName";
            this.colCurAuthPersonName.Visible = true;
            this.colCurAuthPersonName.VisibleIndex = 4;
            // 
            // colCurDiscount
            // 
            this.colCurDiscount.FieldName = "İndirim Oranı";
            this.colCurDiscount.Name = "colCurDiscount";
            this.colCurDiscount.Visible = true;
            this.colCurDiscount.VisibleIndex = 5;
            // 
            // colCurRiskLimit
            // 
            this.colCurRiskLimit.FieldName = "Risk Limiti";
            this.colCurRiskLimit.Name = "colCurRiskLimit";
            this.colCurRiskLimit.Visible = true;
            this.colCurRiskLimit.VisibleIndex = 6;
            // 
            // colCurCity
            // 
            this.colCurCity.FieldName = "Şehir";
            this.colCurCity.Name = "colCurCity";
            this.colCurCity.Visible = true;
            this.colCurCity.VisibleIndex = 7;
            // 
            // colCurBalance
            // 
            this.colCurBalance.FieldName = "Bakiye";
            this.colCurBalance.Name = "colCurBalance";
            this.colCurBalance.Visible = true;
            this.colCurBalance.VisibleIndex = 8;
            // 
            // colCurCompanyType
            // 
            this.colCurCompanyType.FieldName = "Şirket Tipi";
            this.colCurCompanyType.Name = "colCurCompanyType";
            this.colCurCompanyType.Visible = true;
            this.colCurCompanyType.VisibleIndex = 9;
            // 
            // colCurDate
            // 
            this.colCurDate.FieldName = "Tarih";
            this.colCurDate.Name = "colCurDate";
            this.colCurDate.Visible = true;
            this.colCurDate.VisibleIndex = 10;
            // 
            // colCurCreatedDate
            // 
            this.colCurCreatedDate.FieldName = "Oluşturulduğu Tarih";
            this.colCurCreatedDate.Name = "colCurCreatedDate";
            this.colCurCreatedDate.Visible = true;
            this.colCurCreatedDate.VisibleIndex = 11;
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
            this.barButtonItem1,
            this.btnNewAccount,
            this.btnEditAccount,
            this.barButtonItem2,
            this.btnRemAccount,
            this.btnSeaAccount,
            this.btnAccountTransactions,
            this.btnCurTranClose,
            this.btnRegInfo});
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeaAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAccountTransactions),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRegInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCurTranClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Caption = "Yeni Hesap";
            this.btnNewAccount.Id = 1;
            this.btnNewAccount.ImageOptions.ImageIndex = 1;
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAccount_ItemClick);
            // 
            // btnRemAccount
            // 
            this.btnRemAccount.Caption = "Hesap Sil";
            this.btnRemAccount.Id = 4;
            this.btnRemAccount.ImageOptions.ImageIndex = 4;
            this.btnRemAccount.Name = "btnRemAccount";
            this.btnRemAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemAccount_ItemClick);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Caption = "Hesap Düzelt";
            this.btnEditAccount.Id = 2;
            this.btnEditAccount.ImageOptions.ImageIndex = 2;
            this.btnEditAccount.Name = "btnEditAccount";
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
            this.btnAccountTransactions.ImageOptions.ImageIndex = 7;
            this.btnAccountTransactions.Name = "btnAccountTransactions";
            // 
            // btnRegInfo
            // 
            this.btnRegInfo.Caption = "Kayıt Bilgisi";
            this.btnRegInfo.Id = 8;
            this.btnRegInfo.ImageOptions.ImageIndex = 11;
            this.btnRegInfo.Name = "btnRegInfo";
            // 
            // btnCurTranClose
            // 
            this.btnCurTranClose.Caption = "Kapat";
            this.btnCurTranClose.Id = 7;
            this.btnCurTranClose.ImageOptions.ImageIndex = 5;
            this.btnCurTranClose.Name = "btnCurTranClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("bo_price", "image://svgimages/business objects/bo_price.svg");
            this.svgImageCollection1.Add("actions_add", "image://svgimages/icon builder/actions_add.svg");
            this.svgImageCollection1.Add("actions_edit", "image://svgimages/icon builder/actions_edit.svg");
            this.svgImageCollection1.Add("viewmergeddata", "image://svgimages/richedit/viewmergeddata.svg");
            this.svgImageCollection1.Add("actions_remove", "image://svgimages/icon builder/actions_remove.svg");
            this.svgImageCollection1.Add("del", "image://svgimages/diagramicons/del.svg");
            this.svgImageCollection1.Add("actions_zoom", "image://svgimages/icon builder/actions_zoom.svg");
            this.svgImageCollection1.Add("movechartnewsheet", "image://svgimages/spreadsheet/movechartnewsheet.svg");
            this.svgImageCollection1.Add("changedatasourcepivottable", "image://svgimages/spreadsheet/changedatasourcepivottable.svg");
            this.svgImageCollection1.Add("barcode", "image://svgimages/content/barcode.svg");
            this.svgImageCollection1.Add("saveandclose2", "image://svgimages/save/saveandclose2.svg");
            this.svgImageCollection1.Add("bo_mydetails", "image://svgimages/business objects/bo_mydetails.svg");
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 408);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcvCurTransaction;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 388);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmCurrentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCurrentTransactions";
            this.Text = "Cari İşlemler";
            this.Load += new System.EventHandler(this.CurrentTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcvCurTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTransactionGrid)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcvCurTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView CurTransactionGrid;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnNewAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnEditAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnRemAccount;
        private DevExpress.XtraBars.BarButtonItem btnSeaAccount;
        private DevExpress.XtraBars.BarButtonItem btnAccountTransactions;
        private DevExpress.XtraBars.BarButtonItem btnCurTranClose;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnRegInfo;
        private System.Windows.Forms.BindingSource CurTranBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCurId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurType;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAuthPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurRiskLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCity;
        private DevExpress.XtraGrid.Columns.GridColumn colCurBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCompanyType;
        private DevExpress.XtraGrid.Columns.GridColumn colCurDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCreatedDate;
    }
}