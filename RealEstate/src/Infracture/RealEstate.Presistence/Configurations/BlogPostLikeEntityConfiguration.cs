using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    public class BlogPostLikeEntityConfiguration : IEntityTypeConfiguration<BlogPostLike>
    {
        public void Configure(EntityTypeBuilder<BlogPostLike> builder)
        {
            builder.ToTable("BlogPostLike");
            builder.HasKey(a => new { a.BlogPostId, a.CreatedBy });
            builder.ConfigureAuditableEntity();

            builder.Property(bpl => bpl.BlogPostId).HasColumnType("int").IsRequired();

            builder.HasOne<BlogPost>()
                   .WithMany()
                   .HasForeignKey(bpl => bpl.BlogPostId)
                   .HasPrincipalKey(m=> m.Id)
                   .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
