using EasyWatch.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyWatch.BLayer.IAdapter
{
    public interface IUserLoginAdapter
    {
        Task<UserLogin> AddAsync(UserLogin entity);
    }
}
