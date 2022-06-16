using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostProductLandViewModel : ProductLandPostViewModel<EmployeeProductLand>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutProductLandViewModel : ProductLandPutViewModel<EmployeeProductLand>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteProductLandViewModel : ProductLandDeleteViewModel<EmployeeProductLand>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsProductLandViewModel : ProductLandGetsViewModel<EmployeeProductLand>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
