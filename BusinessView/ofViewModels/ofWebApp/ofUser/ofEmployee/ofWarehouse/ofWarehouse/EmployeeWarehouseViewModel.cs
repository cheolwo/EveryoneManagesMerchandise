using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostWarehouseViewModel : WarehousePostViewModel<EmployeeWarehouse>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutWarehouseViewModel : WarehousePutViewModel<EmployeeWarehouse>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteWarehouseViewModel : WarehouseDeleteViewModel<EmployeeWarehouse>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsWarehouseViewModel : WarehouseGetsViewModel<EmployeeWarehouse>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsWarehouseViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
