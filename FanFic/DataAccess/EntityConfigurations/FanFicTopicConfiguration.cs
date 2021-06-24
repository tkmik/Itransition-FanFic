using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class FanFicTopicConfiguration : IEntityTypeConfiguration<FanFicTopic>
    {
        public void Configure(EntityTypeBuilder<FanFicTopic> builder)
        {
            builder.HasKey(ffc => ffc.Id);
            builder.HasAlternateKey(ffc => new { ffc.TopicId, ffc.FanFicId });
            builder.Property(ffc => ffc.TopicId)
                   .IsRequired();
            builder.Property(ffc => ffc.FanFicId)
                   .IsRequired();
            builder.ToTable("fan_fic_topic");
        }
    }
}
