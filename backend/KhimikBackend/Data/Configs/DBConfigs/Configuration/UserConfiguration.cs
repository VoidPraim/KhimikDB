using KhimikBackend.Data.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhimikBackend.Data.Configs.DBConfigs.Configuration {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Username).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(30);
            builder.Property(u => u.ActivityDate).IsRequired();
            builder.Property(u => u.Status).HasDefaultValue(true);
            builder.HasOne(u => u.Mentor).WithOne(m => m.User).HasForeignKey<Mentor>(m => m.Id);
        }
    }
}
