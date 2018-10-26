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
    public class PasteryController : ControllerBase
    {
        [HttpPost("[action]")]
        public void AddPaste()
        {

        }

        [HttpGet("[action]")]
        public List<Object> GetPastes()
        {
            throw new NotImplementedException();
        }

        [HttpGet("[action]")]
        public string OpenPaste()
        {
            throw new NotImplementedException();
        }



    }
}