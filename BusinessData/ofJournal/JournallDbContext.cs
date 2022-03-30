using System.Collections.Generic;
using BusinessData.ofFinancial.Model;
using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofFinancial
{
    public class JournalDbContext : DbContext
    {
        public JournalDbContext(DbContextOptions<JournalDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<JournalCenter>(new JournalCenterConfiguration());
            modelBuilder.ApplyConfiguration<JCommodity>(new JCommodityConfiguration());
            modelBuilder.ApplyConfiguration<Journal>(new JournalConfiguration());
            modelBuilder.ApplyConfiguration<UserSettingJournal>(new UserSettingJournalConfiguration());
        }
    }
    public class UserSettingJournalConfiguration : EntityConfiguration<UserSettingJournal>
    {
        public override void Configure(EntityTypeBuilder<UserSettingJournal> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Debits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Debit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.Credits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Credit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
    public class JCommodityConfiguration : CommodityConfiguration<JCommodity>
    {
        public override void Configure(EntityTypeBuilder<JCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class JournalCenterConfiguration : CenterConfiguration<JournalCenter>
    {
        public override void Configure(EntityTypeBuilder<JournalCenter> builder)
        {
            base.Configure(builder);
        }
    }
    public class JournalConfiguration : EntityConfiguration<Journal> 
    {
        public override void Configure(EntityTypeBuilder<Journal> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Debits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Debit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.Credits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Credit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            
        }
    }
}

