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
            this.gcv_CurTrans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAuthPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurAdressTwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurPhoneOne = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurPhoneTwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnCurTranClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSeaAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegInfo = new DevExpress.XtraBars.BarButtonItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colCurEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCurTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_CurTrans)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(887, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcvCurTransaction
            // 
            this.gcvCurTransaction.DataSource = this.CurTranBindingSource;
            this.gcvCurTransaction.Location = new System.Drawing.Point(12, 12);
            this.gcvCurTransaction.MainView = this.gcv_CurTrans;
            this.gcvCurTransaction.MenuManager = this.barManager1;
            this.gcvCurTransaction.Name = "gcvCurTransaction";
            this.gcvCurTransaction.Size = new System.Drawing.Size(863, 384);
            this.gcvCurTransaction.TabIndex = 4;
            this.gcvCurTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_CurTrans});
            // 
            // CurTranBindingSource
            // 
            this.CurTranBindingSource.DataSource = typeof(Msp.Models.Models.CTransactionsDTO);
            // 
            // gcv_CurTrans
            // 
            this.gcv_CurTrans.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurType,
            this.colCurCode,
            this.colCurAccountName,
            this.colCurAuthPersonName,
            this.colCurCreatedDate,
            this.colCurAdress,
            this.colCurAdressTwo,
            this.colCurPhoneOne,
            this.colCurPhoneTwo,
            this.colCurEmail});
            this.gcv_CurTrans.GridControl = this.gcvCurTransaction;
            this.gcv_CurTrans.Name = "gcv_CurTrans";
            this.gcv_CurTrans.OptionsBehavior.Editable = false;
            this.gcv_CurTrans.OptionsView.ShowAutoFilterRow = true;
            this.gcv_CurTrans.OptionsView.ShowGroupPanel = false;
            // 
            // colCurType
            // 
            this.colCurType.Caption = "C.Tipi";
            this.colCurType.FieldName = "CurType";
            this.colCurType.Name = "colCurType";
            this.colCurType.Visible = true;
            this.colCurType.VisibleIndex = 1;
            this.colCurType.Width = 41;
            // 
            // colCurCode
            // 
            this.colCurCode.Caption = "C.Kodu";
            this.colCurCode.FieldName = "CurCode";
            this.colCurCode.Name = "colCurCode";
            this.colCurCode.Visible = true;
            this.colCurCode.VisibleIndex = 2;
            this.colCurCode.Width = 20;
            // 
            // colCurAccountName
            // 
            this.colCurAccountName.Caption = "C.Adı";
            this.colCurAccountName.FieldName = "CurAccountName";
            this.colCurAccountName.Name = "colCurAccountName";
            this.colCurAccountName.Visible = true;
            this.colCurAccountName.VisibleIndex = 3;
            this.colCurAccountName.Width = 55;
            // 
            // colCurAuthPersonName
            // 
            this.colCurAuthPersonName.Caption = "C.Yetk.Adı";
            this.colCurAuthPersonName.FieldName = "CurAuthPersonName";
            this.colCurAuthPersonName.Name = "colCurAuthPersonName";
            this.colCurAuthPersonName.Visible = true;
            this.colCurAuthPersonName.VisibleIndex = 4;
            this.colCurAuthPersonName.Width = 40;
            // 
            // colCurCreatedDate
            // 
            this.colCurCreatedDate.Caption = "Oluşt.Tarihi";
            this.colCurCreatedDate.FieldName = "CurCreatedDate";
            this.colCurCreatedDate.Name = "colCurCreatedDate";
            this.colCurCreatedDate.Visible = true;
            this.colCurCreatedDate.VisibleIndex = 5;
            this.colCurCreatedDate.Width = 20;
            // 
            // colCurAdress
            // 
            this.colCurAdress.Caption = "Adres";
            this.colCurAdress.FieldName = "CurAdress";
            this.colCurAdress.Name = "colCurAdress";
            this.colCurAdress.Visible = true;
            this.colCurAdress.VisibleIndex = 6;
            this.colCurAdress.Width = 20;
            // 
            // colCurAdressTwo
            // 
            this.colCurAdressTwo.Caption = "Adres2";
            this.colCurAdressTwo.FieldName = "CurAdressTwo";
            this.colCurAdressTwo.Name = "colCurAdressTwo";
            this.colCurAdressTwo.Visible = true;
            this.colCurAdressTwo.VisibleIndex = 7;
            this.colCurAdressTwo.Width = 20;
            // 
            // colCurPhoneOne
            // 
            this.colCurPhoneOne.Caption = "Telefon";
            this.colCurPhoneOne.FieldName = "CurPhoneOne";
            this.colCurPhoneOne.Name = "colCurPhoneOne";
            this.colCurPhoneOne.Visible = true;
            this.colCurPhoneOne.VisibleIndex = 8;
            this.colCurPhoneOne.Width = 20;
            // 
            // colCurPhoneTwo
            // 
            this.colCurPhoneTwo.Caption = "Telefon2";
            this.colCurPhoneTwo.FieldName = "CurPhoneTwo";
            this.colCurPhoneTwo.Name = "colCurPhoneTwo";
            this.colCurPhoneTwo.Visible = true;
            this.colCurPhoneTwo.VisibleIndex = 9;
            this.colCurPhoneTwo.Width = 20;
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
            this.btnRegInfo,
            this.btnRefresh});
            this.barManager1.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCurTranClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Id = 9;
            this.btnRefresh.ImageOptions.ImageIndex = 43;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Caption = "Yeni Hesap";
            this.btnNewAccount.Id = 1;
            this.btnNewAccount.ImageOptions.ImageIndex = 46;
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewAccount_ItemClick);
            // 
            // btnRemAccount
            // 
            this.btnRemAccount.Caption = "Hesap Sil";
            this.btnRemAccount.Id = 4;
            this.btnRemAccount.ImageOptions.ImageIndex = 44;
            this.btnRemAccount.Name = "btnRemAccount";
            this.btnRemAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemAccount_ItemClick);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Caption = "Hesap Düzelt";
            this.btnEditAccount.Id = 2;
            this.btnEditAccount.ImageOptions.ImageIndex = 48;
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAccount_ItemClick);
            // 
            // btnCurTranClose
            // 
            this.btnCurTranClose.Caption = "Kapat";
            this.btnCurTranClose.Id = 7;
            this.btnCurTranClose.ImageOptions.ImageIndex = 1;
            this.btnCurTranClose.Name = "btnCurTranClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(887, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(887, 42);
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
            this.barDockControlRight.Location = new System.Drawing.Point(887, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(887, 408);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcvCurTransaction;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(867, 388);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colCurEmail
            // 
            this.colCurEmail.Caption = "E-Mail";
            this.colCurEmail.FieldName = "CurEmail";
            this.colCurEmail.Name = "colCurEmail";
            this.colCurEmail.Visible = true;
            this.colCurEmail.VisibleIndex = 10;
            // 
            // frmCurrentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCurrentTransactions";
            this.Text = "Cari İşlemler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCurrentTransactions_FormClosing);
            this.Load += new System.EventHandler(this.CurrentTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcvCurTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurTranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_CurTrans)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_CurTrans;
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
        private DevExpress.XtraBars.BarButtonItem btnRegInfo;
        private System.Windows.Forms.BindingSource CurTranBindingSource;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurType;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAuthPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colCurAdressTwo;
        private DevExpress.XtraGrid.Columns.GridColumn colCurPhoneOne;
        private DevExpress.XtraGrid.Columns.GridColumn colCurPhoneTwo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colCurEmail;
    }
}