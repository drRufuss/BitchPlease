using BitchPlease.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BitchPlease.DAL.Configurations
{
    public class UserGroupConfig : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> entity)
        {
            entity.HasKey(ug => new { ug.UserId, ug.GroupId });

            entity.Property(b => b.Admin)
                .HasDefaultValue(false);

            entity.Property(b => b.CreateDate)
                .HasDefaultValueSql("NOW()");
        }
    }
}
