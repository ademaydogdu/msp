namespace Msp.SimleCurrent
{
    partial class MainForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbi_HesapTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlimFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.btnFis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlinanCekListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHizliFaturaGirisi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.img_sicButton = new DevExpress.Utils.SvgImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sicButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbi_HesapTanimlari,
            this.btnAlimFaturasi,
            this.btnSatisFaturasi,
            this.btnFis,
            this.barButtonItem5,
            this.btnAlinanCekListesi,
            this.btnHizliFaturaGirisi,
            this.barButtonItem1});
            this.ribbonControl1.LargeImages = this.img_sicButton;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1031, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbi_HesapTanimlari
            // 
            this.bbi_HesapTanimlari.Caption = "Hesap Tanımları";
            this.bbi_HesapTanimlari.Id = 1;
            this.bbi_HesapTanimlari.ImageOptions.LargeImageIndex = 0;
            this.bbi_HesapTanimlari.Name = "bbi_HesapTanimlari";
            this.bbi_HesapTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_HesapTanimlari_ItemClick);
            // 
            // btnAlimFaturasi
            // 
            this.btnAlimFaturasi.Caption = "Alım Faturası";
            this.btnAlimFaturasi.Id = 2;
            this.btnAlimFaturasi.ImageOptions.LargeImageIndex = 3;
            this.btnAlimFaturasi.Name = "btnAlimFaturasi";
            this.btnAlimFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlimFaturasi_ItemClick);
            // 
            // btnSatisFaturasi
            // 
            this.btnSatisFaturasi.Caption = "Satış Faturası";
            this.btnSatisFaturasi.Id = 3;
            this.btnSatisFaturasi.ImageOptions.LargeImageIndex = 4;
            this.btnSatisFaturasi.Name = "btnSatisFaturasi";
            this.btnSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisFaturasi_ItemClick);
            // 
            // btnFis
            // 
            this.btnFis.Caption = "Fiş";
            this.btnFis.Id = 4;
            this.btnFis.ImageOptions.LargeImageIndex = 1;
            this.btnFis.Name = "btnFis";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnAlinanCekListesi
            // 
            this.btnAlinanCekListesi.Caption = "Alınan/Verilen Çek Listesi";
            this.btnAlinanCekListesi.Id = 6;
            this.btnAlinanCekListesi.ImageOptions.LargeImageIndex = 2;
            this.btnAlinanCekListesi.Name = "btnAlinanCekListesi";
            // 
            // btnHizliFaturaGirisi
            // 
            this.btnHizliFaturaGirisi.Caption = "Hızlı Fatura Girişi";
            this.btnHizliFaturaGirisi.Id = 7;
            this.btnHizliFaturaGirisi.ImageOptions.LargeImageIndex = 5;
            this.btnHizliFaturaGirisi.Name = "btnHizliFaturaGirisi";
            this.btnHizliFaturaGirisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHizliFaturaGirisi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Fatura ve Fiş Arama";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.LargeImageIndex = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // img_sicButton
            // 
            this.img_sicButton.ImageSize = new System.Drawing.Size(32, 32);
            this.img_sicButton.Add("bo_contact", "image://svgimages/business objects/bo_contact.svg");
            this.img_sicButton.Add("bo_sale", "image://svgimages/business objects/bo_sale.svg");
            this.img_sicButton.Add("bo_security_permission_member", "image://svgimages/business objects/bo_security_permission_member.svg");
            this.img_sicButton.Add("snapinsertheader", "image://svgimages/snap/snapinsertheader.svg");
            this.img_sicButton.Add("removegroupheader", "image://svgimages/snap/removegroupheader.svg");
            this.img_sicButton.Add("weather_lightning", "image://svgimages/icon builder/weather_lightning.svg");
            this.img_sicButton.Add("zoom", "image://svgimages/spreadsheet/zoom.svg");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cari İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbi_HesapTanimlari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHizliFaturaGirisi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAlimFaturasi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSatisFaturasi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFis);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAlinanCekListesi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1031, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 600);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Basit Cari Takip";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sicButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem bbi_HesapTanimlari;
        private DevExpress.XtraBars.BarButtonItem btnAlimFaturasi;
        private DevExpress.XtraBars.BarButtonItem btnSatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem btnFis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnAlinanCekListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.Utils.SvgImageCollection img_sicButton;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHizliFaturaGirisi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}