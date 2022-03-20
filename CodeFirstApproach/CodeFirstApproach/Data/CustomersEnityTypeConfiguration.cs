using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Data
{
    public class CustomersEnityTypeConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("Tbl_Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.CustomerName).HasMaxLength(50);

            builder.HasOne(x => x.Users)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.UserId);
        }
    }
}
