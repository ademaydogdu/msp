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
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;
using msp.App;
using Msp.Service.Service.Depot;

namespace Msp.App.Depo_Stok
{
    public partial class frmDepo : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmDepo()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<DepotDTO> _depotList = new List<DepotDTO>();
        MspTool mspTool = new MspTool();
        //deneme
        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

  


        public void do_refresh()
        {

            _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_Depot.DataSource = _depotList;
        }

        #region Edit
        public void do_Edit()
        {
            DepotDTO Orow = (DepotDTO)gcv_Depot.GetFocusedRow();
            if (Orow != null)
            {
                frmDepoEdit frm = new frmDepoEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.DID);
            }
        }

        #endregion

        #region Add
        private void btnAddNewDepot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepoEdit frm = new frmDepoEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }


        #endregion

        #region Delete
        private void btnRemoveDepot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            DepotDTO oRow = (DepotDTO)gcv_Depot.GetFocusedRow();

            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DepotService, ActionResponse<DepotDTO>>(x => x.DeleteDepot(oRow.DID));
                    do_refresh();
                }
            }

        }





        #endregion

        private void btnRefreshDepot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnEditDepot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }

        private void frmDepo_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_GridControl(this.Name, gridControl1);
        }

        private void frmDepo_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gridControl1);
        }
    }
}