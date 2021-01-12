using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class AgeCategory : BaseModel{
        [Required]
        public int BeginAge { get; set; }
        [Required]
        public int EndAge { get; set; }
    }
}
