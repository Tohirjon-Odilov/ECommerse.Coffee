using ECommerse.Coffee.Domain.Auditable;
using ECommerse.Coffee.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public required string Phone { get; set; }
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
