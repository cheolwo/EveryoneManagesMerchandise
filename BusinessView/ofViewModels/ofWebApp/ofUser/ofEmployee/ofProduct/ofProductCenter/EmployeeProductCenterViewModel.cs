using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostProductCenterViewModel : ProductCenterPostViewModel<EmployeeProductCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutProductCenterViewModel : ProductCenterPutViewModel<EmployeeProductCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteProductCenterViewModel : ProductCenterDeleteViewModel<EmployeeProductCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsProductCenterViewModel : ProductCenterGetsViewModel<EmployeeProductCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsProductCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
