using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofGenericRepository;
using System;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;

namespace BusinessData.ofWarehouse.ofRepository
{
    public class WarehouseRepository : CenterDataRepository<Warehouse>, IWarehouseRepository, IEmployeeWarehouseRepository, IEmployerWarehouseRepository, IPlatformWarehouseRepository 
    {
        public WarehouseRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

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

    public class SWCommodityRepository : StatusDataRepository<SWCommodity>, ISWCommodityRepository, IEmployeeSWCommodityRepository, IEmployerSWCommodityRepository, IPlatformSWCommodityRepository
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

    public class MWCommodityRepository : StatusDataRepository<MWCommodity>, IMWCommodityRepository, IEmployeeMWCommodityRepository, IEmployerMWCommodityRepository, IPlatformMWCommodityRepository
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

    public class EWCommodityRepository : StatusDataRepository<EWCommodity>, IEWCommodityRepository, IEmployeeEWCommodityRepository, IEmployerEWCommodityRepository, IPlatformEWCommodityRepository
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
    public class WorkingDeskRepository : EntityDataRepository<WorkingDesk>, IWorkingDeskRepository, IEmployeeWorkingDeskRepository, IEmployerWorkingDeskRepository, IPlatformWorkingDeskRepository
    {
        public WorkingDeskRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
    public interface IDotBarcodeRepository : IEntityDataRepository<DotBarcode>
    {

    }
    public class DotBarcodeRepository : EntityDataRepository<DotBarcode>, IDotBarcodeRepository, IEmployeeDotBarcodeRepository, IEmployerDotBarcodeRepository, IPlatformDotBarcodeRepository
    {
        public DotBarcodeRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
    public interface IIncomingTagRepository : IEntityDataRepository<IncomingTag>
    {

    }
    public class IncomingTagRepository : EntityDataRepository<IncomingTag>, IIncomingTagRepository, IEmployeeIncomingTagRepository, IEmployerIncomingTagRepository, IPlatformIncomingTagRepository
    {
        public IncomingTagRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
    public interface IDividedTagRepository : IEntityDataRepository<DividedTag>
    {

    }
    public class DividedTagRepository : EntityDataRepository<DividedTag>, IDividedTagRepository, IEmployeeDividedTagRepository, IEmployerDividedTagRepository, IPlatformDividedTagRepository
    {
        public DividedTagRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
    public interface ILoadFrameRepository : IEntityDataRepository<LoadFrame>
    {

    }
    public class LoadFrameRepository : EntityDataRepository<LoadFrame>, ILoadFrameRepository, IEmployeeLoadFrameRepository, IEmployerLoadFrameRepository, IPlatformLoadFrameRepository
    {
        public LoadFrameRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
    }
}