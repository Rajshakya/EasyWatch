using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.Common.Response.Base
{
    public class BaseResponse
    {
        public DateTime? ResponseDateTime { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool IsSuccess { get; set; }
    }
}
