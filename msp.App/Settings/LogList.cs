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
using Msp.App.Tool;

namespace Msp.App.Settings
{
    public partial class LogList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;

        public LogList()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool MspTool = new MspTool();

        #region Record

        public void do_refresh()
        {

        }

        #endregion


        private void LogList_Load(object sender, EventArgs e)
        {
            do_refresh();
            MspTool.Get_Layout(this);

        }

        private void LogList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);

        }

        private void LogList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}