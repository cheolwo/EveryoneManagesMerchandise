using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeEPCommodityViewModel : BaseStatusViewModel<EmployeeEPCommodity>
    {
        public BaseEmployeeEPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEPCommodityViewModel : StatusPostViewModel<EmployeeEPCommodity>
    {
        public EmployeePostEPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEPCommodityViewModel : StatusPutViewModel<EmployeeEPCommodity>
    {
        public EmployeePutEPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEPCommodityViewModel : StatusDeleteViewModel<EmployeeEPCommodity>
    {
        public EmployeeDeleteEPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEPCommodityViewModel : StatusGetsViewModel<EmployeeEPCommodity>
    {
        public EmployeeGetsEPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
