using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class AnnouncementSpecificationValue: AutibleEntity
    {
        public int SpecificationId { get; set; }
        public int AnnouncementId { get; set; }
        public string Value { get; set; }
    }
}
