using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDividedTag
{
    public class PlatformDividedTagPageViewModel : DividedTagPageViewModel<PlatformDividedTag> 
    {
        public readonly PlatformPostDividedTagViewModel _PlatformPostDividedTagViewModel;
        public readonly PlatformPutDividedTagViewModel _PlatformPutDividedTagViewModel;
        public readonly PlatformDeleteDividedTagViewModel _PlatformDeleteDividedTagViewModel;
        public readonly PlatformGetsDividedTagViewModel _PlatformGetsDividedTagViewModel;

        public PlatformDividedTagPageViewModel(PlatformPostDividedTagViewModel PlatformPostDividedTagViewModel, 
                                        PlatformPutDividedTagViewModel PlatformPutDividedTagViewModel,
                                        PlatformDeleteDividedTagViewModel PlatformDeleteDividedTagViewModel,
                                        PlatformGetsDividedTagViewModel PlatformGetsDividedTagViewModel)
                :base(PlatformPostDividedTagViewModel, PlatformPutDividedTagViewModel, PlatformDeleteDividedTagViewModel, PlatformGetsDividedTagViewModel)
                    
        {
            _PlatformPostDividedTagViewModel = PlatformPostDividedTagViewModel;
            _PlatformPutDividedTagViewModel = PlatformPutDividedTagViewModel;
            _PlatformDeleteDividedTagViewModel = PlatformDeleteDividedTagViewModel;
            _PlatformGetsDividedTagViewModel = PlatformGetsDividedTagViewModel;
        }
    }
}