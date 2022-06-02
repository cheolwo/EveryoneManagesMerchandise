using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal
{
    public class EmployeePostJCommodityViewModel : JCommodityPostViewModel<EmployeeJCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutJCommodityViewModel : JCommodityPutViewModel<EmployeeJCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteJCommodityViewModel : JCommodityDeleteViewModel<EmployeeJCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsJCommodityViewModel : JCommodityGetsViewModel<EmployeeJCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsJCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
