using KhimikBackend.Data.Configs.DBConfigs.Configuration;
using KhimikBackend.Data.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Configs.DBConfigs {
    public class KhimikContext : DbContext {
        public KhimikContext(DbContextOptions<KhimikContext> options) : base(options) { }
        public DbSet<AgeCategory> AgeCategory { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Day> Day { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<IceOccupation> IceOccupation { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<SessionKind> SessionKind { get; set; }
        public DbSet<Sportsman> Sportsman { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TimeRange> TimeRange { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Workout> Workout { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string connString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=KhimikDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WorkoutConfiguration());
        }
    }
}
