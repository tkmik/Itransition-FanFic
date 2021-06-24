using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class CapabilityConfiguration : IEntityTypeConfiguration<Capability>
    {
        public void Configure(EntityTypeBuilder<Capability> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.NameCapability);
            builder.Property(c => c.NameCapability)
                   .HasMaxLength(100)
                   .IsRequired()
                   .HasConversion<int>();
            builder.ToTable("capability");
        }
    }
}
