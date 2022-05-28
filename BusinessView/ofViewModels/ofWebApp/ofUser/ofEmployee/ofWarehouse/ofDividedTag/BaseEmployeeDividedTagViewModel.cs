using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeDividedTagViewModel : BaseEntityViewModel<EmployeeDividedTag>
    {
        public BaseEmployeeDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostDividedTagViewModel : EntityPostViewModel<EmployeeDividedTag>
    {
        public EmployeePostDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutDividedTagViewModel : EntityPutViewModel<EmployeeDividedTag>
    {
        public EmployeePutDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteDividedTagViewModel : EntityDeleteViewModel<EmployeeDividedTag>
    {
        public EmployeeDeleteDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsDividedTagViewModel : EntityGetsViewModel<EmployeeDividedTag>
    {
        public EmployeeGetsDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
