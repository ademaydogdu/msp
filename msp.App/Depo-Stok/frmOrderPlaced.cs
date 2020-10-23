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
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Entity.Entities;

namespace Msp.App.Depo_Stok
{
    public partial class frmOrderPlaced : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository = new Repository();
        public frmOrderPlaced()
        {
            InitializeComponent();

        }
        public FormOpenType _FormOpenType;

        private OrderManagementDTO __orders = new OrderManagementDTO();
        List<OrderManagementDTO> units = new List<OrderManagementDTO>();

        //public void Show(int id)
        //{

        //    if (_FormOpenType == FormOpenType.New)
        //    {
        //        __orders = new OrderManagementDTO();

        //        if (_FormOpenType == FormOpenType.Edit)
        //        {
        //            __orders = _repository.Run<OrderManagement, OrderManagementDTO>(x => x.(id));
        //        }

        //    }

        //}

    }
}