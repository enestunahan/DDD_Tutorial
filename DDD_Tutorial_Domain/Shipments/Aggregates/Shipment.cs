using DDD_Tutorial_Domain.Shared.BaseClasses;
using DDD_Tutorial_Domain.Shared.Interfaces;
using DDD_Tutorial_Domain.Shipments.Entities;
using DDD_Tutorial_Domain.Shipments.Enums;

namespace DDD_Tutorial_Domain.Shipments.Aggregates
{
    // sevkiyat
    public sealed class Shipment : BaseEntity, IAggregateRoot
    {
        public ShipmentStatus Status { get; set; }
        public string CarrierName { get; set; }
        public ShipmentDetail Detail { get; set; }
    }
}
