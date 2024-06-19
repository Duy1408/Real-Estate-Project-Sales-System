using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.FluentAPI
{
    public class BookingPaymentConfiguration : IEntityTypeConfiguration<BookingPayment>
    {
        public void Configure(EntityTypeBuilder<BookingPayment> builder)
        {
            builder.ToTable("BookingPayment");
            builder.HasKey(x => x.BookingPaymentID);
            builder.Property(x => x.CustomerID).IsRequired();
            builder.Property(x => x.PaymentTypeID).IsRequired();
            builder.Property(x => x.ProjectID).IsRequired();
            builder.Property(x => x.Deposittoholdproject).IsRequired();
            builder.Property(x => x.Status).IsRequired();

        }
    }
}
