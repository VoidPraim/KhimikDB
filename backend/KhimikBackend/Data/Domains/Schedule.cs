using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Schedule : BaseModel {
        public string TimeRangeId { get; set; }
        public TimeRange TimeRange { get; set; }
        public string DayId { get; set; }
        public Day Day { get; set; }
    }
}
