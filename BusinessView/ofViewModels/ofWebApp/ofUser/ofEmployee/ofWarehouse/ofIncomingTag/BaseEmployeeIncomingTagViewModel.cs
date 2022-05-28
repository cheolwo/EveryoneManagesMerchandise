using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class BaseEmployeeIncomingTagViewModel : BaseEntityViewModel<EmployeeIncomingTag>
    {
        public BaseEmployeeIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostIncomingTagViewModel : EntityPostViewModel<EmployeeIncomingTag>
    {
        public EmployeePostIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutIncomingTagViewModel : EntityPutViewModel<EmployeeIncomingTag>
    {
        public EmployeePutIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteIncomingTagViewModel : EntityDeleteViewModel<EmployeeIncomingTag>
    {
        public EmployeeDeleteIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsIncomingTagViewModel : EntityGetsViewModel<EmployeeIncomingTag>
    {
        public EmployeeGetsIncomingTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
