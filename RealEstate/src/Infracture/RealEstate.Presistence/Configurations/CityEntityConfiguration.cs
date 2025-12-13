using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(c => c.Id);
            builder.ConfigureAuditableEntity();

            builder.Property(c => c.Id).HasColumnType("int").IsRequired().UseIdentityColumn(1,1);
            builder.Property(c => c.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(c => c.LogaPath).HasColumnType("nvarchar").IsRequired().HasMaxLength(250);

        }
    }
}
