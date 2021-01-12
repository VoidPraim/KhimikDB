using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhimikBackend.Data.Configs.DBConfigs;
using KhimikBackend.Data.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KhimikBackend.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        [HttpGet]
        public IEnumerable<Mentor> Get([FromServices] KhimikContext context) {
            var rng = context.Mentor.Include(m => m.Rank);
            
            return rng;
        }
    }
}
