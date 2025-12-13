using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;

namespace RealEstate.Persistence.Configurations
{
    internal class SubscriberEntityConfiguration : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.Property(m => m.Email).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.CreateAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.Approved).HasColumnType("bit").IsRequired();
            builder.Property(m => m.ApprovedAt).HasColumnType("datetime");

            builder.HasKey(m => m.Email);
            builder.ToTable("Subscribers");
        }
    }
}

