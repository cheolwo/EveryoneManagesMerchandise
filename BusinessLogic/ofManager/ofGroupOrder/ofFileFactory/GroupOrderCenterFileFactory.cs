using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofGroupOrder.ofFileFactory
{
    public interface IGroupOrderCenterFileFactory : ICenterFileFactory<GroupOrderCenter>
    {

    }
    public class GroupOrderCenterFileFactory : CenterFileFactory<GroupOrderCenter>, IGroupOrderCenterFileFactory
    {

    }
    public interface IGOCommodityFileFactory : ICommodityFileFactory<GOCommodity>
    {

    }
    public class GOCommodityFileFactory : CommodityFileFactory<GOCommodity>, IGOCommodityFileFactory
    {

    }
    public interface ISGOCommodityFileFactory : IStatusFileFactory<SGOCommodity>
    {

    }
    public class SGOCommodityFileFactory : StatusFileFactory<SGOCommodity>, ISGOCommodityFileFactory
    {

    }
    public interface IMGOCommodityFileFactory : IStatusFileFactory<MGOCommodity>
    {

    }
    public class MGOCommodityFileFactory : StatusFileFactory<MGOCommodity>, IMGOCommodityFileFactory
    {

    }
    public interface IEGOCommodityFileFactory : IStatusFileFactory<EGOCommodity>
    {

    }
    public class EGOCommodityFileFactory : StatusFileFactory<EGOCommodity>, IEGOCommodityFileFactory
    {

    }
}