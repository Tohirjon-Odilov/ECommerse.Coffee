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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(p => p.FirstName)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(p => p.Login)
                .IsRequired();
        }
    }
}
