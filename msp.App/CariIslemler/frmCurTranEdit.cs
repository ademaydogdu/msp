using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Msp.App.Tanimlar;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.CurrentTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Msp.App.CariIslemler.frmCurTranEdit.CurOnCreditList;
using static Msp.App.CariIslemler.frmCurTranEdit.CurSolePropList;
using static Msp.App.CariIslemler.frmCurTranEdit.CurTypeList;

namespace Msp.App.CariIslemler
{
    public partial class frmCurTranEdit : XtraForm
    {

        Repository _repository;
        public frmCurTranEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public FormOpenType _FormOpenType;

        private CTransactionsDTO __CTransaction = new CTransactionsDTO();


        // List<CTransactionsDTO> __CTransactionList = new List<CTransactionsDTO>();


        //public List<CTransactionsDTO> AccountType = new List<CTransactionsDTO>
        //{
        //    new CTransactionsDTO("Alıcı"),
        //    new CTransactionsDTO("Satıcı"),
        //    new CTransactionsDTO("Alıcı & Satıcı"),
        //    new CTransactionsDTO("Proje"),
        //    new CTransactionsDTO("Personel"),
        //};


        public void Show(int id)
        {


            if (_FormOpenType == FormOpenType.New)
            {
                __CTransaction = new CTransactionsDTO();

            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __CTransaction = _repository.Run<CurrentTransactionsService, CTransactionsDTO>(x => x.GetCurrentTransaction(id));
            }


            bs_CurTransactionSource.DataSource = __CTransaction;
            this.ShowDialog();
        }

        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(CurTransEditAccNameTE.EditValue) == "")
            {
                XtraMessageBox.Show("Hesap Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditAccAuthTE.EditValue) == "")
            {
                XtraMessageBox.Show("Yetkili Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditAdressTE.EditValue) == "")
            {
                XtraMessageBox.Show("Adres Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditDistrictTE.EditValue) == "")
            {
                XtraMessageBox.Show("İlçe Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditCityTE.EditValue) == "")
            {
                XtraMessageBox.Show("İl Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditPhoneTE.EditValue) == "")
            {
                XtraMessageBox.Show("Telefon Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            return _return;
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

        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<CurrentTransactionsService, ActionResponse<CTransactionsDTO>>(x => x.SaveCurrrentCustomer(__CTransaction));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCurTranEditSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void btnCurTranEditClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmCurTranEdit_Load(object sender, EventArgs e)
        {
            CurTypeList cList = new CurTypeList();
            cList.Add(new CurType(0, "Alıcı"));
            cList.Add(new CurType(1, "Satıcı"));
            cList.Add(new CurType(2, "Alıcı + Satıcı"));
            cList.Add(new CurType(3, "Proje"));
            cList.Add(new CurType(4, "Personel"));

            //bind the lookup editor to the list
            CurTransEditAccTypeLE.Properties.DataSource = cList;
            CurTransEditAccTypeLE.Properties.DisplayMember = "Name";
            CurTransEditAccTypeLE.Properties.ValueMember = "Id";
            // Add columns.
            // The ID column is populated 
            // via the GetNotInListValue event (not listed in the example).
            CurTransEditAccTypeLE.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
            CurTransEditAccTypeLE.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));
            //enable text editing
            CurTransEditAccTypeLE.Properties.TextEditStyle = TextEditStyles.Standard;

            ///////////////////////////////////////////////////////

            CurOnCreditList curOList = new CurOnCreditList();
            curOList.Add(new CurOnCredit(0, "Evet"));
            curOList.Add(new CurOnCredit(1, "Hayır"));


            //bind the lookup editor to the list
            lookUpEdit3.Properties.DataSource = curOList;
            lookUpEdit3.Properties.DisplayMember = "Name";
            lookUpEdit3.Properties.ValueMember = "Id";
            // Add columns.
            // The ID column is populated 
            // via the GetNotInListValue event (not listed in the example).
            lookUpEdit3.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
            lookUpEdit3.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));
            //enable text editing
            lookUpEdit3.Properties.TextEditStyle = TextEditStyles.Standard;

            /////////////////////////////////////////////////////////

            CurSolePropList cSList = new CurSolePropList();
            cSList.Add(new CurSoleProp(0, "Evet"));
            cSList.Add(new CurSoleProp(1, "Hayır"));


            //bind the lookup editor to the list
            CurTransEditCompanyTypeLE.Properties.DataSource = cSList;
            CurTransEditCompanyTypeLE.Properties.DisplayMember = "Name";
            CurTransEditCompanyTypeLE.Properties.ValueMember = "Id";
            // Add columns.
            // The ID column is populated 
            // via the GetNotInListValue event (not listed in the example).
            CurTransEditCompanyTypeLE.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
            CurTransEditCompanyTypeLE.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));
            //enable text editing
            CurTransEditCompanyTypeLE.Properties.TextEditStyle = TextEditStyles.Standard;

        }
        public class CurTypeList : System.Collections.CollectionBase
        {
            public CurType this[int index]
            {
                get { return (CurType)(List[index]); }
                set { List[index] = value; }
            }

            public int Add(CurType value)
            {
                return List.Add(value);
            }



            public class CurType
            {
                private string name;
                private int id;

                public CurType(int _id, string _name)
                {
                    id = _id;
                    name = _name;
                }

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Id
                {
                    get { return id; }
                    set { id = value; }
                }
            }
        }

        public class CurOnCreditList : System.Collections.CollectionBase
        {
            public CurOnCredit this[int index]
            {
                get { return (CurOnCredit)(List[index]); }
                set { List[index] = value; }
            }

            public int Add(CurOnCredit value)
            {
                return List.Add(value);
            }



            public class CurOnCredit
            {
                private string name;
                private int id;

                public CurOnCredit(int _id, string _name)
                {
                    id = _id;
                    name = _name;
                }

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Id
                {
                    get { return id; }
                    set { id = value; }
                }
            }
        }

        ///////////////////
        ///
        public class CurSolePropList : System.Collections.CollectionBase
        {
            public CurSoleProp this[int index]
            {
                get { return (CurSoleProp)(List[index]); }
                set { List[index] = value; }
            }

            public int Add(CurSoleProp value)
            {
                return List.Add(value);
            }



            public class CurSoleProp
            {
                private string name;
                private int id;

                public CurSoleProp(int _id, string _name)
                {
                    id = _id;
                    name = _name;
                }

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Id
                {
                    get { return id; }
                    set { id = value; }
                }
            }
        }

    }
}
