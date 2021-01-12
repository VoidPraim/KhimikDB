using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Workout : BaseModel {
        public string MentorId { get; set; }
        public Mentor Mentor { get; set; }
        public string TeamId { get; set; }
        public Team Team { get; set; }

        public IceOccupation IceOccupation { get; set; }
    }
}
