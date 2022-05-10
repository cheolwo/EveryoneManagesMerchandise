using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDotBarcode
{
    public class EmployerDotBarcodePageViewModel : EntityPageViewModel<EmployerDotBarcode> 
    {
        public EmployerDotBarcodePageViewModel(EmployerPostDotBarcodeViewModel EmployerPostDotBarcodeViewModel, 
                                        EmployerPutDotBarcodeViewModel EmployerPutDotBarcodeViewModel,
                                        EmployerDeleteDotBarcodeViewModel EmployerDeleteDotBarcodeViewModel,
                                        EmployerGetsDotBarcodeViewModel EmployerGetsDotBarcodeViewModel)
                :base(EmployerPostDotBarcodeViewModel, EmployerPutDotBarcodeViewModel, EmployerDeleteDotBarcodeViewModel, EmployerGetsDotBarcodeViewModel)
                    
        {
            
        }
    }
}