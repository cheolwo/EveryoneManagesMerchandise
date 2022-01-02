// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using Newtonsoft.Json;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using BusinessData.ofCustomer;
// using BusinessData.ofMarket.ofModel;
// using BusinessData.ofTrade.ofModel;
// using BusinessData.ofWarehouse.Model;

// namespace BusinessData
// {
//     enum Length { UserId = 30 }
//     public class BusinessDataContext : DbContext
//     {
//         public BusinessDataContext(DbContextOptions<BusinessDataContext> options)
//             : base(options)
//         {

//         }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.ApplyConfiguration(new HeadMarketConfiguration());
//             modelBuilder.ApplyConfiguration(new PlatMarketConfiguration());
  
//             modelBuilder.ApplyConfiguration(new OrdererConfiguration());

//             modelBuilder.ApplyConfiguration(new TradeInfoConfiguration());
//             // modelBuilder.ApplyConfiguration(new TCommodityConfiguration());
//             modelBuilder.ApplyConfiguration(new OfficialConfiguration());

//             //modelBuilder.ApplyConfiguration(new Scommodityconfiguration());

//             // modelBuilder.ApplyConfiguration(new WCommodityConfiguration());
//             modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
    
//             modelBuilder.ApplyConfiguration(new DividedTagConfiguration());
//             modelBuilder.ApplyConfiguration(new IncomingTagConfiguration());
//             modelBuilder.ApplyConfiguration(new LoadFrameConfiguration());
//             modelBuilder.ApplyConfiguration(new EWCommodityConfiguration());
//             modelBuilder.ApplyConfiguration(new PackConfiguration());
//         }


//         // public DbSet<TraditionalStore> TraditionalStores { get; set; }
//         // public DbSet<TraditionalCommodity> TraditionalCommodities { get; set; }
//         // public DbSet<TraditionalMarket> TraditionalMarkets { get; set; }
//     }

//     /*----------------------------------------------------------------------------------------------------*/

//     public enum MaxLength { Default = 100, Id = 30 }
//     public class HeadMarketConfiguration : IEntityTypeConfiguration<Market>
//     {
//         public void Configure(EntityTypeBuilder<Market> builder)
//         {
//             builder.Property(c => c.UserId).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class MarketMetaConfiguration<T> : IEntityTypeConfiguration<T> where T : MarketMeta
//     {
//         public void Configure(EntityTypeBuilder<T> builder)
//         {
//             builder.Property(c => c.AccessKey).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.SecreatKey).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Name).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.UserId).HasMaxLength((int)MaxLength.Id);
//             builder.Property(c => c.VendorId).HasMaxLength((int)MaxLength.Id);
//         }
//     }

//     public class PlatMarketConfiguration : MarketMetaConfiguration<PlatMarket>, IEntityTypeConfiguration<PlatMarket>
//     {
//         public new void Configure(EntityTypeBuilder<PlatMarket> builder)
//         {
//             base.Configure(builder);
//         }
//     }

    

//     public class OrderConfiguration : IEntityTypeConfiguration<Order>
//     {
//         public void Configure(EntityTypeBuilder<Order> builder)
//         {
//             builder.ToTable("Order").HasKey(c => c.Id);
//             builder.Property(c => c.OrderedAt).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Quantity).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class OrdererConfiguration : IEntityTypeConfiguration<Orderer>
//     {
//         public void Configure(EntityTypeBuilder<Orderer> builder)
//         {
//             builder.ToTable("Orderer").HasKey(c => c.Id);
//             builder.Property(c => c.Name).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Email).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.SafeNumber).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.OrdererNumber).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     /*------------------------------------------- ---------------------------------------------------------*/

//     //public class Scommodityconfiguration : CommodityConfiguration<SCommodity>, IEntityTypeConfiguration<SCommodity>
//     //{
//     //    public void Configure(EntityTypeBuilder<SCommodity> builder)
//     //    {
//     //        base.Configure(builder);

//     //        builder.Property(c => c.Category).HasMaxLength((int)MaxLength.Default);
//     //        builder.Property(c => c.Url).HasMaxLength((int)MaxLength.Default);

//     //        builder.Property(c => c.ImageofInfos).HasConversion(
//     //            v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //            v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//     //        builder.Property(c => c.Options).HasConversion(
//     //             v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //             v => JsonConvert.DeserializeObject<IList<Option>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//     //        builder.Property(c => c.DetailofSCommodity).HasConversion(
//     //             v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //             v => JsonConvert.DeserializeObject<DetailofSCommodity>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//     //    }
//     //}


