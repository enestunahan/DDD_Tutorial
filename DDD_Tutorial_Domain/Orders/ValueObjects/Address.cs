using DDD_Tutorial_Domain.Shared.BaseClasses;

namespace DDD_Tutorial_Domain.Orders.ValueObjects
{
    public sealed class Address : ValueObject
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Country;
            yield return City;
            yield return Street;
            yield return PostalCode;
        }
    }
}
