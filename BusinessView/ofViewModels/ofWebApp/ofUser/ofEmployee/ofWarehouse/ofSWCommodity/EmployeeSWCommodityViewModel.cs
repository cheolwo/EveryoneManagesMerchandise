using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostSWCommodityViewModel : SWCommodityPostViewModel<EmployeeSWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutSWCommodityViewModel : SWCommodityPutViewModel<EmployeeSWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteSWCommodityViewModel : SWCommodityDeleteViewModel<EmployeeSWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsSWCommodityViewModel : SWCommodityGetsViewModel<EmployeeSWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsSWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
