using BusinessData.ofTrade.ofModel;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofPlatform;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofTradeCenter
{
    public interface ITradeCenterManager : ICenterManager<TradeCenter>
    {
        Task<TradeCenter> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> TradeCenterLoginAsync(string LoginId, string Password);
    }
    public class TradeCenterManager : CenterManager<TradeCenter>, IEmployerTradeCenterManager, IEmployeeTradeCenterManager, IPlatformTradeCenterManager
    {
        private readonly ITradeCenterRepository _TradeCenterRepository;
        public TradeCenterManager(ITradeCenterRepository TradeCenterRepository,
                               ITradeCenterIdFactory TradeCenterIdFactory,
                               ITradeCenterFileFactory TradeCenterFileFactory,
                               ITradeCenterBlobStorage blobStorage,
                               CenterPasswordHasher<TradeCenter> centerPasswordHasher,
                            DicConvertFactory<TradeCenter> dicConvertFactory)
            : base(TradeCenterRepository, TradeCenterIdFactory, TradeCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _TradeCenterRepository = TradeCenterRepository;
        }

        public Task<TradeCenter> LoginWithDataAsync(string LoginId, string Password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> TradeCenterLoginAsync(string LoginId, string Password)
        {
            TradeCenter TradeCenter = await base.LoginAsync(LoginId, Password);
            if(TradeCenter != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}