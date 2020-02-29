using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyWatch.BLayer.IAdapter;
using EasyWatch.Common.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EasyWatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private readonly ICityAdapter _CityAdapter; 
        public CityController(ICityAdapter cityAdapter, ILogger<CityController> logger)
        {
            _CityAdapter = cityAdapter;
            _logger = logger;
        }

        [Route("NeedOTP")]
        [HttpPost]
     
        public async Task<ActionResult> NeedOTP([FromBody]CityRequest request)
        {
            try
            {
               await _CityAdapter.AddCity(request);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "asdf");
                return Ok();
            }
        }
    }
}