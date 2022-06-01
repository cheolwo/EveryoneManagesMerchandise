using BusinessData.ofDeliveryCenter;
using BusinessData.ofMarket.ofModel;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory
{
    public interface IMarketFileFactory : ICenterFileFactory<Market>
    {

    }
    public class MarketFileFactory : CenterFileFactory<Market>, IMarketFileFactory
    {

    }
    public interface IMCommodityFileFactory : ICommodityFileFactory<MCommodity>
    {

    }
    public class MCommodityFileFactory : CommodityFileFactory<MCommodity>, IMCommodityFileFactory
    {

    }
    public interface ISMCommodityFileFactory : IStatusFileFactory<SMCommodity>
    {

    }
    public class SMCommodityFileFactory : StatusFileFactory<SMCommodity>, ISMCommodityFileFactory
    {

    }
    public interface IMMCommodityFileFactory : IStatusFileFactory<MMCommodity>
    {

    }
    public class MMCommodityFileFactory : StatusFileFactory<MMCommodity>, IMMCommodityFileFactory
    {

    }
    public interface IEMCommodityFileFactory : IStatusFileFactory<EMCommodity>
    {

    }
    public class EMCommodityFileFactory : StatusFileFactory<EMCommodity>, IEMCommodityFileFactory
    {

    }
}