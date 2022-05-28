using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofEPCommodity
{
    public class PlatformEPCommodityPageViewModel : StatusPageViewModel<PlatformEPCommodity> 
    {
        public readonly PlatformPostEPCommodityViewModel _PlatformPostEPCommodityViewModel;
        public readonly PlatformPutEPCommodityViewModel _PlatformPutEPCommodityViewModel;
        public readonly PlatformDeleteEPCommodityViewModel _PlatformDeleteEPCommodityViewModel;
        public readonly PlatformGetsEPCommodityViewModel _PlatformGetsEPCommodityViewModel;
        public PlatformEPCommodityPageViewModel(PlatformPostEPCommodityViewModel PlatformPostEPCommodityViewModel, 
                                        PlatformPutEPCommodityViewModel PlatformPutEPCommodityViewModel,
                                        PlatformDeleteEPCommodityViewModel PlatformDeleteEPCommodityViewModel,
                                        PlatformGetsEPCommodityViewModel PlatformGetsEPCommodityViewModel)
                :base(PlatformPostEPCommodityViewModel, PlatformPutEPCommodityViewModel, PlatformDeleteEPCommodityViewModel, PlatformGetsEPCommodityViewModel)
                    
        {
            _PlatformPostEPCommodityViewModel = PlatformPostEPCommodityViewModel;
            _PlatformPutEPCommodityViewModel = PlatformPutEPCommodityViewModel;
            _PlatformDeleteEPCommodityViewModel = PlatformDeleteEPCommodityViewModel;
            _PlatformGetsEPCommodityViewModel = PlatformGetsEPCommodityViewModel;
        }
    }
}