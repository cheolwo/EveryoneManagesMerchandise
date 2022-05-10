using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeMCommodityViewModel : BaseCommodityViewModel<EmployeeMCommodity>
    {
        public BaseEmployeeMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMCommodityViewModel : CommodityPostViewModel<EmployeeMCommodity>
    {
        public EmployeePostMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMCommodityViewModel : CommodityPutViewModel<EmployeeMCommodity>
    {
        public EmployeePutMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMCommodityViewModel : CommodityDeleteViewModel<EmployeeMCommodity>
    {
        public EmployeeDeleteMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMCommodityViewModel : CommodityGetsViewModel<EmployeeMCommodity>
    {
        public EmployeeGetsMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
