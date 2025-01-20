using DDD_Tutorial_Domain.Orders.Aggregates;
using DDD_Tutorial_Domain.Shared.BaseClasses;

namespace DDD_Tutorial_Domain.Orders.Entities
{
    public sealed class OrderItem : BaseEntity
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
