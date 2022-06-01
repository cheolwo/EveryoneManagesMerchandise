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
        private string _connectionstring;
        public HRDbContext(DbContextOptions<HRDbContext> options)
            : base(options)
        {

        }
        public HRDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.HRDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HRCenterConfigration());
            builder.ApplyConfiguration(new HREmployeeConfigration());
            builder.ApplyConfiguration(new HRRoleConfigration());
            builder.ApplyConfiguration(new EmployeeRoleConfigration());
            builder.ApplyConfiguration(new HRBusinessPartConfigration());
        }
    }
    public class HRCenterConfigration : CenterConfiguration<HRCenter>
    {
        public override void Configure(EntityTypeBuilder<HRCenter> builder)
        {
            base.Configure(builder);
            builder.ToTable("HRCenter");
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
    public class HRBusinessPartConfigration : EntityConfiguration<HRBusinessPart>
    {
        public override void Configure(EntityTypeBuilder<HRBusinessPart> builder)
        {
            base.Configure(builder);
        }
    }
}