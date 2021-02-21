using DevExpress.XtraEditors;
using Msp.SimleCurrent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.SimleCurrent.Screen
{
    public partial class InvoiceList : DevExpress.XtraEditors.XtraForm
    {
        public InvoiceList()
        {
            InitializeComponent();
        }
        public InvoiceType invoice;

        private void InvoiceList_Load(object sender, EventArgs e)
        {

            switch (invoice)
            {
                case InvoiceType.AlisFaturasi:
                    this.Text = "Alım Faturası";
                    break;
                case InvoiceType.SatisFaturasi:
                    this.Text = "Satış Faturası";
                    break;
                default:
                    break;
            }




        }
    }
}