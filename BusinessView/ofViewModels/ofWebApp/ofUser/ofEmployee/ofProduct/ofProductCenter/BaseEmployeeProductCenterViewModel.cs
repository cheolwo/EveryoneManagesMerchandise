using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProductCenterViewModel : BaseCenterViewModel<EmployeeProductCenter>
    {
        public BaseEmployeeProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostProductCenterViewModel : CenterPostViewModel<EmployeeProductCenter>
    {
        public EmployeePostProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutProductCenterViewModel : CenterPutViewModel<EmployeeProductCenter>
    {
        public EmployeePutProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteProductCenterViewModel : CenterDeleteViewModel<EmployeeProductCenter>
    {
        public EmployeeDeleteProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsProductCenterViewModel : CenterGetsViewModel<EmployeeProductCenter>
    {
        public EmployeeGetsProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
