using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class BlogPostEntityConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.ToTable("Agents");
            builder.HasKey(a => a.Id);

            builder.ConfigureAuditableEntity();

            builder.Property(bp => bp.Id).HasColumnType("int");
            builder.Property(bp => bp.Title).HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            builder.Property(bp => bp.Slug).HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            builder.Property(bp => bp.Body).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(bp => bp.PublishedAt).HasColumnType("datetime");
            builder.Property(bp => bp.PublishedBy).HasColumnType("int");
            builder.Property(bp => bp.ImagePath).HasColumnType("nvarchar").HasMaxLength(500);

        }
    }
}
