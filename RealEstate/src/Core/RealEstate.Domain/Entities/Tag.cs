using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class Tag: BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
