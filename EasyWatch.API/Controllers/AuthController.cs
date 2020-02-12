using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyWatch.Common.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyWatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }
        public async Task<IActionResult> Login([FromBody]LoginRequest request)
        {
            try
            {
              return  Ok();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
    }
}