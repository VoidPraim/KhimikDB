using KhimikBackend.Data.Configs.DBConfigs;
using KhimikBackend.Data.Domains;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class MentorsController : ControllerBase {
        private KhimikContext _context;
        public MentorsController([FromServices] KhimikContext context) {
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllMentor(KhimikContext context) {
            var mentors = context.Mentor.ToArray();
            return new JsonResult(new { Count = mentors.Length, List = mentors});
        }
    }
}
