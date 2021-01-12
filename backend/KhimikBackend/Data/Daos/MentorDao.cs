using KhimikBackend.Data.Configs.DBConfigs;
using KhimikBackend.Data.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Daos {
    public class MentorDao {
        private KhimikContext _context;
        public MentorDao([FromServices] KhimikContext context) {
            _context = context;
        }

        public IEnumerable<Mentor> GetAll() {
            return _context.Mentor.Include(m => m.Rank).Include(m => m.User);
        }
        public IEnumerable<Mentor> GetAllStartsWithLastName(string lastName) {
            return _context.Mentor.Where(m => m.LastName.StartsWith(lastName)).Include(m => m.Rank).Include(m => m.User);
        }
        public Mentor GetById(string id) {
            return _context.Mentor.Single(m => m.Id == id);
        }
        public Mentor Add(Mentor mentor) {
            Mentor addedMentor = _context.Mentor.Add(mentor).Entity;
            _context.SaveChanges();
            return addedMentor;

        }
        public Mentor Edit(Mentor mentor) {
            Mentor editingMentor = _context.Mentor.Single(m => m.Id == mentor.Id);

            editingMentor.Address = mentor.Address;
            editingMentor.DOB = mentor.DOB;
            editingMentor.FirstName = mentor.FirstName;
            editingMentor.IsReferee = mentor.IsReferee;
            editingMentor.LastName = mentor.LastName;
            editingMentor.Phone = mentor.Phone;
            editingMentor.RankId = mentor.RankId;
            editingMentor.SecondName = mentor.SecondName;

            _context.Entry(editingMentor).State = EntityState.Modified;
            _context.SaveChanges();

            return GetById(editingMentor.Id);

        }
        public string Remove(Mentor mentor) {
            Mentor deletedMentor = _context.Mentor.Remove(mentor).Entity;
            _context.SaveChanges();
            return deletedMentor.Id;

        }
    }
}
