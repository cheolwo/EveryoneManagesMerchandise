using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOCommodity
{
    public class PlatformOCommodityPageViewModel : OCommodityPageViewModel<PlatformOCommodity> 
    {
        public readonly PlatformPostOCommodityViewModel _PlatformPostOCommodityViewModel;
        public readonly PlatformPutOCommodityViewModel _PlatformPutOCommodityViewModel;
        public readonly PlatformDeleteOCommodityViewModel _PlatformDeleteOCommodityViewModel;
        public readonly PlatformGetsOCommodityViewModel _PlatformGetsOCommodityViewModel;

        public PlatformOCommodityPageViewModel(PlatformPostOCommodityViewModel PlatformPostOCommodityViewModel, 
                                        PlatformPutOCommodityViewModel PlatformPutOCommodityViewModel,
                                        PlatformDeleteOCommodityViewModel PlatformDeleteOCommodityViewModel,
                                        PlatformGetsOCommodityViewModel PlatformGetsOCommodityViewModel)
                :base(PlatformPostOCommodityViewModel, PlatformPutOCommodityViewModel, PlatformDeleteOCommodityViewModel, PlatformGetsOCommodityViewModel)
                    
        {
            _PlatformPostOCommodityViewModel = PlatformPostOCommodityViewModel;
            _PlatformPutOCommodityViewModel = PlatformPutOCommodityViewModel;
            _PlatformDeleteOCommodityViewModel = PlatformDeleteOCommodityViewModel;
            _PlatformGetsOCommodityViewModel = PlatformGetsOCommodityViewModel;
        }
    }
}