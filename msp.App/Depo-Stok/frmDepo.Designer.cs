namespace Msp.App.Depo_Stok
{
    partial class frmDepo
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
            this.bs_Depot = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_Depot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepAuthPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepPhoneOne = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepPhoneTwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepTaxAdministration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepTaxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnRefreshDepot = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNewDepot = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveDepot = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditDepot = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransacDepot = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepotClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSeaDepot = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Depot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 41);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(843, 442);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_Depot;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gcv_Depot;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 418);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_Depot});
            // 
            // bs_Depot
            // 
            this.bs_Depot.DataSource = typeof(Msp.Models.Models.DepotDTO);
            // 
            // gcv_Depot
            // 
            this.gcv_Depot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDID,
            this.colDepName,
            this.colDepAuthPerson,
            this.colDepAddress,
            this.colDepCity,
            this.colDepDistrict,
            this.colDepPhoneOne,
            this.colDepPhoneTwo,
            this.colDepTaxAdministration,
            this.colDepTaxNo,
            this.colDepDate,
            this.colDepActive});
            this.gcv_Depot.GridControl = this.gridControl1;
            this.gcv_Depot.Name = "gcv_Depot";
            // 
            // colDID
            // 
            this.colDID.FieldName = "ID";
            this.colDID.Name = "colDID";
            this.colDID.Visible = true;
            this.colDID.VisibleIndex = 0;
            // 
            // colDepName
            // 
            this.colDepName.FieldName = "Depo Adı";
            this.colDepName.Name = "colDepName";
            this.colDepName.Visible = true;
            this.colDepName.VisibleIndex = 1;
            // 
            // colDepAuthPerson
            // 
            this.colDepAuthPerson.FieldName = "Yetkili Kişi";
            this.colDepAuthPerson.Name = "colDepAuthPerson";
            this.colDepAuthPerson.Visible = true;
            this.colDepAuthPerson.VisibleIndex = 2;
            // 
            // colDepAddress
            // 
            this.colDepAddress.FieldName = "Adres";
            this.colDepAddress.Name = "colDepAddress";
            this.colDepAddress.Visible = true;
            this.colDepAddress.VisibleIndex = 3;
            // 
            // colDepCity
            // 
            this.colDepCity.FieldName = "İl";
            this.colDepCity.Name = "colDepCity";
            this.colDepCity.Visible = true;
            this.colDepCity.VisibleIndex = 4;
            // 
            // colDepDistrict
            // 
            this.colDepDistrict.FieldName = "İlçe";
            this.colDepDistrict.Name = "colDepDistrict";
            this.colDepDistrict.Visible = true;
            this.colDepDistrict.VisibleIndex = 5;
            // 
            // colDepPhoneOne
            // 
            this.colDepPhoneOne.FieldName = "Telefon";
            this.colDepPhoneOne.Name = "colDepPhoneOne";
            this.colDepPhoneOne.Visible = true;
            this.colDepPhoneOne.VisibleIndex = 6;
            // 
            // colDepPhoneTwo
            // 
            this.colDepPhoneTwo.FieldName = "Telefon 2";
            this.colDepPhoneTwo.Name = "colDepPhoneTwo";
            this.colDepPhoneTwo.Visible = true;
            this.colDepPhoneTwo.VisibleIndex = 7;
            // 
            // colDepTaxAdministration
            // 
            this.colDepTaxAdministration.FieldName = "Vergi Dairesi";
            this.colDepTaxAdministration.Name = "colDepTaxAdministration";
            this.colDepTaxAdministration.Visible = true;
            this.colDepTaxAdministration.VisibleIndex = 8;
            // 
            // colDepTaxNo
            // 
            this.colDepTaxNo.FieldName = "Vergi No";
            this.colDepTaxNo.Name = "colDepTaxNo";
            this.colDepTaxNo.Visible = true;
            this.colDepTaxNo.VisibleIndex = 9;
            // 
            // colDepDate
            // 
            this.colDepDate.FieldName = "Tarih";
            this.colDepDate.Name = "colDepDate";
            this.colDepDate.Visible = true;
            this.colDepDate.VisibleIndex = 10;
            // 
            // colDepActive
            // 
            this.colDepActive.FieldName = "Aktiflik Durumu";
            this.colDepActive.Name = "colDepActive";
            this.colDepActive.Visible = true;
            this.colDepActive.VisibleIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(843, 442);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(823, 422);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddNewDepot,
            this.btnRemoveDepot,
            this.btnEditDepot,
            this.btnSeaDepot,
            this.btnTransacDepot,
            this.btnDepotClose,
            this.btnRefreshDepot});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshDepot),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewDepot),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveDepot),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditDepot),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTransacDepot),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDepotClose)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnRefreshDepot
            // 
            this.btnRefreshDepot.Caption = "Yenile";
            this.btnRefreshDepot.Id = 6;
            this.btnRefreshDepot.ImageOptions.Image = global::Msp.App.Properties.Resources.refreshallpivottable_32x32;
            this.btnRefreshDepot.Name = "btnRefreshDepot";
            this.btnRefreshDepot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshDepot_ItemClick);
            // 
            // btnAddNewDepot
            // 
            this.btnAddNewDepot.Caption = "Yeni Depo";
            this.btnAddNewDepot.Id = 0;
            this.btnAddNewDepot.ImageOptions.Image = global::Msp.App.Properties.Resources.add_32x32;
            this.btnAddNewDepot.Name = "btnAddNewDepot";
            this.btnAddNewDepot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewDepot_ItemClick);
            // 
            // btnRemoveDepot
            // 
            this.btnRemoveDepot.Caption = "Depo Sil";
            this.btnRemoveDepot.Id = 1;
            this.btnRemoveDepot.ImageOptions.Image = global::Msp.App.Properties.Resources.remove_32x32;
            this.btnRemoveDepot.Name = "btnRemoveDepot";
            this.btnRemoveDepot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveDepot_ItemClick);
            // 
            // btnEditDepot
            // 
            this.btnEditDepot.Caption = "Depo Düzenle";
            this.btnEditDepot.Id = 2;
            this.btnEditDepot.ImageOptions.Image = global::Msp.App.Properties.Resources.pencolor_32x32;
            this.btnEditDepot.Name = "btnEditDepot";
            // 
            // btnTransacDepot
            // 
            this.btnTransacDepot.Caption = "Depo Hareketleri";
            this.btnTransacDepot.Id = 4;
            this.btnTransacDepot.ImageOptions.Image = global::Msp.App.Properties.Resources.bar_32x32;
            this.btnTransacDepot.Name = "btnTransacDepot";
            // 
            // btnDepotClose
            // 
            this.btnDepotClose.Caption = "Kapat";
            this.btnDepotClose.Id = 5;
            this.btnDepotClose.ImageOptions.Image = global::Msp.App.Properties.Resources.cancel_32x32;
            this.btnDepotClose.Name = "btnDepotClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(843, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(843, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(843, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // btnSeaDepot
            // 
            this.btnSeaDepot.Caption = "Depo Bul";
            this.btnSeaDepot.Id = 3;
            this.btnSeaDepot.Name = "btnSeaDepot";
            // 
            // frmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 525);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDepo";
            this.Text = "Depo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Depot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_Depot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_Depot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAddNewDepot;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnRemoveDepot;
        private DevExpress.XtraBars.BarButtonItem btnEditDepot;
        private DevExpress.XtraBars.BarButtonItem btnSeaDepot;
        private DevExpress.XtraBars.BarButtonItem btnTransacDepot;
        private DevExpress.XtraBars.BarButtonItem btnDepotClose;
        private DevExpress.XtraBars.BarButtonItem btnRefreshDepot;
        private System.Windows.Forms.BindingSource bs_Depot;
        private DevExpress.XtraGrid.Columns.GridColumn colDID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepAuthPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colDepAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDepCity;
        private DevExpress.XtraGrid.Columns.GridColumn colDepDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colDepPhoneOne;
        private DevExpress.XtraGrid.Columns.GridColumn colDepPhoneTwo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepTaxAdministration;
        private DevExpress.XtraGrid.Columns.GridColumn colDepTaxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepActive;
    }
}