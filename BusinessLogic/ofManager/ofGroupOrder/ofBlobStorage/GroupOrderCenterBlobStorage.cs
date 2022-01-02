using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofGroupOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage
{
    public interface IGOCommodityBlobContainerFactory : IEntityContainerFactory<GOCommodity>
    {

    }
    public interface ISGOCommodityBlobContainerFactory : IEntityContainerFactory<SGOCommodity>
    {

    }
    public interface IMGOCommodityBlobContainerFactory : IEntityContainerFactory<MGOCommodity>
    {

    }
    public interface IEGOCommodityBlobContainerFactory : IEntityContainerFactory<EGOCommodity>
    {

    }
    public interface IGroupOrderCenterBlobContainerFactory : IEntityContainerFactory<GroupOrderCenter>
    {

    }
    public class GroupOrderCenterBlobContainerFactory : EntityContainerFactory<GroupOrderCenter>, IGroupOrderCenterBlobContainerFactory
    {
        private readonly IGroupOrderCenterRepository _GroupOrderCenterRepository;
        public GroupOrderCenterBlobContainerFactory(IGroupOrderCenterRepository GroupOrderCenterRepository)
                :base(GroupOrderCenterRepository)
        {
            _GroupOrderCenterRepository = GroupOrderCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(GroupOrderCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IGOCommodityBlobStorage : IEntityBlobStorage<GOCommodity>
    {

    }
    public interface ISGOCommodityBlobStorage : IEntityBlobStorage<SGOCommodity>
    {

    }
    public interface IMGOCommodityBlobStorage : IEntityBlobStorage<MGOCommodity>
    {

    }
    public interface IEGOCommodityBlobStorage : IEntityBlobStorage<EGOCommodity>
    {

    }
    public interface IGroupOrderCenterBlobStorage : IEntityBlobStorage<GroupOrderCenter>
    {

    }
    public class GOCommodityBlobStorage : EntityBlobStorage<GOCommodity>, IGOCommodityBlobStorage
    {
        public GOCommodityBlobStorage(IGOCommodityBlobContainerFactory GOCommodityBlobContainerFactory)
            : base(GOCommodityBlobContainerFactory)
        {

        }
    }
    public class SGOCommodityBlobStorage : EntityBlobStorage<SGOCommodity>, ISGOCommodityBlobStorage
    {
        public SGOCommodityBlobStorage(ISGOCommodityBlobContainerFactory SGOCommodityBlobContainerFactory)
            : base(SGOCommodityBlobContainerFactory)
        {

        }

    }
    public class MGOCommodityBlobStorage : EntityBlobStorage<MGOCommodity>, IMGOCommodityBlobStorage
    {
        public MGOCommodityBlobStorage(IMGOCommodityBlobContainerFactory MGOCommodityBlobContainerFactory)
            : base(MGOCommodityBlobContainerFactory)
        {

        }
    }
    public class EGOCommodityBlobStorage : EntityBlobStorage<EGOCommodity>, IEGOCommodityBlobStorage
    {
        public EGOCommodityBlobStorage(IEGOCommodityBlobContainerFactory EGOCommodityBlobContainerFactory)
            : base(EGOCommodityBlobContainerFactory)
        {

        }
    }
    public class GroupOrderCenterBlobStorage : EntityBlobStorage<GroupOrderCenter>, IGroupOrderCenterBlobStorage
    {
        public GroupOrderCenterBlobStorage(IGroupOrderCenterBlobContainerFactory GroupOrderCenterBlobContainerFactory)
            : base(GroupOrderCenterBlobContainerFactory)
        {

        }
    }
}