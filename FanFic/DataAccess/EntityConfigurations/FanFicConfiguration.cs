using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class FanFicConfiguration : IEntityTypeConfiguration<FanFic>
    {
        public void Configure(EntityTypeBuilder<FanFic> builder)
        {
            builder.HasKey(ff => ff.Id);
            builder.Property(ff => ff.Name)
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(ff => ff.Text)
                   .IsRequired();
            builder.Property(ff => ff.Rate)
                   .IsRequired();
            builder.Property(ff => ff.UserId)
                   .IsRequired();
            builder.ToTable("fan_fic");
        }
    }
}
