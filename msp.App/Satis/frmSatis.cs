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
using DevExpress.XtraLayout;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.Settings;
using Msp.App.Depo_Stok;

namespace msp.App
{
    public partial class frmSatis : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public frmSatis()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        #region Descriptons
        int RecId;
        #endregion

        #region Record

        public void Insert_Product(int ProductId)
        {


        }


        #endregion

        #region FORM

        public void Show(int _recId)
        {
            RecId = _recId;
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            if (_parameters != null)
            {
                if (_parameters.NumaratorShow == true) lyt_NumaratorControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; else lyt_NumaratorControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }






            this.Show();
        }


        private void frmSatis_Load(object sender, EventArgs e)
        {
            btn_N0.AutoWidthInLayoutControl = true;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            frm.ShowDialog();
        }


        #endregion

    }
}