using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class BaseModel {
        [MaxLength(36)]
        public string Id { get; set; }
        public void GenId() {
            Id = Guid.NewGuid().ToString();
        }
    }
}
