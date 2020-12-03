using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.Tanimlar;
using Msp.App.Tool;
using Msp.Models.Models.Utilities;

namespace Msp.App.Tanimlar
{
    public partial class CurrencyTypeList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        List<CurrencyTypeDTO> __List_CurrencyType;
        public CurrencyTypeList()
        {
            InitializeComponent();
            _repository = new Repository();
            __List_CurrencyType = new List<CurrencyTypeDTO>();
        }

        MspTool MspTool = new MspTool();


        #region Record
        public void do_refresh()
        {
            __List_CurrencyType = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyList.DataSource = __List_CurrencyType;
        } 
        public void do_Save()
        {
            try
            {
                foreach (var item in __List_CurrencyType)
                {
                    if (__List_CurrencyType.Where(x => x.CurrencyCode == item.CurrencyCode).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DefinitionsService, ActionResponse<List<CurrencyTypeDTO>>>(x => x.SaveCurrencyType(__List_CurrencyType));
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
            }
        }
        #endregion

        private void CurrencyTypeList_Load(object sender, EventArgs e)
        {
            do_refresh();
            MspTool.Get_Layout(this);
        }

        private void CurrencyTypeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);

        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrencyTypeDTO oRow = (CurrencyTypeDTO)gcv_DovizCinsi.GetFocusedRow();
            if (oRow != null)
            {
                if (MspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    if (oRow.RecId != 0)
                    {
                        var result = _repository.Run<DefinitionsService, ActionResponse<CurrencyTypeDTO>>(x => x.DeleteCurrencyType(oRow.RecId));
                        do_refresh();
                    }
                    else
                    {
                        __List_CurrencyType.Remove(oRow);
                        gc_DovizCinsi.RefreshDataSource();
                    }

             
                }
            }
        }
    }
}