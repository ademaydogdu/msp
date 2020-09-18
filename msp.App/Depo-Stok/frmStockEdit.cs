using DevExpress.XtraEditors;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.DepotStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Depo_Stok
{
    public partial class frmStockEdit : XtraForm
    {
        Repository _repository = new Repository();

        public frmStockEdit()
        {
            InitializeComponent();
        }

        public FormOpenType _FormOpenType;

        private ProductDTO __product = new ProductDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();

        public void Show(int id)
        {
            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;

            if (_FormOpenType == FormOpenType.New)
            {
                __product = new ProductDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
            }

            bs_StockEdit.DataSource = __product;
            this.ShowDialog();
        }

        #region Record
        private void do_save()

        {
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.SaveProduct(__product));
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
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }







        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }



        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        #endregion


        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

    }
}
