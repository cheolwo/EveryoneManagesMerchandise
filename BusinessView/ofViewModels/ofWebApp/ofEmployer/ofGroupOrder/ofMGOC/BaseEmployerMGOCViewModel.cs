using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerMGOCViewModel : BaseStatusViewModel<EmployerMGOC>
    {
        public BaseEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMGOCViewModel : StatusPostViewModel<EmployerMGOC>
    {
        public EmployerPostMGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMGOCViewModel : StatusPutViewModel<EmployerMGOC>
    {
        public EmployerPutMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMGOCViewModel : StatusDeleteViewModel<EmployerMGOC>
    {
        public EmployerDeleteMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMGOCViewModel : StatusGetsViewModel<EmployerMGOC>
    {
        public EmployerGetsMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
