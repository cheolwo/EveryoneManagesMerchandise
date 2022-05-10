using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDividedTag
{
    public class PlatformDividedTagPageViewModel : EntityPageViewModel<PlatformDividedTag> 
    {
        public PlatformDividedTagPageViewModel(PlatformPostDividedTagViewModel PlatformPostDividedTagViewModel, 
                                        PlatformPutDividedTagViewModel PlatformPutDividedTagViewModel,
                                        PlatformDeleteDividedTagViewModel PlatformDeleteDividedTagViewModel,
                                        PlatformGetsDividedTagViewModel PlatformGetsDividedTagViewModel)
                :base(PlatformPostDividedTagViewModel, PlatformPutDividedTagViewModel, PlatformDeleteDividedTagViewModel, PlatformGetsDividedTagViewModel)
                    
        {
            
        }
    }
}