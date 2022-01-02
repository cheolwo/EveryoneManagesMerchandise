using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;

namespace BusinessLogic.ofManager.ofWarehouse.ofIdFactory
{
    public interface IWarehouseIdFactory : ICenterIdFactory<Warehouse>
    {

    }
    public class WarehouseIdFactory : CenterIdFactory<Warehouse>, IWarehouseIdFactory
    {
        public WarehouseIdFactory(IWarehouseRepository warehouseRepository)
            : base(warehouseRepository)
        {

        }
    }
    public interface IWCommodityIdFactory : ICommodityIdFactory<WCommodity>
    {

    }
    public class WCommodityIdFactory : CommodityIdFactory<WCommodity>, IWCommodityIdFactory
    {
        public WCommodityIdFactory(IWCommodityRepository WCommodityRepository)
            : base(WCommodityRepository)
        {

        }
    }
    public interface ISWCommodityIdFactory : IStatusIdFactory<SWCommodity>
    {

    }
    public class SWCommodityIdFactory : StatusIdFactory<SWCommodity>, ISWCommodityIdFactory
    {
        public SWCommodityIdFactory(ISWCommodityRepository SWCommodityRepository)
            : base(SWCommodityRepository)
        {

        }
    }
    public interface IMWCommodityIdFactory : IStatusIdFactory<MWCommodity>
    {

    }
    public class MWCommodityIdFactory : StatusIdFactory<MWCommodity>, IMWCommodityIdFactory
    {
        public MWCommodityIdFactory(IMWCommodityRepository MWCommodityRepository)
            : base(MWCommodityRepository)
        {

        }
    }
    public interface IEWCommodityIdFactory : IStatusIdFactory<EWCommodity>
    {

    }
    public class EWCommodityIdFactory : StatusIdFactory<EWCommodity>, IEWCommodityIdFactory
    {
        public EWCommodityIdFactory(IEWCommodityRepository EWCommodityRepository)
            : base(EWCommodityRepository)
        {

        }
    }
    public interface IWorkingDeskIdFactory : IEntityIdFactory<WorkingDesk>
    {

    }
    public class WorkingDeskIdFactory : EntityIdFactory<WorkingDesk>, IWorkingDeskIdFactory
    {
        public WorkingDeskIdFactory(IWorkingDeskRepository WorkingDeskRepository)
            : base(WorkingDeskRepository)
        {

        }
    }
    public interface IDotBarcodeIdFactory : IEntityIdFactory<DotBarcode>
    {

    }
    public class DotBarcodeIdFactory : EntityIdFactory<DotBarcode>, IDotBarcodeIdFactory
    {
        public DotBarcodeIdFactory(IDotBarcodeRepository DotBarcodeRepository)
            : base(DotBarcodeRepository)
        {

        }
    }

}