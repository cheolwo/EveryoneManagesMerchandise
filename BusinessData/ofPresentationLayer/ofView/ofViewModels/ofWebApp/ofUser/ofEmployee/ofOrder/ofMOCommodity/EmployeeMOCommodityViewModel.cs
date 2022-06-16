using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class EmployeePostMOCommodityViewModel : MOCommodityPostViewModel<EmployeeMOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMOCommodityViewModel : MOCommodityPutViewModel<EmployeeMOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMOCommodityViewModel : MOCommodityDeleteViewModel<EmployeeMOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMOCommodityViewModel : MOCommodityGetsViewModel<EmployeeMOCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
