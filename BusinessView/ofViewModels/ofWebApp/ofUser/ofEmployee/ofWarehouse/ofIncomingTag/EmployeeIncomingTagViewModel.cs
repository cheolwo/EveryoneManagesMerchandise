using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostIncomingTagViewModel : IncomingTagPostViewModel<EmployeeIncomingTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutIncomingTagViewModel : IncomingTagPutViewModel<EmployeeIncomingTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteIncomingTagViewModel : IncomingTagDeleteViewModel<EmployeeIncomingTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsIncomingTagViewModel : IncomingTagGetsViewModel<EmployeeIncomingTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
