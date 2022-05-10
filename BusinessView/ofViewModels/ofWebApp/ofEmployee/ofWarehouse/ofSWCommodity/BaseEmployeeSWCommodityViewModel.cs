using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeSWCommodityViewModel : BaseStatusViewModel<EmployeeSWCommodity>
    {
        public BaseEmployeeSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSWCommodityViewModel : StatusPostViewModel<EmployeeSWCommodity>
    {
        public EmployeePostSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSWCommodityViewModel : StatusPutViewModel<EmployeeSWCommodity>
    {
        public EmployeePutSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSWCommodityViewModel : StatusDeleteViewModel<EmployeeSWCommodity>
    {
        public EmployeeDeleteSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSWCommodityViewModel : StatusGetsViewModel<EmployeeSWCommodity>
    {
        public EmployeeGetsSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
