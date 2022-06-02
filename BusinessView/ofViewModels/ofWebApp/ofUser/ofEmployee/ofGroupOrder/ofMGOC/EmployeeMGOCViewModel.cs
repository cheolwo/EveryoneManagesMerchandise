using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class EmployeePostMGOCViewModel : MGOCPostViewModel<EmployeeMGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMGOCViewModel : MGOCPutViewModel<EmployeeMGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMGOCViewModel : MGOCDeleteViewModel<EmployeeMGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMGOCViewModel : MGOCGetsViewModel<EmployeeMGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
