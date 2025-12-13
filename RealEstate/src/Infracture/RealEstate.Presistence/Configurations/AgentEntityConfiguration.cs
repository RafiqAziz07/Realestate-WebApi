using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{
    internal class AgentEntityConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.ToTable("Agents");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnType("int");
            builder.Property(a => a.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Surname).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Email).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Phone).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            builder.Property(a => a.ImagePath).HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(a => a.Rate).HasColumnType("decimal(3,2)").IsRequired();


            builder.ConfigureAuditableEntity();
        }

    }
}
