using BusinessData.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofIot.Model
{
    [DataContext(typeof(IotDbContext), DevelopmentDbConnetionString.IotDbConnection)]
    [Relation(typeof(TemperatureHumidity), "TH")]
    public class TemperatureHumidity : Entity
    {
        public string Humidity { get; set; }
        public string Temperature { get; set; }
    }
    public class TemperatureHumidityConfiguration : EntityConfiguration<TemperatureHumidity>
    {
        public override void Configure(EntityTypeBuilder<TemperatureHumidity> builder)
        {
            base.Configure(builder);
            builder.Ignore(e => e.ChangedUsers);
            builder.Ignore(e => e.Code);
            builder.Ignore(e => e.Container);
            builder.Ignore(e => e.Docs);
            builder.Ignore(e => e.ImageofInfos);
        }
    }
    [DataContext(typeof(IotDbContext), DevelopmentDbConnetionString.IotDbConnection)]
    [Relation(typeof(TemperatureHumidity), "BankInfo")]
    public class BankInfo : Entity
    {
       public int Money { get; set; }
    }
    public class BaknInfoConfiguration : EntityConfiguration<BankInfo>
    {
        public override void Configure(EntityTypeBuilder<BankInfo> builder)
        {
            base.Configure(builder);
            builder.Ignore(e => e.ChangedUsers);
            builder.Ignore(e => e.Code);
            builder.Ignore(e => e.Container);
            builder.Ignore(e => e.Docs);
            builder.Ignore(e => e.ImageofInfos);
        }
    }
}
