using BusinessData.ofGeneric.ofTypeConfiguration;
using BusinessData.ofGroupOrder.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofGroupOrder.ofDbContext
{
    public class GroupOrderDbContext : DbContext
    {
        private string _connectionstring;
        public GroupOrderDbContext(DbContextOptions<GroupOrderDbContext> options)
            :base(options)
        {

        }
        public GroupOrderDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.GroupOrderDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GOCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new GroupOrderCenterConfiguration());
            modelBuilder.ApplyConfiguration(new SGOCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MGOCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EGOCommodityConfiguration());
        }
    }
    public class GOCommodityConfiguration : CommodityConfiguration<GOCommodity>
    {
        public override void Configure(EntityTypeBuilder<GOCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class GroupOrderCenterConfiguration : CenterConfiguration<GroupOrderCenter>
    {
        public override void Configure(EntityTypeBuilder<GroupOrderCenter> builder)
        {
            base.Configure(builder);
        }
    }
    public class SGOCommodityConfiguration : SStatusConfiguration<SGOCommodity>
    {
        public override void Configure(EntityTypeBuilder<SGOCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MGOCommodityConfiguration : MStatusConfiguration<MGOCommodity>
    {
        public override void Configure(EntityTypeBuilder<MGOCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class EGOCommodityConfiguration : EStatusConfiguration<EGOCommodity>
    {
        public override void Configure(EntityTypeBuilder<EGOCommodity> builder)
        {
            base.Configure(builder);
        }
    }
}