using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostIncomingTagViewModel : EmployerPostViewModel<EmployerIncomingTag>
    {
        public EmployerPostIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutIncomingTagViewModel : EmployerPutViewModel<EmployerIncomingTag>
    {
        public EmployerPutIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteIncomingTagViewModel : EmployerDeleteViewModel<EmployerIncomingTag>
    {
        public EmployerDeleteIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsIncomingTagViewModel : EmployerGetsViewModel<EmployerIncomingTag>
    {
        public EmployerGetsIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
