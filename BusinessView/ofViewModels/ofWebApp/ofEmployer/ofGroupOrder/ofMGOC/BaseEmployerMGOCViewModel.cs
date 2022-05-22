using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerMGOCViewModel : BaseStatusViewModel<EmployerMGOC>
    {
        public BaseEmployerMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMGOCViewModel : EmployerStatusPostViewModel<EmployerMGOC>
    {
        public EmployerPostMGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMGOCViewModel : EmployerStatusPutViewModel<EmployerMGOC>
    {
        public EmployerPutMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMGOCViewModel : EmployerStatusDeleteViewModel<EmployerMGOC>
    {
        public EmployerDeleteMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMGOCViewModel : EmployerStatusGetsViewModel<EmployerMGOC>
    {
        public EmployerGetsMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
