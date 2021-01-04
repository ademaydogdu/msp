namespace Msp.App.Islemler
{
    partial class frmBankEntryEdit
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
            this.bankNameTE = new DevExpress.XtraEditors.LookUpEdit();
            this.docNoTE = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.docDescTE = new DevExpress.XtraEditors.TextEdit();
            this.amountTE = new DevExpress.XtraEditors.TextEdit();
            this.withdrawTE = new DevExpress.XtraEditors.TextEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.LayoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bs_BankEntries = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDescTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_BankEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bankNameTE);
            this.layoutControl1.Controls.Add(this.docNoTE);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.docDescTE);
            this.layoutControl1.Controls.Add(this.amountTE);
            this.layoutControl1.Controls.Add(this.withdrawTE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.svgImageCollection1;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(602, 304);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bankNameTE
            // 
            this.bankNameTE.Location = new System.Drawing.Point(137, 48);
            this.bankNameTE.Name = "bankNameTE";
            this.bankNameTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.bankNameTE.Properties.DisplayMember = "UName";
            this.bankNameTE.Properties.NullText = "";
            this.bankNameTE.Properties.ValueMember = "UID";
            this.bankNameTE.Size = new System.Drawing.Size(453, 20);
            this.bankNameTE.StyleController = this.layoutControl1;
            this.bankNameTE.TabIndex = 14;
            this.bankNameTE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bankNameTE_ButtonClick);
            // 
            // docNoTE
            // 
            this.docNoTE.EditValue = "";
            this.docNoTE.Location = new System.Drawing.Point(428, 12);
            this.docNoTE.Name = "docNoTE";
            this.docNoTE.Size = new System.Drawing.Size(162, 20);
            this.docNoTE.StyleController = this.layoutControl1;
            this.docNoTE.TabIndex = 4;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(137, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(162, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 5;
            // 
            // docDescTE
            // 
            this.docDescTE.Location = new System.Drawing.Point(137, 85);
            this.docDescTE.Name = "docDescTE";
            this.docDescTE.Size = new System.Drawing.Size(453, 20);
            this.docDescTE.StyleController = this.layoutControl1;
            this.docDescTE.TabIndex = 7;
            // 
            // amountTE
            // 
            this.amountTE.Location = new System.Drawing.Point(137, 121);
            this.amountTE.Name = "amountTE";
            this.amountTE.Size = new System.Drawing.Size(161, 20);
            this.amountTE.StyleController = this.layoutControl1;
            this.amountTE.TabIndex = 8;
            // 
            // withdrawTE
            // 
            this.withdrawTE.Location = new System.Drawing.Point(427, 121);
            this.withdrawTE.Name = "withdrawTE";
            this.withdrawTE.Size = new System.Drawing.Size(163, 20);
            this.withdrawTE.StyleController = this.layoutControl1;
            this.withdrawTE.TabIndex = 9;
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem1,
            this.LayoutControlItem3,
            this.simpleSeparator1,
            this.LayoutControlItem4,
            this.LayoutControlItem6,
            this.LayoutControlItem7,
            this.LayoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(602, 304);
            this.Root.TextVisible = false;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.dateEdit1;
            this.LayoutControlItem1.ImageOptions.ImageIndex = 64;
            this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Size = new System.Drawing.Size(291, 36);
            this.LayoutControlItem1.Text = "Dekont Tarih";
            this.LayoutControlItem1.TextSize = new System.Drawing.Size(122, 32);
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.docNoTE;
            this.LayoutControlItem3.ImageOptions.ImageIndex = 13;
            this.LayoutControlItem3.Location = new System.Drawing.Point(291, 0);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Size = new System.Drawing.Size(291, 36);
            this.LayoutControlItem3.Text = "Fiş No";
            this.LayoutControlItem3.TextSize = new System.Drawing.Size(122, 32);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 72);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(582, 1);
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.docDescTE;
            this.LayoutControlItem4.ImageOptions.ImageIndex = 66;
            this.LayoutControlItem4.Location = new System.Drawing.Point(0, 73);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Size = new System.Drawing.Size(582, 36);
            this.LayoutControlItem4.Text = "Dekont Açıklaması";
            this.LayoutControlItem4.TextSize = new System.Drawing.Size(122, 32);
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.amountTE;
            this.LayoutControlItem6.ImageOptions.ImageIndex = 68;
            this.LayoutControlItem6.Location = new System.Drawing.Point(0, 109);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            this.LayoutControlItem6.Size = new System.Drawing.Size(290, 36);
            this.LayoutControlItem6.Text = "Yatan Tutar";
            this.LayoutControlItem6.TextSize = new System.Drawing.Size(122, 32);
            // 
            // LayoutControlItem7
            // 
            this.LayoutControlItem7.Control = this.withdrawTE;
            this.LayoutControlItem7.ImageOptions.ImageIndex = 69;
            this.LayoutControlItem7.Location = new System.Drawing.Point(290, 109);
            this.LayoutControlItem7.Name = "LayoutControlItem7";
            this.LayoutControlItem7.Size = new System.Drawing.Size(292, 36);
            this.LayoutControlItem7.Text = "Çekilen Tutar";
            this.LayoutControlItem7.TextSize = new System.Drawing.Size(122, 32);
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.bankNameTE;
            this.LayoutControlItem2.ImageOptions.ImageIndex = 70;
            this.LayoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Size = new System.Drawing.Size(582, 36);
            this.LayoutControlItem2.Text = "Banka Adı";
            this.LayoutControlItem2.TextSize = new System.Drawing.Size(122, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(290, 145);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(292, 139);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 145);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(290, 139);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bs_BankEntries
            // 
            this.bs_BankEntries.DataSource = typeof(Msp.Models.Models.BankEntryDTO);
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
            this.bbi_save,
            this.barButtonItem2,
            this.bbi_Delete,
            this.bbi_Refresh});
            this.barManager1.LargeImages = this.img_bar;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_save
            // 
            this.bbi_save.Caption = "Kaydet";
            this.bbi_save.Id = 0;
            this.bbi_save.ImageOptions.ImageIndex = 1;
            this.bbi_save.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_save.Name = "bbi_save";
            this.bbi_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_save_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Vazgeç";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 0;
            this.barButtonItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(602, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 304);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(602, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 304);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(602, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 304);
            // 
            // img_bar
            // 
            this.img_bar.Add("delete", "image://svgimages/dashboards/delete.svg");
            this.img_bar.Add("save", "image://svgimages/outlook inspired/save.svg");
            this.img_bar.Add("charthorizontalaxis_logscale", "image://svgimages/spreadsheet/charthorizontalaxis_logscale.svg");
            this.img_bar.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 3;
            this.bbi_Refresh.ImageOptions.ImageIndex = 4;
            this.bbi_Refresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Refresh.Name = "bbi_Refresh";
            // 
            // frmBankEntryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBankEntryEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBankEntryEdit";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docDescTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_BankEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bs_BankEntries;
        private DevExpress.XtraEditors.TextEdit docNoTE;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit docDescTE;
        private DevExpress.XtraEditors.TextEdit amountTE;
        private DevExpress.XtraEditors.TextEdit withdrawTE;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem7;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.LookUpEdit bankNameTE;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_save;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
    }
}