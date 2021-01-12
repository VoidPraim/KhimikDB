using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class TimeRange : BaseModel {
        [StringLength(5), Required]
        public string BeginTime { get; set; }
        [StringLength(5), Required]
        public string EndTime { get; set; }
    }
}
