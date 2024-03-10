using ECommerse.Coffee.Domain.Auditable;
using ECommerse.Coffee.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Employee : AudiTable
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public long AddressId { get; set; }
        public EmpStatus empStatus { get; set; }
        public int PositionId { get; set; }
        public string Description { get; set; }
        
        [ForeignKey(nameof(PositionId))]
        public virtual Role Role { get; set; }

        [ForeignKey(nameof(AddressId))]
        public virtual Address Address { get; set; }
    }
}
