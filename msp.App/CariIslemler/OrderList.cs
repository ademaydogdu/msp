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
using Msp.App.Tool;

namespace Msp.App.CariIslemler
{
    public partial class OrderList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public OrderList()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        MspTool MspTool = new MspTool();

        #region Record

        public void do_refresh()
        {

        }


        #endregion

        #region Form
        private void OrderList_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);
        }

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void OrderList_KeyDown(object sender, KeyEventArgs e)
        {

        } 
        #endregion
    }
}