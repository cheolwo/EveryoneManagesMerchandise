using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostPCommodityViewModel : PCommodityPostViewModel<EmployeePCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutPCommodityViewModel : PCommodityPutViewModel<EmployeePCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeletePCommodityViewModel : PCommodityDeleteViewModel<EmployeePCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeletePCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsPCommodityViewModel : PCommodityGetsViewModel<EmployeePCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
