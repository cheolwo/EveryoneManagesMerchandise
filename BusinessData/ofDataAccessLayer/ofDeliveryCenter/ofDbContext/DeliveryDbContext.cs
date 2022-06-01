﻿using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofDbContext
{
    public class DeliveryDbContext : DbContext
    {
        public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeliveryCenterConfiguration());
            modelBuilder.ApplyConfiguration(new DCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SDCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MDCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EDCommodityConfiguration());
        }
        public class DCommodityConfiguration : CommodityConfiguration<DCommodity>
        {
            public override void Configure(EntityTypeBuilder<DCommodity> builder)
            {
                base.Configure(builder);
            }
        }
        public class DeliveryCenterConfiguration : CenterConfiguration<DeliveryCenter>
        {
            public override void Configure(EntityTypeBuilder<DeliveryCenter> builder)
            {
                base.Configure(builder);
                builder.Property(c => c.Address).HasMaxLength((int)ConstraintLength.Address);
            }
        }
        public class SDCommodityConfiguration : StatusConfiguration<SDCommodity>
        {
            public override void Configure(EntityTypeBuilder<SDCommodity> builder)
            {
                base.Configure(builder);
            }
        }
        public class MDCommodityConfiguration : StatusConfiguration<MDCommodity>
        {
            public override void Configure(EntityTypeBuilder<MDCommodity> builder)
            {
                base.Configure(builder);
            }
        }
        public class EDCommodityConfiguration : StatusConfiguration<EDCommodity>
        {
            public override void Configure(EntityTypeBuilder<EDCommodity> builder)
            {
                base.Configure(builder);
            }
        }
    }
}
