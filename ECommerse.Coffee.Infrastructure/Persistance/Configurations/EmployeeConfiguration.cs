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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(p => p.Email)
                .IsRequired().
                HasMaxLength(50);
            builder.Property(p=>p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p=>p.Description)
                .IsRequired(false)
                .HasMaxLength(120);
            builder.Property(p => p.Login)
                .IsRequired();
        }
    }
}
