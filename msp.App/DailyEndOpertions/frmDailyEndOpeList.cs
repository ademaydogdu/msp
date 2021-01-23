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
using Msp.Models.Models.Daily;
using Msp.Service.Service.Daily;
using Msp.App.Tool;
using Msp.Models.Models.Utilities;
using Msp.App.Report;

namespace Msp.App.DailyEndOpertions
{
    public partial class frmDailyEndOpeList : DevExpress.XtraEditors.XtraForm
    {

        Repository _repository;
        public frmDailyEndOpeList()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        List<DailyOwnerDTO> _dailyOwner = new List<DailyOwnerDTO>();
        MspTool mspTool = new MspTool();

        private void do_refresh()
        {
            _dailyOwner = _repository.Run<DailyService, List<DailyOwnerDTO>>(x => x.Get_List_DailyOwner());
            bs_DailyOwner.DataSource = _dailyOwner;
        }

        private void do_report()
        {
            DailyOwnerDTO oRow = (DailyOwnerDTO)gcv_DailyOwner.GetFocusedRow();
            if (oRow != null)
            {
                frmPrint frm = new frmPrint();
                frm.PrintGunSonu(oRow);
                frm.ShowDialog(); 
            }
        }


        private void frmDailyEndOpeList_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_Layout(this);
        }

        private void frmDailyEndOpeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmDailyEndOpeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Deleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DailyOwnerDTO oRow = (DailyOwnerDTO)gcv_DailyOwner.GetFocusedRow();
            if (oRow != null)
            {
                if (mspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DailyService, ActionResponse<DailyOwnerDTO>>(x => x.Delete_Daily(oRow));
                    if (result.ResponseType != ResponseType.Ok)
                    {
                        XtraMessageBox.Show(result.Message);
                    }
                    else
                    {
                        do_refresh();
                    }
                }
            }
        }

        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_report();
        }
    }
}