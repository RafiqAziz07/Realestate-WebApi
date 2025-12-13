using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Agents");
            builder.HasKey(a => a.Id);
            builder.ConfigureAuditableEntity();

            builder.Property(t => t.Id).HasColumnType("int");
            builder.Property(t => t.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }
}
