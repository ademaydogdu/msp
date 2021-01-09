using AutoMapper;
using Msp.Entity.Entities;
using Msp.Infrastructure;
using Msp.Models.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service
{
    public abstract class BaseService
    {
        public string FormName { get; set; }
        public virtual TDestination Map<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }
        public virtual TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        public void SetLog<S, T>(S entity, T model, Entity.Entities.MspDbContext db, int RecId)
        {
            string tableName = entity.GetType().CustomAttributes.Count() == 0 ? entity.GetType().BaseType.Name : entity.GetType().Name;
            var diffirences = new LogsDTO();
            Type entiType = entity.GetType();
            Type modelType = model.GetType();
            var tableId = (dynamic)null;
            var modelPropertys = modelType.GetProperties();
            var properties = entiType.GetProperties();
            foreach (var item in properties)
            {

                var targetProperty = modelType.GetProperty(item.Name);
                if (targetProperty != null && item.PropertyType.Equals(targetProperty.PropertyType))
                {
                    if (item.PropertyType.IsGenericType && !item.PropertyType.IsValueType)
                    {
                        continue;
                    }

                    object oldValue = item.GetValue(entity, null);
                    object newValue = item.GetValue(Map<T, S>(model), null);
                    if (oldValue == null && newValue == null)
                    {
                        continue;
                    }
                    if (oldValue != null && newValue != null)
                    {
                        if (oldValue.ToString().Length > 50)
                        {
                            oldValue = oldValue.ToString().Substring(0, 50);
                        }
                        if (newValue.ToString().Length > 50)
                        {
                            newValue = newValue.ToString().Substring(0, 50);
                        }
                    }


                    if (oldValue != null && newValue != null && !oldValue.Equals(newValue))
                    {
                        if (tableId == null)
                        {
                            for (int k = 0; k < properties.Length; k++)
                            {
                                if (properties[k].Name == "RecId")
                                {
                                    tableId = properties[k].GetValue(entity, null);
                                }
                            }
                        }
                        diffirences.UserCode = AppMain.User.username;
                        diffirences.CompanyCode = "";// Global.Company.CompanyCode;
                        diffirences.FieldName = item.Name;
                        diffirences.TableName = tableName;
                        diffirences.Old = oldValue.ToString();
                        diffirences.New = newValue.ToString();
                        diffirences.PCName = Environment.MachineName.ToString();
                        diffirences.FormName = "";//FormName;
                        diffirences.CompanyRecId = AppMain.CompanyRecId;// Global.Company.RecId;
                        db.LOGS.Add(Map<LogsDTO, Logs>(diffirences));
                    }
                }
            }

        }

        public void Insert_ProductMovement(string Durum, int ProductId, int Quantity, decimal ProductPrice, Entity.Entities.MspDbContext _db)
        {
            Models.Models.ProductMovementDTO productMovement = new Models.Models.ProductMovementDTO
            {
                ProductId = ProductId,
                Date = DateTime.Now,
                Quantity = Convert.ToInt32(Quantity),
                Durum = Durum,
                Deleted = false,
                Amount = Quantity * ProductPrice,
            };
            _db.ProductMovement.Add(Map<Models.Models.ProductMovementDTO, Entity.Entities.ProductMovement>(productMovement));
            _db.SaveChanges();
        }


    }
}
