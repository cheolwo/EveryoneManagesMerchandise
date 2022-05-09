using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeEWCommodityViewModel : BaseStatusViewModel<EmployeeEWCommodity>
    {
        public BaseEmployeeEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEWCommodityViewModel : StatusPostViewModel<EmployeeEWCommodity>
    {
        public EmployeePostEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEWCommodityViewModel : StatusPutViewModel<EmployeeEWCommodity>
    {
        public EmployeePutEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEWCommodityViewModel : StatusDeleteViewModel<EmployeeEWCommodity>
    {
        public EmployeeDeleteEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEWCommodityViewModel : StatusGetsViewModel<EmployeeEWCommodity>
    {
        public EmployeeGetsEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
