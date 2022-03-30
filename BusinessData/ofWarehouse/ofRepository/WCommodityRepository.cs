using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofGenericRepository;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;

namespace BusinessData.ofWarehouse.ofRepository
{
    public class WCommodityRepository : CommodityDataRepository<WCommodity>, IWCommodityRepository, IEmployeeWCommodityRepository, IEmployerWCommodityRepository, IPlatformWCommodityRepository
    {
        public WCommodityRepository(WarehouseDbContext BusinessDataContext)
                : base(BusinessDataContext)
        {

        }

        public async Task<List<WCommodity>> GetToListByWarehouseWithStatusAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<WCommodity>()
                                                    .Include(WCommodity => WCommodity.SWCommodities)
                                                    .Include(WCommodity => WCommodity.MWCommodities)
                                                    .Include(WCommodity => WCommodity.EWCommodities)
                                                    .ToListAsync();
        } 

        public async Task<List<WCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<WCommodity>().Where(e=>e.Warehouse.Equals(warehouse)).ToListAsync();
        }
    }
}