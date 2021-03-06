﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace Msp.App.Satis
{
    public partial class frmChangeMoney : DevExpress.XtraEditors.XtraForm
    {
        public frmChangeMoney()
        {
            InitializeComponent();
        }

        decimal TotalTutar = 0;
        decimal AlinanPara = 0;

        public void Show(decimal _totalTutar, decimal _paraAlinan)
        {
            TotalTutar = _totalTutar;
            AlinanPara = _paraAlinan;
            this.ShowDialog();
        }

        private void frmChangeMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmChangeMoney_Load(object sender, EventArgs e)
        {
            if (TotalTutar > 0 && AlinanPara > 0)
            {
                decimal paraustu = 0;
                paraustu = Convert.ToDecimal(AlinanPara - TotalTutar);
                lblParaUstu.Text = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", paraustu);
            }
        }
    }
}