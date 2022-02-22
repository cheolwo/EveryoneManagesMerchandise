using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofSmartFarm
{
    // 일단 이것에 대한 WebAPI 컨트롤러를 우선적으로 만들어야겠다.
    public class SmartFarmDbContext : DbContext
    {
        private string _connectionstring;
        public SmartFarmDbContext(DbContextOptions<SmartFarmDbContext> options)
            : base(options)
        {

        }
        public SmartFarmDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.SmartFarmDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SmartFarmConfiguration());
            modelBuilder.ApplyConfiguration(new FarmCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EFarmCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MFarmCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EFarmCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new FarmControllerConfiguration());
            modelBuilder.ApplyConfiguration(new ControllerCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SControllerValueConfiguration());
            modelBuilder.ApplyConfiguration(new MControllerValueConfiguration());
            modelBuilder.ApplyConfiguration(new EControllerValueConfiguration());
        }
    }
    public class SmartFarmConfiguration : CenterConfiguration<SmartFarm>
    {
        public override void Configure(EntityTypeBuilder<SmartFarm> builder)
        {
            base.Configure(builder);
            builder.ToTable("SmartFarm");
        }
    }
    public class FarmCommodityConfiguration  : CommodityConfiguration<FarmCommodtiy>
    {
        public override void Configure(EntityTypeBuilder<FarmCommodtiy> builder)
        {
            base.Configure(builder);
            builder.ToTable("FarmCommodity");
            builder.HasOne(e => e.ControllerCommodity).WithOne(e => e.FarmCommodtiy).HasForeignKey<ControllerCommodity>(e => e.FarmCommodtiyId);
        }
    }
    public class SFarmCommodityConfiguration : StatusConfiguration<SFarmCommodity>
    {
        public override void Configure(EntityTypeBuilder<SFarmCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SFarmCommodity");
        }
    }
    public class MFarmCommodityConfiguration : StatusConfiguration<MFarmCommodity>
    {
        public override void Configure(EntityTypeBuilder<MFarmCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MFarmCommodity");
        }
    }
    public class EFarmCommodityConfiguration : StatusConfiguration<EFarmCommodity>
    {
        public override void Configure(EntityTypeBuilder<EFarmCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("EFarmCommodity");
        }
    }
    public class FarmControllerConfiguration : EntityConfiguration<FarmController>
    {
        public override void Configure(EntityTypeBuilder<FarmController> builder)
        {
            base.Configure(builder);
            builder.HasOne(e => e.ControllerCommodity).WithOne(e => e.FarmController).HasForeignKey<ControllerCommodity>(e => e.FarmCommodtiyId);
        }
    }
    public class ControllerCommodityConfiguration : EntityConfiguration<ControllerCommodity>
    {
        public override void Configure(EntityTypeBuilder<ControllerCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class SControllerValueConfiguration : EntityConfiguration<SControllerValue>
    {
        public override void Configure(EntityTypeBuilder<SControllerValue> builder)
        {
            base.Configure(builder);
        }
    }
    public class MControllerValueConfiguration : EntityConfiguration<MControllerValue>
    {
        public override void Configure(EntityTypeBuilder<MControllerValue> builder)
        {
            base.Configure(builder);
        }
    }
    public class EControllerValueConfiguration : EntityConfiguration<EControllerValue>
    {
        public override void Configure(EntityTypeBuilder<EControllerValue> builder)
        {
            base.Configure(builder);
        }
    }
}