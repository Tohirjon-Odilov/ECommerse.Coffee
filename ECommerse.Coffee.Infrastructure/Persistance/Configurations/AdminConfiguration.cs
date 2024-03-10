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

            builder.HasData(new Admin()
            {
                Id = 1,
                FirstName = "Ibrohim",
                LastName = "Qosimov",
                Email = "ibrohim.qosiomov@gmail.com",
                PhoneNumber = "+9989843943489",
            });
            builder.HasData(new Admin()
            {
                Id = 2,
                FirstName = "Tohirjon",
                LastName = "Odilov",
                Email = "tohirjon-odilov@outlook.com",
                PhoneNumber = "+998999999999"
            });
            builder.HasData(new Admin()
            {
                Id = 3,
                FirstName = "Akramjon",
                LastName = "Abduvahobov",
                Email = "akramzonabduvahobov6@gmail.com",
                PhoneNumber = "+998997777777"
            });
        }
    }
}
