namespace Msp.App.App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lc_serverList = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_ServerList = new System.Windows.Forms.BindingSource(this.components);
            this.lc_Company = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_company = new System.Windows.Forms.BindingSource(this.components);
            this.txt_userCode = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.chk_BeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this._ResetPassword = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lc_serverList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ServerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_BeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ResetPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lc_serverList);
            this.layoutControl1.Controls.Add(this.lc_Company);
            this.layoutControl1.Controls.Add(this.txt_userCode);
            this.layoutControl1.Controls.Add(this.txt_Password);
            this.layoutControl1.Controls.Add(this.chk_BeniHatirla);
            this.layoutControl1.Controls.Add(this.btn_login);
            this.layoutControl1.Controls.Add(this.btn_Cancel);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this._ResetPassword);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.img_sic;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(702, 70, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(305, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lc_serverList
            // 
            this.lc_serverList.Location = new System.Drawing.Point(115, 312);
            this.lc_serverList.Name = "lc_serverList";
            this.lc_serverList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_serverList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServerName", "Server Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Server", "Server")});
            this.lc_serverList.Properties.DataSource = this.bs_ServerList;
            this.lc_serverList.Properties.DisplayMember = "ServerName";
            this.lc_serverList.Properties.NullText = "";
            this.lc_serverList.Properties.ValueMember = "Id";
            this.lc_serverList.Size = new System.Drawing.Size(166, 20);
            this.lc_serverList.StyleController = this.layoutControl1;
            this.lc_serverList.TabIndex = 12;
            // 
            // bs_ServerList
            // 
            this.bs_ServerList.DataSource = typeof(Msp.Models.Models.App.ApplicationServerDTO);
            // 
            // lc_Company
            // 
            this.lc_Company.Location = new System.Drawing.Point(103, 197);
            this.lc_Company.Name = "lc_Company";
            this.lc_Company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_Company.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "İşyeri Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "İşyeri Adı")});
            this.lc_Company.Properties.DataSource = this.bs_company;
            this.lc_Company.Properties.DisplayMember = "CompanyName";
            this.lc_Company.Properties.NullText = "";
            this.lc_Company.Properties.ValueMember = "CompanyCode";
            this.lc_Company.Size = new System.Drawing.Size(190, 20);
            this.lc_Company.StyleController = this.layoutControl1;
            this.lc_Company.TabIndex = 10;
            // 
            // bs_company
            // 
            this.bs_company.DataSource = typeof(Msp.Models.Models.CompanyDTO);
            // 
            // txt_userCode
            // 
            this.txt_userCode.EditValue = "myEmail@mail.com";
            this.txt_userCode.Location = new System.Drawing.Point(103, 149);
            this.txt_userCode.Name = "txt_userCode";
            this.txt_userCode.Size = new System.Drawing.Size(190, 20);
            this.txt_userCode.StyleController = this.layoutControl1;
            this.txt_userCode.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.EditValue = "";
            this.txt_Password.Location = new System.Drawing.Point(103, 173);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(190, 20);
            this.txt_Password.StyleController = this.layoutControl1;
            this.txt_Password.TabIndex = 5;
            // 
            // chk_BeniHatirla
            // 
            this.chk_BeniHatirla.Location = new System.Drawing.Point(12, 221);
            this.chk_BeniHatirla.Name = "chk_BeniHatirla";
            this.chk_BeniHatirla.Properties.Caption = "Beni Hatırla";
            this.chk_BeniHatirla.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chk_BeniHatirla.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chk_BeniHatirla.Properties.ValueChecked = 1;
            this.chk_BeniHatirla.Properties.ValueGrayed = 0;
            this.chk_BeniHatirla.Properties.ValueUnchecked = 0;
            this.chk_BeniHatirla.Size = new System.Drawing.Size(281, 20);
            this.chk_BeniHatirla.StyleController = this.layoutControl1;
            this.chk_BeniHatirla.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.ImageOptions.ImageIndex = 0;
            this.btn_login.ImageOptions.ImageList = this.img_sic;
            this.btn_login.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btn_login.Location = new System.Drawing.Point(101, 420);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(189, 49);
            this.btn_login.StyleController = this.layoutControl1;
            this.btn_login.TabIndex = 7;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // img_sic
            // 
            this.img_sic.Add("checkbox", "image://svgimages/content/checkbox.svg");
            this.img_sic.Add("cancel", "image://svgimages/outlook inspired/cancel.svg");
            this.img_sic.Add("closeheaderandfooter", "image://svgimages/richedit/closeheaderandfooter.svg");
            this.img_sic.Add("bo_employee", "image://svgimages/business objects/bo_employee.svg");
            this.img_sic.Add("encrypt", "image://svgimages/spreadsheet/encrypt.svg");
            this.img_sic.Add("bo_category", "image://svgimages/business objects/bo_category.svg");
            this.img_sic.Add("bo_organization", "image://svgimages/business objects/bo_organization.svg");
            this.img_sic.Add("replace", "image://svgimages/richedit/replace.svg");
            this.img_sic.Add("private", "image://svgimages/scheduling/private.svg");
            this.img_sic.Add("timezones", "image://svgimages/scheduling/timezones.svg");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ImageOptions.ImageIndex = 2;
            this.btn_Cancel.ImageOptions.ImageList = this.img_sic;
            this.btn_Cancel.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btn_Cancel.Location = new System.Drawing.Point(12, 420);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 49);
            this.btn_Cancel.StyleController = this.layoutControl1;
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(281, 133);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 9;
            // 
            // _ResetPassword
            // 
            this._ResetPassword.Location = new System.Drawing.Point(12, 245);
            this._ResetPassword.Name = "_ResetPassword";
            this._ResetPassword.Properties.Caption = "Şifre Değiştir";
            this._ResetPassword.Size = new System.Drawing.Size(281, 20);
            this._ResetPassword.StyleController = this.layoutControl1;
            this._ResetPassword.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.emptySpaceItem2,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(305, 481);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_userCode;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.ImageOptions.ImageIndex = 3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 137);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem1.Text = "Kullanıcı Adı";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txt_Password;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.ImageOptions.ImageIndex = 4;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 161);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem2.Text = "Şifre";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chk_BeniHatirla;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 209);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_Cancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(89, 53);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(89, 53);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(89, 53);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_login;
            this.layoutControlItem4.Location = new System.Drawing.Point(89, 408);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(193, 53);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(193, 53);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(196, 53);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.lc_Company;
            this.layoutControlItem7.ImageOptions.ImageIndex = 6;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem7.Text = "İşyeri";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.pictureEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(285, 137);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 257);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(282, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(282, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ResetPassword;
            this.layoutControlItem8.ImageOptions.ImageIndex = 7;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 233);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 336);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(285, 72);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 267);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(285, 69);
            this.layoutControlGroup2.Text = "Connection";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.lc_serverList;
            this.layoutControlItem9.ImageOptions.ImageIndex = 5;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem9.Text = "Server : ";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(88, 16);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(305, 481);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Login.IconOptions.SvgImage")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lc_serverList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ServerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_BeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ResetPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txt_userCode;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.CheckEdit chk_BeniHatirla;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraEditors.LookUpEdit lc_Company;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit _ResetPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.LookUpEdit lc_serverList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource bs_ServerList;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.BindingSource bs_company;
    }
}