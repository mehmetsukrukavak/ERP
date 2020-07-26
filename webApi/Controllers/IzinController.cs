using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IzinController : ControllerBase
    {
        private IIzinService izinService;

        public IzinController(IIzinService izinService)
        {
            this.izinService = izinService;
        }

        [HttpPost("izingiris")]
        public IActionResult IzinGiris(Izin request)
        {
            var result = izinService.IzinGiris(request);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);
        }
    }
}
