﻿using ECommerse.Coffee.Domain.Auditable;
using ECommerse.Coffee.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public int Quantity { get; set; }
        public OrderStatus orderStatus { get; set; }
        public virtual List<Product> Products { get; set; }

        [ForeignKey(nameof(AddressId))]
        public virtual Address Address { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }
    }
}
