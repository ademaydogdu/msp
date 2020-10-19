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
using Msp.Models.Models;
using Msp.Service.Repository;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Operations;

namespace Msp.App.Tanimlar
{
    public partial class frmBirimTanim : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmBirimTanim()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<UnitsDTO> __dl_List_Units = new List<UnitsDTO>();

        private UnitsDTO _units = new UnitsDTO();



        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void do_refresh()
        {
            __dl_List_Units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_UnitType.DataSource = __dl_List_Units;
        }

        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(unitNameTE.EditValue) == "")
            {
                XtraMessageBox.Show("Birim Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
        }




        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<DepotStockService, ActionResponse<UnitsDTO>>(x => x.SaveUnit(_units));
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


                //    if (get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
                //    {
                //        gcv_UnitType.CloseEditor();
                //        try
                //        {
                //            foreach (var item in __dl_List_Units)
                //            {
                //                if (__dl_List_Units.Where(x => x.UName == item.UName).Count() > 1)
                //                {
                //                    XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                //                    return;
                //                }
                //            }
                //            var response = _repository.Run<DepotStockService, ActionResponse<List<UnitsDTO>>>(x => x.SaveUnit(__dl_List_Units));
                //            if (response.ResponseType != ResponseType.Ok)
                //            {
                //                DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //            }
                //            else
                //            {
                //                this.Close();
                //            }
                //        }
                //        catch (Exception)
                //        {
                //        } 
                //    }
            }

        private void frmBirimTanim_Load(object sender, EventArgs e)
        {
            do_refresh();
            unitNameTE.Text = Convert.ToString(gcv_UnitType.FocusedRowHandle);
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


        private void btnUnitTypeAdd_Click(object sender, EventArgs e)
        {

           

            //if (get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
            //{
            //    //gcv_UnitType.CloseEditor();
            //    try
            //    {
            //        foreach (var item in __dl_List_Units)
            //        {
            //            if (__dl_List_Units.Where(x => x.UName == item.UName).Count() > 1)
            //            {
            //                XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
            //                return;
            //            }
            //        }
            //        var response = _repository.Run<DepotStockService, ActionResponse<List<UnitsDTO>>>(x => x.SaveUnit(__dl_List_Units));
            //        if (response.ResponseType != ResponseType.Ok)
            //        {
            //            DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //else
            //{
            //    this.Close();
            //}
            //}
            //catch (Exception)
            //{
            //}

            //}
            //repositoryItemLookUpEdit1.DataSource = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            //repositoryItemLookUpEdit1.ValueMember = "UID";
            //repositoryItemLookUpEdit1.DisplayMember = "UName";

            //  var response = _repository.Run<DepotStockService, ActionResponse<UnitsDTO>>(x => x.SaveUnit(_units));

            do_refresh();

            
        }

        private void btnUnitDefAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            unitNameTE.EditValue = "";
        }

        private void btnUnitDefRem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitsDTO oRow = (UnitsDTO)gcv_UnitType.GetFocusedRow();
            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DepotStockService, ActionResponse<UnitsDTO>>(x => x.DeleteUnit(oRow.UID));
                    do_refresh();
                }
            }
        }
    }

}
    
