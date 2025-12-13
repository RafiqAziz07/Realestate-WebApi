using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Infrastruce.Commons;




namespace RealEstate.Infrastruce.Extensions
{
    public static partial class Extension
    {
        public static EntityTypeBuilder<T> ConfigureAuditableEntity<T>(this EntityTypeBuilder<T> builder) where T : class, IAutibleInterface
        {
            builder.Property(e => e.CreatedBy).HasColumnType("int");
            builder.Property(e => e.CreateAt).HasColumnType("datetime").IsRequired();
            builder.Property(e => e.LastModifiedAt).HasColumnType("datetime");
            builder.Property(e => e.LastModifiedBy).HasColumnType("int");
            builder.Property(e => e.DeleteAt).HasColumnType("datetime");
            builder.Property(e => e.DeletedBy).HasColumnType("int");
        

            
            return builder;
        }

    }
}
