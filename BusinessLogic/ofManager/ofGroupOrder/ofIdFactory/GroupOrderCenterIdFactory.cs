using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;

namespace BusinessLogic.ofManager.ofGroupOrder.ofIdFactory
{
    public interface IGroupOrderCenterIdFactory : ICenterIdFactory<GroupOrderCenter>
    {

    }
    public class GroupOrderCenterIdFactory : CenterIdFactory<GroupOrderCenter>, IGroupOrderCenterIdFactory
    {
        public GroupOrderCenterIdFactory(IGroupOrderCenterRepository GroupOrderCenterRepository)
            : base(GroupOrderCenterRepository)
        {

        }
        public async Task<string> CreateByKApt(GroupOrderCenter groupOrderCenter, KAptBasicInfo kAptBasicInfo)
        {
            string Id = await base.CreateAsync(groupOrderCenter);
            stringBuilder.Append(Id);
            stringBuilder.Append('-');
            stringBuilder.Append("KApt");
            stringBuilder.Appned(kAptBasicInfo.Id);
            return strnigBuilder.ToString();
        }
    }
    public interface IGOCommodityIdFactory : ICommodityIdFactory<GOCommodity>
    {

    }
    public class GOCommodityIdFactory : CommodityIdFactory<GOCommodity>, IGOCommodityIdFactory
    {
        public GOCommodityIdFactory(IGOCommodityRepository GOCommodityRepository)
            : base(GOCommodityRepository)
        {

        }
    }
    public interface ISGOCommodityIdFactory : IStatusIdFactory<SGOCommodity>
    {

    }
    public class SGOCommodityIdFactory : StatusIdFactory<SGOCommodity>, ISGOCommodityIdFactory
    {
        public SGOCommodityIdFactory(ISGOCommodityRepository SGOCommodityRepository)
            : base(SGOCommodityRepository)
        {

        }
    }
    public interface IMGOCommodityIdFactory : IStatusIdFactory<MGOCommodity>
    {

    }
    public class MGOCommodityIdFactory : StatusIdFactory<MGOCommodity>, IMGOCommodityIdFactory
    {
        public MGOCommodityIdFactory(IMGOCommodityRepository MGOCommodityRepository)
            : base(MGOCommodityRepository)
        {

        }
    }
    public interface IEGOCommodityIdFactory : IStatusIdFactory<EGOCommodity>
    {

    }
    public class EGOCommodityIdFactory : StatusIdFactory<EGOCommodity>, IEGOCommodityIdFactory
    {
        public EGOCommodityIdFactory(IEGOCommodityRepository EGOCommodityRepository)
            : base(EGOCommodityRepository)
        {

        }
    }
}