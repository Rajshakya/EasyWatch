using EasyWatch.Common.Request.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWatch.Common.Request
{
    public  class LoginRequest:BaseRequest
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
    }
}
