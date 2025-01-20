using DDD_Tutorial_Domain.Shared.BaseClasses;

namespace DDD_Tutorial_Domain.Shipments.Entities
{
    public class ShipmentDetail : BaseEntity
    {
        public DateTime EstimatedDeliveryDate { get;  set; }
        public double Weight { get;  set; }  
    }
}
