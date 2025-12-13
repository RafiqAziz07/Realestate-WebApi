using RealEstate.Infrastruce.Commons;

namespace RealEstate.Domain.Commons { 

    public class AutibleEntity : IAutibleInterface
    {
         public DateTime CreateAt { get; set; }
         public int CreatedBy { get; set; }
         public DateTime LastModifiedAt { get; set; }
         public int LastModifiedBy { get; set; }
         public DateTime DeleteAt { get; set; }
         public int DeletedBy { get; set; }
    }
}
