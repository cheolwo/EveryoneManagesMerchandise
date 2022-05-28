using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeDotBarcodeViewModel : BaseEntityViewModel<EmployeeDotBarcode>
    {
        public BaseEmployeeDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostDotBarcodeViewModel : EntityPostViewModel<EmployeeDotBarcode>
    {
        public EmployeePostDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutDotBarcodeViewModel : EntityPutViewModel<EmployeeDotBarcode>
    {
        public EmployeePutDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteDotBarcodeViewModel : EntityDeleteViewModel<EmployeeDotBarcode>
    {
        public EmployeeDeleteDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsDotBarcodeViewModel : EntityGetsViewModel<EmployeeDotBarcode>
    {
        public EmployeeGetsDotBarcodeViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
