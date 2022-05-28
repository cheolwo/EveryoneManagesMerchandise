using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofMPCommodity
{
    public class PlatformMPCommodityPageViewModel : StatusPageViewModel<PlatformMPCommodity> 
    {
        public readonly PlatformPostMPCommodityViewModel _PlatformPostMPCommodityViewModel;
        public readonly PlatformPutMPCommodityViewModel _PlatformPutMPCommodityViewModel;
        public readonly PlatformDeleteMPCommodityViewModel _PlatformDeleteMPCommodityViewModel;
        public readonly PlatformGetsMPCommodityViewModel _PlatformGetsMPCommodityViewModel;
        public PlatformMPCommodityPageViewModel(PlatformPostMPCommodityViewModel PlatformPostMPCommodityViewModel, 
                                        PlatformPutMPCommodityViewModel PlatformPutMPCommodityViewModel,
                                        PlatformDeleteMPCommodityViewModel PlatformDeleteMPCommodityViewModel,
                                        PlatformGetsMPCommodityViewModel PlatformGetsMPCommodityViewModel)
                :base(PlatformPostMPCommodityViewModel, PlatformPutMPCommodityViewModel, PlatformDeleteMPCommodityViewModel, PlatformGetsMPCommodityViewModel)
                    
        {
            _PlatformPostMPCommodityViewModel = PlatformPostMPCommodityViewModel;
            _PlatformPutMPCommodityViewModel = PlatformPutMPCommodityViewModel;
            _PlatformDeleteMPCommodityViewModel = PlatformDeleteMPCommodityViewModel;
            _PlatformGetsMPCommodityViewModel = PlatformGetsMPCommodityViewModel;
        }
    }
}