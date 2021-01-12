using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Sportsman : BaseModel {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string RankId { get; set; }
        public Rank Rank { get; set; }
        public string TeamId { get; set; }
        public Team Team { get; set; }
    }
}