//     /*----------------------------------------------------------------------------------------------------*/

    
//     public class TradeInfoConfiguration : IEntityTypeConfiguration<TradeInfo>
//     {
//         public void Configure(EntityTypeBuilder<TradeInfo> builder)
//         {
//             builder.ToTable("TradeInfo").HasKey(c => c.Id);
//             builder.Property(c => c.UserId).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class OfficialConfiguration : IEntityTypeConfiguration<Official>
//     {
//         public void Configure(EntityTypeBuilder<Official> builder)
//         {
//             builder.Property(c => c.Role).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Name).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Tel).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Pax).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Address).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.NumberofCompanyRegistration).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Email).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.HomepageUrl).HasMaxLength((int)MaxLength.Default);
//         }
//     }


//     // public class TCommodityConfiguration : CommodityConfiguration<TCommodity>, IEntityTypeConfiguration<TCommodity>
//     // {
//     //     public new void Configure(EntityTypeBuilder<TCommodity> builder)
//     //     {
//     //         base.Configure(builder);
//     //         builder.ToTable("TCommodity").HasKey(c => c.Id);
           
//     //     }
//     // }

//     /*----------------------------------------------------------------------------------------------------*/

//     public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
//     {
//         public void Configure(EntityTypeBuilder<Warehouse> builder)
//         {
//             builder.Property(c => c.UserId).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Address).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     // public class DividedCommodityConfiguration : IEntityTypeConfiguration<MWCommodity>
//     // {
//     //     public void Configure(EntityTypeBuilder<MWCommodity> builder)
//     //     {
//     //         builder.Property(c => c.ImageofWCommodities).HasConversion(
//     //              v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //              v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            
//     //         builder.Property(c => c.TagofDividing).HasMaxLength((int)MaxLength.Default);

//     //          builder.Property(c => c.ImageofWCommodities).HasConversion(
//     //              v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //              v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//     //     }
//     // }

//     public class DividedTagConfiguration : IEntityTypeConfiguration<DividedTag>
//     {
//         public void Configure(EntityTypeBuilder<DividedTag> builder)
//         {
//             builder.Property(c => c.Code).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class IncomingTagConfiguration : IEntityTypeConfiguration<IncomingTag>
//     {
//         public void Configure(EntityTypeBuilder<IncomingTag> builder)
//         {
//             builder.Property(c => c.Code).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class LoadFrameConfiguration : IEntityTypeConfiguration<LoadFrame>
//     {
//         public void Configure(EntityTypeBuilder<LoadFrame> builder)
//         {
//             builder.Property(c => c.Code).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class LoadFrameTagConfiguration : IEntityTypeConfiguration<LoadFrameTag>
//     {
//         public void Configure(EntityTypeBuilder<LoadFrameTag> builder)
//         {
//             builder.Property(c => c.Code).HasMaxLength((int)MaxLength.Default);
//         }
//     }

//     public class EWCommodityConfiguration : IEntityTypeConfiguration<EWCommodity>
//     {
//         public void Configure(EntityTypeBuilder<EWCommodity> builder)
//         {
          
//         }
//     }

//     public class PackConfiguration : IEntityTypeConfiguration<Pack>
//     {
//         public void Configure(EntityTypeBuilder<Pack> builder)
//         {
//             builder.Property(c => c.Name).HasMaxLength((int)MaxLength.Default);
//             builder.Property(c => c.Material).HasMaxLength((int)MaxLength.Default);

//             builder.Property(c => c.ImagesofPack).HasConversion(
//                  v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//                  v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//         }
//     }

//     // public class WCommodityConfiguration : CommodityConfiguration<WCommodity>, IEntityTypeConfiguration<WCommodity>
//     // {
//     //     public new void Configure(EntityTypeBuilder<WCommodity> builder)
//     //     {
//     //         base.Configure(builder);
            
//     //         builder.Property(c => c.Name).HasMaxLength((int)MaxLength.Default);
//     //         builder.Property(c => c.Barcode).HasMaxLength((int)MaxLength.Default);
//     //         builder.Property(c => c.IncomingTag).HasMaxLength((int)MaxLength.Default);

//     //          builder.Property(c => c.ImageofWCommodities).HasConversion(
//     //              v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
//     //              v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
//     //     }
//     // }

// }
