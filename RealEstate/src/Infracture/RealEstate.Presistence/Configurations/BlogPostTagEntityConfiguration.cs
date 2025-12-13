using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class BlogPostTagEntityConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(bt => new { bt.BlogPostId, bt.TagId });
            builder.ToTable("BlogPostTags");
            builder.ConfigureAuditableEntity();

            builder.Property(bt => bt.BlogPostId).HasColumnType("int");
            builder.Property(bt => bt.TagId).HasColumnType("int");

            builder.HasOne<BlogPost>()
                   .WithMany()
                   .HasForeignKey(bt => bt.BlogPostId)
                   .HasPrincipalKey(bt => bt.Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Tag>()
                     .WithMany()
                     .HasForeignKey(bt => bt.TagId)
                     .HasPrincipalKey(t => t.Id)
                     .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
