using EasyWatch.BLayer.IAdapter;
using EasyWatch.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyWatch.BLayer
{

    public class UserLoginAdapter : IUserLoginAdapter
    {
        public Task<UserLogin> AddAsync(UserLogin entity)
        {
            throw new NotImplementedException();
        }
    }
}
