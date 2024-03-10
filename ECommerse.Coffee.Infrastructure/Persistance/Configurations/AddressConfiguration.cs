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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.Street)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.City)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p=>p.HomeNumber)
                .IsRequired();
            builder.Property(p=>p.Region)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.Description)
                .IsRequired(false)
                .HasMaxLength(70);
        }
    }
}
