using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeMWCommodityViewModel : BaseStatusViewModel<EmployeeMWCommodity>
    {
        public BaseEmployeeMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMWCommodityViewModel : StatusPostViewModel<EmployeeMWCommodity>
    {
        public EmployeePostMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMWCommodityViewModel : StatusPutViewModel<EmployeeMWCommodity>
    {
        public EmployeePutMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMWCommodityViewModel : StatusDeleteViewModel<EmployeeMWCommodity>
    {
        public EmployeeDeleteMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMWCommodityViewModel : StatusGetsViewModel<EmployeeMWCommodity>
    {
        public EmployeeGetsMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
