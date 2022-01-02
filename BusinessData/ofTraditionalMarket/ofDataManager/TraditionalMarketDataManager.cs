// using BusinessData.ofTraditionalMarket.ofRepository;
// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// namespace BusinessData.ofTraditionalMarket.ofDataManager
// {
//     public class TraditionalMarketDataManager
//     {
//         private readonly TraditionalMarketRepository _traditionalMarketRepository;
//         private readonly TraditionalCommodityRepository _traditionalCommodityRepository;
//         private readonly TraditionalStoreRepository _traditionalStoreRepository;

//         public TraditionalMarketDataManager(TraditionalMarketRepository traditionalMarketRepository,
//                                             TraditionalCommodityRepository traditionalCommodityRepository,
//                                             TraditionalStoreRepository traditionalStoreRepository)
//         {
//             _traditionalMarketRepository = traditionalMarketRepository;
//             _traditionalStoreRepository = traditionalStoreRepository;
//             _traditionalCommodityRepository = traditionalCommodityRepository;
//         }      
        
//         public async Task<TraditionalMarket> GetMarketByNameAsync(string Name)
//         {
//             TraditionalMarket traditionalMarket = await _traditionalMarketRepository.GetByNameAsync(Name);

//             if(traditionalMarket != null)
//             {
//                 return traditionalMarket;
//             }
//             throw new ArgumentException("Traditional Market is Null");
//         }

//         public async Task<List<TraditionalMarket>> GetMarketToListAsync()
//         {
//            return await _traditionalMarketRepository.GetToListAsync();
//         }

//         public async Task<List<TraditionalCommodity>> GetTraditionalCommodityToListAsync()
//         {
//             return await _traditionalCommodityRepository.GetToListAsync();
//         }

//         public async Task<List<TraditionalStore>> GetTraditionalStoresAsync()
//         {
//             return await _traditionalStoreRepository.GetToListAsync();
//         }
//     }
// }
