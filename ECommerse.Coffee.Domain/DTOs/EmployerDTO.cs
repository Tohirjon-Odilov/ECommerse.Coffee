using ECommerse.Coffee.Domain.Enums;

namespace ECommerse.Coffee.Domain.DTOs
{
    public class EmployerDTO
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public long AddressId { get; set; }
        public EmpStatus empStatus { get; set; }
        public int PositionId { get; set; }
        public string Description { get; set; }
    }
}
