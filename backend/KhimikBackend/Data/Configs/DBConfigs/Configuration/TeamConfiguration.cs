using KhimikBackend.Data.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Configs.DBConfigs.Configuration {
    public class TeamConfiguration : IEntityTypeConfiguration<Team> {
        public void Configure(EntityTypeBuilder<Team> builder) {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(30);
            builder.HasMany(t => t.Mentors).WithMany(m => m.Teams);
            builder.HasMany(t => t.Sportsmen).WithOne(s => s.Team).HasForeignKey(s => s.TeamId);
        }
    }
}
