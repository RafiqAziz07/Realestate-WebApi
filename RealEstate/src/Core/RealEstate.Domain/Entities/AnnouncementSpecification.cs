using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class AnnouncementSpecification: BaseEntity<int>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
