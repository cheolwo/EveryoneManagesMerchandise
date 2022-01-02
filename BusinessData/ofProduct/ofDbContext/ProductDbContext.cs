using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofProduct.ofDbContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCenterConfiguration());
            modelBuilder.ApplyConfiguration(new PCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLandConfiguration());
        }
    }
    public class ProductLandConfiguration : EntityConfiguration<ProductLand>
    {
        public override void Configure(EntityTypeBuilder<ProductLand> builder)
        {
            base.Configure(builder);
        }
    }
    public class PCommodityConfiguration : CommodityConfiguration<PCommodity>
    {
        public override void Configure(EntityTypeBuilder<PCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class ProductCenterConfiguration : CenterConfiguration<ProductCenter>
    {
        public override void Configure(EntityTypeBuilder<ProductCenter> builder)
        {
            base.Configure(builder);
        }
    }
    public class SPCommodityConfiguration : StatusConfiguration<SPCommodity>
    {
        public override void Configure(EntityTypeBuilder<SPCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MPCommodityConfiguration : StatusConfiguration<MPCommodity>
    {
        public override void Configure(EntityTypeBuilder<MPCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class EPCommodityConfiguration : StatusConfiguration<EPCommodity>
    {
        public override void Configure(EntityTypeBuilder<EPCommodity> builder)
        {
            base.Configure(builder);
        }
    }
}