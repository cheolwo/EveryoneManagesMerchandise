using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerIncomingTagViewModel : BaseEntityViewModel<EmployerIncomingTag>
    {
        public BaseEmployerIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostIncomingTagViewModel : EntityPostViewModel<EmployerIncomingTag>
    {
        public EmployerPostIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutIncomingTagViewModel : EntityPutViewModel<EmployerIncomingTag>
    {
        public EmployerPutIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteIncomingTagViewModel : EntityDeleteViewModel<EmployerIncomingTag>
    {
        public EmployerDeleteIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsIncomingTagViewModel : EntityGetsViewModel<EmployerIncomingTag>
    {
        public EmployerGetsIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
