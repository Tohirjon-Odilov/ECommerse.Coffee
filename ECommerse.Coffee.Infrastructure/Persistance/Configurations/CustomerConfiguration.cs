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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Email)
                .IsRequired();
            builder.Property(p => p.PhoneNumber)
                .IsRequired(true)
                .HasMaxLength(15);
            builder.Property(p => p.Login)
                .IsRequired();
        }
    }
}
