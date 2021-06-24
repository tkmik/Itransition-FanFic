﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfigurations
{
    class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Text)
                   .IsRequired();
            builder.Property(c => c.FanFicId)
                   .IsRequired();
            builder.ToTable("comment");
        }
    }
}
