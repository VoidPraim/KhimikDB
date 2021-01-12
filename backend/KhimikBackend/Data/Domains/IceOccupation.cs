using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class IceOccupation : BaseModel {
        public string ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public string SessionKindId { get; set; }
        public SessionKind SessionKind { get; set; }
        public DateTime HoldDate { get; set; }
        public Game Game { get; set; }
        public Workout Workout { get; set; }
    }
}
