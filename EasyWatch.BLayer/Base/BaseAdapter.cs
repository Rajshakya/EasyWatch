

using AutoMapper;
using EasyWatch.Datalayer.Models;

namespace EasyWatch.BLayer.Base
{
    public class BaseAdapter
    {
        protected readonly Datalayer.Models.EasyWatchContext DbContext;
        protected readonly IMapper Mapper;
        public BaseAdapter()
        {

        }
        public BaseAdapter(EasyWatchContext dbContext, IMapper mapper)//, IDistributedCache cache =null)
        {
           
            DbContext = dbContext;
            Mapper = mapper;
        }

    }
}
