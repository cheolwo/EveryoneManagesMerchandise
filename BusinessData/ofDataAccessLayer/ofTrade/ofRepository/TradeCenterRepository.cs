using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofTrade.ofDbContext;
using BusinessData.ofDataAccessLayer.ofTrade.ofinterface.ofEmployee;
using BusinessData.ofDataAccessLayer.ofTrade.ofinterface.ofEmployer;
using BusinessData.ofDataAccessLayer.ofTrade.ofinterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofRepository
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
    public class TradeCenterRepository : CenterDataRepository<TradeCenter>, ITradeCenterRepository, IEmployeeTradeCenterRepository, IEmployerTradeCenterRepository, IPlatformTradeCenterRepository
    {
        public TradeCenterRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class TCommodityRepository : CommodityDataRepository<TCommodity>, ITCommodityRepository, IEmployeeTCommodityRepository, IEmployerTCommodityRepository, IPlatformTCommodityRepository
    {
        public TCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class STCommodityRepository : StatusDataRepository<STCommodity>, ISTCommodityRepository, IEmployeeSTCommodityRepository, IEmployerSTCommodityRepository, IPlatformSTCommodityRepository
    {
        public STCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class MTCommodityRepository : StatusDataRepository<MTCommodity>, IMTCommodityRepository, IEmployeeMTCommodityRepository, IEmployerMTCommodityRepository, IPlatformMTCommodityRepository
    {
        public MTCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
    public class ETCommodityRepository : StatusDataRepository<ETCommodity>, IETCommodityRepository, IEmployeeETCommodityRepository, IEmployerETCommodityRepository, IPlatformETCommodityRepository
    {
        public ETCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
    }
}