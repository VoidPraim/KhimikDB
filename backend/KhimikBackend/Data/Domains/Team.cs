using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Domains {
    public class Team : BaseModel {
        public string Name { get; set; }
        public string AgeCategoryId { get; set; }
        public AgeCategory AgeCategory { get; set; }
        public string ClubId { get; set; }
        public Club Club { get; set; }

        public ICollection<Sportsman> Sportsmen { get; set; }
        public ICollection<Game> Games1 { get; set; }
        public ICollection<Game> Games2 { get; set; }
        public ICollection<Mentor> Mentors { get; set; }
        public ICollection<Workout> Workouts { get; set; }
    }
}
