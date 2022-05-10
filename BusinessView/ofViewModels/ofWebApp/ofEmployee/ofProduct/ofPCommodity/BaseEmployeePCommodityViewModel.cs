using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeePCommodityViewModel : BaseCommodityViewModel<EmployeePCommodity>
    {
        public BaseEmployeePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostPCommodityViewModel : CommodityPostViewModel<EmployeePCommodity>
    {
        public EmployeePostPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutPCommodityViewModel : CommodityPutViewModel<EmployeePCommodity>
    {
        public EmployeePutPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeletePCommodityViewModel : CommodityDeleteViewModel<EmployeePCommodity>
    {
        public EmployeeDeletePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsPCommodityViewModel : CommodityGetsViewModel<EmployeePCommodity>
    {
        public EmployeeGetsPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
