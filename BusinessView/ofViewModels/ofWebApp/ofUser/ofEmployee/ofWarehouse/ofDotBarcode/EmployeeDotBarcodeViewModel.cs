using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostDotBarcodeViewModel : DotBarcodePostViewModel<EmployeeDotBarcode>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutDotBarcodeViewModel : DotBarcodePutViewModel<EmployeeDotBarcode>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteDotBarcodeViewModel : DotBarcodeDeleteViewModel<EmployeeDotBarcode>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsDotBarcodeViewModel : DotBarcodeGetsViewModel<EmployeeDotBarcode>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
