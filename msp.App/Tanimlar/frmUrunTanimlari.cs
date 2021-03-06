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
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.App.Tool;
using Msp.Service.Service.Tanimlar;
using Msp.Models.Models.Utilities;

namespace Msp.App.Tanimlar
{
    public partial class frmUrunTanimlari : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmUrunTanimlari()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<ProductMarkDTO> productMarks = new List<ProductMarkDTO>();
        MspTool MspTool = new MspTool();


        #region Record

        public void do_refresh()
        {
            productMarks = _repository.Run<DefinitionsService, List<ProductMarkDTO>>(x => x.Get_List_ProductMark());
            bs_ProductMarks.DataSource = productMarks;
        }

        public void do_Save()
        {
            try
            {
                foreach (var item in productMarks)
                {
                    if (productMarks.Where(x => x.Mark == item.Mark).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DefinitionsService, ActionResponse<List<ProductMarkDTO>>>(x => x.SaveProductMark(productMarks));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }


        #endregion

        private void frmUrunTanimlari_Load(object sender, EventArgs e)
        {
            do_refresh();
            MspTool.Get_Layout(this);
        }

        private void frmUrunTanimlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductMarkDTO oRow = (ProductMarkDTO)gcv_ProductMarks.GetFocusedRow();
            if (oRow != null)
            {
                if (MspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    if (oRow.RecId != 0)
                    {
                        var result = _repository.Run<DefinitionsService, ActionResponse<ProductMarkDTO>>(x => x.DeleteProductMark(oRow.RecId));
                        do_refresh();
                    }
                    else
                    {
                       productMarks.Remove(oRow);
                        gc_ProductMarks.RefreshDataSource();
                    }


                }
            }
        }
    }
}