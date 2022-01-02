// using Microsoft.EntityFrameworkCore;
// using System.Threading.Tasks;

// namespace BusinessData.ofTraditionalMarket.ofRepository
// {
//     public class TraditionalMarketRepository : EntityDataRepository<TraditionalMarket>
//     {
//         public TraditionalMarketRepository(BusinessDataContext businessDataContext)
//             :base(businessDataContext)
//         {

//         }
        
//         public async Task<TraditionalMarket> GetByNameAsync(string Name)
//         {
//             return await _BusinessDataContext.Set<TraditionalMarket>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
//         }

//     }

//     public class TraditionalStoreRepository : BusinessDataRepository<TraditionalStore>
//     {
//         public TraditionalStoreRepository(BusinessDataContext businessDataContext)
//             : base(businessDataContext)
//         {

//         }

//         public async Task<TraditionalStore> GetByNameAsync(string Name)
//         {
//             return await _BusinessDataContext.Set<TraditionalStore>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
//         }
//     }

//     public class TraditionalCommodityRepository : BusinessDataRepository<TraditionalCommodity>
//     {
//         public TraditionalCommodityRepository(BusinessDataContext businessDataContext)
//             : base(businessDataContext)
//         {

//         }

//         public async Task<TraditionalCommodity> GetByNameAsync(string Name)
//         {
//             return await _BusinessDataContext.Set<TraditionalCommodity>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
//         }
//     }
// }
