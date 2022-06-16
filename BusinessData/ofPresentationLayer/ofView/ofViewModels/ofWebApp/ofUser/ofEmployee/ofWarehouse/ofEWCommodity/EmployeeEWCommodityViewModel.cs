using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostEWCommodityViewModel : EWCommodityPostViewModel<EmployeeEWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutEWCommodityViewModel : EWCommodityPutViewModel<EmployeeEWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteEWCommodityViewModel : EWCommodityDeleteViewModel<EmployeeEWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsEWCommodityViewModel : EWCommodityGetsViewModel<EmployeeEWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsEWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
