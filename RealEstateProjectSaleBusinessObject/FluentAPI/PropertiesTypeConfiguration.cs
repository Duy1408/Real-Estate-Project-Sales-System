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
    public class PropertiesTypeConfiguration : IEntityTypeConfiguration<PropertiesType>
    {
        public void Configure(EntityTypeBuilder<PropertiesType> builder)
        {
            builder.ToTable("PropertiesType");
            builder.HasKey(x => x.PropertiesTypeID);
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x => x.Properties).WithOne(x => x.PropertiesType).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.PromotionDetails).WithOne(x => x.PropertiesType).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
