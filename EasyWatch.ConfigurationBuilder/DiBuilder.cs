using AutoMapper;
using EasyWatch.BLayer;
using EasyWatch.BLayer.IAdapter;
using EasyWatch.Datalayer.Models;
using EasyWatch.Logger;
using EasyWatch.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.ConfigurationBuilder
{
     public static class DiBuilder
    {
        public static IServiceProvider Provider { get; private set; }

        public static IServiceCollection Build(IServiceCollection collection)
        {
            Action<IMapperConfigurationExpression> config = MapHelper.ConfigureMapper();
           
            collection.AddSingleton<ILog, LogNLog>();
            collection.AddDbContext<EasyWatchContext>(options => options.UseSqlServer(ConfigurationManager.iEdPlanConnectionString));

            collection.AddScoped(typeof(ICityAdapter), typeof(CityAdapter));
         

            Provider = collection.BuildServiceProvider();

            return collection;
        }

        public static void BuildiEwayWatch(this IServiceCollection collection)
        {
            Build(collection);
        }
    }
}
