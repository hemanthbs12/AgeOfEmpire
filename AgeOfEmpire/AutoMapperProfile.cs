using AgeOfEmpire.Domain.Models;
using AgeOfEmpire.ServiceModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfEmpire.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Unit, UnitDTO>();
        }
    }
}
