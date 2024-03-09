using ECommerse.Coffee.Domain.Auditable;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public string Description { get; set; }

    }
}
