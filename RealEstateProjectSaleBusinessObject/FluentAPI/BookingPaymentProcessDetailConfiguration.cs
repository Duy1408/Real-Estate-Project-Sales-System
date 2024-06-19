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
    public class BookingPaymentProcessDetailConfiguration : IEntityTypeConfiguration<BookingPaymentProcessDetail>
    {
        public void Configure(EntityTypeBuilder<BookingPaymentProcessDetail> builder)
        {
            builder.ToTable("BookingPaymentProcessDetail");
            builder.HasKey(x => x.BookingPaymentProcessDetailID);
            builder.Property(x => x.BookingID).IsRequired();
            builder.Property(x => x.Paymentprogress).IsRequired();
            builder.Property(x => x.Paymentduedate).IsRequired();
            builder.Property(x => x.Customervaluepaid).IsRequired();
            builder.Property(x => x.Note);

        }
    }
}
