using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class EmployeePostProducterViewModel : ProducterPostViewModel<EmployeeProducter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostProducterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutProducterViewModel : ProducterPutViewModel<EmployeeProducter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteProducterViewModel : ProducterDeleteViewModel<EmployeeProducter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsProducterViewModel : ProducterGetsViewModel<EmployeeProducter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsProducterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
