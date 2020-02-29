using EasyWatch.Common.Request;
using EasyWatch.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyWatch.BLayer.IAdapter
{
    public interface IUserLoginAdapter
    {
        Task<LoginRequest> AddAsync(UserLogin entity);
    }
}
