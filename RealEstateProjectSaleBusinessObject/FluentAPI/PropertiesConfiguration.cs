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
    public class PropertiesConfiguration : IEntityTypeConfiguration<Properties>
    {
        public void Configure(EntityTypeBuilder<Properties> builder)
        {
            builder.ToTable("Properties");
            builder.HasKey(x => x.PropertiesID);
            builder.Property(x => x.Floor).IsRequired();
            builder.Property(x => x.SizeArea).IsRequired();
            builder.Property(x => x.BedRoom).IsRequired();
            builder.Property(x => x.BathRoom).IsRequired();
            builder.Property(x => x.LivingRoom).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.View);
            builder.Property(x => x.Image);
            builder.Property(x => x.ProjectID).IsRequired();
            builder.Property(x => x.PropertiesTypeID).IsRequired();
            builder.HasMany(x => x.Comments).WithOne(x => x.Properties).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
