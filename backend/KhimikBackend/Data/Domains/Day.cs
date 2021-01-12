using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Day : BaseModel {
        [MaxLength(30), MinLength(3), Required]
        public string Name { get; set; }
    }
}
