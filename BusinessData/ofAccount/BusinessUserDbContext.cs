using BusinessData.ofAccount.ofModel;
using BusinessData.ofGeneric.ofTypeConfiguration.ofAccount;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofAccount
{
    // 사업자 계정 DB
    public class EmployerIdentityDbContext : IdentityDbContext
    {
        public EmployerIdentityDbContext(DbContextOptions<EmployerIdentityDbContext> options)
            :base(options)
        {

        }
    }

    // 근로자 계정 DB
    public class EmployeeIdentityDbContext : IdentityDbContext
    {
        public EmployeeIdentityDbContext(DbContextOptions<EmployeeIdentityDbContext> options)
            :base(options)
        {

        }
    }
    
    // 사업자 인력관리 DB
    public class EmployerEmployeeIdentityDbContextg : IdentityDbContext
    {
        public EmployerEmployeeIdentityDbContextg(DbContextOptions<EmployerEmployeeIdentityDbContextg> options)
            :base(options)
        {

        }
    }
   
    public class BusinessUserDbContext : DbContext
    {
        public BusinessUserDbContext(DbContextOptions<BusinessUserDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessUserConfiguration());
        }
    }
    public class BusinessUserConfiguration : BusinessAccountEntityConfiguration<BusinessUser>
    {
        public override void Configure(EntityTypeBuilder<BusinessUser> builder)
        {
            base.Configure(builder);
        }
    }
    // public class AccountDbContext : IdentityDbContext<BusinessUser>
    // {
    //     public AccountDbContext(DbContextOptions<AccountDbContext> options)
    //         :base(options)
    //     {

    //     }
    //     protected override void OnModelCreating(ModelBuilder builder)
    //     {
    //         base.OnModelCreating(builder);
    //         builder.ApplyConfiguration(new BusinessUserConfiguration());
    //     }
    // }
    // public class BusinessUserConfiguration : IEntityTypeConfiguration<BusinessUser>
    // {
    //     public void Configure(EntityTypeBuilder<BusinessUser> builder)
    //     {
    //         builder.Property(c => c.JournalSettings).HasConversion(
    //               v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
    //               v => JsonConvert.DeserializeObject<IList<JournalSetting>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
    //         builder.Property(c => c.PayServices).HasConversion(
    //               v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
    //               v => JsonConvert.DeserializeObject<IList<PayService>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
   
    //     }
    // }
}
