using ECommerse.Coffee.Domain.Auditable;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Admin : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
