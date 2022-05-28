using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofSPCommodity
{
    public class PlatformSPCommodityPageViewModel : SPCommodityPageViewModel<PlatformSPCommodity> 
    {
        public readonly PlatformPostSPCommodityViewModel _PlatformPostSPCommodityViewModel;
        public readonly PlatformPutSPCommodityViewModel _PlatformPutSPCommodityViewModel;
        public readonly PlatformDeleteSPCommodityViewModel _PlatformDeleteSPCommodityViewModel;
        public readonly PlatformGetsSPCommodityViewModel _PlatformGetsSPCommodityViewModel;

        public PlatformSPCommodityPageViewModel(PlatformPostSPCommodityViewModel PlatformPostSPCommodityViewModel, 
                                        PlatformPutSPCommodityViewModel PlatformPutSPCommodityViewModel,
                                        PlatformDeleteSPCommodityViewModel PlatformDeleteSPCommodityViewModel,
                                        PlatformGetsSPCommodityViewModel PlatformGetsSPCommodityViewModel)
                :base(PlatformPostSPCommodityViewModel, PlatformPutSPCommodityViewModel, PlatformDeleteSPCommodityViewModel, PlatformGetsSPCommodityViewModel)
                    
        {
            _PlatformPostSPCommodityViewModel = PlatformPostSPCommodityViewModel;
            _PlatformPutSPCommodityViewModel = PlatformPutSPCommodityViewModel;
            _PlatformDeleteSPCommodityViewModel = PlatformDeleteSPCommodityViewModel;
            _PlatformGetsSPCommodityViewModel = PlatformGetsSPCommodityViewModel;
        }
    }
}