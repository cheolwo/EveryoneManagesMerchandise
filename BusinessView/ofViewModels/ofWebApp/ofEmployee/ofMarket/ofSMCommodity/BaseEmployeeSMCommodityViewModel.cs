using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeSMCommodityViewModel : BaseStatusViewModel<EmployeeSMCommodity>
    {
        public BaseEmployeeSMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSMCommodityViewModel : StatusPostViewModel<EmployeeSMCommodity>
    {
        public EmployeePostSMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSMCommodityViewModel : StatusPutViewModel<EmployeeSMCommodity>
    {
        public EmployeePutSMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSMCommodityViewModel : StatusDeleteViewModel<EmployeeSMCommodity>
    {
        public EmployeeDeleteSMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSMCommodityViewModel : StatusGetsViewModel<EmployeeSMCommodity>
    {
        public EmployeeGetsSMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
