using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostDotBarcodeViewModel : DotBarcodePostViewModel<EmployerDotBarcode>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutDotBarcodeViewModel : DotBarcodePutViewModel<EmployerDotBarcode>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteDotBarcodeViewModel : DotBarcodeDeleteViewModel<EmployerDotBarcode>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsDotBarcodeViewModel : DotBarcodeGetsViewModel<EmployerDotBarcode>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsDotBarcodeViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
