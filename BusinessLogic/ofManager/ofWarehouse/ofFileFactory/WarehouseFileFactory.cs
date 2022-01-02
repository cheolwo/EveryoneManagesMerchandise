using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofWarehouse.ofFileFactory
{
    public interface IWarehouseFileFactory : ICenterFileFactory<Warehouse>
    {

    }
    public class WarehouseFileFactory : CenterFileFactory<Warehouse>, IWarehouseFileFactory
    {

    }
    public interface IWCommodityFileFactory : ICommodityFileFactory<WCommodity>
    {

    }
    public class WCommodityFileFactory : CommodityFileFactory<WCommodity>, IWCommodityFileFactory
    {

    }
    public interface ISWCommodityFileFactory : IStatusFileFactory<SWCommodity>
    {

    }
    public class SWCommodityFileFactory : StatusFileFactory<SWCommodity>, ISWCommodityFileFactory
    {

    }
    public interface IMWCommodityFileFactory : IStatusFileFactory<MWCommodity>
    {

    }
    public class MWCommodityFileFactory : StatusFileFactory<MWCommodity>, IMWCommodityFileFactory
    {

    }
    public interface IEWCommodityFileFactory : IStatusFileFactory<EWCommodity>
    {

    }
    public class EWCommodityFileFactory : StatusFileFactory<EWCommodity>, IEWCommodityFileFactory
    {

    }
    public interface IWorkingDeskFileFactory : IEntityFileFactory<WorkingDesk>
    {

    }
    public class WorkingDeskFileFactory : EntityFileFactory<WorkingDesk>, IWorkingDeskFileFactory
    {

    }
    public interface IDotBarcodeFileFactory : IEntityFileFactory<DotBarcode>
    {

    }
    public class DotBarcodeFileFactory : EntityFileFactory<DotBarcode>, IDotBarcodeFileFactory
    {

    }
}