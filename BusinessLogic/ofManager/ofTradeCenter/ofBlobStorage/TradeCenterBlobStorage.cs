using System.Threading.Tasks;
using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;

namespace BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage
{
    public interface ITCommodityBlobContainerFactory : IEntityContainerFactory<TCommodity>
    {

    }
    public interface ISTCommodityBlobContainerFactory : IEntityContainerFactory<STCommodity>
    {

    }
    public interface IMTCommodityBlobContainerFactory : IEntityContainerFactory<MTCommodity>
    {

    }
    public interface IETCommodityBlobContainerFactory : IEntityContainerFactory<ETCommodity>
    {

    }
    public interface ITradeCenterBlobContainerFactory : IEntityContainerFactory<TradeCenter>
    {

    }
    public class TradeCenterBlobContainerFactory : EntityContainerFactory<TradeCenter>, ITradeCenterBlobContainerFactory
    {
        private readonly ITradeCenterRepository _TradeCenterRepository;
        public TradeCenterBlobContainerFactory(ITradeCenterRepository TradeCenterRepository)
                :base(TradeCenterRepository)
        {
            _TradeCenterRepository = TradeCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(TradeCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface ITCommodityBlobStorage : IEntityBlobStorage<TCommodity>
    {

    }
    public interface ISTCommodityBlobStorage : IEntityBlobStorage<STCommodity>
    {

    }
    public interface IMTCommodityBlobStorage : IEntityBlobStorage<MTCommodity>
    {

    }
    public interface IETCommodityBlobStorage : IEntityBlobStorage<ETCommodity>
    {

    }
    public interface ITradeCenterBlobStorage : IEntityBlobStorage<TradeCenter>
    {

    }
    public class TCommodityBlobStorage : EntityBlobStorage<TCommodity>, ITCommodityBlobStorage
    {
        public TCommodityBlobStorage(ITCommodityBlobContainerFactory TCommodityBlobContainerFactory)
            : base(TCommodityBlobContainerFactory)
        {

        }
    }
    public class STCommodityBlobStorage : EntityBlobStorage<STCommodity>, ISTCommodityBlobStorage
    {
        public STCommodityBlobStorage(ISTCommodityBlobContainerFactory STCommodityBlobContainerFactory)
            : base(STCommodityBlobContainerFactory)
        {

        }

    }
    public class MTCommodityBlobStorage : EntityBlobStorage<MTCommodity>, IMTCommodityBlobStorage
    {
        public MTCommodityBlobStorage(IMTCommodityBlobContainerFactory MTCommodityBlobContainerFactory)
            : base(MTCommodityBlobContainerFactory)
        {

        }
    }
    public class ETCommodityBlobStorage : EntityBlobStorage<ETCommodity>, IETCommodityBlobStorage
    {
        public ETCommodityBlobStorage(IETCommodityBlobContainerFactory ETCommodityBlobContainerFactory)
            : base(ETCommodityBlobContainerFactory)
        {

        }
    }
    public class TradeCenterBlobStorage : EntityBlobStorage<TradeCenter>, ITradeCenterBlobStorage
    {
        public TradeCenterBlobStorage(ITradeCenterBlobContainerFactory TradeCenterBlobContainerFactory)
            : base(TradeCenterBlobContainerFactory)
        {

        }
    }
}