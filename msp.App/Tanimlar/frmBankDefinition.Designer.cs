namespace Msp.App.Tanimlar
{
    partial class frmBankDefinition
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
            this.bs_BankDetails = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_BankDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnBankDefRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankDefSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankDefAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankDefRemove = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankDefClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.btnBankDefEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bankDefBankNameTE = new DevExpress.XtraEditors.TextEdit();
            this.bankDefBranchName = new DevExpress.XtraEditors.TextEdit();
            this.bankDefBranchCode = new DevExpress.XtraEditors.TextEdit();
            this.bankDefAccNo = new DevExpress.XtraEditors.TextEdit();
            this.bankDefAccName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_BankDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_BankDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBankNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBranchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefAccNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.bankDefBankNameTE);
            this.layoutControl1.Controls.Add(this.bankDefBranchName);
            this.layoutControl1.Controls.Add(this.bankDefBranchCode);
            this.layoutControl1.Controls.Add(this.bankDefAccNo);
            this.layoutControl1.Controls.Add(this.bankDefAccName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.svgImageCollection1;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(531, 406);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_BankDetails;
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gcv_BankDetails;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(507, 310);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_BankDetails});
            // 
            // bs_BankDetails
            // 
            this.bs_BankDetails.DataSource = typeof(Msp.Models.Models.BanksDTO);
            // 
            // gcv_BankDetails
            // 
            this.gcv_BankDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBid,
            this.colBankName,
            this.colBankBranch,
            this.colBankBranchCode,
            this.colBankAccountNumber,
            this.colBankAccountName});
            this.gcv_BankDetails.GridControl = this.gridControl1;
            this.gcv_BankDetails.Name = "gcv_BankDetails";
            // 
            // colBid
            // 
            this.colBid.FieldName = "ID";
            this.colBid.Name = "colBid";
            this.colBid.Visible = true;
            this.colBid.VisibleIndex = 0;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "Banka Adı";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 1;
            // 
            // colBankBranch
            // 
            this.colBankBranch.FieldName = "Şube Adı";
            this.colBankBranch.Name = "colBankBranch";
            this.colBankBranch.Visible = true;
            this.colBankBranch.VisibleIndex = 2;
            // 
            // colBankBranchCode
            // 
            this.colBankBranchCode.FieldName = "Şube Kodu";
            this.colBankBranchCode.Name = "colBankBranchCode";
            this.colBankBranchCode.Visible = true;
            this.colBankBranchCode.VisibleIndex = 3;
            // 
            // colBankAccountNumber
            // 
            this.colBankAccountNumber.FieldName = "Hesap No";
            this.colBankAccountNumber.Name = "colBankAccountNumber";
            this.colBankAccountNumber.Visible = true;
            this.colBankAccountNumber.VisibleIndex = 4;
            // 
            // colBankAccountName
            // 
            this.colBankAccountName.FieldName = "Hesap Adı";
            this.colBankAccountName.Name = "colBankAccountName";
            this.colBankAccountName.Visible = true;
            this.colBankAccountName.VisibleIndex = 5;
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
            this.btnBankDefSave,
            this.btnBankDefRemove,
            this.btnBankDefEdit,
            this.btnBankDefClose,
            this.btnBankDefRefresh,
            this.btnBankDefAddNew});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBankDefRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBankDefSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBankDefAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBankDefRemove),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBankDefClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnBankDefRefresh
            // 
            this.btnBankDefRefresh.Caption = "Yenile";
            this.btnBankDefRefresh.Id = 4;
            this.btnBankDefRefresh.ImageOptions.ImageIndex = 43;
            this.btnBankDefRefresh.Name = "btnBankDefRefresh";
            this.btnBankDefRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankDefRefresh_ItemClick);
            // 
            // btnBankDefSave
            // 
            this.btnBankDefSave.Caption = "Kaydet";
            this.btnBankDefSave.Id = 0;
            this.btnBankDefSave.ImageOptions.ImageIndex = 0;
            this.btnBankDefSave.Name = "btnBankDefSave";
            this.btnBankDefSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankDefSave_ItemClick);
            // 
            // btnBankDefAddNew
            // 
            this.btnBankDefAddNew.Caption = "Yeni";
            this.btnBankDefAddNew.Id = 5;
            this.btnBankDefAddNew.ImageOptions.ImageIndex = 46;
            this.btnBankDefAddNew.Name = "btnBankDefAddNew";
            this.btnBankDefAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankDefAddNew_ItemClick);
            // 
            // btnBankDefRemove
            // 
            this.btnBankDefRemove.Caption = "Sil";
            this.btnBankDefRemove.Id = 1;
            this.btnBankDefRemove.ImageOptions.ImageIndex = 44;
            this.btnBankDefRemove.Name = "btnBankDefRemove";
            this.btnBankDefRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankDefRemove_ItemClick);
            // 
            // btnBankDefClose
            // 
            this.btnBankDefClose.Caption = "Kapat";
            this.btnBankDefClose.Id = 3;
            this.btnBankDefClose.ImageOptions.ImageIndex = 1;
            this.btnBankDefClose.Name = "btnBankDefClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(531, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(531, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(531, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
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
            this.svgImageCollection1.Add("bo_attention_1", "image://svgimages/business objects/bo_attention.svg");
            this.svgImageCollection1.Add("bo_price", "image://svgimages/business objects/bo_price.svg");
            this.svgImageCollection1.Add("bo_price_item", "image://svgimages/business objects/bo_price_item.svg");
            this.svgImageCollection1.Add("buynow", "image://svgimages/outlook inspired/buynow.svg");
            this.svgImageCollection1.Add("categorize", "image://svgimages/outlook inspired/categorize.svg");
            this.svgImageCollection1.Add("group", "image://svgimages/dashboards/group.svg");
            this.svgImageCollection1.Add("bo_sale", "image://svgimages/business objects/bo_sale.svg");
            this.svgImageCollection1.Add("sales", "image://svgimages/outlook inspired/sales.svg");
            this.svgImageCollection1.Add("bo_sale_item", "image://svgimages/business objects/bo_sale_item.svg");
            this.svgImageCollection1.Add("weightedpies", "image://svgimages/dashboards/weightedpies.svg");
            this.svgImageCollection1.Add("bo_product", "image://svgimages/business objects/bo_product.svg");
            this.svgImageCollection1.Add("bo_product_group", "image://svgimages/business objects/bo_product_group.svg");
            this.svgImageCollection1.Add("shipmentreceived", "image://svgimages/outlook inspired/shipmentreceived.svg");
            this.svgImageCollection1.Add("bo_quote", "image://svgimages/business objects/bo_quote.svg");
            this.svgImageCollection1.Add("longdate", "image://svgimages/spreadsheet/longdate.svg");
            this.svgImageCollection1.Add("financial", "image://svgimages/spreadsheet/financial.svg");
            this.svgImageCollection1.Add("singlepageview", "image://svgimages/pdf viewer/singlepageview.svg");
            this.svgImageCollection1.Add("bo_project", "image://svgimages/business objects/bo_project.svg");
            this.svgImageCollection1.Add("rotateclockwise", "image://svgimages/pdf viewer/rotateclockwise.svg");
            this.svgImageCollection1.Add("rotatecounterclockwise", "image://svgimages/pdf viewer/rotatecounterclockwise.svg");
            this.svgImageCollection1.Add("bo_invoice", "image://svgimages/business objects/bo_invoice.svg");
            // 
            // btnBankDefEdit
            // 
            this.btnBankDefEdit.Caption = "Düzenle";
            this.btnBankDefEdit.Id = 2;
            this.btnBankDefEdit.ImageOptions.ImageIndex = 48;
            this.btnBankDefEdit.Name = "btnBankDefEdit";
            // 
            // bankDefBankNameTE
            // 
            this.bankDefBankNameTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_BankDetails, "BankName", true));
            this.bankDefBankNameTE.Location = new System.Drawing.Point(92, 12);
            this.bankDefBankNameTE.MenuManager = this.barManager1;
            this.bankDefBankNameTE.Name = "bankDefBankNameTE";
            this.bankDefBankNameTE.Size = new System.Drawing.Size(427, 20);
            this.bankDefBankNameTE.StyleController = this.layoutControl1;
            this.bankDefBankNameTE.TabIndex = 4;
            // 
            // bankDefBranchName
            // 
            this.bankDefBranchName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_BankDetails, "BankBranch", true));
            this.bankDefBranchName.Location = new System.Drawing.Point(347, 36);
            this.bankDefBranchName.MenuManager = this.barManager1;
            this.bankDefBranchName.Name = "bankDefBranchName";
            this.bankDefBranchName.Size = new System.Drawing.Size(172, 20);
            this.bankDefBranchName.StyleController = this.layoutControl1;
            this.bankDefBranchName.TabIndex = 5;
            // 
            // bankDefBranchCode
            // 
            this.bankDefBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_BankDetails, "BankBranchCode", true));
            this.bankDefBranchCode.Location = new System.Drawing.Point(92, 36);
            this.bankDefBranchCode.MenuManager = this.barManager1;
            this.bankDefBranchCode.Name = "bankDefBranchCode";
            this.bankDefBranchCode.Size = new System.Drawing.Size(171, 20);
            this.bankDefBranchCode.StyleController = this.layoutControl1;
            this.bankDefBranchCode.TabIndex = 6;
            // 
            // bankDefAccNo
            // 
            this.bankDefAccNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_BankDetails, "BankAccountNumber", true));
            this.bankDefAccNo.Location = new System.Drawing.Point(347, 60);
            this.bankDefAccNo.MenuManager = this.barManager1;
            this.bankDefAccNo.Name = "bankDefAccNo";
            this.bankDefAccNo.Size = new System.Drawing.Size(172, 20);
            this.bankDefAccNo.StyleController = this.layoutControl1;
            this.bankDefAccNo.TabIndex = 7;
            // 
            // bankDefAccName
            // 
            this.bankDefAccName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_BankDetails, "BankAccountName", true));
            this.bankDefAccName.Location = new System.Drawing.Point(92, 60);
            this.bankDefAccName.MenuManager = this.barManager1;
            this.bankDefAccName.Name = "bankDefAccName";
            this.bankDefAccName.Size = new System.Drawing.Size(171, 20);
            this.bankDefAccName.StyleController = this.layoutControl1;
            this.bankDefAccName.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(531, 406);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bankDefBankNameTE;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(511, 24);
            this.layoutControlItem1.Text = "Banka Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bankDefBranchCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem3.Text = "Şube Kodu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.bankDefAccName;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem5.Text = "Hesap Adı";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.bankDefBranchName;
            this.layoutControlItem2.Location = new System.Drawing.Point(255, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(256, 24);
            this.layoutControlItem2.Text = "Şube Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bankDefAccNo;
            this.layoutControlItem4.Location = new System.Drawing.Point(255, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(256, 24);
            this.layoutControlItem4.Text = "Hesap Numarası";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(511, 314);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmBankDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 448);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBankDefinition";
            this.Text = "frmBankDefinition";
            this.Load += new System.EventHandler(this.frmBankDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_BankDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_BankDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBankNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefBranchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefAccNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDefAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit bankDefBankNameTE;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit bankDefBranchName;
        private DevExpress.XtraEditors.TextEdit bankDefBranchCode;
        private DevExpress.XtraEditors.TextEdit bankDefAccNo;
        private DevExpress.XtraEditors.TextEdit bankDefAccName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarButtonItem btnBankDefSave;
        private DevExpress.XtraBars.BarButtonItem btnBankDefRemove;
        private DevExpress.XtraBars.BarButtonItem btnBankDefEdit;
        private DevExpress.XtraBars.BarButtonItem btnBankDefClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_BankDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem btnBankDefRefresh;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private System.Windows.Forms.BindingSource bs_BankDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colBid;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colBankBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountName;
        private DevExpress.XtraBars.BarButtonItem btnBankDefAddNew;
    }
}