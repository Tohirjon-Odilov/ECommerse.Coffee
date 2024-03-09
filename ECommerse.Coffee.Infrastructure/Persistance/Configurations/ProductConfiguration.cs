using ECommerse.Coffee.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Infrastructure.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(35)
                .IsRequired();
            builder.Property(p => p.Description)
                .HasMaxLength(150);


            builder.HasData(new Product()
            {
                Id = 1,
                Name = "Americano",
                CategoryId = 1,
                Price = 15000,
                PicturePath = @"\images\americano.jpg",
                Description = "Haqiyqiy Amerikancha ta'm\nHajm: 600 ml"
            });
        }
    }
}
