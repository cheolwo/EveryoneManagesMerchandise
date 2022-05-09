using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerDotBarcodeViewModel : BaseEntityViewModel<EmployerDotBarcode>
    {
        public BaseEmployerDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostDotBarcodeViewModel : EntityPostViewModel<EmployerDotBarcode>
    {
        public EmployerPostDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutDotBarcodeViewModel : EntityPutViewModel<EmployerDotBarcode>
    {
        public EmployerPutDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteDotBarcodeViewModel : EntityDeleteViewModel<EmployerDotBarcode>
    {
        public EmployerDeleteDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsDotBarcodeViewModel : EntityGetsViewModel<EmployerDotBarcode>
    {
        public EmployerGetsDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
