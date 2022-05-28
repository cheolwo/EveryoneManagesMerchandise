using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeSTCommodityViewModel : BaseStatusViewModel<EmployeeSTCommodity>
    {
        public BaseEmployeeSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSTCommodityViewModel : StatusPostViewModel<EmployeeSTCommodity>
    {
        public EmployeePostSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSTCommodityViewModel : StatusPutViewModel<EmployeeSTCommodity>
    {
        public EmployeePutSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSTCommodityViewModel : StatusDeleteViewModel<EmployeeSTCommodity>
    {
        public EmployeeDeleteSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSTCommodityViewModel : StatusGetsViewModel<EmployeeSTCommodity>
    {
        public EmployeeGetsSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
