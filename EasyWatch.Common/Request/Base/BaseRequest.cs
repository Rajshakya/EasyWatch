using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.Common.Request.Base
{
   public class BaseRequest
    {
        public long? UserLoginId { get; set; }
        public DateTime ? LastRequestDateTime { get; set; }
    }
    public class BasePagedRequest : BaseRequest
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }

    public class BasePagedSortRequest : BasePagedRequest
    {
        public string SearchCriteria { get; set; }
        public string SearchTerm { get; set; }
        public string SortBy { get; set; }
        public bool IsAscending { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
