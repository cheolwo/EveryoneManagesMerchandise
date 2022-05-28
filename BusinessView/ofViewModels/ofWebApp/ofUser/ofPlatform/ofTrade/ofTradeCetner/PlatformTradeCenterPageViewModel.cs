using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTradeCenter
{
    public class PlatformTradeCenterPageViewModel : TradeCenterPageViewModel<PlatformTradeCenter> 
    {
        public readonly PlatformPostTradeCenterViewModel _PlatformPostTradeCenterViewModel;
        public readonly PlatformPutTradeCenterViewModel _PlatformPutTradeCenterViewModel;
        public readonly PlatformDeleteTradeCenterViewModel _PlatformDeleteTradeCenterViewModel;
        public readonly PlatformGetsTradeCenterViewModel _PlatformGetsTradeCenterViewModel;

        public PlatformTradeCenterPageViewModel(PlatformPostTradeCenterViewModel PlatformPostTradeCenterViewModel, 
                                        PlatformPutTradeCenterViewModel PlatformPutTradeCenterViewModel,
                                        PlatformDeleteTradeCenterViewModel PlatformDeleteTradeCenterViewModel,
                                        PlatformGetsTradeCenterViewModel PlatformGetsTradeCenterViewModel)
                :base(PlatformPostTradeCenterViewModel, PlatformPutTradeCenterViewModel, PlatformDeleteTradeCenterViewModel, PlatformGetsTradeCenterViewModel)
                    
        {
            _PlatformPostTradeCenterViewModel = PlatformPostTradeCenterViewModel;
            _PlatformPutTradeCenterViewModel = PlatformPutTradeCenterViewModel;
            _PlatformDeleteTradeCenterViewModel = PlatformDeleteTradeCenterViewModel;
            _PlatformGetsTradeCenterViewModel = PlatformGetsTradeCenterViewModel;
        }
    }
}