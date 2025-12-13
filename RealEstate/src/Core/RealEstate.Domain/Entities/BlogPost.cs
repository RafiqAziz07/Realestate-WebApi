using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class BlogPost: BaseEntity<int>
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime PublishedBy { get; set; }
        public string ImagePath { get; set; }
    }
}
