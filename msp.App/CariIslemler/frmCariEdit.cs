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

namespace Msp.App.CariIslemler
{
    public partial class frmCariEdit : DevExpress.XtraEditors.XtraForm
    {
        public frmCariEdit()
        {
            InitializeComponent();
        }
        public FormOpenType _FormOpenType;


        public void Show(int RecId)
        {


            this.ShowDialog();
        }




        private void frmCariEdit_Load(object sender, EventArgs e)
        {

        }

        private void frmCariEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}