using EasyWatch.BLayer.Base;
using EasyWatch.BLayer.IAdapter;
using EasyWatch.Datalayer.Models;
using System.Threading.Tasks;
using System.Linq;
using EasyWatch.Common.Request;
using AutoMapper.Configuration;
using AutoMapper;

namespace EasyWatch.BLayer
{

    public class UserLoginAdapter : BaseAdapter,IUserLoginAdapter
    {
        public UserLoginAdapter(IConfiguration config, EasyWatchContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }
        public async Task<LoginRequest> AddAsync(UserLogin entity)
        {
            LoginRequest response = new LoginRequest();
            await Task.Run(() =>
            {
                var userLogin = from u in DbContext.UserLogin select u; 



            });
            return response;
        }
    }
}
