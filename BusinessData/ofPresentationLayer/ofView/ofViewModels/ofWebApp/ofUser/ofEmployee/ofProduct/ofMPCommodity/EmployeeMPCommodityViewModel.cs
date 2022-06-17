using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostMPCommodityViewModel : MPCommodityPostViewModel<EmployeeMPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMPCommodityViewModel : MPCommodityPutViewModel<EmployeeMPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMPCommodityViewModel : MPCommodityDeleteViewModel<EmployeeMPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMPCommodityViewModel : MPCommodityGetsViewModel<EmployeeMPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}