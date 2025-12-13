using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class AnnouncementSpecificationeEntityConfiguration: IentiytypeConfiguration<AnnouncementSpecification>
    {
        public void Configure(EntityTypeBuilder<AnnouncementSpecification> builder)
        {
            builder.ToTable("AnnouncementSpecifications");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(a => a.Name).HasColumnType("nvarchar(250)").IsRequired();
            builder.Property(a => a.IsActive).HasColumnType("bit").IsRequired();
            builder.ConfigureAuditableEntity();

            


        }

    }
}
