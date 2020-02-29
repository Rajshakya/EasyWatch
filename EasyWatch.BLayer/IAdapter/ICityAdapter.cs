using EasyWatch.Common.Request;
using EasyWatch.Common.Response.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyWatch.BLayer.IAdapter
{
    public interface ICityAdapter
    {
        Task<BaseResponse> AddCity(CityRequest entity);
    }
}
