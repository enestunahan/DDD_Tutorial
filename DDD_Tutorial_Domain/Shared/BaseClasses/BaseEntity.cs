using DDD_Tutorial_Domain.Shared.Interfaces;

namespace DDD_Tutorial_Domain.Shared.BaseClasses
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
