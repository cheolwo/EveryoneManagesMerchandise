using BusinessData.ofDeliveryCenter;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory
{
    public interface IDeliveryCenterFileFactory : ICenterFileFactory<DeliveryCenter>
    {

    }
    public class DeliveryCenterFileFactory : CenterFileFactory<DeliveryCenter>, IDeliveryCenterFileFactory
    {

    }
    public interface IDCommodityFileFactory : ICommodityFileFactory<DCommodity>
    {

    }
    public class DCommodityFileFactory : CommodityFileFactory<DCommodity>, IDCommodityFileFactory
    {

    }
    public interface ISDCommodityFileFactory : IStatusFileFactory<SDCommodity>
    {

    }
    public class SDCommodityFileFactory : StatusFileFactory<SDCommodity>, ISDCommodityFileFactory
    {

    }
    public interface IMDCommodityFileFactory : IStatusFileFactory<MDCommodity>
    {

    }
    public class MDCommodityFileFactory : StatusFileFactory<MDCommodity>, IMDCommodityFileFactory
    {

    }
    public interface IEDCommodityFileFactory : IStatusFileFactory<EDCommodity>
    {

    }
    public class EDCommodityFileFactory : StatusFileFactory<EDCommodity>, IEDCommodityFileFactory
    {

    }
}