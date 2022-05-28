using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeSOCommodityViewModel : BaseStatusViewModel<EmployeeSOCommodity>
    {
        public BaseEmployeeSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSOCommodityViewModel : StatusPostViewModel<EmployeeSOCommodity>
    {
        public EmployeePostSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSOCommodityViewModel : StatusPutViewModel<EmployeeSOCommodity>
    {
        public EmployeePutSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSOCommodityViewModel : StatusDeleteViewModel<EmployeeSOCommodity>
    {
        public EmployeeDeleteSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSOCommodityViewModel : StatusGetsViewModel<EmployeeSOCommodity>
    {
        public EmployeeGetsSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
