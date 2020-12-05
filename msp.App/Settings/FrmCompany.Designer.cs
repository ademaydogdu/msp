namespace Msp.App.Settings
{
    partial class FrmCompany
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
            this.bbi_New = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.gc_company = new DevExpress.XtraGrid.GridControl();
            this.bs_companyList = new System.Windows.Forms.BindingSource(this.components);
            this.gcv_company = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_companyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_company)).BeginInit();
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
            this.barManager1.Images = this.img_bar;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_New,
            this.bbi_Edit,
            this.bbi_delete,
            this.bbi_refresh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_refresh, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_New
            // 
            this.bbi_New.Caption = "Yeni";
            this.bbi_New.Id = 0;
            this.bbi_New.ImageOptions.ImageIndex = 0;
            this.bbi_New.Name = "bbi_New";
            this.bbi_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_New_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "Düzenle";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.ImageOptions.ImageIndex = 2;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_delete
            // 
            this.bbi_delete.Caption = "Sil";
            this.bbi_delete.Id = 2;
            this.bbi_delete.ImageOptions.ImageIndex = 1;
            this.bbi_delete.Name = "bbi_delete";
            this.bbi_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_delete_ItemClick);
            // 
            // bbi_refresh
            // 
            this.bbi_refresh.Caption = "Yenile";
            this.bbi_refresh.Id = 3;
            this.bbi_refresh.ImageOptions.ImageIndex = 3;
            this.bbi_refresh.Name = "bbi_refresh";
            this.bbi_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_refresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(763, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 552);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(763, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 552);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(763, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 552);
            // 
            // img_bar
            // 
            this.img_bar.ImageSize = new System.Drawing.Size(24, 24);
            this.img_bar.Add("new", "image://svgimages/actions/new.svg");
            this.img_bar.Add("del", "image://svgimages/diagramicons/del.svg");
            this.img_bar.Add("linecolor", "image://svgimages/spreadsheet/linecolor.svg");
            this.img_bar.Add("convertto", "image://svgimages/dashboards/convertto.svg");
            // 
            // gc_company
            // 
            this.gc_company.DataSource = this.bs_companyList;
            this.gc_company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_company.Location = new System.Drawing.Point(0, 0);
            this.gc_company.MainView = this.gcv_company;
            this.gc_company.MenuManager = this.barManager1;
            this.gc_company.Name = "gc_company";
            this.gc_company.Size = new System.Drawing.Size(763, 552);
            this.gc_company.TabIndex = 4;
            this.gc_company.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_company});
            // 
            // bs_companyList
            // 
            this.bs_companyList.DataSource = typeof(Msp.Models.Models.CompanyDTO);
            // 
            // gcv_company
            // 
            this.gcv_company.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyCode,
            this.colCompanyName});
            this.gcv_company.GridControl = this.gc_company;
            this.gcv_company.Name = "gcv_company";
            this.gcv_company.OptionsBehavior.Editable = false;
            this.gcv_company.OptionsView.ColumnAutoWidth = false;
            this.gcv_company.OptionsView.ShowGroupPanel = false;
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.FieldName = "CompanyCode";
            this.colCompanyCode.Name = "colCompanyCode";
            this.colCompanyCode.Visible = true;
            this.colCompanyCode.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 586);
            this.Controls.Add(this.gc_company);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCompany";
            this.Text = "İşyeri Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompany_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_companyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_company)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gc_company;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_company;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private System.Windows.Forms.BindingSource bs_companyList;
        private DevExpress.XtraBars.BarButtonItem bbi_New;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_delete;
        private DevExpress.XtraBars.BarButtonItem bbi_refresh;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
    }
}