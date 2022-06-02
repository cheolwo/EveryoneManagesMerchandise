using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class EmployeePostSTCommodityViewModel : STCommodityPostViewModel<EmployeeSTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutSTCommodityViewModel : STCommodityPutViewModel<EmployeeSTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteSTCommodityViewModel : STCommodityDeleteViewModel<EmployeeSTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsSTCommodityViewModel : STCommodityGetsViewModel<EmployeeSTCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsSTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
