using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofPlatMarket
{
    public class EmployerPlatMarketPageViewModel : PlatMarketPageViewModel<EmployerPlatMarket> 
    {
        public readonly EmployerPostPlatMarketViewModel _EmployerPostPlatMarketViewModel;
        public readonly EmployerPutPlatMarketViewModel _EmployerPutPlatMarketViewModel;
        public readonly EmployerDeletePlatMarketViewModel _EmployerDeletePlatMarketViewModel;
        public readonly EmployerGetsPlatMarketViewModel _EmployerGetsPlatMarketViewModel;

        public EmployerPlatMarketPageViewModel(EmployerPostPlatMarketViewModel EmployerPostPlatMarketViewModel, 
                                        EmployerPutPlatMarketViewModel EmployerPutPlatMarketViewModel,
                                        EmployerDeletePlatMarketViewModel EmployerDeletePlatMarketViewModel,
                                        EmployerGetsPlatMarketViewModel EmployerGetsPlatMarketViewModel)
                :base(EmployerPostPlatMarketViewModel, EmployerPutPlatMarketViewModel, EmployerDeletePlatMarketViewModel, EmployerGetsPlatMarketViewModel)
                    
        {
            _EmployerPostPlatMarketViewModel = EmployerPostPlatMarketViewModel;
            _EmployerPutPlatMarketViewModel = EmployerPutPlatMarketViewModel;
            _EmployerDeletePlatMarketViewModel = EmployerDeletePlatMarketViewModel;
            _EmployerGetsPlatMarketViewModel = EmployerGetsPlatMarketViewModel;
        }
    }
}