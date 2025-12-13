using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class City: BaseEntity<int>
    {
        public string Name { get; set; }
        public string LogaPath { get; set; }
    }
}
