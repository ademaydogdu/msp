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
using Msp.Infrastructure;
using Msp.App.Tool;
using Msp.Service.Repository;
using Msp.Models.Models;

namespace Msp.App.CariIslemler
{
    public partial class InvoiceEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public InvoiceEdit()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        public InvoiceType invoice;
        MspTool MspTool = new MspTool();

        #region Form

        private void InvoiceEdit_Load(object sender, EventArgs e)
        {
            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Alım Faturası";
                    break;
                default:
                    break;
            }
            MspTool.Get_Layout(this);

        }

        private void InvoiceEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InvoiceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        } 
        #endregion
    }
}