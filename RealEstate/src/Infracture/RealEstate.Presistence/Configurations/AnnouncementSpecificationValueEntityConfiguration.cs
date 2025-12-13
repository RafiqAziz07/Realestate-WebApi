using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class AnnouncementSpecificationValueEntityConfiguration: IentiytypeConfiguration<AnnouncementSpecificationValue>
    {
        public void Configure(EntityTypeBuilder<AnnouncementSpecificationValue> builder)
        {
            builder.ToTable("AnnouncementSpecificationValues");
            builder.HasKey(a => new { a.SpecificationId, a.AnnouncementId});
            
            builder.Property(a => a.SpecificationId).HasColumnType("int").IsRequired();
            builder.Property(a => a.AnnouncementId).HasColumnType("int").IsRequired();
            builder.Property(a => a.Value).HasColumnType("nvarchar(500)").IsRequired();
            builder.ConfigureAuditableEntity();
        }
    }
}
