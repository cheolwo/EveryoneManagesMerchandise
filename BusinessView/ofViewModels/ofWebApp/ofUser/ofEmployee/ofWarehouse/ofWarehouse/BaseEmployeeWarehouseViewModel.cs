using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWarehouseViewModel : BaseCenterViewModel<EmployeeWarehouse>
    {
        public BaseEmployeeWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostWarehouseViewModel : CenterPostViewModel<EmployeeWarehouse>
    {
        public EmployeePostWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutWarehouseViewModel : CenterPutViewModel<EmployeeWarehouse>
    {
        public EmployeePutWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteWarehouseViewModel : CenterDeleteViewModel<EmployeeWarehouse>
    {
        public EmployeeDeleteWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsWarehouseViewModel : CenterGetsViewModel<EmployeeWarehouse>
    {
        public EmployeeGetsWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
