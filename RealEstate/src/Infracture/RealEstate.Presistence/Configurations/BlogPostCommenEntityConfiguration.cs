using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    public class BlogPostCommenEntityConfiguration : IEntityTypeConfiguration<BlogPostComment>
    {
        public void Configure(EntityTypeBuilder<BlogPostComment> builder)
        {
            builder.ToTable("BlogPostComment");
            builder.HasKey(a => a.Id);
            builder.ConfigureAuditableEntity();

            builder.Property(bpc => bpc.Id).HasColumnType("int");
            builder.Property(bpc => bpc.BlogPostId).HasColumnType("int").IsRequired();
            builder.Property(bpc => bpc.Text).HasColumnType("nvarchar(max)");
            builder.Property(bpc => bpc.ParentId).HasColumnType("int");

            builder.HasOne<BlogPost>()
                .WithMany()
                .HasForeignKey(m => m.BlogPostId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<BlogPostComment>()
                .WithMany()
                .HasForeignKey(m => m.ParentId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
