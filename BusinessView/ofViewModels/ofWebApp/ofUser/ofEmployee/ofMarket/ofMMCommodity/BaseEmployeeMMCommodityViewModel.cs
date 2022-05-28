using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeMMCommodityViewModel : BaseStatusViewModel<EmployeeMMCommodity>
    {
        public BaseEmployeeMMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMMCommodityViewModel : StatusPostViewModel<EmployeeMMCommodity>
    {
        public EmployeePostMMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMMCommodityViewModel : StatusPutViewModel<EmployeeMMCommodity>
    {
        public EmployeePutMMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMMCommodityViewModel : StatusDeleteViewModel<EmployeeMMCommodity>
    {
        public EmployeeDeleteMMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMMCommodityViewModel : StatusGetsViewModel<EmployeeMMCommodity>
    {
        public EmployeeGetsMMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
