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
using Msp.App.Tool;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Case;
using Msp.Models.Models.Daily;
using Msp.Service.Service.Sale;
using Msp.Service.Service.Case;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Daily;

namespace Msp.App.DailyEndOpertions
{
    public partial class frmDailyStart : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmDailyStart()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool mspTool = new MspTool();

        List<SaleOwnerDTO> _saleOwner = new List<SaleOwnerDTO>();
        List<SaleTransDTO> _saleTrans = new List<SaleTransDTO>();
        List<CaseMovementDTO> _caseMovements = new List<CaseMovementDTO>();


        List<DailyTransDTO> _dailyTrans = new List<DailyTransDTO>();

        private void frmDailyStart_Load(object sender, EventArgs e)
        {


        }

        #region Record


        private void do_Save()
        {
            try
            {

                var control = _repository.Run<DailyService, List<DailyOwnerDTO>>(x => x.Get_List_DailyOwner_Control());
                if (control.Count > 0)
                {
                    XtraMessageBox.Show("Bugün için oluşturulan Gün Sonu işlemleri Vardır. Lütfen Siliniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //1-Gelir/2-Gider/Expense - Gider//Revune - Gelir
                _saleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_Date(DateTime.Today));
                var caseMovements = _repository.Run<CaseService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement_Date(AppMain.CompanyRecId));
                _caseMovements = caseMovements.Where(x => x.SaleOwnerId == null || x.SaleOwnerId == 0).ToList();
                decimal _saleAmount = _saleOwner.Sum(x => x.TotalPrice.GetValueOrDefault());
                decimal __Amount = _saleOwner.Sum(x => x.TotalPrice.GetValueOrDefault()) + _caseMovements.Where(x => x.IslemTuru == 1).Sum(x => x.Tutar.GetValueOrDefault());

                DailyOwnerDTO DailyOwner = new DailyOwnerDTO()
                {
                    Date = DateTime.Now,
                    CompanyRecId = AppMain.CompanyRecId,
                    Deleted = false,
                    Remark = DateTime.Today.ToString() + " - " + textEdit1.EditValue.ToString(),
                    Amount = __Amount - _caseMovements.Where(x => x.IslemTuru == 2).Sum(x => x.Tutar.GetValueOrDefault()),
                    SaleAmount = _saleAmount,
                    CardAmount = _saleOwner.Where(x => x.PaymentType == 2).Sum(x => x.TotalPrice),
                    CashAmount = _saleOwner.Where(x => x.PaymentType == 1).Sum(x => x.TotalPrice),
                    RetailSaleCount = _saleOwner.Count,
                    RetailSaleAmount = _saleAmount,
                    Revenue = __Amount,
                    Expense = _caseMovements.Where(x => x.IslemTuru == 2).Sum(x => x.Tutar),
                };

                #region DailyTrans

                foreach (var item in _saleOwner)
                {
                    var saleTrans = _repository.Run<SaleService, List<SaleTransDTO>>(x => x.Get_List_SaleOwner(item.RecId));
                    if (saleTrans.Count > 0)
                    {
                        _saleTrans.AddRange(saleTrans);
                    }
                }

                foreach (var item in _saleTrans)
                {
                    DailyTransDTO dailyTrans = new DailyTransDTO()
                    {
                        Date = DateTime.Now,
                        SaleTransId = item.SaleOwnerId,
                        Quantity = item.ProductQuantity,
                        Amount = item.ProductPrice,
                        CaseOwnerId = 0,
                        Type = 1,
                        CompanyRecId = AppMain.CompanyRecId,
                        OwnerId = 0
                    };
                    _dailyTrans.Add(dailyTrans);
                }

                foreach (var item in _caseMovements)
                {
                    DailyTransDTO dailyTrans = new DailyTransDTO()
                    {
                        Amount = item.Tutar,
                        Type = 2,
                        SaleTransId = 0,
                        CaseOwnerId = item.RecId,
                        Quantity = 0,
                        CompanyRecId = AppMain.CompanyRecId,
                        Date = DateTime.Now,
                        OwnerId = 0,
                    };
                    _dailyTrans.Add(dailyTrans);
                }


                #endregion
                var req = new DailyRequest
                {
                    dailyOwner = DailyOwner,
                    dailyTrans = _dailyTrans
                };
                var response = _repository.Run<DailyService, ActionResponse<DailyRequest>>(x => x.Save_Daily(req));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("İşlem Tamamlandı..", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }



        #endregion



        private void frmDailyStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Start_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }
    }
}