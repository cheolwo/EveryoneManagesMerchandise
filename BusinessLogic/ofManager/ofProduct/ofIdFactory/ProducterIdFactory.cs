using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofProduct;

namespace BusinessData.ofMarket.ofRepository.ofIdFactory
{
    public interface IProductCenterIdFactory : ICenterIdFactory<ProductCenter>
    {
        
    }
    public interface IPCommodityIdFactory : ICommodityIdFactory<PCommodity>
    {
        
    }
    public interface ISPCommodityIdFactory : IStatusIdFactory<SPCommodity>
    {
        
    }
    public interface IMPCommodityIdFactory : IStatusIdFactory<MPCommodity>
    {
        
    }
    public interface IEPCommodityIdFactory : IStatusIdFactory<EPCommodity>
    {
        
    }
}