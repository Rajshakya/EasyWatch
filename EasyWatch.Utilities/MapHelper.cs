using AutoMapper;
using EasyWatch.Common.Request;
using EasyWatch.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.Utilities
{
    public class MapHelper
    {
        public MapHelper()
        {
        }

        public static Action<IMapperConfigurationExpression> ConfigureMapper()
        {
            Action<IMapperConfigurationExpression> action = (cfg) =>
            {
                

                cfg.CreateMap<CityRequest, City>()
                .ForMember(dest => dest.IsActive, m => m.MapFrom(src => true))
                .ForMember(dest => dest.IsDeleted, m => m.MapFrom(src => false))
                .ForMember(dest => dest.CreatedOn, m => m.MapFrom(src => DateTime.UtcNow));

          
            };
            return action;
        }

    }
}
