using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class PartnerEntityConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.ToTable("Partners");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(200).HasColumnType("nvarchar").UseIdentityColumn(1,1);   
            builder.Property(a => a.LogoPath).IsRequired().HasMaxLength(500).HasColumnType("nvarchar");
            builder.Property(a => a.Id).IsRequired().HasColumnType("int");
            builder.ConfigureAuditableEntity();
        }
    }
}
