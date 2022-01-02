using System.Collections.Generic;
using BusinessData.ofGeneric.ofTypeConfiguration;
using BusinessData.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofMarket.ofDbContext
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarketConfiguration());
            modelBuilder.ApplyConfiguration(new MCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SMCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MMCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EMCommodityConfiguration());
        }
        public DbSet<PlatMarket> PlatMarkets {get; set;}
    }
    public class MCommodityConfiguration : CommodityConfiguration<MCommodity>
    {
        public override void Configure(EntityTypeBuilder<MCommodity> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Options).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Option>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
    public class MarketConfiguration : CenterConfiguration<Market>
    {
        public override void Configure(EntityTypeBuilder<Market> builder)
        {
            base.Configure(builder);
        }
    }
    public class SMCommodityConfiguration : StatusConfiguration<SMCommodity>
    {
        public override void Configure(EntityTypeBuilder<SMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MMCommodityConfiguration : StatusConfiguration<MMCommodity>
    {
        public override void Configure(EntityTypeBuilder<MMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class EMCommodityConfiguration : StatusConfiguration<EMCommodity>
    {
        public override void Configure(EntityTypeBuilder<EMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
}