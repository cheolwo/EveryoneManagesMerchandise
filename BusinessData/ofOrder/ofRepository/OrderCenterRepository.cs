using System.Threading.Tasks;
using BusinessData.ofGenericRepository;
using BusinessData.ofOrder.ofDbContext;
using BusinessData.ofOrder.ofModel;

namespace BusinessData.ofOrder.ofRepository
{
    public interface IOrderCenterRepository : ICenterDataRepository<OrderCenter>
    {
        Task<OrderCenter> GetRelatedData(OrderCenter OrderCenter);
    }
    public interface IOCommodityRepository : ICommodityDataRepository<OCommodity>
    {
    }
    public interface ISOCommodityRepository : IStatusDataRepository<SOCommodity>
    {

    }
    public interface IMOCommodityRepository : IStatusDataRepository<MOCommodity>
    {

    }
    public interface IEOCommodityRepository : IStatusDataRepository<EOCommodity>
    {

    }
    public class OrderCenterRepository : CenterDataRepository<OrderCenter>, IOrderCenterRepository
    {
        public OrderCenterRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }

        public Task<OrderCenter> GetRelatedData(OrderCenter OrderCenter)
        {
            throw new System.NotImplementedException();
        }
    }
    public class OCommodityRepository : CommodityDataRepository<OCommodity>, IOCommodityRepository
    {
        public OCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
    }
    public class SOCommodityRepository : StatusDataRepository<SOCommodity>, ISOCommodityRepository
    {
        public SOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
    }
    public class MOCommodityRepository : StatusDataRepository<MOCommodity>, IMOCommodityRepository
    {
        public MOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
    }
    public class EOCommodityRepository : StatusDataRepository<EOCommodity>, IEOCommodityRepository
    {
        public EOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
    }
}
