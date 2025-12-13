using RealEstate.Domain.Commons;
using System;

namespace RealEstate.Domain.Entities
{
    public class Subscriber: BaseEntity<int>
    {
        public string Email { get; set; }
        public DateTime CratedAt { get; set; }
        public bool Approved { get; set; }
        public DateTime ApprovedAt { get; set; }
    }
}
