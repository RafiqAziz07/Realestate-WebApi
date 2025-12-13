using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Categories");
            builder.ConfigureAuditableEntity();
            builder.Property(c => c.Id).HasColumnType("int").IsRequired();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar"); ;
            builder.Property(c => c.ImagePath).HasMaxLength(255).HasColumnType("nvarchar");
        }
    }
}
