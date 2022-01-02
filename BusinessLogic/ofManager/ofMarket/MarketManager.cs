using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;

namespace BusinessLogic.ofManager.ofMarket
{
    [DataManager(typeof(Market))]
    public class MarketManager : CenterManager<Market>
    {
        public MarketManager(IMarketRepository CenterDataRepository,
                               IMarketIdFactory marketIdFactory,
                               IMarketFileFactory CenterFileFactory,
                               IMarketBlobStorage blobStorage,
                               CenterPasswordHasher<Market>  centerPasswordHasher,
                            DicConvertFactory<Market> dicConvertFactory)
            : base(CenterDataRepository, marketIdFactory, CenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
}