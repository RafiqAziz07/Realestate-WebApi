using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;


namespace RealEstate.Presistence.Configurations
{
    internal class AnnouncementCommentEntityConfiguration : IEntityTypeConfiguration<AnnouncementComment>
    {
        public void Configure(EntityTypeBuilder<AnnouncementComment> builder)
        {
            builder.HasKey(ac => ac.Id);
            builder.Property(ac => ac.Id).IsRequired().HasColumnType("int");
            builder.Property(ac => ac.AnnouncementId).IsRequired().HasColumnType("int");
            builder.Property(ac => ac.ParentId).HasColumnType("int");
            builder.Property(ac => ac.Text).IsRequired().HasColumnType("nvarchar(max)");
            builder.ConfigureAuditableEntity();
            builder.ToTable("AnnouncementComments");

        }
    }
}
