using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class EmployeePostTCommodityViewModel : TCommodityPostViewModel<EmployeeTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutTCommodityViewModel : TCommodityPutViewModel<EmployeeTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteTCommodityViewModel : TCommodityDeleteViewModel<EmployeeTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsTCommodityViewModel : TCommodityGetsViewModel<EmployeeTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
