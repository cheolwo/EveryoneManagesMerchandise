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
            modelBuilder.ApplyConfiguration(new KamisSubCountryAdministrationPartConfiguration());
            modelBuilder.ApplyConfiguration(new KamisMarketConfiguration());
            modelBuilder.ApplyConfiguration(new KamisDayPriceConfiguration());
        }
    }
    
    public class KamisEntityConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : KamisEntity
    {
        protected override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamisPartConfiguration : KamisEntityConfiguration<KamisPart>
    {
        protected override void Configure(EntityTypeBuilder<KamisPart> builder)
        {
            base.Configure(builder);
        }
    }
    public class KamsiCommodityConfiguration : KamisEntityConfiguration<KamisCommodity>
    {
        protected override void Configure(EntityTypeBuilder<KamisCommodity> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.KamisPart).HasMany(c => c.KamisCommodityCodes).HasForeignKey(p => p.KamisPartId);
        }
    }
    public class KamisKindofCommodityConfiguration : KamisEntityConfiguration<KamisKindofCommodity>
    {
        protected override void Configure(EntityTypeBuilder<KamisKindofCommodity> builder)
        {
            base.Configure(builder);
            builder.HasOne(c => c.KamisCommodity).HasMany(k => k.KamisKindsofCommodity).HasForeignKey(c => c.KamisCommodityId);         
            builder.Property(c => c.WholeSaleGrades).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            builder.Property(c => c.RetailSaleGrades).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            builder.Property(c => c.EcoFriendlyGrades).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<KamisGrade>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<KamisGrade>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }
    public class KamisCountryAdministrationPartConfiguration : KamisEntityConfiguration<KamisCountryAdministrationPart>
    {
        protected override void Configure(EntityTypeBuilder<KamisCountryAdministrationPart> builder)
        {
            base.Configure(builder);
        }
    }
    public class KamisSubCountryAdministrationPartConfiguration : KamisEntityConfiguration<KamisSubCountryAdministrationPart>
    {
        protected override void Configure(EntityTypeBuilder<KamisSubCountryAdministrationPart> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.KamisCountryAdministrationPart).WithMany(m => m.KamisSubCountryAdministrationParts).HasForeignKey(o => o.KamisCountryAdministrationPartId);
        }
    }
    public class KamisMarketConfiguration : KamisEntityConfiguration<KamisMarket>
    {
        protected override void Configure(EntityTypeBuilder<KamisMarket> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.KamisSubCountryAdministrationPart).WithMany(m => m.KamisMarkets).HasForeignKey(o => o.KamisSubCountryAdministrationPartId);
        }
    }
    public class KamisDayPriceConfiguration : KamisEntityConfiguration<KamisDayPrice>
    {
        protected override void Configure(EntityTypeBuilder<KamisDayPrice> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.KamisMarket).WithMany(m => m.KamisDayPrices).HasForeignKey(o => o.KamisMarketId);
            builder.HasOne(o => o.KamisKindofCommodity).WithMany(m => m.KamisDayPrices).HasForeignKey(o => o.KamisKindofCommodityId);
        }
    }
    
}