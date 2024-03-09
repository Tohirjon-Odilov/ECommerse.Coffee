using ECommerse.Coffee.Domain.Auditable;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string PicturePath { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
    }
}
