using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofGenericRepository;
using System;

namespace BusinessData.ofWarehouse.ofRepository
{
    public interface IWarehouseRepository : ICenterDataRepository<Warehouse>
    {
        Task<Warehouse> GetRelatedData(Warehouse warehouse);
    }
    public interface IWCommodityRepository : ICommodityDataRepository<WCommodity>
    {

    }
    public interface ISWCommodityRepository : IStatusDataRepository<SWCommodity>
    {

    }
    public interface IMWCommodityRepository : IStatusDataRepository<MWCommodity>
    {

    }
    public interface IEWCommodityRepository : IStatusDataRepository<EWCommodity>
    {

    }
    public class WarehouseRepository : CenterDataRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public async Task<List<Warehouse>> GetToListByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<Warehouse>().Where(e => e.UserId.Equals(UserId)).ToListAsync();
        }

        public async Task<List<Warehouse>> GetToListByUserIdWithWCommodityAsync(string UserId)
        {
            List<Warehouse> Warehouses = await _DbContext.Set<Warehouse>()
                                            .Where(e => e.UserId.Equals(UserId))
                                            .Include(Warehouse => Warehouse.WCommodities)
                                            .ToListAsync();
            return Warehouses;
        }
        public new async Task<Warehouse> GetByNameAsync(string Name)
        {
            return await _DbContext.Set<Warehouse>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
        }

        public async Task<Warehouse> GetRelatedData(Warehouse warehouse)
        {
            if (warehouse != null)
            {
                Warehouse WithRelatedWarehouse = await _DbContext.Set<Warehouse>()
                                                .Where(e => e.Id.Equals(warehouse.Id))
                                                .Include(Warehouse => Warehouse.WCommodities)
                                                .Include(Warehouse => Warehouse.SWCommodities)
                                                .Include(Warehouse => Warehouse.MWCommodities)
                                                .Include(Warehouse => Warehouse.EWCommodities)
                                                .Include(Warehouse => Warehouse.LoadFrames)
                                                .Include(Warehouse => Warehouse.DotBarcodes)
                                                .Include(Warehouse => Warehouse.WorkingDesks)
                                                .Include(Warehouse => Warehouse.DividedTags)
                                                .Include(Warehouse => Warehouse.IncomingTags).FirstOrDefaultAsync();

                return WithRelatedWarehouse;
            }
            else {throw new ArgumentNullException();}
        }
    }

    public class SWCommodityRepository : StatusDataRepository<SWCommodity>, ISWCommodityRepository
    {
        public SWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }

        public async Task<List<SWCommodity>> GetToListByWCommodityWithStatusAsync(WCommodity wCommodity)
        {
            List<SWCommodity> SWCommodities = await _DbContext.Set<SWCommodity>()
                                                        .Include(SWCommodity => SWCommodity.MWCommodities)
                                                        .ThenInclude(MWCommodity => MWCommodity.EWCommodities)
                                                        .ToListAsync();
            return SWCommodities;
        }

        public async Task<List<SWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<SWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }

    }

    public class MWCommodityRepository : StatusDataRepository<MWCommodity>, IMWCommodityRepository
    {
        public MWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public async Task<List<MWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<MWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }

    }

    public class EWCommodityRepository : StatusDataRepository<EWCommodity>, IEWCommodityRepository
    {
        public EWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public async Task<List<EWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<EWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }
    }
    public interface IWorkingDeskRepository : IEntityDataRepository<WorkingDesk>
    {

    }
    public class WorkingDeskRepository : EntityDataRepository<WorkingDesk>
    {
        public WorkingDeskRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
    public interface IDotBarcodeRepository : IEntityDataRepository<DotBarcode>
    {

    }
    public class DotBarcodeRepository : EntityDataRepository<DotBarcode>
    {
        public DotBarcodeRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }

}