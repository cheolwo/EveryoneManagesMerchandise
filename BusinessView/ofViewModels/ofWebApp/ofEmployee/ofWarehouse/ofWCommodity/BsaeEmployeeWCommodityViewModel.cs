using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeWCommodityViewModel : BaseCommodityViewModel<EmployeeWCommodity>
    {
        public BaseEmployeeWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostWCommodityViewModel : CommodityPostViewModel<EmployeeWCommodity>
    {
        public EmployeePostWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutWCommodityViewModel : CommodityPutViewModel<EmployeeWCommodity>
    {
        public EmployeePutWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteWCommodityViewModel : CommodityDeleteViewModel<EmployeeWCommodity>
    {
        public EmployeeDeleteWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsWCommodityViewModel : CommodityGetsViewModel<EmployeeWCommodity>
    {
        public EmployeeGetsWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
