using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class UserCapabilityConfiguration : IEntityTypeConfiguration<UserCapability>
    {
        public void Configure(EntityTypeBuilder<UserCapability> builder)
        {
            builder.HasKey(uc => uc.Id);
            builder.HasAlternateKey(uc => new { uc.UserId, uc.CapabilityId });
            builder.Property(uc => uc.UserId)
                   .IsRequired();
            builder.Property(uc => uc.CapabilityId)
                   .IsRequired();
            builder.ToTable("user_capability");
        }
    }
}
