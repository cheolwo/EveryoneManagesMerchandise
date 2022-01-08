namespace BusinessData.ofCommon.ofKamis.ofDbContext
{
    public class KamisDbContext : DbContext
    {
        private string _connectionstring;
        public KamisDbContext(DbContextOptions<KamisDbContext> options)
            : base(options)
        {

        }
        public KamisDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.KamisDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}