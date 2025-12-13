namespace RealEstate.Infrastruce.Commons
{
    public interface IAutibleInterface
    {
        DateTime CreateAt { get; set; }
        int CreatedBy { get; set; }
        DateTime LastModifiedAt { get; set; }
        int LastModifiedBy { get; set; }
        DateTime DeleteAt { get; set; }
        int DeletedBy { get; set; }
    }
}
