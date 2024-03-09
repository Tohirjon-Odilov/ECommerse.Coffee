using ECommerse.Coffee.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerse.Coffee.Domain.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
    }
}
