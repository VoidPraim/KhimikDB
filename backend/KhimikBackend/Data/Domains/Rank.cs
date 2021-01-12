using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Rank : BaseModel {
        [MaxLength(15), MinLength(3), Required]
        public string Name { get; set; }
        [MaxLength(30), MinLength(3), Required]
        public string Decryption { get; set; }
    }
}
