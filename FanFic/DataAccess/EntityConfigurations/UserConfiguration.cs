using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Login)
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(u=>u.Password)
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(u => u.FirstName)
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(u => u.LastName)
                   .HasMaxLength(100)
                   .IsRequired();
            builder.ToTable("user");
        }
    }
}
