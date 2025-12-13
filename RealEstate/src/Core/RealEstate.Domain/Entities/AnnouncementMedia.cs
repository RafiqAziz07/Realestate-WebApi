using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class AnnouncementMedia: BaseEntity<int>
    {
        public int AnnocementId { get; set; }
        public string MediaPath { get; set; }
        public bool IsMain { get; set; }   
        public int Type { get; set; }   
           

    }
}
