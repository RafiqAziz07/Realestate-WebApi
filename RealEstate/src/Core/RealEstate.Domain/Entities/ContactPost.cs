using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class ContactPost : BaseEntity<int>
    {
        
        public String FullName { get; set; }
        public String Email { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerdAT { get; set; }
    }
}
