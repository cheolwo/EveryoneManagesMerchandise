using System.Threading.Tasks;
using BusinessData.ofGenericRepository;
using BusinessData.ofTrade.ofDbContext;
using BusinessData.ofTrade.ofModel;

namespace BusinessData.ofTrade.ofRepository
{
    public interface ITradeCenterRepository : ICenterDataRepository<TradeCenter>
    {
    
    }
    public interface ITCommodityRepository : ICommodityDataRepository<TCommodity>
    {

    }
    public interface ISTCommodityRepository : IStatusDataRepository<STCommodity>
    {

    }
    public interface IMTCommodityRepository : IStatusDataRepository<MTCommodity>
    {

    }
    public interface IETCommodityRepository : IStatusDataRepository<ETCommodity>
    {

    }   
    public class TradeCenterRepository : CenterDataRepository<TradeCenter>, ITradeCenterRepository
    {
        public TradeCenterRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class TCommodityRepository : CommodityDataRepository<TCommodity>, ITCommodityRepository
    {
        public TCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class STCommodityRepository : StatusDataRepository<STCommodity>, ISTCommodityRepository
    {
        public STCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class MTCommodityRepository : StatusDataRepository<MTCommodity>, IMTCommodityRepository
    {
        public MTCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class ETCommodityRepository : StatusDataRepository<ETCommodity>, IETCommodityRepository
    {
        public ETCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
}