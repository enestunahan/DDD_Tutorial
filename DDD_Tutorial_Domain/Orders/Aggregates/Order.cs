using DDD_Tutorial_Domain.Orders.Entities;
using DDD_Tutorial_Domain.Orders.Enums;
using DDD_Tutorial_Domain.Orders.ValueObjects;
using DDD_Tutorial_Domain.Shared.BaseClasses;
using DDD_Tutorial_Domain.Shared.Interfaces;

namespace DDD_Tutorial_Domain.Orders.Aggregates
{
    public sealed class Order : BaseEntity , IAggregateRoot
    {
        public Address Address { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
