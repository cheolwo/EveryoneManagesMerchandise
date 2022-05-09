using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeEOCommodityViewModel : BaseStatusViewModel<EmployeeEOCommodity>
    {
        public BaseEmployeeEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEOCommodityViewModel : StatusPostViewModel<EmployeeEOCommodity>
    {
        public EmployeePostEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEOCommodityViewModel : StatusPutViewModel<EmployeeEOCommodity>
    {
        public EmployeePutEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEOCommodityViewModel : StatusDeleteViewModel<EmployeeEOCommodity>
    {
        public EmployeeDeleteEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEOCommodityViewModel : StatusGetsViewModel<EmployeeEOCommodity>
    {
        public EmployeeGetsEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
