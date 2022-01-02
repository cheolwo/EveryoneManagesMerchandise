using BusinessData.ofGeneric.ofTypeConfiguration;
using BusinessData.ofTrade.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofTrade.ofDbContext
{
    public class TradeDbContext : DbContext
    {
        public TradeDbContext(DbContextOptions<TradeDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TradeCenterConfiguration());
            modelBuilder.ApplyConfiguration(new TCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new STCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MTCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new ETCommodityConfiguration());
        }
    }
    public class TCommodityConfiguration : CommodityConfiguration<TCommodity>
    {
        public override void Configure(EntityTypeBuilder<TCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class TradeCenterConfiguration : CenterConfiguration<TradeCenter>
    {
        public override void Configure(EntityTypeBuilder<TradeCenter> builder)
        {
            base.Configure(builder);
        }
    }
    public class STCommodityConfiguration : StatusConfiguration<STCommodity>
    {
        public override void Configure(EntityTypeBuilder<STCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MTCommodityConfiguration : StatusConfiguration<MTCommodity>
    {
        public override void Configure(EntityTypeBuilder<MTCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class ETCommodityConfiguration : StatusConfiguration<ETCommodity>
    {
        public override void Configure(EntityTypeBuilder<ETCommodity> builder)
        {
            base.Configure(builder);
        }
    }
}