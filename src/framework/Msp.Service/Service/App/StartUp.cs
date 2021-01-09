using Msp.Entity.Entities;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.App;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.App
{
    public class StartUp : BaseService
    {

        public void Start()
        {
            LoadStatics();
        }



        public ProgramsControlsDTO CheckVersion()
        {
            ProgramsControlsDTO dataVersion = new ProgramsControlsDTO()
            {
                MspVersion = "1.0.0.0",
            };
            using (MspDbContext db = new MspDbContext())
            {
                var versionDto = db.Database.SqlQuery<ProgramsControlsDTO>("select * from ProgramsControl").FirstOrDefault();
                if (versionDto == null)
                {
                    db.ProgramsControl.Add(base.Map<ProgramsControlsDTO, ProgramsControl>(dataVersion));
                    db.SaveChanges();
                    versionDto.MspVersion = dataVersion.MspVersion;
                }
                dataVersion = versionDto;
            }

            return dataVersion;
        }

        public List<ApplicationServerDTO> Get_List_ApplicationServer()
        {
            using (MspDbContext _db = new MspDbContext())
            {
                return base.Map<List<ApplicationServer>, List<ApplicationServerDTO>>(_db.ApplicationServer.ToList());
            }
        }

        public List<CompanyDTO> GetList_Company()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Company>, List<CompanyDTO>>(_db.Company.ToList());
            }
        }
        public UsersDTO GetUser(string UserCode)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Users, UsersDTO>(_db.users.FirstOrDefault(x => x.username == UserCode));
            }
        }



        public ActionResponse<FormLayoutsDTO> Save_FormLayout(FormLayoutsDTO gridSettings)
        {
            ActionResponse<FormLayoutsDTO> response = new ActionResponse<FormLayoutsDTO>()
            {
                Response = gridSettings,
                ResponseType = ResponseType.Ok
            };
            using (var _db = new MspDbContext())
            {
                try
                {
                    var grid = _db.FormLayouts.Where(x => x.ControlName == gridSettings.ControlName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode).FirstOrDefault();
                    if (grid != null)
                    {
                        gridSettings.RecId = grid.RecId;
                        _db.Entry(grid).CurrentValues.SetValues(gridSettings);
                        _db.Entry(grid).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        _db.FormLayouts.Add(base.Map<FormLayoutsDTO, FormLayouts>(gridSettings));
                        _db.SaveChanges();
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public FormLayoutsDTO Get_FormLayout(FormLayoutsDTO gridSettings)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<FormLayouts, FormLayoutsDTO>(_db.FormLayouts.FirstOrDefault(x => x.ControlName == gridSettings.ControlName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode));
            }
        }

        public void LoadStatics()
        {
            RegisterForms();
        }

        private void RegisterForms()
        {
            AppMain.Forms = new Dictionary<string, string>()
            {
                { "Satış","btnQuickSell"},
                { "Hızlı Satış","btnSpeedSale"},
                { "Fiyat Sorgula","tbnPriceInquiry"},
                { "Satış Listesi","btnSatisListesi"},
                { "Kontrol Paneli","btnDashboard"},
                { "Satış Anında Barkod İşlemleri","bbi_SatisAnindaBarkod"},
                { "Veresiye Defter","bbi_veresiye"},
                { "Veresiye Süresi Geçenler","barButtonItem79"},
                { "Ürün Kartları","btnStok"},
                { "Ürün Envanter Bilgileri","barButtonItem81"},
                { "Son Kullanma Tarihi Geçen Ürünler","btnSonKullanmaTar"},
                { "Son Kullanma Tarihi Yaklaşan Ürünler","btnSKTGecenUrun"},
                { "Depo","btnDepo"},
                { "Ürün Barkod Yazdırma","barButtonItem82"},
                { "Cari Hesaplar","btnCurAccount"},
                { "Alış Siparişi","btnBuyingOrder"},
                { "Satış Siparişi","barButtonItem84"},
                { "Sipariş Ara","barButtonItem85"},
                { "Bekleyen Siparişler","barButtonItem86"},
                { "Alış İrsaliyesi","barButtonItem89"},
                { "Satış İrsaliyesi","barButtonItem90"},
                { "İrsaliye Ara","barButtonItem91"},
                { "Bekleyen İrsaliye","bbi_BekleyenIrsaliye"},
                { "Alım Faturası","btnAlimFaturasi"},
                { "Satış Faturası","barButtonItem87"},
                { "Fatura Ara","btnFaturaAra"},
            };
        }

    }
}
