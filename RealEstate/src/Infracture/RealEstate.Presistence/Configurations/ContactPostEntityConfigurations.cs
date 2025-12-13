using RealEstate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Infrastruce.Extensions;

namespace RealEstate.Presistence.Configurations
{

    internal class ContactPostEntityConfigurations : IEntityTypeConfiguration<ContactPost>
    {
        public void Configure(EntityTypeBuilder<ContactPost> builder)
        {
            builder.ToTable("ContactPosts");
            builder.HasKey(e => e.Id);



            builder.Property(e => e.Id).HasColumnType("int");

            builder.Property(e => e.FullName)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Email)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Message)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(e => e.Answer).HasColumnType("nvarchar").HasMaxLength(1000);
            builder.Property(e => e.AnswerdAT).HasColumnType("datetime");

            builder.ConfigureAuditableEntity();
        }    
    }

    
}
