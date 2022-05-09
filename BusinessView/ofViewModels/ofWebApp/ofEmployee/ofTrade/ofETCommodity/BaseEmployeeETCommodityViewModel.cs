using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeETCommodityViewModel : BaseStatusViewModel<EmployeeETCommodity>
    {
        public BaseEmployeeETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostETCommodityViewModel : StatusPostViewModel<EmployeeETCommodity>
    {
        public EmployeePostETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutETCommodityViewModel : StatusPutViewModel<EmployeeETCommodity>
    {
        public EmployeePutETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteETCommodityViewModel : StatusDeleteViewModel<EmployeeETCommodity>
    {
        public EmployeeDeleteETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsETCommodityViewModel : StatusGetsViewModel<EmployeeETCommodity>
    {
        public EmployeeGetsETCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
