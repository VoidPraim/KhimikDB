using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class User : BaseModel {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime ActivityDate { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public Mentor Mentor  { get; set; }
        public void UpdateActivity() {
            ActivityDate = DateTime.Now;
        }
    }
}
