﻿using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessData.ofCommon.ofHsCode.ofDbContext
{
    public class HsDbContext : DbContext
    {
        public HsDbContext(DbContextOptions<HsDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgreetMentConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HsCodePartConfiguration());
            modelBuilder.ApplyConfiguration(new SubPartofHsCodeConfiguration());
            modelBuilder.ApplyConfiguration(new PracticalHsCodeConfiguration());
            modelBuilder.ApplyConfiguration(new ClarnaceInfoofHsCodeConfiguration());
            modelBuilder.ApplyConfiguration(new ConfirmationbythecustomsofficerConfiguration());
            modelBuilder.ApplyConfiguration(new DetailPracticalConfiguration());
        }
        public class AgreetMentConfiguration : EntityConfiguration<AgreetMent>
        {
            public override void Configure(EntityTypeBuilder<AgreetMent> builder)
            {
                base.Configure(builder);
                builder.Property(c => c.CoutryName).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            }
        }
        public class DetailPracticalConfiguration : EntityConfiguration<DetailPracticalHsCode>
        {
            public override void Configure(EntityTypeBuilder<DetailPracticalHsCode> builder)
            {
                base.Configure(builder);
            }
        }
        public class CountryConfiguration : EntityConfiguration<Country> 
        {
            public override void Configure(EntityTypeBuilder<Country> builder)
            {
                base.Configure(builder);
            }
        }
        public class ConfirmationbythecustomsofficerConfiguration : EntityConfiguration<ConfirmationByTheCustomsOfficer> 
        {
            public override void Configure(EntityTypeBuilder<ConfirmationByTheCustomsOfficer> builder)
            {
                base.Configure(builder);
            }
        }
        public class ClarnaceInfoofHsCodeConfiguration : EntityConfiguration<ClearanceInfoofHsCode>
        {
            public override void Configure(EntityTypeBuilder<ClearanceInfoofHsCode> builder)
            {
                base.Configure(builder);
                builder.Property(c => c.AgreetMentTaxRates).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<AgreetMentTaxRate>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<AgreetMentTaxRate>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            }
        }
        public class PracticalHsCodeConfiguration : EntityConfiguration<PracticalHsCode>
        {
            public override void Configure(EntityTypeBuilder<PracticalHsCode> builder)
            {
                base.Configure(builder);
            }
        }
        public class SubPartofHsCodeConfiguration : EntityConfiguration<SubPartofHsCode>
        {
            public override void Configure(EntityTypeBuilder<SubPartofHsCode> builder)
            {
                base.Configure(builder);
            }
        }
        public class HsCodePartConfiguration : EntityConfiguration<HsCodePart>
        {
            public override void Configure(EntityTypeBuilder<HsCodePart> builder)
            {
                base.Configure(builder);
            }
        }
    }
}
