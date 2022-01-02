using System.Collections.Generic;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofAccount
{
    public class BusinessEmployeeDbContext : DbContext
    {
        public BusinessEmployeeDbContext(DbContextOptions<BusinessEmployeeDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessEmployeeConfiguration());
        }
    }
    public class BusinessEmployeeConfiguration : EntityConfiguration<BusinessEmployee>
    {
        public override void Configure(EntityTypeBuilder<BusinessEmployee> builder)
        {
            base.Configure(builder);
        }
    }
}