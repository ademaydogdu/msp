using AutoMapper;
using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.App;
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
        }


    }
}
