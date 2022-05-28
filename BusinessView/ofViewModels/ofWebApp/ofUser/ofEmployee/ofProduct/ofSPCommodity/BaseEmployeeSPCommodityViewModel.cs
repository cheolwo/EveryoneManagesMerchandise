using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeSPCommodityViewModel : BaseStatusViewModel<EmployeeSPCommodity>
    {
        public BaseEmployeeSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSPCommodityViewModel : StatusPostViewModel<EmployeeSPCommodity>
    {
        public EmployeePostSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSPCommodityViewModel : StatusPutViewModel<EmployeeSPCommodity>
    {
        public EmployeePutSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSPCommodityViewModel : StatusDeleteViewModel<EmployeeSPCommodity>
    {
        public EmployeeDeleteSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSPCommodityViewModel : StatusGetsViewModel<EmployeeSPCommodity>
    {
        public EmployeeGetsSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
