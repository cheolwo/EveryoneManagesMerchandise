using BusinessData.ofGenericRepository;
using BusinessData.ofMarket.ofDbContext;
using BusinessData.ofMarket.ofInterface.ofEmployee;
using BusinessData.ofMarket.ofInterface.ofEmployer;
using BusinessData.ofMarket.ofInterface.ofPlatform;
using BusinessData.ofMarket.ofModel;

namespace BusinessData.ofMarket.ofRepository
{
    public interface IMarketRepository : ICenterDataRepository<Market>
    {

    }
    public interface IMCommodityRepository : ICommodityDataRepository<MCommodity>
    {

    }
    public interface ISMCommodityRepository : IStatusDataRepository<SMCommodity>
    {

    }
    public interface IMMCommodityRepository : IStatusDataRepository<MMCommodity>
    {

    }
    public interface IEMCommodityRepository : IStatusDataRepository<EMCommodity>
    {

    }
    public interface IPlatMarketRepository : ICenterDataRepository<PlatMarket>
    {

    }
    public class MarketRepository : CenterDataRepository<Market>, IMarketRepository, IEmployeeMarketRepository, IEmployerMarketRepository, IPlatformMarketRepository
    {
        public MarketRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
    }
    public class MCommodityRepository : CommodityDataRepository<MCommodity>, IMCommodityRepository, IEmployeeMCommodityRepository, IEmployerMCommodityRepository, IPlatformMCommodityRepository
    {
        public MCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
    }
    public class SMCommodityRepository : StatusDataRepository<SMCommodity>, ISMCommodityRepository, IEmployeeSMCommodityRepository, IEmployerSMCommodityRepository, IPlatformSMCommodityRepository
    {
        public SMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
    }
    public class MMCommodityRepository : StatusDataRepository<MMCommodity>, IMMCommodityRepository, IEmployeeMMCommodityRepository, IEmployerMMCommodityRepository, IPlatformMMCommodityRepository
    {
        public MMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
    }
    public class EMCommodityRepository : StatusDataRepository<EMCommodity>, IEMCommodityRepository, IEmployeeEMCommodityRepository, IEmployerEMCommodityRepository, IPlatformEMCommodityRepository
    {
        public EMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
    }
}