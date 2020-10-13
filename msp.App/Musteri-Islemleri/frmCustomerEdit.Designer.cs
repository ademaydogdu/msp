namespace Msp.App.Musteri_Islemleri
{
    partial class frmCustomerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bs_CustomersEdit = new System.Windows.Forms.BindingSource(this.components);
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSaveCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CustomersEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.memoEdit1);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Controls.Add(this.lookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(527, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_CustomersEdit, "name", true));
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(119, 27);
            this.textEdit1.MenuManager = this.barManager2;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(363, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // bs_CustomersEdit
            // 
            this.bs_CustomersEdit.DataSource = typeof(Msp.Models.Models.CustomersDTO);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Images = this.svgImageCollection1;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaveCustomer,
            this.btnCustomerClose});
            this.barManager2.MaxItemId = 2;
            this.barManager2.StatusBar = this.bar1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Status bar";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCustomerClose)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Status bar";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Caption = "Kaydet";
            this.btnSaveCustomer.Id = 0;
            this.btnSaveCustomer.ImageOptions.ImageIndex = 30;
            this.btnSaveCustomer.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveCustomer_ItemClick);
            // 
            // btnCustomerClose
            // 
            this.btnCustomerClose.Caption = "Kapat";
            this.btnCustomerClose.Id = 1;
            this.btnCustomerClose.ImageOptions.ImageIndex = 18;
            this.btnCustomerClose.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerClose.Name = "btnCustomerClose";
            this.btnCustomerClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerClose_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(527, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 468);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(527, 40);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 468);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(527, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 468);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("statistics-document-svgrepo-com", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.statistics-document-svgrepo-com"))));
            this.svgImageCollection1.Add("alcaline_spiral_calendar", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.alcaline_spiral_calendar"))));
            this.svgImageCollection1.Add("primary-percent", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-percent"))));
            this.svgImageCollection1.Add("ftpercent", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.ftpercent"))));
            this.svgImageCollection1.Add("Architetto----Calcolatrice", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Architetto----Calcolatrice"))));
            this.svgImageCollection1.Add("calculator", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.calculator"))));
            this.svgImageCollection1.Add("kuba-icon-delete", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.kuba-icon-delete"))));
            this.svgImageCollection1.Add("1550775830", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1550775830"))));
            this.svgImageCollection1.Add("tag (1)", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tag (1)"))));
            this.svgImageCollection1.Add("1307548250", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1307548250"))));
            this.svgImageCollection1.Add("1298512738", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1298512738"))));
            this.svgImageCollection1.Add("Remove-349235435", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Remove-349235435"))));
            this.svgImageCollection1.Add("tag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tag"))));
            this.svgImageCollection1.Add("eastshores_Warning_Notification", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.eastshores_Warning_Notification"))));
            this.svgImageCollection1.Add("Warning", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Warning"))));
            this.svgImageCollection1.Add("warning-17", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.warning-17"))));
            this.svgImageCollection1.Add("tasto-8-architetto-franc-01", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.tasto-8-architetto-franc-01"))));
            this.svgImageCollection1.Add("jean_victor_balin_cross", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.jean_victor_balin_cross"))));
            this.svgImageCollection1.Add("molumen_red_round_error_warning_icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.molumen_red_round_error_warning_icon"))));
            this.svgImageCollection1.Add("error-button", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.error-button"))));
            this.svgImageCollection1.Add("map-pin", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.map-pin"))));
            this.svgImageCollection1.Add("color-icons-green-home", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.color-icons-green-home"))));
            this.svgImageCollection1.Add("1392496432", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1392496432"))));
            this.svgImageCollection1.Add("green", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.green"))));
            this.svgImageCollection1.Add("location_icon", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.location_icon"))));
            this.svgImageCollection1.Add("1328388231", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.1328388231"))));
            this.svgImageCollection1.Add("Android-Phone-1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Android-Phone-1"))));
            this.svgImageCollection1.Add("matt-icons_contact-add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.matt-icons_contact-add"))));
            this.svgImageCollection1.Add("Planned-obsolescence-barcode-in-squarre---French", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Planned-obsolescence-barcode-in-squarre---French"))));
            this.svgImageCollection1.Add("rodentia-icons_ok", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.rodentia-icons_ok"))));
            this.svgImageCollection1.Add("primary-apply", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-apply"))));
            this.svgImageCollection1.Add("jean_victor_balin_add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.jean_victor_balin_add"))));
            this.svgImageCollection1.Add("primary-tab-new", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.primary-tab-new"))));
            this.svgImageCollection1.Add("positive", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.positive"))));
            this.svgImageCollection1.Add("view-refresh", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.view-refresh"))));
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_CustomersEdit, "surname", true));
            this.textEdit2.Location = new System.Drawing.Point(119, 63);
            this.textEdit2.MenuManager = this.barManager2;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(363, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_CustomersEdit, "address", true));
            this.memoEdit1.Location = new System.Drawing.Point(119, 99);
            this.memoEdit1.MenuManager = this.barManager2;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(363, 38);
            this.memoEdit1.StyleController = this.layoutControl1;
            this.memoEdit1.TabIndex = 6;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_CustomersEdit, "phone", true));
            this.textEdit3.Location = new System.Drawing.Point(119, 141);
            this.textEdit3.MenuManager = this.barManager2;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(363, 20);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 7;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_CustomersEdit, "active", true));
            this.lookUpEdit1.EditValue = null;
            this.lookUpEdit1.Location = new System.Drawing.Point(43, 177);
            this.lookUpEdit1.MenuManager = this.barManager2;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.lookUpEdit1.Properties.Caption = "Aktif";
            this.lookUpEdit1.Properties.NullText = "[EditValue is null]";
            this.lookUpEdit1.Size = new System.Drawing.Size(439, 20);
            this.lookUpEdit1.StyleController = this.layoutControl1;
            this.lookUpEdit1.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(527, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem1.ImageOptions.SvgImage")));
            this.layoutControlItem1.Location = new System.Drawing.Point(31, 15);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(443, 36);
            this.layoutControlItem1.Text = "Ad";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(31, 189);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(443, 259);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem2.ImageOptions.SvgImage")));
            this.layoutControlItem2.Location = new System.Drawing.Point(31, 51);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(443, 36);
            this.layoutControlItem2.Text = "Soyad";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.memoEdit1;
            this.layoutControlItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem3.ImageOptions.SvgImage")));
            this.layoutControlItem3.Location = new System.Drawing.Point(31, 87);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(443, 42);
            this.layoutControlItem3.Text = "Adres";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 32);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit3;
            this.layoutControlItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("layoutControlItem4.ImageOptions.SvgImage")));
            this.layoutControlItem4.Location = new System.Drawing.Point(31, 129);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(443, 36);
            this.layoutControlItem4.Text = "Telefon";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 32);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(31, 165);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(443, 24);
            this.layoutControlItem5.Text = "Aktiflik Durumu";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 15);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(31, 433);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(474, 15);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(33, 433);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(507, 15);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 508);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmCustomerEdit";
            this.Text = "Müşteri Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CustomersEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSaveCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCustomerClose;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private System.Windows.Forms.BindingSource bs_CustomersEdit;
        private DevExpress.XtraEditors.CheckEdit lookUpEdit1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}