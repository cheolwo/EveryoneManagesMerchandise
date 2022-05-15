using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofSMCommodity
{
    public class PlatformSMCommodityPageViewModel : StatusPageViewModel<PlatformSMCommodity> 
    {
        public readonly PlatformPostSMCommodityViewModel _PlatformPostSMCommodityViewModel;
        public readonly PlatformPutSMCommodityViewModel _PlatformPutSMCommodityViewModel;
        public readonly PlatformDeleteSMCommodityViewModel _PlatformDeleteSMCommodityViewModel;
        public readonly PlatformGetsSMCommodityViewModel _PlatformGetsSMCommodityViewModel;
        public PlatformSMCommodityPageViewModel(PlatformPostSMCommodityViewModel PlatformPostSMCommodityViewModel, 
                                        PlatformPutSMCommodityViewModel PlatformPutSMCommodityViewModel,
                                        PlatformDeleteSMCommodityViewModel PlatformDeleteSMCommodityViewModel,
                                        PlatformGetsSMCommodityViewModel PlatformGetsSMCommodityViewModel)
                :base(PlatformPostSMCommodityViewModel, PlatformPutSMCommodityViewModel, PlatformDeleteSMCommodityViewModel, PlatformGetsSMCommodityViewModel)
                    
        {
            _PlatformPostSMCommodityViewModel = PlatformPostSMCommodityViewModel;
            _PlatformPutSMCommodityViewModel = PlatformPutSMCommodityViewModel;
            _PlatformDeleteSMCommodityViewModel = PlatformDeleteSMCommodityViewModel;
            _PlatformGetsSMCommodityViewModel = PlatformGetsSMCommodityViewModel;
        }
    }
}