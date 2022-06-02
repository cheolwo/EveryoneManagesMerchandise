using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class EmployeePostSOCommodityViewModel : SOCommodityPostViewModel<EmployeeSOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutSOCommodityViewModel : SOCommodityPutViewModel<EmployeeSOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteSOCommodityViewModel : SOCommodityDeleteViewModel<EmployeeSOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsSOCommodityViewModel : SOCommodityGetsViewModel<EmployeeSOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsSOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
