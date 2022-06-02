using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class EmployeePostEOCommodityViewModel : EOCommodityPostViewModel<EmployeeEOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutEOCommodityViewModel : EOCommodityPutViewModel<EmployeeEOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteEOCommodityViewModel : EOCommodityDeleteViewModel<EmployeeEOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsEOCommodityViewModel : EOCommodityGetsViewModel<EmployeeEOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsEOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
