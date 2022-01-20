using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofCommon
{
    // public class WEntityDataRepositroy<TEntity> : EntityDataRepository<TEntity> where TEntity : Entity, IRelationable, new()
    // {
    //     private readonly WarehouseDbContext _WarehouseDbContext;
    //     public WEntityDataRepositroy(WarehosueDbContext wareohuseDbConext)
    //     {
    //         if(wareohuseDbConext != null)
    //         {
    //             _WarehouseDbContext = wareohuseDbConext;
    //         }
    //     }
    //     public WEntityDataRepositroy()
    //     {
    //         _DbContext = (DbContext)Actiovator.CreateInstance(EntityDataRepository.GetDbContextType(), nentity.GetDbConnetionString());
    //     }
    // }
    public class FisheriesDbContext : DbContext
    {
        protected string _connectionstring;
        public FisheriesDbContext(DbContextOptions<FisheriesDbContext> options)
            :base(options)
        {

        }
        public FisheriesDbContext(string connectionString)
        {
            _connectionstring = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.FisheriesDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        // 이 부분에서 DotBaroce 같은 게 테이블로서 만들어지는지를 잘 모르겠어.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            modelBuilder.ApplyConfiguration(new FisheriesConfiguration());
            modelBuilder.ApplyConfiguration(new FishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SFishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MFishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EFishCommodityConfiguration());
        }
    }
    public class FisheriesConfiguration : FisheriesConfiguration
    {
        public override void Configure(EntityTypeBuilder<Fisheries> builder)
        {
            base.Configure(builder);
            builder.ToTable("Fisheries");
            // 필요없는 속성의 경우 무시할 로직을 작성할 필요가 있음.
        }
    }
    public class FishCommodityConfiguration : CommodityConfiguration<FishCommodity>
    {
        public override void Configure(EntityTypeBuilder<FishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("FishCommodity");
        }
    }
    public class SFishCommodityConfiguration : SStatusConfiguration<SFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<SFishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SFishCommodity");
        }
    }
    public class MFishCommodityConfiguration : MStatusConfiguration<MFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<MFishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MFishCommodity");
        }
    }
    public class EFishCommodityConfiguration : EStatusConfiguration<EFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<EFishCommodity> builder)
        {

            base.Configure(builder);
            builder.ToTable("EFishCommodity");
        }
    }
    
}