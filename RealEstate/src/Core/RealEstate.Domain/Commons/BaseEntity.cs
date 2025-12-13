namespace RealEstate.Domain.Commons
{
    public class BaseEntity<T> : AutibleEntity
        where T : unmanaged
    {
        public T Id { get; set; }

    }
}
