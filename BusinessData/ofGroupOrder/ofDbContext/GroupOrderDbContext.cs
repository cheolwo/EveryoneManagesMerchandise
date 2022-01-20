using BusinessData.ofGeneric.ofTypeConfiguration;
using BusinessData.ofGroupOrder.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessData.ofGroupOrder.ofDbContext
{
    public class GODbContext : DbContext
    {
        private string _connectionstring;
        public GODbContext(DbContextOptions<GODbContext> options)
            :base(options)
        {

        }
        public GODbContext(string connectionstring)
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
            modelBuilder.ApplyConfiguration(new GOCCConfiguration());
            modelBuilder.ApplyConfiguration(new GOCConfiguration());
            modelBuilder.ApplyConfiguration(new SGOConfiguration());
            modelBuilder.ApplyConfiguration(new MGOConfiguration());
            modelBuilder.ApplyConfiguration(new EGOConfiguration());
        }
    }
    public class GOCCConfiguration : CommodityConfiguration<GOCC>
    {
        public override void Configure(EntityTypeBuilder<GOCC> builder)
        {
            base.Configure(builder);
            builder.ToTable("GOCCC");
        }
    }
    public class GOCConfiguration : CenterConfiguration<GOC>
    {
        public override void Configure(EntityTypeBuilder<GOC> builder)
        {
            base.Configure(builder);
            builder.ToTable("GOCC");
            builder.Property(c => c.OrderCenters).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }
    public class SGOConfiguration : SStatusConfiguration<SGOC>
    {
        public override void Configure(EntityTypeBuilder<SGOC> builder)
        {
            base.Configure(builder);
            builder.ToTable("SGOC");
        }
    }
    public class MGOConfiguration : MStatusConfiguration<MGOC>
    {
        public override void Configure(EntityTypeBuilder<MGOC> builder)
        {
            base.Configure(builder);
            builder.ToTable("MGOC");
        }
    }
    public class EGOConfiguration : EStatusConfiguration<EGOC>
    {
        public override void Configure(EntityTypeBuilder<EGOC> builder)
        {
            base.Configure(builder);
            builder.ToTable("EGOC");
        }
    }
}