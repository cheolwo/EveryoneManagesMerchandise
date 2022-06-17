using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class EmployeePostMCommodityViewModel : MCommodityPostViewModel<EmployeeMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMCommodityViewModel : MCommodityPutViewModel<EmployeeMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMCommodityViewModel : MCommodityDeleteViewModel<EmployeeMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMCommodityViewModel : MCommodityGetsViewModel<EmployeeMCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}