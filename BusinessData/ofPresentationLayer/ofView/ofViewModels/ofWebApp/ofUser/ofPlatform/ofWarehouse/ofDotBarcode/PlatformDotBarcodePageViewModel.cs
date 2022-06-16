using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDotBarcode
{
    public class PlatformDotBarcodePageViewModel : DotBarcodePageViewModel<PlatformDotBarcode> 
    {
        public readonly PlatformPostDotBarcodeViewModel _PlatformPostDotBarcodeViewModel;
        public readonly PlatformPutDotBarcodeViewModel _PlatformPutDotBarcodeViewModel;
        public readonly PlatformDeleteDotBarcodeViewModel _PlatformDeleteDotBarcodeViewModel;
        public readonly PlatformGetsDotBarcodeViewModel _PlatformGetsDotBarcodeViewModel;

        public PlatformDotBarcodePageViewModel(PlatformPostDotBarcodeViewModel PlatformPostDotBarcodeViewModel, 
                                        PlatformPutDotBarcodeViewModel PlatformPutDotBarcodeViewModel,
                                        PlatformDeleteDotBarcodeViewModel PlatformDeleteDotBarcodeViewModel,
                                        PlatformGetsDotBarcodeViewModel PlatformGetsDotBarcodeViewModel)
                :base(PlatformPostDotBarcodeViewModel, PlatformPutDotBarcodeViewModel, PlatformDeleteDotBarcodeViewModel, PlatformGetsDotBarcodeViewModel)
                    
        {
            _PlatformPostDotBarcodeViewModel = PlatformPostDotBarcodeViewModel;
            _PlatformPutDotBarcodeViewModel = PlatformPutDotBarcodeViewModel;
            _PlatformDeleteDotBarcodeViewModel = PlatformDeleteDotBarcodeViewModel;
            _PlatformGetsDotBarcodeViewModel = PlatformGetsDotBarcodeViewModel;
        }
    }
}