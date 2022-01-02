using System.Collections.Generic;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofGeneric.ofTypeConfiguration.ofAccount;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofAccount
{
    public class EmployeeUserDbContext : DbContext
    {
        public EmployeeUserDbContext(DbContextOptions<EmployeeUserDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeUserConfiguration());
        }
    }
    public class EmployeeUserConfiguration : EmployeeAccountEntityConfiguration<EmployeeUser>
    {
        public override void Configure(EntityTypeBuilder<EmployeeUser> builder)
        {
            base.Configure(builder);
        }
    }
}