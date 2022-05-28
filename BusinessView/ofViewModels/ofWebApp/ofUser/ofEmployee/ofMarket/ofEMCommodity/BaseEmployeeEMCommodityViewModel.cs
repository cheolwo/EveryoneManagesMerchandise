using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeEMCommodityViewModel : BaseStatusViewModel<EmployeeEMCommodity>
    {
        public BaseEmployeeEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEMCommodityViewModel : StatusPostViewModel<EmployeeEMCommodity>
    {
        public EmployeePostEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEMCommodityViewModel : StatusPutViewModel<EmployeeEMCommodity>
    {
        public EmployeePutEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEMCommodityViewModel : StatusDeleteViewModel<EmployeeEMCommodity>
    {
        public EmployeeDeleteEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEMCommodityViewModel : StatusGetsViewModel<EmployeeEMCommodity>
    {
        public EmployeeGetsEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
