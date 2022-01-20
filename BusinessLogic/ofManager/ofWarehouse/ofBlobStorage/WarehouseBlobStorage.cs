using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofWarehouse.ofBlobStorage
{
    public interface IWCommodityBlobContainerFactory : IEntityContainerFactory<WCommodity>
    {

    }
    public interface ISWCommodityBlobContainerFactory : IEntityContainerFactory<SWCommodity>
    {

    }
    public interface IMWCommodityBlobContainerFactory : IEntityContainerFactory<MWCommodity>
    {

    }
    public interface IEWCommodityBlobContainerFactory : IEntityContainerFactory<EWCommodity>
    {

    }
    public interface IWarehouseBlobContainerFactory : IEntityContainerFactory<Warehouse>
    {

    }
    public class WarehouseBlobContainerFactory : EntityContainerFactory<Warehouse>, IWarehouseBlobContainerFactory
    {
        public WarehouseBlobContainerFactory(IWarehouseRepository warehouseRepository)
                :base(warehouseRepository)
        {
            
        }
        public override async Task<string> CreateNameofContainer(Warehouse entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class WCommodityBlobContainerFactory : EntityContainerFactory<WCommodity>, IWCommodityBlobContainerFactory
    {
        public WCommodityBlobContainerFactory(IWCommodityRepository WCommodityRepository)
                :base(WCommodityRepository)
        {
            
        }
    }
    public class SWCommodityBlobContainerFactory : EntityContainerFactory<SWCommodity>, ISWCommodityBlobContainerFactory
    {
        public SWCommodityBlobContainerFactory(ISWCommodityRepository SWCommodityRepository)
                :base(SWCommodityRepository)
        {
            
        }
    }
    public class MWCommodityBlobContainerFactory : EntityContainerFactory<MWCommodity>, IMWCommodityBlobContainerFactory
    {
        public MWCommodityBlobContainerFactory(IMWCommodityRepository MWCommodityRepository)
                :base(MWCommodityRepository)
        {
            
        }
    }
    public class EWCommodityBlobContainerFactory : EntityContainerFactory<EWCommodity>, IEWCommodityBlobContainerFactory
    {
        public EWCommodityBlobContainerFactory(IEWCommodityRepository EWCommodityRepository)
                :base(EWCommodityRepository)
        {
            
        }
    }
    public interface IWCommodityBlobStorage : IEntityBlobStorage<WCommodity>
    {

    }
    public interface ISWCommodityBlobStorage : IEntityBlobStorage<SWCommodity>
    {

    }
    public interface IMWCommodityBlobStorage : IEntityBlobStorage<MWCommodity>
    {

    }
    public interface IEWCommodityBlobStorage : IEntityBlobStorage<EWCommodity>
    {

    }
    public interface IWarehouseBlobStorage : IEntityBlobStorage<Warehouse>
    {

    }
    public class WCommodityBlobStorage : EntityBlobStorage<WCommodity>, IWCommodityBlobStorage
    {
        public WCommodityBlobStorage(IWCommodityBlobContainerFactory WCommodityBlobContainerFactory)
            : base(WCommodityBlobContainerFactory)
        {

        }
    }
    public class SWCommodityBlobStorage : EntityBlobStorage<SWCommodity>, ISWCommodityBlobStorage
    {
        public SWCommodityBlobStorage(ISWCommodityBlobContainerFactory SWCommodityBlobContainerFactory)
            : base(SWCommodityBlobContainerFactory)
        {

        }

    }
    public class MWCommodityBlobStorage : EntityBlobStorage<MWCommodity>, IMWCommodityBlobStorage
    {
        public MWCommodityBlobStorage(IMWCommodityBlobContainerFactory MWCommodityBlobContainerFactory)
            : base(MWCommodityBlobContainerFactory)
        {

        }
    }
    public class EWCommodityBlobStorage : EntityBlobStorage<EWCommodity>, IEWCommodityBlobStorage
    {
        public EWCommodityBlobStorage(IEWCommodityBlobContainerFactory EWCommodityBlobContainerFactory)
            : base(EWCommodityBlobContainerFactory)
        {

        }
    }
    public class WarehouseBlobStorage : EntityBlobStorage<Warehouse>, IWarehouseBlobStorage
    {
        public WarehouseBlobStorage(IWarehouseBlobContainerFactory WarehouseBlobContainerFactory)
            : base(WarehouseBlobContainerFactory)
        {

        }
    }
}