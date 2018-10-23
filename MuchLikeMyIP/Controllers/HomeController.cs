using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MuchLikeMyIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")]
        public Object UserIp()
        {
            return new { ip = HttpContext.Connection.RemoteIpAddress.ToString() };
        }
        

    }
}