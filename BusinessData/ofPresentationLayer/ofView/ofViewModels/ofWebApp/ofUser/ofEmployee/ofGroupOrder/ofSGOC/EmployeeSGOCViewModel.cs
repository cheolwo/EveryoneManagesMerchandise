using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class EmployeePostSGOCViewModel : SGOCPostViewModel<EmployeeSGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutSGOCViewModel : SGOCPutViewModel<EmployeeSGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteSGOCViewModel : SGOCDeleteViewModel<EmployeeSGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsSGOCViewModel : SGOCGetsViewModel<EmployeeSGOC>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
