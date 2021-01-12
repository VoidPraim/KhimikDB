using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Game : BaseModel {
        public string Team1Id { get; set; }
        public Team Team1 { get; set; }
        public string Team2Id { get; set; }
        public Team Team2 { get; set; }
        public int Team1Points { get; set; }
        public int Team2Points { get; set; }
        public string ResultDescription { get; set; }

        public ICollection<Mentor> Mentors { get; set; }

        public IceOccupation IceOccupation { get; set; }
    }
}
