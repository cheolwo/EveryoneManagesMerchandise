using BusinessData.ofIot.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofIot
{
    public class IotDbContext : DbContext
    {
        private string _connectionstring;
        public IotDbContext(DbContextOptions<IotDbContext> options)
            : base(options)
        {

        }
        public IotDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.IotDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TemperatureHumidityConfiguration());
            modelBuilder.ApplyConfiguration(new BaknInfoConfiguration());
        }
    }
}
