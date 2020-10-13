using AutoMapper;
using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.App;
using Msp.Models.Models.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Mapping
{
    public class Mappings : Profile
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Users, UsersDTO>();
            cfg.CreateMap<UsersDTO, Users>();
            cfg.CreateMap<Products, ProductDTO>();
            cfg.CreateMap<ProductDTO, Products>();
            cfg.CreateMap<ProgramsControl, ProgramsControlsDTO>();
            cfg.CreateMap<ProgramsControlsDTO, ProgramsControl>();
            cfg.CreateMap<Units, UnitsDTO>();
            cfg.CreateMap<UnitsDTO, Units>();
            cfg.CreateMap<CTransactions, CTransactionsDTO>();
            cfg.CreateMap<CTransactionsDTO, CTransactions>();
            cfg.CreateMap<Parameters, ParametersDTO>();
            cfg.CreateMap<ParametersDTO, Parameters>();
            cfg.CreateMap<SaleOwner, SaleOwnerDTO>();
            cfg.CreateMap<SaleOwnerDTO, SaleOwner>();
            cfg.CreateMap<SaleTrans, SaleTransDTO>();
            cfg.CreateMap<SaleTransDTO, SaleTrans>();
            cfg.CreateMap<Customers, CustomersDTO>();
            cfg.CreateMap<CustomersDTO, Customers>();
            cfg.CreateMap<PaymentType, PaymentTypeDTO>();
            cfg.CreateMap<PaymentTypeDTO, PaymentType>();
            cfg.CreateMap<SpeedSaleProduct, SpeedSaleProductDTO>();
            cfg.CreateMap<SpeedSaleProductDTO, SpeedSaleProduct>();
        }


    }
}
