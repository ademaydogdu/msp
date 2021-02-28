
namespace Msp.SimleCurrent.Screen
{
    partial class InvoiceList
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
            this.bbi_Deleted = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_closed = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.gc_InvoiceList = new DevExpress.XtraGrid.GridControl();
            this.gcv_InvoiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bs_Invoice = new System.Windows.Forms.BindingSource(this.components);
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_InvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_InvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).BeginInit();
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
            this.barManager1.Images = this.svgImageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_New,
            this.bbi_Edit,
            this.bbi_closed,
            this.bbi_Deleted});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Deleted),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_closed, true)});
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
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "Düzelt";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.ImageOptions.ImageIndex = 3;
            this.bbi_Edit.Name = "bbi_Edit";
            // 
            // bbi_Deleted
            // 
            this.bbi_Deleted.Caption = "Sil";
            this.bbi_Deleted.Id = 3;
            this.bbi_Deleted.ImageOptions.ImageIndex = 4;
            this.bbi_Deleted.Name = "bbi_Deleted";
            // 
            // bbi_closed
            // 
            this.bbi_closed.Caption = "Vazgeç";
            this.bbi_closed.Id = 2;
            this.bbi_closed.ImageOptions.ImageIndex = 1;
            this.bbi_closed.Name = "bbi_closed";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(811, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(811, 41);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(811, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(31, 31);
            this.svgImageCollection1.Add("addfile", "image://svgimages/outlook inspired/addfile.svg");
            this.svgImageCollection1.Add("delete", "image://svgimages/scheduling/delete.svg");
            this.svgImageCollection1.Add("snapdeletelist", "image://svgimages/snap/snapdeletelist.svg");
            this.svgImageCollection1.Add("edit", "image://svgimages/dashboards/edit.svg");
            this.svgImageCollection1.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            // 
            // gc_InvoiceList
            // 
            this.gc_InvoiceList.DataSource = this.bs_Invoice;
            this.gc_InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_InvoiceList.Location = new System.Drawing.Point(0, 0);
            this.gc_InvoiceList.MainView = this.gcv_InvoiceList;
            this.gc_InvoiceList.MenuManager = this.barManager1;
            this.gc_InvoiceList.Name = "gc_InvoiceList";
            this.gc_InvoiceList.Size = new System.Drawing.Size(811, 478);
            this.gc_InvoiceList.TabIndex = 4;
            this.gc_InvoiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_InvoiceList});
            // 
            // gcv_InvoiceList
            // 
            this.gcv_InvoiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.colCariId,
            this.colInvoiceDate,
            this.colInvoiceType,
            this.colInvoiceNo,
            this.colRemark,
            this.colVade,
            this.colBorc,
            this.colAlacak,
            this.colBakiye,
            this.colCurrencyBorc,
            this.colCurrencyAlacak,
            this.colCurrencyBakiye,
            this.colIsDetail,
            this.colCurrencyId});
            this.gcv_InvoiceList.GridControl = this.gc_InvoiceList;
            this.gcv_InvoiceList.Name = "gcv_InvoiceList";
            this.gcv_InvoiceList.OptionsView.ShowGroupPanel = false;
            // 
            // bs_Invoice
            // 
            this.bs_Invoice.DataSource = typeof(Msp.Models.SimleCurrentModels.SimpleInvoiceOwnerDTO);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            this.colRecId.Visible = true;
            this.colRecId.VisibleIndex = 0;
            // 
            // colCariId
            // 
            this.colCariId.FieldName = "CariId";
            this.colCariId.Name = "colCariId";
            this.colCariId.Visible = true;
            this.colCariId.VisibleIndex = 1;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 2;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.FieldName = "InvoiceType";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 3;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 4;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            // 
            // colVade
            // 
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.Visible = true;
            this.colVade.VisibleIndex = 6;
            // 
            // colBorc
            // 
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 7;
            // 
            // colAlacak
            // 
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 8;
            // 
            // colBakiye
            // 
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 9;
            // 
            // colCurrencyBorc
            // 
            this.colCurrencyBorc.FieldName = "CurrencyBorc";
            this.colCurrencyBorc.Name = "colCurrencyBorc";
            this.colCurrencyBorc.Visible = true;
            this.colCurrencyBorc.VisibleIndex = 10;
            // 
            // colCurrencyAlacak
            // 
            this.colCurrencyAlacak.FieldName = "CurrencyAlacak";
            this.colCurrencyAlacak.Name = "colCurrencyAlacak";
            this.colCurrencyAlacak.Visible = true;
            this.colCurrencyAlacak.VisibleIndex = 11;
            // 
            // colCurrencyBakiye
            // 
            this.colCurrencyBakiye.FieldName = "CurrencyBakiye";
            this.colCurrencyBakiye.Name = "colCurrencyBakiye";
            this.colCurrencyBakiye.Visible = true;
            this.colCurrencyBakiye.VisibleIndex = 12;
            // 
            // colIsDetail
            // 
            this.colIsDetail.FieldName = "IsDetail";
            this.colIsDetail.Name = "colIsDetail";
            this.colIsDetail.Visible = true;
            this.colIsDetail.VisibleIndex = 13;
            // 
            // colCurrencyId
            // 
            this.colCurrencyId.FieldName = "CurrencyId";
            this.colCurrencyId.Name = "colCurrencyId";
            this.colCurrencyId.Visible = true;
            this.colCurrencyId.VisibleIndex = 14;
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.gc_InvoiceList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "InvoiceList";
            this.Text = "InvoiceList";
            this.Load += new System.EventHandler(this.InvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_InvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_InvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_New;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Deleted;
        private DevExpress.XtraBars.BarButtonItem bbi_closed;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gc_InvoiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_InvoiceList;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private System.Windows.Forms.BindingSource bs_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn colCariId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colVade;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyBakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
    }
}