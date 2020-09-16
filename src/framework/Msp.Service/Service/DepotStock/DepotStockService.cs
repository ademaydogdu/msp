using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.DepotStock
{
    public class DepotStockService : BaseService
    {
        #region Product
        public List<ProductDTO> GetListProduct()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Products>, List<ProductDTO>>(_db.products.ToList());
            }
        }
        public ProductDTO GetProduct(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Products, ProductDTO>(_db.products.FirstOrDefault(x => x.PID == id));
            }
        }
        public ActionResponse<ProductDTO> InsertProduct(ProductDTO model)
        {
            ActionResponse<ProductDTO> response = new ActionResponse<ProductDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.PID == 0)
                    {
                        _db.products.Add(base.Map<ProductDTO, Products>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.PID);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(entity);
                            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        }
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

        #endregion

        #region Unit
        public List<UnitsDTO> GetListUnit()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Units>, List<UnitsDTO>>(_db.Units.ToList());
            }
        }
        #endregion

    }
}
