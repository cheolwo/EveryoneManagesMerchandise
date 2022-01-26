using BusinessData.ofAccount.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using BusinessData.ofGeneric.ofTypeConfiguration;

namespace BusinessData.ofAccount
{
    public class BusinessUserDbContext : DbContext
    {
        private string _connectionstring;
        public BusinessUserDbContext(DbContextOptions<BusinessUserDbContext> options)
            :base(options)
        {

        }
        public BusinessUserDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.BusinessUserDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessUserConfiguration());
            modelBuilder.ApplyConfiguration(new JournalSettingConfiguration());
            modelBuilder.ApplyConfiguration(new PayServiceConfiguration());
            modelBuilder.ApplyConfiguration(new TableSettingConfiguration());
        }
    }
    public class BusinessUserConfiguration : EntityConfiguration<BusinessUser>
    {
        public override void Configure(EntityTypeBuilder<BusinessUser> builder)
        {
        }
    }
    public class JournalSettingConfiguration : EntityConfiguration<JournalSetting>
    {
        public override void Configure(EntityTypeBuilder<JournalSetting> builder)
        {
            builder.Property(c => c.Debits).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            builder.Property(c => c.Credits).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            builder.Ignore(c => c.Container);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.UserId);
        }
    }
    public class PayServiceConfiguration : EntityConfiguration<PayService>
    {
        public override void Configure(EntityTypeBuilder<PayService> builder)
        {
            builder.Ignore(c => c.Container);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.UserId);
        }
    }
    /*
     * Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageofInfos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docs = table.Column<string>(type: "nvarchar(max)", nullable: true)
     */
    public class TableSettingConfiguration : EntityConfiguration<TableSetting>
    {
        public override void Configure(EntityTypeBuilder<TableSetting> builder)
        {
            builder.Ignore(c => c.Container);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.UserId);
            builder.Property(c => c.GetColumnsSelected).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            builder.Property(c => c.DetailColumnsSelected).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }
}
