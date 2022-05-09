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
    public class EmployeePostIncomingTagommodityViewModel : EntityPostViewModel<EmployeeIncomingTag>
    {
        public EmployeePostIncomingTagommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutIncomingTagommodityViewModel : EntityPutViewModel<EmployeeIncomingTag>
    {
        public EmployeePutIncomingTagommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteIncomingTagommodityViewModel : EntityDeleteViewModel<EmployeeIncomingTag>
    {
        public EmployeeDeleteIncomingTagommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsIncomingTagommodityViewModel : EntityGetsViewModel<EmployeeIncomingTag>
    {
        public EmployeeGetsIncomingTagommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
