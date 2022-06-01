using BusinessData.ofDeliveryCenter;
using BusinessData.ofGeneric.ofIdFactory;

namespace BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory
{
    public interface IDeliveryCenterIdFactory : ICenterIdFactory<DeliveryCenter>
    {
        
    }
    public interface IDCommodityIdFactory : ICommodityIdFactory<DCommodity>
    {
        
    }
    public interface ISDCommodityIdFactory : IStatusIdFactory<SDCommodity>
    {
        
    }
    public interface IMDCommodityIdFactory : IStatusIdFactory<MDCommodity>
    {
        
    }
    public interface IEDCommodityIdFactory : IStatusIdFactory<EDCommodity>
    {
        
    }
}