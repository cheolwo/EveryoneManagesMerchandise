using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeMPCommodityViewModel : BaseStatusViewModel<EmployeeMPCommodity>
    {
        public BaseEmployeeMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMPCommodityViewModel : StatusPostViewModel<EmployeeMPCommodity>
    {
        public EmployeePostMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMPCommodityViewModel : StatusPutViewModel<EmployeeMPCommodity>
    {
        public EmployeePutMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMPCommodityViewModel : StatusDeleteViewModel<EmployeeMPCommodity>
    {
        public EmployeeDeleteMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMPCommodityViewModel : StatusGetsViewModel<EmployeeMPCommodity>
    {
        public EmployeeGetsMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
