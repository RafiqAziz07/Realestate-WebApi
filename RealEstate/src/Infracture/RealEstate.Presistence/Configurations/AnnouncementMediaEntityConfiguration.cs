using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class AnnouncementMediaEntityConfiguration : IEntityTypeConfiguration<AnnouncementMedia>
    {
        public void Configure(EntityTypeBuilder<AnnouncementMedia> builder)
        {
            builder.ToTable("AnnouncementMedias");
            builder.HasKey(a => a.Id);

            builder.Property(am => am.Id).HasColumnType("int");
            builder.Property(am => am.AnnocementId).HasColumnType("int").IsRequired();
            builder.Property(am => am.IsMain).HasColumnType("bit").IsRequired().HasMaxLength(500);
            builder.Property(am => am.Type).HasColumnType("int").IsRequired();



            builder.ConfigureAuditableEntity();
        }

        
    }
}
