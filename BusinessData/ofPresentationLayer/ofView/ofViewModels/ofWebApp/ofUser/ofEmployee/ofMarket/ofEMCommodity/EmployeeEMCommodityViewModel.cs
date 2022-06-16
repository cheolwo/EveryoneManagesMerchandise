using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class EmployeePostEMCommodityViewModel : EMCommodityPostViewModel<EmployeeEMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutEMCommodityViewModel : EMCommodityPutViewModel<EmployeeEMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteEMCommodityViewModel : EMCommodityDeleteViewModel<EmployeeEMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsEMCommodityViewModel : EMCommodityGetsViewModel<EmployeeEMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsEMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
