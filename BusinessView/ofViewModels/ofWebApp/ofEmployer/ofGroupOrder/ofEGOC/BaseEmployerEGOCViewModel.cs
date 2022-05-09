using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerEGOCViewModel : BaseStatusViewModel<EmployerEGOC>
    {
        public BaseEmployerEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEGOCViewModel : StatusPostViewModel<EmployerEGOC>
    {
        public EmployerPostEGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEGOCViewModel : StatusPutViewModel<EmployerEGOC>
    {
        public EmployerPutEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEGOCViewModel : StatusDeleteViewModel<EmployerEGOC>
    {
        public EmployerDeleteEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEGOCViewModel : StatusGetsViewModel<EmployerEGOC>
    {
        public EmployerGetsEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
