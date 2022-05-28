using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProducterViewModel : BaseCenterViewModel<EmployeeProducter>
    {
        public BaseEmployeeProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostProducterViewModel : CenterPostViewModel<EmployeeProducter>
    {
        public EmployeePostProducterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutProducterViewModel : CenterPutViewModel<EmployeeProducter>
    {
        public EmployeePutProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteProducterViewModel : CenterDeleteViewModel<EmployeeProducter>
    {
        public EmployeeDeleteProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsProducterViewModel : CenterGetsViewModel<EmployeeProducter>
    {
        public EmployeeGetsProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
