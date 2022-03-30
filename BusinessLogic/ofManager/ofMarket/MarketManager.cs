using BusinessData.ofMarket.ofModel;
using BusinessData.ofMarket.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofManager.ofMarket.ofIdFactory;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofMarket.ofInterface.ofPlatform;

namespace BusinessLogic.ofManager.ofMarket
{
    public interface IMarketManager : ICenterManager<Market>
    {

    }
    [DataManager(typeof(Market))]
    public class MarketManager : CenterManager<Market>, IEmployerMarketManager, IEmployeeMarketManager, IPaltformMarketManager, IMarketManager
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