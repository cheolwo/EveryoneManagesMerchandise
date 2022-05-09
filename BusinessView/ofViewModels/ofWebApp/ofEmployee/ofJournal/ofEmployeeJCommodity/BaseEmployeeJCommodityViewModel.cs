using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class BaseEmployeeJCommodityViewModel : BaseCommodityViewModel<EmployeeJCommodity>
    {
        public BaseEmployeeJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostJCommodityViewModel : CommodityPostViewModel<EmployeeJCommodity>
    {
        public EmployeePostJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutJCommodityViewModel : CommodityPutViewModel<EmployeeJCommodity>
    {
        public EmployeePutJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteJCommodityViewModel : CommodityDeleteViewModel<EmployeeJCommodity>
    {
        public EmployeeDeleteJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsJCommodityViewModel : CommodityGetsViewModel<EmployeeJCommodity>
    {
        public EmployeeGetsJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
