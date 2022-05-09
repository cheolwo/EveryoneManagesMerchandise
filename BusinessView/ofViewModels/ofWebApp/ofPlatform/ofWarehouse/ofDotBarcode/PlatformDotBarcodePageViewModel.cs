using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDotBarcode
{
    public class PlatformDotBarcodePageViewModel : EntityPageViewModel<PlatformDotBarcode> 
    {
        public PlatformDotBarcodePageViewModel(PlatformPostDotBarcodeViewModel PlatformPostDotBarcodeViewModel, 
                                        PlatformPutDotBarcodeViewModel PlatformPutDotBarcodeViewModel,
                                        PlatformDeleteDotBarcodeViewModel PlatformDeleteDotBarcodeViewModel,
                                        PlatformGetsDotBarcodeViewModel PlatformGetsDotBarcodeViewModel)
                :base(PlatformPostDotBarcodeViewModel, PlatformPutDotBarcodeViewModel, PlatformDeleteDotBarcodeViewModel, PlatformGetsDotBarcodeViewModel)
                    
        {
            
        }
    }
}