namespace BusinessData.ofSmartFarm
{
    // 일단 이것에 대한 WebAPI 컨트롤러를 우선적으로 만들어야겠다.
    public class SmartFarmDbContext : DbContext
    {
        private string _connectionstring;
        public SmartFarmDbContext(DbContextOptions<SmartFarmDbContext> options)
            : base(options)
        {

        }
        public SmartFarmDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.SmartFarmDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CenterFarmConfiguraion());
            modelBuilder.ApplyConfiguration(new CensorControllerConfiguraion());
            modelBuilder.ApplyConfiguration(new ControllerValueConfiguraion());
        }
    }
    public class CenterFarmConfiguraion : EntityConfiguration<CenterFarm>
    {
        public override void Configure(EntityTypeBuilder<CenterFarm> builder)
        {
            base.Configure(builder);
        }
    }
    public class CensorControllerConfiguraion : EntityConfiguration<CensorController>
    {
        public override void Configure(EntityTypeBuilder<CensorController> builder)
        {
            base.Configure(builder);
        }
    }
    public class ControllerValueConfiguraion : EntityConfiguration<ControllerValue>
    {
        public override void Configure(EntityTypeBuilder<ControllerValue> builder)
        {
            base.Configure(builder);
        }
    }
}