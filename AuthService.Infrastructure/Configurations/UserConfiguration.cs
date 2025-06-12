using AuthService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x=>x.Email).IsUnique();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.PasswordHash).IsRequired();
            builder.Property(x => x.Role).IsRequired().HasMaxLength(50);
        }
    }
}
