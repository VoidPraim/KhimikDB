using KhimikBackend.Data.Domains;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AuthorizationController : ControllerBase {
        [HttpPost("[action]")]
        public IActionResult LoginIn([FromBody] User user) {
            return new JsonResult(null);
        }
    }
}
