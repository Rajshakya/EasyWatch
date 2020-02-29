
using AutoMapper;
using EasyWatch.BLayer.Base;
using EasyWatch.BLayer.IAdapter;
using EasyWatch.Common.Request;
using EasyWatch.Common.Response.Base;
using EasyWatch.Datalayer.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyWatch.BLayer
{
    public class CityAdapter : BaseAdapter, ICityAdapter
    {

        public CityAdapter(IConfiguration config, EasyWatchContext dbContext,IMapper mapper) : base( dbContext,mapper)
        {

        }
        public async Task<BaseResponse> AddCity(CityRequest request)
        {
            BaseResponse baseResponse = new BaseResponse();
            City city = null;
            city = Mapper.Map<CityRequest, City>(request, city);
            await DbContext.City.AddAsync(city);
           var update=await DbContext.SaveChangesAsync();
            return baseResponse;
        }
    }
}
