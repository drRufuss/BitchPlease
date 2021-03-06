﻿using BitchPlease.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BitchPlease.DAL.Configurations
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> entity)
        {
            entity.Property(b => b.CreateDate)
                .HasDefaultValueSql("NOW()");

            entity.Property(b => b.Active)
                .ValueGeneratedNever()
                .HasDefaultValue(true);

            entity.HasOne(b => b.CreatedByUser)
                .WithMany(b => b.CreatedGroups)
                .HasForeignKey(b => b.CreatedBy);

            entity.HasOne(b => b.UpdatedByUser)
                .WithMany(b => b.UpdatedGroups)
                .HasForeignKey(b => b.UpdatedBy);
        }
    }
}
