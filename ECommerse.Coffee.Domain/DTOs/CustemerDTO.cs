using ECommerse.Coffee.Domain.Enums;

namespace ECommerse.Coffee.Domain.DTOs
{
    public class CustemerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
