using BitchPlease.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BitchPlease.DAL.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(b => b.CreateDate)
                .HasDefaultValueSql("NOW()");

            entity.Property(b => b.Admin)
                .HasDefaultValue(false);

            entity.Property(b => b.Blocked)
                .HasDefaultValue(false);

            entity.Property(b => b.Verified)
                .HasDefaultValue(false);

            entity.Property(b => b.Gender)
                .HasDefaultValue(0);
        }
    }
}
