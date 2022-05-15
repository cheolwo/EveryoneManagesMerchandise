using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofPCommodity
{
    public class PlatformPCommodityPageViewModel : CommodityPageViewModel<PlatformPCommodity> 
    {
        public readonly PlatformPostPCommodityViewModel _PlatformPostPCommodityViewModel;
        public readonly PlatformPutPCommodityViewModel _PlatformPutPCommodityViewModel;
        public readonly PlatformDeletePCommodityViewModel _PlatformDeletePCommodityViewModel;
        public readonly PlatformGetsPCommodityViewModel _PlatformGetsPCommodityViewModel;
        public PlatformPCommodityPageViewModel(PlatformPostPCommodityViewModel PlatformPostPCommodityViewModel, 
                                        PlatformPutPCommodityViewModel PlatformPutPCommodityViewModel,
                                        PlatformDeletePCommodityViewModel PlatformDeletePCommodityViewModel,
                                        PlatformGetsPCommodityViewModel PlatformGetsPCommodityViewModel)
                :base(PlatformPostPCommodityViewModel, PlatformPutPCommodityViewModel, PlatformDeletePCommodityViewModel, PlatformGetsPCommodityViewModel)
                    
        {
            _PlatformPostPCommodityViewModel = PlatformPostPCommodityViewModel;
            _PlatformPutPCommodityViewModel = PlatformPutPCommodityViewModel;
            _PlatformDeletePCommodityViewModel = PlatformDeletePCommodityViewModel;
            _PlatformGetsPCommodityViewModel = PlatformGetsPCommodityViewModel;
        }
    }
}