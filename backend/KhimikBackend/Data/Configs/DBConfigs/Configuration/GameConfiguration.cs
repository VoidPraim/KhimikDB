using KhimikBackend.Data.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Configs.DBConfigs.Configuration {
    public class GameConfiguration : IEntityTypeConfiguration<Game> {
        public void Configure(EntityTypeBuilder<Game> builder) {
            builder.HasKey(g => g.Id);
            builder.HasOne(g => g.Team1).WithMany(t => t.Games1).HasForeignKey(g => g.Team1Id).HasConstraintName("Game_Team1_Key");
            builder.HasOne(g => g.Team2).WithMany(t => t.Games2).HasForeignKey(g => g.Team2Id).HasConstraintName("Game_Team2_Key");
            builder.Property(g => g.Team1Points).IsRequired();
            builder.Property(g => g.Team2Points).IsRequired();
            builder.Property(g => g.ResultDescription).IsRequired().HasMaxLength(50);
            builder.HasMany(g => g.Mentors).WithMany(m => m.Games);
            builder.HasOne(g => g.IceOccupation).WithOne(o => o.Game).HasForeignKey<IceOccupation>(o => o.Id);
        }
    }
}
