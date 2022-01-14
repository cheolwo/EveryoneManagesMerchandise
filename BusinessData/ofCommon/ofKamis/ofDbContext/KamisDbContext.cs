using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofCommon.ofKamis.ofDbContext
{
    public class KamisDbContext : DbContext
    {
        private string _connectionstring;
        public KamisDbContext(DbContextOptions<KamisDbContext> options)
            : base(options)
        {

        }
        public KamisDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.KamisDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KamisPartConfiguration());
            modelBuilder.ApplyConfiguration(new KamsiCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new KamisKindofCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new KamisCountryAdministrationPartConfiguration());
            modelBuilder.ApplyConfiguration(new KamisMarketConfiguration());
            modelBuilder.ApplyConfiguration(new KamisDayPriceConfiguration());
            modelBuilder.ApplyConfiguration(new KamisGradeConfiguration());
        }
    }
    
    public class KamisEntityConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : KamisEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamisPartConfiguration : KamisEntityConfiguration<KamisPart>
    {
        public override void Configure(EntityTypeBuilder<KamisPart> builder)
        {
            base.Configure(builder);
        }
    }
    public class KamisGradeConfiguration : KamisEntityConfiguration<KamisGrade>
    {
        public override void Configure(EntityTypeBuilder<KamisGrade> builder)
        {
            base.Configure(builder);
        }
    }
    public class KamsiCommodityConfiguration : KamisEntityConfiguration<KamisCommodity>
    {
        public override void Configure(EntityTypeBuilder<KamisCommodity> builder)
        {
            base.Configure(builder);
            object p = builder.HasOne(p => p.KamisPart).WithMany(c => c.KamisCommodities).HasForeignKey(p => p.KamisPartId);
        }
    }
    public class KamisKindofCommodityConfiguration : KamisEntityConfiguration<KamisKindofCommodity>
    {
        public override void Configure(EntityTypeBuilder<KamisKindofCommodity> builder)
        {
            base.Configure(builder);
            builder.HasOne(c => c.KamisCommodity).WithMany(k => k.KamisKindsofCommodity).HasForeignKey(c => c.KamisCommodityId);         
            //builder.Property(c => c.WholeSaleGrades).HasConversion(
            //     v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
            //     c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            //c => c.ToList()));
            //builder.Property(c => c.RetailSaleGrades).HasConversion(
            //     v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
            //     c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            //c => c.ToList()));
            //builder.Property(c => c.EcoFriendlyGrades).HasConversion(
            //     v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
            //     new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
            //     c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            //c => c.ToList()));
        }
    }
    public class KamisCountryAdministrationPartConfiguration : KamisEntityConfiguration<KamisCountryAdministrationPart>
    {
        public override void Configure(EntityTypeBuilder<KamisCountryAdministrationPart> builder)
        {
            base.Configure(builder);
        }
    }
    public class KamisMarketConfiguration : KamisEntityConfiguration<KamisMarket>
    {
        public override void Configure(EntityTypeBuilder<KamisMarket> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.KamisCountryAdministrationPart).WithMany(m => m.KamisMakrets).HasForeignKey(o => o.KamisCountryAdministrationPartId);
        }
    }
    public class KamisDayPriceConfiguration : KamisEntityConfiguration<KamisDayPrice>
    {
        public override void Configure(EntityTypeBuilder<KamisDayPrice> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.KamisMarket).WithMany(m => m.KamisDaysPrices).HasForeignKey(o => o.KamisMarketId);
            builder.HasOne(o => o.KamisKindofCommodity).WithMany(m => m.KamisDayPrices).HasForeignKey(o => o.KamisKindofCommodityId);
        }
    }
    
}