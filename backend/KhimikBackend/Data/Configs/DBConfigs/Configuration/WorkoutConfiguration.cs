using KhimikBackend.Data.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Configs.DBConfigs.Configuration {
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout> {
        public void Configure(EntityTypeBuilder<Workout> builder) {
            builder.HasKey(w => w.Id);
            builder.HasOne(w => w.IceOccupation).WithOne(o => o.Workout);
            builder.HasOne(w => w.IceOccupation).WithOne(o => o.Workout).HasForeignKey<IceOccupation>(o => o.Id);
            builder.HasOne(w => w.Mentor).WithMany(m => m.Workouts).HasForeignKey(w => w.MentorId);
        }
    }
}
