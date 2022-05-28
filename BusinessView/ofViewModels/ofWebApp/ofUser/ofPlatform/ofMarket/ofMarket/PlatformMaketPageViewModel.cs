using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMarket
{
    public class PlatformMarketPageViewModel : MarketPageViewModel<PlatformMarket> 
    {
        public readonly PlatformPostMarketViewModel _PlatformPostMarketViewModel;
        public readonly PlatformPutMarketViewModel _PlatformPutMarketViewModel;
        public readonly PlatformDeleteMarketViewModel _PlatformDeleteMarketViewModel;
        public readonly PlatformGetsMarketViewModel _PlatformGetsMarketViewModel;

        public PlatformMarketPageViewModel(PlatformPostMarketViewModel PlatformPostMarketViewModel, 
                                        PlatformPutMarketViewModel PlatformPutMarketViewModel,
                                        PlatformDeleteMarketViewModel PlatformDeleteMarketViewModel,
                                        PlatformGetsMarketViewModel PlatformGetsMarketViewModel)
                :base(PlatformPostMarketViewModel, PlatformPutMarketViewModel, PlatformDeleteMarketViewModel, PlatformGetsMarketViewModel)
                    
        {
            _PlatformPostMarketViewModel = PlatformPostMarketViewModel;
            _PlatformPutMarketViewModel = PlatformPutMarketViewModel;
            _PlatformDeleteMarketViewModel = PlatformDeleteMarketViewModel;
            _PlatformGetsMarketViewModel = PlatformGetsMarketViewModel;
        }
    }
}