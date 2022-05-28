using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;
using BusinessView.ofUser.ofCommon;

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
