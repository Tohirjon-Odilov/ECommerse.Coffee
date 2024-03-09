using ECommerse.Coffee.Domain.Auditable;
using ECommerse.Coffee.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrderId { get; set; }
        public PaymentType PaymentType { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
    }
}
