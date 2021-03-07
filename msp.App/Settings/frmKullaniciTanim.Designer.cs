namespace Msp.App.Settings
{
    partial class frmKullaniciTanim
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
            this.bbi_bar = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_New = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_View = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_DeletedRow = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bs_UserList = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bbi_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bbi_bar
            // 
            this.bbi_bar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.bbi_bar.DockControls.Add(this.barDockControlTop);
            this.bbi_bar.DockControls.Add(this.barDockControlBottom);
            this.bbi_bar.DockControls.Add(this.barDockControlLeft);
            this.bbi_bar.DockControls.Add(this.barDockControlRight);
            this.bbi_bar.Form = this;
            this.bbi_bar.Images = this.img_bar;
            this.bbi_bar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1,
            this.bbi_New,
            this.bbi_Edit,
            this.bbi_Cancel,
            this.bbi_View,
            this.bbi_Refresh,
            this.barButtonItem1,
            this.bbi_DeletedRow});
            this.bbi_bar.LargeImages = this.img_bar;
            this.bbi_bar.MaxItemId = 8;
            this.bbi_bar.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_View),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_DeletedRow),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_New
            // 
            this.bbi_New.Caption = "Yeni Kayıt";
            this.bbi_New.Id = 1;
            this.bbi_New.ImageOptions.ImageIndex = 0;
            this.bbi_New.Name = "bbi_New";
            this.bbi_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_New_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "Düzenle";
            this.bbi_Edit.Id = 2;
            this.bbi_Edit.ImageOptions.ImageIndex = 2;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_View
            // 
            this.bbi_View.Caption = "Ön İzleme";
            this.bbi_View.Id = 4;
            this.bbi_View.ImageOptions.ImageIndex = 4;
            this.bbi_View.Name = "bbi_View";
            this.bbi_View.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_View_ItemClick);
            // 
            // bbi_DeletedRow
            // 
            this.bbi_DeletedRow.Caption = "Satır Sil";
            this.bbi_DeletedRow.Id = 7;
            this.bbi_DeletedRow.ImageOptions.ImageIndex = 6;
            this.bbi_DeletedRow.Name = "bbi_DeletedRow";
            this.bbi_DeletedRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_DeletedRow_ItemClick);
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenileme";
            this.bbi_Refresh.Id = 5;
            this.bbi_Refresh.ImageOptions.ImageIndex = 3;
            this.bbi_Refresh.Name = "bbi_Refresh";
            this.bbi_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Refresh_ItemClick);
            // 
            // bbi_Cancel
            // 
            this.bbi_Cancel.Caption = "Çıkış";
            this.bbi_Cancel.Id = 3;
            this.bbi_Cancel.ImageOptions.ImageIndex = 1;
            this.bbi_Cancel.Name = "bbi_Cancel";
            this.bbi_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Cancel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "LOG";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.ImageIndex = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bbi_bar;
            this.barDockControlTop.Size = new System.Drawing.Size(760, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 522);
            this.barDockControlBottom.Manager = this.bbi_bar;
            this.barDockControlBottom.Size = new System.Drawing.Size(760, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.bbi_bar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 522);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(760, 0);
            this.barDockControlRight.Manager = this.bbi_bar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 522);
            // 
            // img_bar
            // 
            this.img_bar.ImageSize = new System.Drawing.Size(24, 24);
            this.img_bar.Add("new", "image://svgimages/actions/new.svg");
            this.img_bar.Add("del", "image://svgimages/diagramicons/del.svg");
            this.img_bar.Add("linecolor", "image://svgimages/spreadsheet/linecolor.svg");
            this.img_bar.Add("convertto", "image://svgimages/dashboards/convertto.svg");
            this.img_bar.Add("preview", "image://svgimages/print/preview.svg");
            this.img_bar.Add("chartverticalaxis_logscale", "image://svgimages/spreadsheet/chartverticalaxis_logscale.svg");
            this.img_bar.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_UserList;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.bbi_bar;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 522);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bs_UserList
            // 
            this.bs_UserList.DataSource = typeof(Msp.Models.Models.UsersDTO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colActive,
            this.colusername,
            this.colEmail});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 0;
            // 
            // colusername
            // 
            this.colusername.Caption = "Kullanıcı Kodu";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 1;
            this.colusername.Width = 139;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 156;
            // 
            // frmKullaniciTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 556);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKullaniciTanim";
            this.Text = "Kulalnıcı Tanımları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciTanim_FormClosing);
            this.Load += new System.EventHandler(this.frmKullaniciTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbi_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bbi_bar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_New;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Cancel;
        private DevExpress.XtraBars.BarButtonItem bbi_View;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bs_UserList;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbi_DeletedRow;
    }
}