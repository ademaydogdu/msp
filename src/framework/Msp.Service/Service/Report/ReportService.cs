using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Case;
using Msp.Models.Models.Invoice;
using Msp.Models.Models.Order;
using Msp.Models.Models.Product;
using Msp.Models.Models.Report;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Report
{
    public class ReportService : BaseService
    {

        #region EnvanterBilgi
        public List<ProductDTO> Get_List_EnvanterBilgisi(ProductPrintRequest req)
        {
            using (var _db = new MspDbContext())
            {
                List<ProductDTO> products = new List<ProductDTO>();
                products = base.Map<List<Products>, List<ProductDTO>>(_db.products.Where(x => x.PID >= req.ProductBegin && x.PID <= req.ProductEnd).ToList());
                if (req.DepotId != 0)
                {
                    products = products.Where(x => x.PDepotId == req.DepotId).ToList();
                }
                if (req.companyId != 0)
                {
                    products = products.Where(x => x.PCompanyId == req.companyId).ToList();
                }
                return products;
            }
        }
        #endregion

        #region Sale




        #endregion

        #region CaseReport
        public List<CaseMovementDTO> Get_List_CaseMovement(CaseReportFilter filter)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CaseMovement>, List<CaseMovementDTO>>(_db.CaseMovement.Where(x => x.Deleted == false &&
                x.CompanyRecId == filter.companyId && x.RecordDate >= filter.BeginDate && x.RecordDate <= filter.EndDate && x.CaseId == filter.CaseId).ToList());
            }
        }

        public List<CaseBakiyeReportDTO> Get_List_CaseBakiyeReport(CaseReportFilter filter)
        {
            using (var _db = new MspDbContext())
            {
                string _sql = "Select SUM(Case When IslemTuru = 1 then Tutar else 0 end) as DonemGelir, SUM(Case When IslemTuru = 2 then Tutar else 0 end) as DonemGider, "
                + " SUM(Case When IslemTuru = 2 then Tutar else 0 end) -SUM(Case When IslemTuru = 1 then Tutar else 0 end) as SonBakiye , CaseDefinition.CaseName "
                + "   from CaseMovement "
                + "   Inner Join CaseDefinition on CaseDefinition.RecId = CaseMovement.CaseId "
                + "where Deleted = 0 and RecordDate >= @BeginDate and RecordDate <= @EndDate and CaseId = @CaseId"
                + "  Group By CaseDefinition.CaseName";
                var _param = new SqlParameter[]
                {
                    new SqlParameter{ParameterName = "BeginDate", Value = filter.BeginDate },
                    new SqlParameter{ParameterName = "EndDate", Value = filter.EndDate },
                    new SqlParameter{ParameterName = "CaseId", Value = filter.CaseId }
                };

                return _db.Database.SqlQuery<CaseBakiyeReportDTO>(_sql, _param.ToArray()).ToList();
            }
        }


        #endregion

        #region StockHareketRaporu
        public List<ProductMovementDTO> Get_List_StokHareketListesi(CaseReportFilter filter)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<ProductMovement>, List<ProductMovementDTO>>(_db.ProductMovement.Where(x => x.Deleted == false && x.Date >= filter.BeginDate && x.Date <= filter.EndDate && x.ProductId >= filter.BeginProduct && x.ProductId <= filter.EndProduct).ToList());
            }
        }
        #endregion

        #region EncokSatilanStok

        public List<SumSaleStockDTO> Get_List_SumSaleStock()
        {
            using (var _db = new MspDbContext())
            {
                string _sql = "Select Top 10 P.PCode, P.PName, SUM(sl.ProductQuantity) as SatilanMiktar, SUM(sl.ProductAmount) as ToplamTutar "
                    + " from SaleTrans sl "
                    + " Inner Join products P on sl.ProductId = P.PID "
                    + " group by sl.ProductId, P.PName, P.PCode "
                    + " order by SatilanMiktar desc";
                return _db.Database.SqlQuery<SumSaleStockDTO>(_sql).ToList();
            }
        }


        #endregion

        #region HareketGormeyenStock

        public List<ProductDTO> Get_List_HareketGormeyenStock(DateTime BeginDate, DateTime EndDate)
        {
            using (var _db = new MspDbContext())
            {
                string _sql = "select * from products where not exists (select * from SaleTrans INNER JOIN SaleOwner  on SaleOwner.RecId = SaleTrans.SaleOwnerId  "
                            + " where SaleTrans.ProductId = products.PID And SaleOwner.Date >= @BeginDate and SaleOwner.Date <= @EndDate)";
                var _param = new SqlParameter[]
                {
                    new SqlParameter{ParameterName = "BeginDate", Value = BeginDate },
                    new SqlParameter{ParameterName = "EndDate", Value = EndDate },
                };

                return _db.Database.SqlQuery<ProductDTO>(_sql, _param.ToArray()).ToList();
            }
        }


        #endregion

        #region StockBakiyeReport

        public List<StockBakiyeReportDTO> Get_List_StockBakiyeReport(int CompanyId)
        {
            using (var _db = new MspDbContext())
            {
                string _sql = "SELECT         dbo.products.PID, products.PDepotId, products.PName, products.PTotal, products.PUnitId, SUM(case when  dbo.InvoiceOwner.InvoiceType = 1 then InvoiceTrans.Tutar Else 0 end) as TGiren,  "
                    + " SUM(case when  dbo.InvoiceOwner.InvoiceType = 2 then InvoiceTrans.Tutar Else 0 end) as TCikis "
                    + " FROM dbo.products INNER JOIN "
                    + "                 dbo.InvoiceTrans ON dbo.products.PID = dbo.InvoiceTrans.ProductId INNER JOIN  "
                    + "                 dbo.InvoiceOwner ON dbo.InvoiceTrans.InvoiceOwnerId = dbo.InvoiceOwner.RecId "
                    + " where InvoiceOwner.Deleted = 0 and products.Deleted = 0 and InvoiceOwner.CompanyId = @CompanyId "
                    + " GROUP BY dbo.products.PID,products.PDepotId,products.PName, products.PTotal, products.PUnitId";

                var _param = new SqlParameter[]
                {
                    new SqlParameter {ParameterName = "CompanyId", Value = CompanyId }
                };

                return _db.Database.SqlQuery<StockBakiyeReportDTO>(_sql, _param.ToArray()).ToList();
            }
        }

        #endregion

        #region Invoice

        public List<InvoiceOwnerDTO> GetList_Invoice(InvoiceRequest request)
        {
            using (var _db = new MspDbContext())
            {
                List<InvoiceOwnerDTO> result = new List<InvoiceOwnerDTO>();
                result = base.Map<List<InvoiceOwner>, List<InvoiceOwnerDTO>>(_db.InvoiceOwner.Where(x => x.InvoiceType == request.InvoiceType && x.Deleted == false && x.FicDate >= request.BeginDate && x.FicDate <= request.EndDate && x.DovizTuru == request.DovizTuru).ToList());
                return result;
            }
        }


        #endregion

        #region Order

        public List<OrderOwnerDTO> GetList_Order(Models.Models.Report.OrderRequest request)
        {
            using (var _db = new MspDbContext())
            {
                List<OrderOwnerDTO> result = new List<OrderOwnerDTO>();
                result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == request.OrderType && x.Deleted == false && x.SiparisDate >= request.BeginDate && x.SiparisDate <= request.EndDate).ToList());
                return result;
            }
        }

        public List<OrderOwnerDTO> GetList_OrderSevk(Models.Models.Report.OrderRequest request)
        {
            using (var _db = new MspDbContext())
            {
                List<OrderOwnerDTO> result = new List<OrderOwnerDTO>();
                result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == request.OrderType && x.Deleted == false && x.SiparisDate >= request.BeginDate && x.SiparisDate <= request.EndDate && x.IrsaliyeId != 0).ToList());
                return result;
            }
        }


        #endregion

        #region KDVReport
        public List<KDVReportDto> Get_List_KDVReport(int CompanyId, DateTime BeginDate, DateTime EndDate)
        {
            using (var _db = new MspDbContext())
            {
                string _sql = "SELECT        InvoiceTrans.KDV, SUM(Case When InvoiceOwner.InvoiceType = 1 then InvoiceTrans.Tutar Else 0 End) as AlisMatrah, "
                + " SUM(Case When InvoiceOwner.InvoiceType = 2 then InvoiceTrans.Tutar Else 0 End) as SatisMatrah, SUM(Case When InvoiceOwner.InvoiceType = 1 then InvoiceTrans.KDVPrice Else 0 End) as AlisKDV,  "
                + " SUM(Case When InvoiceOwner.InvoiceType = 2 then InvoiceTrans.KDVPrice Else 0 End) as SatisKDV, SUM(Case When InvoiceOwner.InvoiceType = 1 then InvoiceTrans.KDVPrice Else 0 End) - SUM(Case When InvoiceOwner.InvoiceType = 2 then InvoiceTrans.KDVPrice Else 0 End) as Farki "
                + " FROM InvoiceTrans INNER JOIN "
                + "                          dbo.InvoiceOwner ON InvoiceTrans.InvoiceOwnerId = InvoiceOwner.RecId "
                + "                          where ISNULL(InvoiceOwner.Deleted,0) = 0 and InvoiceOwner.CompanyId = @CompanyId "
                + "                          and InvoiceOwner.FicDate >= @BeginDate and InvoiceOwner.FicDate <= @EndDate "
                + " Group By InvoiceTrans.KDV";
                var _param = new SqlParameter[]
                {
                    new SqlParameter {ParameterName = "CompanyId", Value = CompanyId },
                    new SqlParameter{ParameterName = "BeginDate", Value = BeginDate },
                    new SqlParameter{ParameterName = "EndDate", Value = EndDate }
                };

                return _db.Database.SqlQuery<KDVReportDto>(_sql, _param.ToArray()).ToList();
            }
        }

        #endregion
    }
}
