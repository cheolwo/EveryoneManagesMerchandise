using BusinessData.ofGeneric.ofTypeConfiguration;
using BusinessData.ofHumanResource.ofRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace BusinessData.ofHR.ofDbContext
{
    // 고용계약 DB
    public class HRDbContext : DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HRCenterConfigration());
            builder.ApplyConfiguration(new HREmployeeConfigration());
            builder.ApplyConfiguration(new HRRoleConfigration());
            builder.ApplyConfiguration(new EmployeeRoleConfigration());
        }
    }
    public class HRCenterConfigration : CenterConfiguration<HRCenter>
    {
        public override void Configure(EntityTypeBuilder<HRCenter> builder)
        {
            base.Configure(builder);
        }
    }
    public class HREmployeeConfigration : EntityConfiguration<HREmployee>
    {
        public override void Configure(EntityTypeBuilder<HREmployee> builder)
        {
            base.Configure(builder);
        }
    }
    public class HRRoleConfigration : EntityConfiguration<HRRole>
    {
        public override void Configure(EntityTypeBuilder<HRRole> builder)
        {
            base.Configure(builder);
        }
    }
    public class EmployeeRoleConfigration : EntityConfiguration<EmployeeRole>
    {
        public override void Configure(EntityTypeBuilder<EmployeeRole> builder)
        {
            base.Configure(builder);
        }
    }
}