using System.Threading.Tasks;
using BusinessData.ofGenericRepository;
using BusinessData.ofGroupOrder.ofDbContext;
using BusinessData.ofGroupOrder.ofModel;

namespace BusinessData.ofGroupOrder.ofRepository
{
    public interface IGroupOrderCenterRepository : ICenterDataRepository<GroupOrderCenter>
    {
        Task<GroupOrderCenter> GetRelatedData(GroupOrderCenter GroupOrderCenter);
    }
    public interface IGOCommodityRepository : ICommodityDataRepository<GOCommodity>
    {

    }
    public interface ISGOCommodityRepository : IStatusDataRepository<SGOCommodity>
    {

    }
    public interface IMGOCommodityRepository : IStatusDataRepository<MGOCommodity>
    {

    }
    public interface IEGOCommodityRepository : IStatusDataRepository<EGOCommodity>
    {

    }
    public class GroupOrderCenterRepository : CenterDataRepository<GroupOrderCenter>, IGroupOrderCenterRepository
    {
        public GroupOrderCenterRepository(GroupOrderDbContext GroupOrderDbContext)
            :base(GroupOrderDbContext)
        {

        }

        public Task<GroupOrderCenter> GetRelatedData(GroupOrderCenter GroupOrderCenter)
        {
            throw new System.NotImplementedException();
        }
    }
    public class GOCommodityRepository : CommodityDataRepository<GOCommodity>, IGOCommodityRepository
    {
        public GOCommodityRepository(GroupOrderDbContext GroupOrderDbContext)
            :base(GroupOrderDbContext)
        {

        }
    }
    public class SGOCommodityRepository : StatusDataRepository<SGOCommodity>, ISGOCommodityRepository
    {
        public SGOCommodityRepository(GroupOrderDbContext GroupOrderDbContext)
            :base(GroupOrderDbContext)
        {

        }
    }
    public class MGOCommodityRepository : StatusDataRepository<MGOCommodity>, IMGOCommodityRepository
    {
        public MGOCommodityRepository(GroupOrderDbContext GroupOrderDbContext)
            :base(GroupOrderDbContext)
        {

        }
    }
    public class EGOCommodityRepository : StatusDataRepository<EGOCommodity>, IEGOCommodityRepository
    {
        public EGOCommodityRepository(GroupOrderDbContext GroupOrderDbContext)
            :base(GroupOrderDbContext)
        {

        }
    }
}
