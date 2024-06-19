﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateProjectSaleBusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.FluentAPI
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Booking");
            builder.HasKey(x => x.BookingID);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Dateofsignature).IsRequired();
            builder.Property(x => x.BookingFile).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.HasOne(x => x.Contract);
            builder.HasOne(x => x.Properties);

            builder.HasMany(x => x.BookingPayments).WithOne(x => x.Booking).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.BookingPaymentProcessDetails).WithOne(x => x.Booking).OnDelete(DeleteBehavior.NoAction);





        }
    }
}
