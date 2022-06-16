using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostSPCommodityViewModel : SPCommodityPostViewModel<EmployeeSPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutSPCommodityViewModel : SPCommodityPutViewModel<EmployeeSPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteSPCommodityViewModel : SPCommodityDeleteViewModel<EmployeeSPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsSPCommodityViewModel : SPCommodityGetsViewModel<EmployeeSPCommodity>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsSPCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
