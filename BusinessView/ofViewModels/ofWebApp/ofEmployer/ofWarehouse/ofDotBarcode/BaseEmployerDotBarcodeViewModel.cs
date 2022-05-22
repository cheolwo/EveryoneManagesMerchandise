using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostDotBarcodeViewModel : EmployerPostViewModel<EmployerDotBarcode>
    {
        public EmployerPostDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutDotBarcodeViewModel : EmployerPutViewModel<EmployerDotBarcode>
    {
        public EmployerPutDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteDotBarcodeViewModel : EmployerDeleteViewModel<EmployerDotBarcode>
    {
        public EmployerDeleteDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsDotBarcodeViewModel : EmployerGetsViewModel<EmployerDotBarcode>
    {
        public EmployerGetsDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
