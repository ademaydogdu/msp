using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                return base.Map<List<Products>, List<ProductDTO>>(_db.products.Where(x=>x.Deleted == false || x.Deleted == null).ToList());
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

        public ActionResponse<ProductDTO> SaveProduct(ProductDTO model)
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
                        if (model.PBarcode.Length > 0)
                        {
                            var barcodControl = _db.products.Where(x => x.PBarcode == model.PBarcode).Any();
                            if (barcodControl)
                            {
                                response.Message = "Aynı Barkod Ürününden Mevcuttur.";
                                response.ResponseType = ResponseType.Error;
                                return response;
                            }
                        }
                        var product = base.Map<ProductDTO, Products>(response.Response);
                        _db.products.Add(product);
                        _db.SaveChanges();

                        if (model.PBarcode.Length > 0)
                        {
                            ProductBarCodeDTO productBarCode = new ProductBarCodeDTO
                            {
                                Barcode = model.PBarcode,
                                ProductId = product.PID,
                                CompanyRecId = product.PCompanyId,
                                Remark = product.PName
                            };
                            _db.ProductBarCode.Add(base.Map<ProductBarCodeDTO, ProductBarCode>(productBarCode));
                            _db.SaveChanges();
                        }

                        ProductMovementDTO productMovement = new ProductMovementDTO
                        {
                            ProductId = product.PID,
                            Date = DateTime.Now,
                            Quantity = Convert.ToInt32(model.PTotal.GetValueOrDefault()),
                            Durum = "Stok Giriş",
                            Deleted = false,
                            Amount = model.PSalePrice,
                        };
                        _db.ProductMovement.Add(base.Map<ProductMovementDTO, ProductMovement>(productMovement));
                        _db.SaveChanges();

                    }
                    else
                    {
                        var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.PID);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(model);
                            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        }

                        var _ProductBarcode = _db.ProductBarCode.FirstOrDefault(x => x.ProductId == response.Response.PID);
                        if (_ProductBarcode != null)
                        {
                            _ProductBarcode.Barcode = response.Response.PBarcode;
                            _db.Entry(_ProductBarcode).CurrentValues.SetValues(_ProductBarcode);
                            _db.Entry(_ProductBarcode).State = System.Data.Entity.EntityState.Modified;
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

        public ActionResponse<ProductDTO> DeleteProduct(int? PID)
        {
            ActionResponse<ProductDTO> response = new ActionResponse<ProductDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.products.Where(x => x.PID == PID).FirstOrDefault();
                if (record != null)
                {
                    _db.products.Remove(record);
                }
                var speedRecord = _db.SpeedSaleProduct.Where(x => x.ProductId == PID).ToList();
                if (speedRecord.Count > 0)
                {
                    _db.SpeedSaleProduct.RemoveRange(speedRecord);
                }

                var ProductBarcod = _db.ProductBarCode.FirstOrDefault(x => x.ProductId == PID);
                if (ProductBarcod != null)
                {
                    _db.ProductBarCode.Remove(ProductBarcod);
                }

                _db.SaveChanges();
            }
            return response;
        }

        public ProductDTO GetProduct_Code(string PCode)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Products, ProductDTO>(_db.products.FirstOrDefault(x => x.PCode.Trim() == PCode.Trim()));
            }
        }

        #endregion

        #region Product Expiry Day

        public List<ProductDTO> GetListExpDateProducts()
        {

            DateTime endDate = DateTime.Now;
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Products>, List<ProductDTO>>(_db.products.Where(x => EntityFunctions.TruncateTime(x.PExpDate) <= endDate).ToList());
            }
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

        public ActionResponse<List<UnitsDTO>> SaveUnit(List<UnitsDTO> model)
        {
            ActionResponse<List<UnitsDTO>> response = new ActionResponse<List<UnitsDTO>>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    foreach (var item in model)
                    {
                        if (item.UID == 0)
                        {
                            _db.Units.Add(base.Map<UnitsDTO, Units>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.Units.FirstOrDefault(x => x.UID == item.UID);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(item);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
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

        public ActionResponse<UnitsDTO> SaveUnit(UnitsDTO model)
        {
            ActionResponse<UnitsDTO> response = new ActionResponse<UnitsDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.UID == 0)
                    {
                        _db.Units.Add(base.Map<UnitsDTO, Units>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Units.FirstOrDefault(x => x.UID == response.Response.UID);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(model);
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


        public ActionResponse<UnitsDTO> DeleteUnit(int? id)
        {
            ActionResponse<UnitsDTO> response = new ActionResponse<UnitsDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.Units.Where(x => x.UID == id).FirstOrDefault();
                if (record != null)
                {
                    _db.Units.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion

        #region Payment

        public List<PaymentTypeDTO> Get_List_Payment()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<PaymentType>, List<PaymentTypeDTO>>(_db.PaymentTypes.ToList());
            }
        }

        public ActionResponse<List<PaymentTypeDTO>> SavePayment(List<PaymentTypeDTO> model)
        {
            ActionResponse<List<PaymentTypeDTO>> response = new ActionResponse<List<PaymentTypeDTO>>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    foreach (var item in model)
                    {
                        if (item.RecId == 0)
                        {
                            _db.PaymentTypes.Add(base.Map<PaymentTypeDTO, PaymentType>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.PaymentTypes.FirstOrDefault(x => x.RecId == item.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(item);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
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

        public ActionResponse<PaymentTypeDTO> DeletePayment(int? id)
        {
            ActionResponse<PaymentTypeDTO> response = new ActionResponse<PaymentTypeDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.PaymentTypes.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.PaymentTypes.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

        #region frmProductEnvanter

        public ActionResponse<ProductDTO> SaveProduct_EnvanterEkle(ProductDTO model)
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
                    var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.PID);
                    if (entity != null)
                    {
                        _db.Entry(entity).CurrentValues.SetValues(model);
                        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
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

        #region ProductMovemnet
        public List<ProductMovementDTO> GetListProduct_Movement(int Id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<ProductMovement>, List<ProductMovementDTO>>(_db.ProductMovement.Where(x=>x.ProductId == Id && x.Deleted == false).ToList());
            }
        }

        public List<ProductMovementDTO> GetListProduct_Movement_Daily()
        {
            DateTime date = DateTime.Now;
            using (var _db = new MspDbContext())
            {

                //List<ProductMovementDTO> _List_productMovement = new List<ProductMovementDTO>();
                //string sql = "Select * from ProductMovement where Deleted = 0 and DurumType = 1 and Date = @Date";
                //var _param = new SqlParameter[]
                //{
                //    new SqlParameter{ParameterName = "Date", Value = date }
                //};
                //_List_productMovement = _db.Database.SqlQuery<ProductMovementDTO>(sql, _param.ToArray()).ToList();
                //return _List_productMovement;
                return base.Map<List<ProductMovement>, List<ProductMovementDTO>>(_db.ProductMovement.Where(x => EntityFunctions.TruncateTime(x.Date) == date.Date && x.DurumType == 1 && x.Deleted == false).ToList());
            }
        }

        #endregion

    }
}
