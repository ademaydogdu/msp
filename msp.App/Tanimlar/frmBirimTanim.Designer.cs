namespace Msp.App.Tanimlar
{
    partial class frmBirimTanim
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
            this.bs_UnitType = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnUnitTypeRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_save = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnitDefAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnitDefRem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnitAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnitEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnUnitTypeAdd = new DevExpress.XtraEditors.SimpleButton();
            this.unitNameTE = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gcv_UnitType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.bs_UnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_UnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_UnitType
            // 
            this.bs_UnitType.DataSource = typeof(Msp.Models.Models.UnitsDTO);
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
            this.btnUnitAdd,
            this.btnUnitEdit,
            this.barButtonItem1,
            this.btnUnitTypeRefresh,
            this.btnUnitDefRem,
            this.btnUnitDefAdd});
            this.barManager1.LargeImages = this.img_bar;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUnitTypeRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUnitDefAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUnitDefRem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnUnitTypeRefresh
            // 
            this.btnUnitTypeRefresh.Caption = "Yenile";
            this.btnUnitTypeRefresh.Id = 6;
            this.btnUnitTypeRefresh.ImageOptions.ImageIndex = 7;
            this.btnUnitTypeRefresh.Name = "btnUnitTypeRefresh";
            // 
            // bbi_save
            // 
            this.bbi_save.Caption = "Kaydet";
            this.bbi_save.Id = 0;
            this.bbi_save.ImageOptions.ImageIndex = 0;
            this.bbi_save.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_save.Name = "bbi_save";
            this.bbi_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_save_ItemClick);
            // 
            // btnUnitDefAdd
            // 
            this.btnUnitDefAdd.Caption = "Yeni";
            this.btnUnitDefAdd.Id = 8;
            this.btnUnitDefAdd.ImageOptions.ImageIndex = 4;
            this.btnUnitDefAdd.Name = "btnUnitDefAdd";
            this.btnUnitDefAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnitDefAdd_ItemClick);
            // 
            // btnUnitDefRem
            // 
            this.btnUnitDefRem.Caption = "Sil";
            this.btnUnitDefRem.Id = 7;
            this.btnUnitDefRem.ImageOptions.ImageIndex = 3;
            this.btnUnitDefRem.Name = "btnUnitDefRem";
            this.btnUnitDefRem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnitDefRem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Vazgeç";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(526, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(526, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(526, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // img_bar
            // 
            this.img_bar.ImageSize = new System.Drawing.Size(32, 32);
            this.img_bar.Add("bo_validation", "image://svgimages/business objects/bo_validation.svg");
            this.img_bar.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.img_bar.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.img_bar.Add("deletedatasource", "image://svgimages/dashboards/deletedatasource.svg");
            this.img_bar.Add("newdatasource", "image://svgimages/dashboards/newdatasource.svg");
            this.img_bar.Add("editdatasource", "image://svgimages/dashboards/editdatasource.svg");
            this.img_bar.Add("editnames", "image://svgimages/dashboards/editnames.svg");
            this.img_bar.Add("refreshallpivottable", "image://svgimages/spreadsheet/refreshallpivottable.svg");
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Delete";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 3;
            this.bbi_Delete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.bbi_Delete.Name = "bbi_Delete";
//            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.Caption = "Birim Ekle";
            this.btnUnitAdd.Id = 3;
            this.btnUnitAdd.ImageOptions.ImageIndex = 4;
            this.btnUnitAdd.Name = "btnUnitAdd";
            // 
            // btnUnitEdit
            // 
            this.btnUnitEdit.Caption = "Birim Düzenle";
            this.btnUnitEdit.Id = 4;
            this.btnUnitEdit.ImageOptions.ImageIndex = 5;
            this.btnUnitEdit.Name = "btnUnitEdit";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnUnitTypeAdd);
            this.layoutControl1.Controls.Add(this.unitNameTE);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.img_bar;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(468, 130, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(526, 389);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnUnitTypeAdd
            // 
            this.btnUnitTypeAdd.Location = new System.Drawing.Point(265, 12);
            this.btnUnitTypeAdd.Name = "btnUnitTypeAdd";
            this.btnUnitTypeAdd.Size = new System.Drawing.Size(67, 22);
            this.btnUnitTypeAdd.StyleController = this.layoutControl1;
            this.btnUnitTypeAdd.TabIndex = 5;
            this.btnUnitTypeAdd.Text = "Ekle";
            this.btnUnitTypeAdd.Click += new System.EventHandler(this.btnUnitTypeAdd_Click);
            // 
            // unitNameTE
            // 
            this.unitNameTE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_UnitType, "UName", true));
            this.unitNameTE.Location = new System.Drawing.Point(92, 12);
            this.unitNameTE.MenuManager = this.barManager1;
            this.unitNameTE.Name = "unitNameTE";
            this.unitNameTE.Size = new System.Drawing.Size(169, 20);
            this.unitNameTE.StyleController = this.layoutControl1;
            this.unitNameTE.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bs_UnitType;
            this.gridControl1.Location = new System.Drawing.Point(12, 48);
            this.gridControl1.MainView = this.gcv_UnitType;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(502, 329);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_UnitType});
            // 
            // gcv_UnitType
            // 
            this.gcv_UnitType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUID,
            this.colUName});
            this.gcv_UnitType.GridControl = this.gridControl1;
            this.gcv_UnitType.Name = "gcv_UnitType";
            // 
            // colUID
            // 
            this.colUID.FieldName = "UID";
            this.colUID.Name = "colUID";
            this.colUID.Visible = true;
            this.colUID.VisibleIndex = 0;
            // 
            // colUName
            // 
            this.colUName.FieldName = "Birim Adı";
            this.colUName.Name = "colUName";
            this.colUName.Visible = true;
            this.colUName.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(526, 389);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(506, 333);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.unitNameTE;
            this.layoutControlItem2.ImageOptions.ImageIndex = 6;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(253, 36);
            this.layoutControlItem2.Text = "Birim Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnUnitTypeAdd;
            this.layoutControlItem3.Location = new System.Drawing.Point(253, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(71, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(324, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(182, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmBirimTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 431);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBirimTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birim Tanımları";
            this.Load += new System.EventHandler(this.frmBirimTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_UnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_UnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bs_UnitType;
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_UnitType;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnUnitAdd;
        private DevExpress.XtraBars.BarButtonItem btnUnitEdit;
        private DevExpress.XtraEditors.SimpleButton btnUnitTypeAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit unitNameTE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colUName;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnUnitTypeRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem btnUnitDefAdd;
        private DevExpress.XtraBars.BarButtonItem btnUnitDefRem;
    }
}