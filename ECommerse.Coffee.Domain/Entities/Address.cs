using ECommerse.Coffee.Domain.Auditable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }

    }
}
