using ECommerse.Coffee.Domain.Auditable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name {  get; set; }
        public virtual List<Permission> Permissions { get; set; }
    }
}
