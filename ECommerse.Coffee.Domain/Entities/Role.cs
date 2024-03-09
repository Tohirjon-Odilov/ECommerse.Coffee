using ECommerse.Coffee.Domain.Auditable;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Permission> Permissions { get; set; }
    }
}
