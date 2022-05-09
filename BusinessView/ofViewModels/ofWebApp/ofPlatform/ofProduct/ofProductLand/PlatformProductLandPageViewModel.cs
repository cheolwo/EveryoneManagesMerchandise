using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductLand
{
    public class PlatformProductLandPageViewModel : EntityPageViewModel<PlatformProductLand> 
    {
        public PlatformProductLandPageViewModel(PlatformPostProductLandViewModel PlatformPostProductLandViewModel, 
                                        PlatformPutProductLandViewModel PlatformPutProductLandViewModel,
                                        PlatformDeleteProductLandViewModel PlatformDeleteProductLandViewModel,
                                        PlatformGetsProductLandViewModel PlatformGetsProductLandViewModel)
                :base(PlatformPostProductLandViewModel, PlatformPutProductLandViewModel, PlatformDeleteProductLandViewModel, PlatformGetsProductLandViewModel)
                    
        {
            
        }
    }
}