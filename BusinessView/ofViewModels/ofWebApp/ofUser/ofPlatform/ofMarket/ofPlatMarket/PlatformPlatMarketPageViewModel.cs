using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofPlatMarket
{
    public class PlatformPlatMarketPageViewModel : PlatMarketPageViewModel<PlatformPlatMarket> 
    {
        public readonly PlatformPostPlatMarketViewModel _PlatformPostPlatMarketViewModel;
        public readonly PlatformPutPlatMarketViewModel _PlatformPutPlatMarketViewModel;
        public readonly PlatformDeletePlatMarketViewModel _PlatformDeletePlatMarketViewModel;
        public readonly PlatformGetsPlatMarketViewModel _PlatformGetsPlatMarketViewModel;

        public PlatformPlatMarketPageViewModel(PlatformPostPlatMarketViewModel PlatformPostPlatMarketViewModel, 
                                        PlatformPutPlatMarketViewModel PlatformPutPlatMarketViewModel,
                                        PlatformDeletePlatMarketViewModel PlatformDeletePlatMarketViewModel,
                                        PlatformGetsPlatMarketViewModel PlatformGetsPlatMarketViewModel)
                :base(PlatformPostPlatMarketViewModel, PlatformPutPlatMarketViewModel, PlatformDeletePlatMarketViewModel, PlatformGetsPlatMarketViewModel)
                    
        {
            _PlatformPostPlatMarketViewModel = PlatformPostPlatMarketViewModel;
            _PlatformPutPlatMarketViewModel = PlatformPutPlatMarketViewModel;
            _PlatformDeletePlatMarketViewModel = PlatformDeletePlatMarketViewModel;
            _PlatformGetsPlatMarketViewModel = PlatformGetsPlatMarketViewModel;
        }
    }
}