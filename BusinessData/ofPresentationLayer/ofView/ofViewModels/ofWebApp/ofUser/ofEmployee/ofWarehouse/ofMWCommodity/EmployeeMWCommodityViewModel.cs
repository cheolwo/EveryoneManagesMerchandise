using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostMWCommodityViewModel : MWCommodityPostViewModel<EmployeeMWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMWCommodityViewModel : MWCommodityPutViewModel<EmployeeMWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMWCommodityViewModel : MWCommodityDeleteViewModel<EmployeeMWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMWCommodityViewModel : MWCommodityGetsViewModel<EmployeeMWCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMWCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}