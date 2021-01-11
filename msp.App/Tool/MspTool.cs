using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Msp.App.Waiting;
using Msp.Infrastructure;
using Msp.Infrastructure.DbConectionModel;
using Msp.Infrastructure.Extensions;
using Msp.Models.Models;
using Msp.Models.Models.App;
using Msp.Models.Models.SecRights;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Tool
{
    public class MspTool
    {
        public static TreeView ActiveView = new TreeView();
        private static ListView lstUsers = new ListView();

        private static Dictionary<SecRightType, string> permissionField;
        private static Dictionary<SecRightType, string> permissionFieldDesc;

        public static bool sqlKontrol(string server, string database, string username, string password)
        {
            bool donus = true;
            string connectionString = "initial catalog=" + database
                + ";data source=" + server
                + ";user id=" + username
                + ";password=" + password
                + ";Packet Size=8000";

            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sConn;
            try
            {
                cmd.Connection.Open();
            }
            catch
            {
                donus = false;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return donus;
        }
        public static bool sqlKontrol(string connectionString)
        {
            bool donus = true;
            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sConn;
            try
            {
                cmd.Connection.Open();
            }
            catch
            {
                donus = false;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return donus;
        }
        public static Form get_OpenForm(string _FormName)
        {
            Form _FormHave = null;
            foreach (Form _Form in Application.OpenForms)
            {
                if (_Form.Name == _FormName)
                {
                    _FormHave = _Form;
                }
            }

            return _FormHave;

        }
        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        #region Regedit
        public static string CreateNewRegistry()
        {
            string message = "";
            try
            {
                //RegistryKey OldKey = Registry.CurrentUser.OpenSubKey(@"Software\SednaHotel\", true);
                RegistryKey NewKey = Registry.CurrentUser.OpenSubKey(@"Software\MSP\", true);

                if (NewKey == null)
                {
                    ActiveView = new TreeView();
                    getUsers();
                    foreach (ListViewItem item in lstUsers.Items)
                    {
                        string filename = "";
                        if (item.ImageIndex != 4) continue;
                        string tag = item.Tag + @"\\Software\MSP\";

                        ReadRegistry(tag);

                        foreach (TreeNode node in ActiveView.Nodes)
                        {

                            if (node.FullPath.Contains(':') == false)
                            {
                                string lcFName = @DateTime.Now.Month.ToString().PadLeft(2, '0')
                                       + DateTime.Now.Day.ToString().PadLeft(2, '0')
                                      + DateTime.Now.Year.ToString()
                                       + DateTime.Now.Hour.ToString().PadLeft(2, '0')
                                       + DateTime.Now.Minute.ToString().PadLeft(2, '0')
                                       + DateTime.Now.Second.ToString().PadLeft(2, '0');
                                string LcDir = System.IO.Path.GetTempPath();
                                filename = LcDir + lcFName + ".srg";



                                if (string.IsNullOrEmpty(filename) == false)
                                {
                                    string path = node.FullPath;
                                    ModRegistry.RegistryHelper.ExportKey(path, filename);
                                }
                            }
                            try
                            {
                                StreamReader oReader = new StreamReader(filename);
                                StringBuilder strBuilder = new StringBuilder();
                                string line;
                                string karsiUserInfo = "";
                                string userInfo = item.Tag.ToString().Trim();
                                while ((line = oReader.ReadLine()) != null)
                                {
                                    if (!string.IsNullOrEmpty(line))
                                    {
                                        line
                                            = line.Replace("hotel", "MSP");
                                    }
                                    if (line.Contains("HKEY_USERS") && karsiUserInfo == "")
                                    {
                                        int birinciSlash = line.IndexOf(@"\") + 1;
                                        int ikinciSlash = line.IndexOf(@"\", birinciSlash);
                                        karsiUserInfo = line.Substring(birinciSlash, ikinciSlash - birinciSlash);
                                    }
                                    if (line.Contains("HKEY_USERS") && karsiUserInfo != "")
                                    {
                                        int birinciSlash = line.IndexOf(@"\") + 1;
                                        int ikinciSlash = line.IndexOf(@"\", birinciSlash);
                                        line = line.Substring(0, birinciSlash)
                                            + userInfo
                                            + line.Substring(ikinciSlash, line.Length - ikinciSlash);
                                    }
                                    strBuilder.Append(line + "\r\n");
                                }
                                oReader.Close();


                                StreamWriter oStream = new StreamWriter(filename);
                                oStream.Write(strBuilder);
                                oStream.Flush();
                                oStream.Close();

                                ModRegistry.RegistryHelper.ImportKey(filename);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Dosya " + item.Text + " Kullanıcısına Import edilemedi.Sebebi:\r\n" + ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
        private static void getUsers()
        {

            System.Management.SelectQuery query = new System.Management.SelectQuery("Win32_UserAccount");
            System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query);

            List<string> userlist = new List<string>();

            foreach (System.Management.ManagementObject envVar in searcher.Get())
            {
                userlist.Add(envVar["Name"].ToString().Trim());
                if (lstUsers.Items.ContainsKey(envVar["Name"].ToString().Trim()) == false)
                {
                    System.Security.Principal.NTAccount f = new System.Security.Principal.NTAccount(envVar["Name"].ToString().Trim());
                    System.Security.Principal.SecurityIdentifier s = (System.Security.Principal.SecurityIdentifier)f.Translate(typeof(System.Security.Principal.SecurityIdentifier));
                    string sid = s.ToString();

                    string registryKey = sid + @"\\";

                    ListViewItem oItem = new ListViewItem();
                    RegistryKey rk = Registry.Users;
                    if (rk.GetSubKeyNames().Contains(sid))
                    { oItem.ImageIndex = 4; }
                    else
                    {
                        oItem.ImageIndex = 3;
                        oItem.ToolTipText = "Oturum Açmamış Kullanıcı";
                    }
                    rk.Flush();
                    rk.Close();
                    oItem.Name = envVar["Name"].ToString().Trim();
                    oItem.Text = envVar["Name"].ToString().Trim();
                    oItem.Tag = sid;
                    lstUsers.Items.Add(oItem);


                }
            }


            Registry.Users.Flush();
            Registry.Users.Close();

        }
        private static void ReadRegistry(string registryKey)
        {
            try
            {
                ActiveView.Nodes.Clear();

                //HKEY_CURRENT_USER  
                RegistryKey rk = Registry.Users.OpenSubKey(registryKey);

                //TreeNode currentUserNode = new TreeNode(Registry.Users.OpenSubKey(registryKey).Name, 0, 1);
                TreeNode currentUserNode = new TreeNode(rk.Name, 0, 1);
                currentUserNode.Tag = true;
                //string[] currentUserSubKeys = Registry.Users.OpenSubKey(registryKey).GetSubKeyNames();
                string[] currentUserSubKeys = rk.GetSubKeyNames();

                foreach (string key in currentUserSubKeys)
                {
                    TreeNode node = new TreeNode(key, 0, 1);
                    node.Tag = false;
                    currentUserNode.Nodes.Add(node);
                    //altlarioku(key, registryKey, node, key, true);
                    altlarioku(registryKey + @"\\" + key, node);
                }
                ActiveView.Nodes.Add(currentUserNode);
                rk.Flush();
                rk.Close();


            }
            catch
            {

            }
            Registry.Users.Flush();
            Registry.Users.Close();
        }
        private static void altlarioku(string registryKey, TreeNode currentUserNode)
        {
            try
            {
                RegistryKey rk = Registry.Users.OpenSubKey(registryKey);
                //string[] subKeys = Registry.Users.OpenSubKey(registryKey).GetSubKeyNames();
                string[] subKeys = rk.GetSubKeyNames();

                if (subKeys.Length > 0)
                {


                    foreach (string subKeysKey in subKeys)
                    {
                        TreeNode subKeyNode = new TreeNode(subKeysKey, 0, 1);
                        try
                        {
                            //GetValuesAndData(Registry.Users.OpenSubKey(registryKey).OpenSubKey(subKeysKey),
                            //    subKeyNode);
                            GetValuesAndData(rk.OpenSubKey(subKeysKey),
                                subKeyNode);

                        }
                        catch { }

                        currentUserNode.Nodes.Add(subKeyNode);

                        //altlarioku(registryKey + @"\\" + subKeysKey, subKeyNode);
                    }

                }
                rk.Flush();
                rk.Close();
            }
            catch
            {
            }
            Registry.Users.Flush();

            Registry.Users.Close();
        }
        private static void GetValuesAndData(RegistryKey registryKey, TreeNode node)
        {
            string[] values = registryKey.GetValueNames();
            foreach (string value in values)
            {
                object data = registryKey.GetValue(value);

                if (data != null)
                {
                    string stringData = data.ToString();

                    //if the data is too long, display the begining only  
                    if (stringData.Length > 50)
                        stringData = stringData.Substring(0, 46) + " ...";

                    //Display the data of the value. The conditional operatore is  
                    //needed because the default value has no name  
                    node.Nodes.Add(value, (value == "" ? "Default" : value) +
                        ": " + stringData, 2, 2);
                }
                else
                {
                    //Display <empty> if the value is empty  
                    node.Nodes.Add(value, (value == "" ? "Default" : value) +
                        ": <empty>", 2, 2);
                }
            }
            registryKey.Flush();
            registryKey.Close();
        }
        #endregion

        #region GridControlDesigner

        public void do_Save_Layout(Form _Form)
        {
            foreach (Control oControl in _Form.Controls)
            {
                do_Save_Layout_Control(_Form.Name, oControl);
            }
        }
        public void do_Save_Layout_Control(string _FormName, Control _Control)
        {
            if (_Control.GetType().Name == "GridControl")
            {
                Save_GridControl(_FormName, (DevExpress.XtraGrid.GridControl)_Control);
            }
            if (_Control.GetType().Name == "SearchLookUpEdit")
            {
                //do_Save_Layout(_FormName, (GridView)(((DevExpress.XtraEditors.SearchLookUpEdit)_Control).Properties.View));
            }
            if (_Control.GetType().Name == "LayoutControl")
            {
                Save_Layout(_FormName, (DevExpress.XtraLayout.LayoutControl)_Control);
            }
            if (_Control.GetType().Name == "DataLayoutControl")
            {
                do_Save_Layout(_FormName, (DevExpress.XtraDataLayout.DataLayoutControl)_Control);
            }
            if (_Control.HasChildren == true)
            {
                foreach (Control __Control in _Control.Controls)
                {
                    do_Save_Layout_Control(_FormName, __Control);
                }
            }
        }

        public void Save_GridControl(string _FormName, GridControl _GridControl)
        {
            try
            {
                if (_GridControl.MainView != null)
                {
                    System.IO.MemoryStream _MemoryStream = new System.IO.MemoryStream();
                    _GridControl.MainView.SaveLayoutToStream(_MemoryStream);
                    _MemoryStream.Seek(0, System.IO.SeekOrigin.Begin);

                    FormLayoutsDTO gridSettings = new FormLayoutsDTO();
                    gridSettings.FormName = _FormName;
                    gridSettings.ControlName = _GridControl.Name;
                    gridSettings.UserCode = AppMain.User.username;
                    gridSettings.XmlData = Compress(_MemoryStream.ToArray());
                    Service.Repository.Repository _repository = new Service.Repository.Repository();
                    ActionResponse<FormLayoutsDTO> result = _repository.Run<Service.Service.App.StartUp, ActionResponse<FormLayoutsDTO>>(x => x.Save_FormLayout(gridSettings));
                    if (result.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Grid Ayarları Kayıt Edilemedi");
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        public void Save_Layout(string _FormName, DevExpress.XtraLayout.LayoutControl _LayoutControl)
        {
            try
            {

                System.IO.MemoryStream _MemoryStream = new System.IO.MemoryStream();
                _LayoutControl.SaveLayoutToStream(_MemoryStream);
                _MemoryStream.Seek(0, System.IO.SeekOrigin.Begin);


                FormLayoutsDTO gridSettings = new FormLayoutsDTO();
                gridSettings.FormName = _FormName;
                gridSettings.ControlName = _LayoutControl.Name;
                gridSettings.UserCode = AppMain.User.username;
                gridSettings.XmlData = Compress(_MemoryStream.ToArray());
                Service.Repository.Repository _repository = new Service.Repository.Repository();
                ActionResponse<FormLayoutsDTO> result = _repository.Run<Service.Service.App.StartUp, ActionResponse<FormLayoutsDTO>>(x => x.Save_FormLayout(gridSettings));
                if (result.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Grid Ayarları Kayıt Edilemedi");
                }

            }
            catch (Exception)
            {
            }

        }

        public void Get_GridControl(string _FormName, GridControl _GridControl)
        {
            try
            {
                FormLayoutsDTO gridSettings = new FormLayoutsDTO();
                gridSettings.FormName = _FormName;
                gridSettings.ControlName = _GridControl.Name;
                gridSettings.UserCode = AppMain.User.username;
                Service.Repository.Repository _repository = new Service.Repository.Repository();
                FormLayoutsDTO _grid = _repository.Run<Service.Service.App.StartUp, FormLayoutsDTO>(x => x.Get_FormLayout(gridSettings));
                if (_grid != null)
                {
                    MemoryStream _MemoryStream = Decompress(_grid.XmlData.ToArray());
                    _MemoryStream.Position = 0;
                    _GridControl.MainView.RestoreLayoutFromStream(_MemoryStream);
                    _MemoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (Exception ex)
            {

            }

        }

        public void Get_Layout(Form _Form)
        {
            foreach (Control oControl in _Form.Controls)
            {
                get_Layout_Control(_Form.Name, oControl);
            }
        }
        private void get_Layout_Control(string _FormName, Control _Control)
        {
            if (_Control.GetType().Name == "GridControl")
            {
                Get_GridControl(_FormName, (DevExpress.XtraGrid.GridControl)_Control);
            }
            if (_Control.GetType().Name == "SearchLookUpEdit")
            {
                // get_Layout(_FormName, (GridView)(((DevExpress.XtraEditors.SearchLookUpEdit)_Control).Properties.View));
            }
            if (_Control.GetType().Name == "ControlContainer")
            {
            }
            if (_Control.GetType().Name == "LayoutControl")
            {
                get_Layout(_FormName, (DevExpress.XtraLayout.LayoutControl)_Control);
            }
            if (_Control.GetType().Name == "DataLayoutControl")
            {
                get_Layout(_FormName, (DevExpress.XtraDataLayout.DataLayoutControl)_Control);
            }
            if (_Control.HasChildren == true)
            {
                foreach (Control __Control in _Control.Controls)
                {
                    get_Layout_Control(_FormName, __Control);
                }
            }
        }
        public void get_Layout(string _FormName, DevExpress.XtraLayout.LayoutControl _LayoutControl)
        {
            FormLayoutsDTO form = new FormLayoutsDTO();
            form.FormName = _FormName;
            form.ControlName = _LayoutControl.Name;
            form.UserCode = AppMain.User.username;
            Service.Repository.Repository _repository = new Service.Repository.Repository();
            FormLayoutsDTO _FormLayouts = _repository.Run<Service.Service.App.StartUp, FormLayoutsDTO>(x => x.Get_FormLayout(form));
            if (_FormLayouts != null)
            {
                MemoryStream _MemoryStream = Decompress(_FormLayouts.XmlData.ToArray());
                _MemoryStream.Position = 0;
                _LayoutControl.RestoreLayoutFromStream(_MemoryStream);

            }
        }


        public void do_Save_Layout(string _FormName, DevExpress.XtraDataLayout.DataLayoutControl _DataLayoutControl)
        {
            System.IO.MemoryStream _MemoryStream = new System.IO.MemoryStream();
            _DataLayoutControl.SaveLayoutToStream(_MemoryStream);
            _MemoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            FormLayoutsDTO gridSettings = new FormLayoutsDTO();
            gridSettings.FormName = _FormName;
            gridSettings.ControlName = _DataLayoutControl.Name;
            gridSettings.UserCode = AppMain.User.username;
            gridSettings.XmlData = Compress(_MemoryStream.ToArray());
            Service.Repository.Repository _repository = new Service.Repository.Repository();
            ActionResponse<FormLayoutsDTO> result = _repository.Run<Service.Service.App.StartUp, ActionResponse<FormLayoutsDTO>>(x => x.Save_FormLayout(gridSettings));
            if (result.ResponseType != ResponseType.Ok)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Grid Ayarları Kayıt Edilemedi");
            }

        }

        public void get_Layout(string _FormName, DevExpress.XtraDataLayout.DataLayoutControl _DataLayoutControl)
        {
            _DataLayoutControl.ForceInitialize();
            try
            {
                FormLayoutsDTO form = new FormLayoutsDTO();
                form.FormName = _FormName;
                form.ControlName = _DataLayoutControl.Name;
                form.UserCode = AppMain.User.username;
                Service.Repository.Repository _repository = new Service.Repository.Repository();
                FormLayoutsDTO _FormLayouts = _repository.Run<Service.Service.App.StartUp, FormLayoutsDTO>(x => x.Get_FormLayout(form));
                if (_FormLayouts != null)
                {
                    MemoryStream _MemoryStream = Decompress(_FormLayouts.XmlData.ToArray());
                    _MemoryStream.Position = 0;
                    _DataLayoutControl.RestoreLayoutFromStream(_MemoryStream);
                }
            }
            catch
            {
            }
        }

        private byte[] Compress(byte[] raw)
        {
            using (var memory = new MemoryStream())
            {
                using (var gzip = new System.IO.Compression.GZipStream(memory, System.IO.Compression.CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }
        private static MemoryStream Decompress(byte[] gzip)
        {

            using (var stream = new System.IO.Compression.GZipStream(new MemoryStream(gzip), System.IO.Compression.CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                MemoryStream memory = new MemoryStream();
                int count = 0;
                do
                {
                    count = stream.Read(buffer, 0, size);
                    if (count > 0)
                    {
                        memory.Write(buffer, 0, count);
                    }
                }
                while (count > 0);
                return memory;
            }

        }
        #endregion

        #region SaveSkin

        public void do_save_User_Skin(string _UserCode, string _SkinGallery, string _SkinPalette, string _FormName)
        {
            Service.Repository.Repository _repository = new Service.Repository.Repository();
            UsersDTO _user = _repository.Run<Service.Service.App.StartUp, UsersDTO>(r => r.GetUser(_UserCode));
            if (_user != null)
            {
                _user.DefaultTheme = _SkinGallery;
                _user.DefaultTheme2 = _SkinPalette;
                var _ReturnProcess = _repository.Run<Service.Service.Settings.SettingsService, ActionResponse<UsersDTO>>(r => r.Save_Users(_user));
                if (_ReturnProcess.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(_ReturnProcess.Message);
                }
            }

        }

        #endregion

        #region Export
        public void Export2AnyDocument(string Docum, GridControl gridControl1)
        {
            string lcFName = @DateTime.Now.Month.ToString().PadLeft(2, '0')
           + DateTime.Now.Day.ToString().PadLeft(2, '0')
          + DateTime.Now.Year.ToString()
           + DateTime.Now.Hour.ToString().PadLeft(2, '0')
           + DateTime.Now.Minute.ToString().PadLeft(2, '0')
           + DateTime.Now.Second.ToString().PadLeft(2, '0')
           + "." + Docum;
            string LcDir = System.IO.Path.GetTempPath();
            string LcFileName = LcDir + lcFName;
            string lcDocName = "";
            try
            {
                if (Docum == "xls")
                {

                    gridControl1.ExportToXls(LcFileName);
                    lcDocName = "Excel Dosyası";
                }
                if (Docum == "xlsx")
                {
                    gridControl1.ExportToXlsx(LcFileName);
                    lcDocName = "Excel Dosyası";
                }
                if (Docum == "pdf")
                {
                    gridControl1.ExportToPdf(LcFileName);
                    lcDocName = "Pdf Dosyası";
                }
                if (Docum == "doc")
                {
                    gridControl1.ExportToHtml(LcFileName);
                    lcDocName = "Word Dosyası";
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LcFileName;
                process.StartInfo.Verb = "Open";
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                process.Start();
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(lcDocName + " Açılamadı.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Yetki

        public static bool PermissionControl(string UserCode, SecRightType secRightType, int documentType, int company = 0)
        {
            //return true;
            bool x = string.Equals(AppMain.User.username, "Admin", StringComparison.CurrentCultureIgnoreCase);
            if (x)
            {
                return x;
            }

            Service.Repository.Repository _repository = new Service.Repository.Repository();
            var __SecRight = _repository.Run<Service.Service.Settings.SettingsService, List<SecRightsDTO>>(r => r.GetList_SecRight());
            //var rightQuery = blvalue.SecRightsAccounting.Where(r => r.Code == code
            //                                                  && r.AppType == (int)apptype
            //                                                  && r.DocumentType == documentType);
            var rightQuery = __SecRight.Where(y => y.UserCode == UserCode && y.DocumentType == documentType);
            if (company != 0)
            {
                rightQuery = rightQuery.Where(r => r.CompanyRecId == company);
            }
            var right = rightQuery.FirstOrDefault();
            x = (right != null && (int)right.GetValue(PermissinField[secRightType]) == 1);
            if (!x)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"{UserCode} İçin {PermissinFieldDesc[secRightType]} Yetkiniz Yok...");
            }
            return x;

        }



        private static Dictionary<SecRightType, string> PermissinField
        {
            get
            {
                if (permissionField == null)
                {
                    permissionField = new Dictionary<SecRightType, string>();
                    permissionField.Add(SecRightType.Update, "SecUpdate");
                    permissionField.Add(SecRightType.Insert, "SecInsert");
                    permissionField.Add(SecRightType.Delete, "SecDelete");
                    permissionField.Add(SecRightType.Preview, "SecPreview");
                }
                return permissionField;
            }
        }

        private static Dictionary<SecRightType, string> PermissinFieldDesc
        {
            get
            {
                if (permissionFieldDesc == null)
                {
                    permissionFieldDesc = new Dictionary<SecRightType, string>();
                    permissionFieldDesc.Add(SecRightType.Update, "Düzenleme");
                    permissionFieldDesc.Add(SecRightType.Insert, "Yeni Kayıt");
                    permissionFieldDesc.Add(SecRightType.Delete, "Silme");
                    permissionFieldDesc.Add(SecRightType.Preview, "İzleme");
                }
                return permissionFieldDesc;
            }
        }


        #endregion

        public static void wclose()
        {
            if (SplashScreenManager.Default != null)
            {

                SplashScreenManager.CloseForm(false);
            }
        }
        public static void wshow()
        {
            if (SplashScreenManager.Default == null)
            {
                SplashScreenManager.ShowForm(typeof(Wait));
            }
        }


    }

    #region ModRegistry
    class ModRegistry
    {
        //   [StandardModule]

        public sealed class RegistryHelper
        {
            //    'Just a wee bit of API to fill the gaps not covered by .NET's registry access 
            //    'Used to determine a value's type and read/write strings of the type REG_EXPAND_SZ 
            [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int RegCloseKey(int hKey);

            [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int RegCreateKey(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, ref int phkResult);

            [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int RegOpenKey(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, ref int phkResult);

            [DllImport("advapi32.dll", EntryPoint = "RegQueryValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int RegQueryValueEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData, ref int lpcbData);

            [DllImport("advapi32.dll", EntryPoint = "RegSetValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern int RegSetValueEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int Reserved, int dwType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData, int cbData);

            // Methods
            public static bool CreateKey(RegistryKey hKey, string strPath, string NewKeyName)
            {
                bool flag1 = false;
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    key1.CreateSubKey(NewKeyName);
                    key1.Close();
                    flag1 = true;
                }
                return flag1;
            }

            public static bool DeleteKey(RegistryKey hKey, string strPath)
            {
                bool flag1 = false;
                int num1 = 0;
                int num2 = 0;
                try
                {
                    ProjectData.ClearProjectError();
                    num2 = 1;
                    hKey.DeleteSubKeyTree(strPath);
                    flag1 = true;
                }
                catch (Exception obj1) //when (?)
                {
                    Exception exception2 = (Exception)obj1;
                    ProjectData.SetProjectError(exception2);
                    Exception exception1 = exception2;
                    if (num1 == 0)
                    {
                        num1 = -1;
                        switch (num2)
                        {
                            case 1:
                                {
                                    goto Label_0058;
                                }
                        }
                        throw;
                    }
                }
            Label_0058:
                if (num1 != 0)
                {
                    ProjectData.ClearProjectError();
                }
                return flag1;
            }
            public static bool DeleteValue(RegistryKey hKey, string strPath, string strValue)
            {
                bool flag1 = false;
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    key1.DeleteValue(strValue);
                    key1.Close();
                    flag1 = true;
                }
                return flag1;
            }
            public static void ExportKey(RegistryKey rKey, string sfile)
            {
                RegistryHelper.ExportKey(rKey.Name, sfile);
            }
            public static void ExportKey(string sRegKeyPath, string sfile)
            {
                string text1 = "\"" + sRegKeyPath + "\"";
                RegistryHelper.FileAppend(sfile, "");
                RegistryHelper.ShellFile("regedit.exe", "/E " + RegistryHelper.GetDosPath(sfile) + " " + text1, ProcessWindowStyle.Normal);
            }
            public static void ExportKey(RegistryKey hKey, string strPath, string sfile)
            {
                string text1 = "";
                if (hKey == Registry.ClassesRoot)
                {
                    text1 = @"HKEY_CLASSES_ROOT\";
                }
                else if (hKey == Registry.CurrentUser)
                {
                    text1 = @"HKEY_CURRENT_USER\";
                }
                else if (hKey == Registry.LocalMachine)
                {
                    text1 = @"HKEY_LOCAL_MACHINE\";
                }
                else if (hKey == Registry.Users)
                {
                    text1 = @"HKEY_USERS\";
                }
                else if (hKey == Registry.CurrentConfig)
                {
                    text1 = @"HKEY_CURRENT_CONFIG\";
                }
                //else if (hKey == Registry.DynData)
                //{
                //    text1 = @"HKEY_DYN_DATA\";
                //}
                else if (hKey == Registry.PerformanceData)
                {
                    text1 = @"HKEY_PERFORMANCE_DATA\";
                }
                RegistryHelper.ExportKey(text1, sfile);
                //        '        FileAppend(sfile, "")
                //        'mPath = Microsoft.VisualBasic.ControlChars.Quote & mPath & strPath & Microsoft.VisualBasic.ControlChars.Quote
                //        'ShellFile("regedit.exe", "/E " & GetDosPath(sfile) & " " & mPath, 0)

            }
            public static string[] GetAllKeys(RegistryKey hKey, string strPath)
            {
                string[] textArray1 = null;
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    textArray1 = key1.GetSubKeyNames();
                    key1.Close();
                }
                return textArray1;
            }
            public static bool GetAllValues(RegistryKey hKey, string strPath, ref string[] mNames)
            {
                bool flag1 = false;
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    mNames = key1.GetValueNames();
                    flag1 = true;
                    key1.Close();
                }
                return flag1;
            }
            public static string GetDosPath(string path)
            {
                return RegistryHelper.GetShortFileName(path);
            }
            public static void GetRootKeyAndPath(string FullPath, ref RegistryKey Rootkey, ref string strPath)
            {
                if ((FullPath.Length != 0) && (FullPath.IndexOf(@"\") != -1))
                {
                    string[] textArray1 = Strings.Split(FullPath, @"\", -1, CompareMethod.Binary);
                    string text1 = RegistryHelper.AddBackslash(FullPath, @"\");
                    //        'tmp(0) is "My Computer" 
                    //        'tmp(1) is the "Root" key - eg. "HKEY_CLASSES_ROOT" 
                    strPath = text1.Replace(textArray1[0] + @"\" + textArray1[1] + @"\", "");
                    //        'strPath is the path of the subkey 
                    string text2 = textArray1[1];//Determine the "Root" key 
                    if (StringType.StrCmp(text2, "HKEY_CLASSES_ROOT", false) == 0)
                    {
                        Rootkey = Registry.ClassesRoot;
                    }
                    else if (StringType.StrCmp(text2, "HKEY_CURRENT_USER", false) == 0)
                    {
                        Rootkey = Registry.CurrentUser;
                    }
                    else if (StringType.StrCmp(text2, "HKEY_LOCAL_MACHINE", false) == 0)
                    {
                        Rootkey = Registry.LocalMachine;
                    }
                    else if (StringType.StrCmp(text2, "HKEY_USERS", false) == 0)
                    {
                        Rootkey = Registry.Users;
                    }
                    else if (StringType.StrCmp(text2, "HKEY_CURRENT_CONFIG", false) == 0)
                    {
                        Rootkey = Registry.CurrentConfig;
                    }
                    //else if (StringType.StrCmp(text2, "HKEY_DYNDATA", false) == 0)
                    //{
                    //    Rootkey = Registry.DynData;
                    //}
                    else if (StringType.StrCmp(text2, "HKEY_PERFORMANCE_DATA", false) == 0)
                    {
                        Rootkey = Registry.PerformanceData;
                    }
                    strPath = RegistryHelper.RemoveBackslash(strPath);
                }
            }
            public static string GetRootKeyString(string FullPath)
            {
                string[] textArray1 = Strings.Split(FullPath, @"\", -1, CompareMethod.Binary);
                return textArray1[1];
            }
            public static string GetSafeKeyName(RegistryKey hKey, string strPath, string NewName, [Optional] bool AsNew /* = false */)
            {
                string text1 = "";
                int num1 = 1;
                string text2 = NewName;
                if (AsNew)
                {
                    text2 = "New Key";
                    NewName = "New Key #1";
                }
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 == null)
                {
                    return text1;
                }
                if (key1.SubKeyCount > 0)
                {
                    string[] textArray1 = key1.GetSubKeyNames();
                    while (true)
                    {
                        bool flag1 = false;
                        int num3 = key1.SubKeyCount - 1;
                        for (int num2 = 0; num2 <= num3; num2++)
                        {
                            if (StringType.StrCmp(textArray1[num2], NewName, false) == 0)
                            {
                                flag1 = true;
                                break;
                            }
                        }
                        if (!flag1)
                        {
                            text1 = NewName;
                            goto Label_0096;
                        }
                        num1++;
                        flag1 = false;
                        NewName = text2 + " #" + StringType.FromInteger(num1);
                    }
                }
                text1 = NewName;
            Label_0096:
                key1.Close();
                return text1;
            }
            public static string GetSafeValueName(RegistryKey hKey, string strPath, string NewName, [Optional] bool AsNew /* = false */)
            {
                string text1 = "";
                int num1 = 1;
                string text2 = NewName;
                if (AsNew)
                {
                    text2 = "New Value";
                    NewName = "New Value #1";
                }
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 == null)
                {
                    return text1;
                }
                if (key1.ValueCount > 0)
                {
                    string[] textArray1 = key1.GetValueNames();
                    while (true)
                    {
                        bool flag1 = false;
                        int num3 = key1.ValueCount - 1;
                        for (int num2 = 0; num2 <= num3; num2++)
                        {
                            if (StringType.StrCmp(textArray1[num2], NewName, false) == 0)
                            {
                                flag1 = true;
                                break;
                            }
                        }
                        if (!flag1)
                        {
                            text1 = NewName;
                            goto Label_0096;
                        }
                        num1++;
                        flag1 = false;
                        NewName = text2 + " #" + StringType.FromInteger(num1);
                    }
                }
                text1 = NewName;
            Label_0096:
                key1.Close();
                return text1;
            }
            public static byte[] GetSettingByte(ref RegistryKey hKey, ref string strPath, ref string strValue)
            {
                byte[] buffer1 = null;
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    byte[] buffer2 = (byte[])key1.GetValue(strValue, "");
                    key1.Close();
                    return buffer2;
                }
                return buffer1;
            }
            public static int GetSettingInteger(ref RegistryKey hKey, ref string strPath, ref string strValue)
            {
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    int num1 = IntegerType.FromObject(key1.GetValue(strValue, 0));
                    key1.Close();
                    return num1;
                }
                return -1;
            }
            public static string GetSettingString(RegistryKey hKey, string strPath, string strValue, [Optional] bool DontExpand /* = false */)
            {
                string text1 = "";
                int num6 = RegistryHelper.GetValueType(hKey, strPath, strValue);
                if (DontExpand | (num6 > 2))
                {
                    //            '.NET will automatically expand string values of the type REG_EXPAND_SZ 
                    //            'It always likes to do the work for you ! Trouble is we want to see 
                    //            'the data in it's raw form !!! 
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num5 = 0;
                    string text2 = "";
                    if (hKey == Registry.ClassesRoot)
                    {
                        num2 = -2147483648;
                    }
                    else if (hKey == Registry.CurrentUser)
                    {
                        num2 = -2147483647;
                    }
                    else if (hKey == Registry.LocalMachine)
                    {
                        num2 = -2147483646;
                    }
                    else if (hKey == Registry.Users)
                    {
                        num2 = -2147483645;
                    }
                    else if (hKey == Registry.CurrentConfig)
                    {
                        num2 = -2147483643;
                    }
                    //else if (hKey == Registry.DynData)
                    //{
                    //    num2 = -2147483642;
                    //}
                    else if (hKey == Registry.PerformanceData)
                    {
                        num2 = -2147483644;
                    }
                    int num4 = RegistryHelper.RegOpenKey(num2, ref strPath, ref num1);
                    num4 = RegistryHelper.RegQueryValueEx(num1, ref strValue, 0, ref num5, ref text2, ref num3);
                    if (num4 == 0)
                    {
                        text2 = new string(' ', num3);
                        int num7 = 0;
                        num4 = RegistryHelper.RegQueryValueEx(num1, ref strValue, 0, ref num7, ref text2, ref num3);
                        text1 = text2;
                    }
                    num4 = RegistryHelper.RegCloseKey(num1);
                    return text1;
                }
                RegistryKey key1 = hKey.OpenSubKey(strPath, true);
                if (key1 != null)
                {
                    //            'If you don't need to see the REG_EXPAND_SZ in it's raw form 
                    //            'then the above code is unneccessary thus the optional DontExpand 
                    text1 = StringType.FromObject(key1.GetValue(strValue, ""));
                    if ((text1.Length == 0) & (strValue.Length == 0))
                    {
                        //                'If it's the Default value and the result is "" then fill it in with "(value not set)" 
                        text1 = "(value not set)";
                    }
                    key1.Close();
                }
                return text1;
            }
            public static int GetValueType(RegistryKey hKey, string strPath, string strValueName)
            {

                //       'Appears to be a limitation in .NET Registry access - no method to determine value type 

                //        'I couldn't find any anyway. 

                //        'We have to resort to the API to provide us with the value type 



                int num2 = 0;

                int num3 = 0;

                int num5 = 0;

                int num7 = 0;

                if (hKey == Registry.ClassesRoot)
                {

                    num3 = -2147483648;

                }

                else if (hKey == Registry.CurrentUser)
                {

                    num3 = -2147483647;

                }

                else if (hKey == Registry.LocalMachine)
                {

                    num3 = -2147483646;

                }

                else if (hKey == Registry.Users)
                {

                    num3 = -2147483645;

                }

                else if (hKey == Registry.CurrentConfig)
                {

                    num3 = -2147483643;

                }

                //else if (hKey == Registry.DynData)
                //{

                //    num3 = -2147483642;

                //}

                else if (hKey == Registry.PerformanceData)
                {

                    num3 = -2147483644;

                }

                strPath = RegistryHelper.RemoveBackslash(strPath);

                int num6 = RegistryHelper.RegOpenKey(num3, ref strPath, ref num2);

                string text2 = StringType.FromLong(0);

                num6 = RegistryHelper.RegQueryValueEx(num2, ref strValueName, 0, ref num7, ref text2, ref num5);

                num6 = RegistryHelper.RegCloseKey(num2);

                return num7;

            }
            public static bool HasSubKeys(RegistryKey hKey, string strPath)
            {
                bool flag1 = false;

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 != null)
                {

                    flag1 = key1.SubKeyCount > 0;

                    key1.Close();

                }

                return flag1;

            }
            public static void ImportKey(string sInFile)
            {

                RegistryHelper.ShellFile("regedit.exe", "/I /S " + RegistryHelper.GetDosPath(sInFile), ProcessWindowStyle.Normal);

            }
            public static bool IsKey(RegistryKey hKey, string strPath)
            {

                bool flag1 = false;

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 != null)
                {

                    flag1 = true;

                    key1.Close();

                }

                return flag1;

            }
            private static void RecurseAllSubKeyValues(RegistryKey hKey, string strPath, ref string[] ValuesColl)
            {

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 != null)
                {

                    int num1;

                    string[] textArray1;

                    int num4;

                    int num3 = key1.ValueCount;

                    int num2 = key1.SubKeyCount;

                    if (num3 > 0)
                    {

                        textArray1 = key1.GetValueNames();

                        num1 = ValuesColl.GetUpperBound(0);

                        ValuesColl = (string[])Utils.CopyArray((Array)ValuesColl, new string[(num1 + num3) + 1]);

                        int num6 = num3 - 1;

                        for (num4 = 0; num4 <= num6; num4++)
                        {

                            ValuesColl[num1] = strPath + @"\" + textArray1[num4];

                            num1++;

                        }

                    }

                    else
                    {

                        num1 = ValuesColl.GetUpperBound(0);

                        ValuesColl = (string[])Utils.CopyArray((Array)ValuesColl, new string[(num1 + 1) + 1]);

                        ValuesColl[num1] = strPath + @"\";

                    }

                    if (num2 > 0)
                    {

                        textArray1 = key1.GetSubKeyNames();

                        int num5 = num3 - 1;

                        for (num4 = 0; num4 <= num5; num4++)
                        {

                            RegistryHelper.RecurseAllSubKeyValues(hKey, strPath + @"\" + textArray1[num4], ref ValuesColl);

                        }

                    }

                    key1.Close();

                }

            }
            public static bool RenameKey(RegistryKey hKey, string strPath, string NewKeyName)
            {

                bool flag1 = false;

                string[] textArray1 = null;

                string text4 = RegistryHelper.PathOnly(strPath);

                string text2 = RegistryHelper.FileOnly(strPath);

                string text1 = text4 + @"\" + NewKeyName;

                RegistryHelper.CreateKey(hKey, text4, NewKeyName);

                RegistryHelper.RecurseAllSubKeyValues(hKey, strPath, ref textArray1);

                if (textArray1.Length > 0)
                {

                    int num5 = textArray1.GetUpperBound(0) - 1;

                    for (int num3 = 0; num3 <= num5; num3++)
                    {

                        string text7;

                        string text6 = RegistryHelper.FileOnly(textArray1[num3]);

                        string text5 = RegistryHelper.PathOnly(textArray1[num3]);

                        string text3 = text5.Replace(strPath, text1);

                        int num2 = RegistryHelper.GetValueType(hKey, text5, text6);

                        if (StringType.StrCmp(text6, "", false) == 0)
                        {

                            num2 = 1;

                        }

                        switch (num2)
                        {

                            case 1:
                                {

                                    text7 = RegistryHelper.GetSettingString(hKey, text5, text6, false);

                                    RegistryHelper.SaveSettingString(hKey, text3, text6, text7, SaveStringType.REG_SZ);

                                    goto Label_014D;

                                }

                            case 2:
                                {

                                    text7 = RegistryHelper.GetSettingString(hKey, text5, text6, false);

                                    RegistryHelper.SaveSettingString(hKey, text3, text6, text7, SaveStringType.REG_EXPAND_SZ);

                                    goto Label_014D;

                                }

                            case 3:
                                {

                                    byte[] buffer1 = RegistryHelper.GetSettingByte(ref hKey, ref text5, ref text6);

                                    RegistryHelper.SaveSettingByte(hKey, text3, text6, buffer1, false);

                                    goto Label_014D;

                                }

                            case 4:
                                {

                                    int num1 = RegistryHelper.GetSettingInteger(ref hKey, ref text5, ref text6);

                                    RegistryHelper.SaveSettingInteger(hKey, text3, text6, num1);

                                    goto Label_014D;

                                }

                            case 5:

                            case 6:
                                {

                                    goto Label_014D;

                                }

                            case 7:
                                {

                                    break;

                                }

                            default:
                                {

                                    goto Label_014D;

                                }

                        }

                        text7 = RegistryHelper.GetSettingString(hKey, text5, text6, false);

                        RegistryHelper.SaveSettingString(hKey, text3, text6, text7, SaveStringType.REG_MULTI_SZ);

                    Label_014D:;

                    }

                }

                RegistryHelper.DeleteKey(hKey, strPath);

                return flag1;

            }
            public static bool RenameValue(RegistryKey hKey, string strPath, string strValue, string NewValueName)
            {

                bool flag1 = false;

                string text1 = "";

                switch (RegistryHelper.GetValueType(hKey, strPath, strValue))
                {

                    case 1:
                        {

                            text1 = RegistryHelper.GetSettingString(hKey, strPath, strValue, false);

                            RegistryHelper.SaveSettingString(hKey, strPath, NewValueName, text1, SaveStringType.REG_SZ);

                            break;

                        }

                    case 2:
                        {

                            text1 = RegistryHelper.GetSettingString(hKey, strPath, strValue, false);

                            RegistryHelper.SaveSettingString(hKey, strPath, NewValueName, text1, SaveStringType.REG_EXPAND_SZ);

                            break;

                        }

                    case 3:
                        {

                            byte[] buffer1 = RegistryHelper.GetSettingByte(ref hKey, ref strPath, ref strValue);

                            RegistryHelper.SaveSettingByte(hKey, strPath, NewValueName, buffer1, false);

                            break;

                        }

                    case 4:
                        {

                            int num1 = RegistryHelper.GetSettingInteger(ref hKey, ref strPath, ref strValue);

                            RegistryHelper.SaveSettingInteger(hKey, strPath, NewValueName, num1);

                            break;

                        }

                    case 7:
                        {

                            text1 = RegistryHelper.GetSettingString(hKey, strPath, strValue, false);

                            RegistryHelper.SaveSettingString(hKey, strPath, NewValueName, text1, SaveStringType.REG_MULTI_SZ);

                            break;

                        }

                }

                RegistryHelper.DeleteValue(hKey, strPath, strValue);
                return flag1;
            }
            public static bool SaveSettingByte(RegistryKey hKey, string strPath, string strValue, byte[] byteData, [Optional] bool SetEmpty /* = false */)
            {

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 == null)
                {

                    bool flag1 = false;

                    return flag1;

                }

                if (SetEmpty)
                {

                    key1.SetValue(strValue, 0);

                }

                else
                {

                    key1.SetValue(strValue, byteData);

                }

                key1.Flush();

                key1.Close();

                return true;

            }
            public static void SaveSettingEmptyByte(RegistryKey hKey, string strPath, string strValueName)
            {

                int num1 = 0;

                int num2 = 0;

                if (hKey == Registry.ClassesRoot)
                {

                    num2 = -2147483648;

                }

                else if (hKey == Registry.CurrentUser)
                {

                    num2 = -2147483647;

                }

                else if (hKey == Registry.LocalMachine)
                {

                    num2 = -2147483646;

                }

                else if (hKey == Registry.Users)
                {

                    num2 = -2147483645;

                }

                else if (hKey == Registry.CurrentConfig)
                {

                    num2 = -2147483643;

                }

                //else if (hKey == Registry.DynData)
                //{

                //    num2 = -2147483642;

                //}

                else if (hKey == Registry.PerformanceData)
                {

                    num2 = -2147483644;

                }

                int num3 = RegistryHelper.RegCreateKey(num2, ref strPath, ref num1);

                string text1 = StringType.FromLong(0);

                num3 = RegistryHelper.RegSetValueEx(num1, ref strValueName, 0, 3, ref text1, 0);

                num3 = RegistryHelper.RegCloseKey(num1);

            }
            public static bool SaveSettingInteger(RegistryKey hKey, string strPath, string strValue, int intData)
            {

                bool flag1 = false;

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 != null)
                {

                    key1.SetValue(strValue, intData);

                    key1.Flush();

                    key1.Close();

                    flag1 = true;

                }

                return flag1;

            }
            public static bool SaveSettingString(RegistryKey hKey, string strPath, string strValue, string strData, SaveStringType sType)
            {

                bool flag1 = false;

                if (!RegistryHelper.IsKey(hKey, strPath))
                {

                    RegistryHelper.CreateKey(hKey, RegistryHelper.PathOnly(strPath), RegistryHelper.FileOnly(strPath));

                }

                //        'If it's the Default value and strData is "" then fill it in with "(value not set)" 

                if ((strValue.Length == 0) & (strData.Length == 0))
                {

                    strData = "(value not set)";

                }

                if (sType != SaveStringType.REG_SZ)
                {

                    int num1 = 0;

                    int num2 = 0;

                    if (hKey == Registry.ClassesRoot)
                    {

                        num1 = -2147483648;

                    }

                    else if (hKey == Registry.CurrentUser)
                    {

                        num1 = -2147483647;

                    }

                    else if (hKey == Registry.LocalMachine)
                    {

                        num1 = -2147483646;

                    }

                    else if (hKey == Registry.Users)
                    {

                        num1 = -2147483645;

                    }

                    else if (hKey == Registry.CurrentConfig)
                    {

                        num1 = -2147483643;

                    }

                    //else if (hKey == Registry.DynData)
                    //{

                    //    num1 = -2147483642;

                    //}

                    else if (hKey == Registry.PerformanceData)
                    {

                        num1 = -2147483644;

                    }

                    int num3 = RegistryHelper.RegCreateKey(num1, ref strPath, ref num2);

                    num3 = RegistryHelper.RegSetValueEx(num2, ref strValue, 0, (int)sType, ref strData, strData.Length);

                    num3 = RegistryHelper.RegCloseKey(num2);

                    return flag1;

                }

                RegistryKey key1 = hKey.OpenSubKey(strPath, true);

                if (key1 != null)
                {

                    key1.SetValue(strValue, strData);

                    key1.Flush();

                    key1.Close();

                    flag1 = true;

                }

                return flag1;

            }
            public static string ShellFile(string path, string arguments, ProcessWindowStyle style)
            {

                string text1 = "";

                Process process1 = new Process();

                try
                {

                    process1.StartInfo.FileName = path;

                    process1.StartInfo.UseShellExecute = false;

                    process1 = Process.Start(path, arguments);

                    process1.WaitForExit();

                }

                finally
                {

                    process1.Dispose();

                }

                return text1;

            }
            public enum SaveStringType
            {

                // Fields

                REG_EXPAND_SZ = 2,

                REG_MULTI_SZ = 7,

                REG_SZ = 1

            }

            #region  "Helper methods"



            //          ' Append a backslash (or any character) at the end of a path

            //          ' if it isn't there already

            //          'http://66.102.7.104/search?q=cache:jfWf2rcyyTgJ:www.devx.com/vb2themax/Tip/18940+AddBackSlash&hl=en

            public static string AddBackslash(string Path, [Optional] string ch /* = @"\" */)
            {

                if (StringType.StrCmp(Strings.Right(Path, 1), ch, false) != 0)
                {

                    return (Path + ch);

                }

                return Path;

            }

            //          'http://66.102.7.104/search?q=cache:m8ISK7XP3OoJ:vbboshi.diy.myrice.com/preblem/41-60/pr59.htm+RemoveBackSlash&hl=en

            //          'aLSO http://relib.com/forums/thread847374.aspx

            public static string RemoveBackslash(string s)
            {

                string text1 = "";

                int num1 = Strings.Len(s);

                if (num1 != 0)
                {

                    if (StringType.StrCmp(Strings.Right(s, 1), @"\", false) == 0)
                    {

                        text1 = Strings.Left(s, num1 - 1);

                        goto Label_003A;

                    }

                    return s;

                }

                text1 = "";

            Label_003A:

                return text1;

            }

            //          'http://vb2themax.com/ShowContent.aspx?ID=40fcf8bb-79a0-49e0-b930-422211907215 

            //          ' this code assumes the following Imports statement

            //          '     Imports System.Text

            public static string GetShortFileName(string path)
            {

                StringBuilder builder1 = new StringBuilder(0x400);

                int num1 = RegistryHelper.GetShortPathName(ref path, builder1, builder1.Capacity);

                return builder1.ToString(0, num1);

            }



            [DllImport("kernel32", EntryPoint = "GetShortPathNameA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

            private static extern int GetShortPathName([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszLongPath, StringBuilder lpszShortPath, int cchBuffer);





            public static void FileAppend(string path, string text)
            {

                //object obj1;

                StreamWriter writer1 = File.AppendText(path);

                writer1.Write(text);

                writer1.Close();

                //return obj1;

            }



            //          'http://translate.google.com/translate?hl=en&sl=de&u=http://www.internet-magazin.de/praxis/cm/page/page.php%3Ftable%3Dpg%26id%3D1690&prev=/search%3Fq%3DPathOnly%2BFileOnly%26start%3D10%26hl%3Den%26lr%3D%26sa%3DN

            public static string FileOnly(string P)
            {

                int num1 = Strings.InStrRev(StringType.FromInteger(0), P, IntegerType.FromString(""), CompareMethod.Binary);

                P = Strings.Mid(P, num1 + 1);

                return P;

            }

            public static object PathComplete(string P)
            {

                if (StringType.StrCmp(Strings.Right(P, 1), "", false) == 0)
                {

                    P = P + "";

                }

                return P;

            }



            //'Also you extract the complete path from a listing structure, by using the InstrRev function. Only, separated in contrast to tap before, the file name. In connection with the procedure shown at the beginning completely PathComplete manufacture you so complete path names.

            public static string PathOnly(string P)
            {

                int num1 = Strings.InStrRev(StringType.FromInteger(0), P, IntegerType.FromString(""), CompareMethod.Binary);

                if (num1 == 0)
                {

                    num1 = 1;

                }

                P = Strings.Left(P, num1 - 1);

                if (Strings.Len(P) == 2)
                {

                    P = StringType.FromObject(RegistryHelper.PathComplete(P));

                }

                return P;

            }

            #endregion  //"Helper methods"

        }




    }

    #endregion

}
