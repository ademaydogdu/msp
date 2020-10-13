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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Repository;

namespace Msp.App.Depo_Stok
{
    public partial class frmExpDateProducts : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmExpDateProducts()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<ProductDTO>__listExpDateProducts = new List<ProductDTO>();

        private void do_refresh() 
        {
            __listExpDateProducts = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListExpDateProducts());
            bs_ExpDateProd.DataSource = __listExpDateProducts;
        }

        private void ExpDateProducts_Load(object sender, EventArgs e)
        {
            do_refresh();
        }



        private void btnExpDateRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}