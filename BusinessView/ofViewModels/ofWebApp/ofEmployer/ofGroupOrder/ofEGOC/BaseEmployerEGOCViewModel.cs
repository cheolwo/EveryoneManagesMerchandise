using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerEGOCViewModel : BaseStatusViewModel<EmployerEGOC>
    {
        public BaseEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEGOCViewModel : EmployerStatusPostViewModel<EmployerEGOC>
    {
        public EmployerPostEGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEGOCViewModel : EmployerStatusPutViewModel<EmployerEGOC>
    {
        public EmployerPutEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEGOCViewModel : EmployerStatusDeleteViewModel<EmployerEGOC>
    {
        public EmployerDeleteEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEGOCViewModel : EmployerStatusGetsViewModel<EmployerEGOC>
    {
        public EmployerGetsEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
