using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSGOCViewModel : BaseStatusViewModel<EmployerSGOC>
    {
        public BaseEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSGOCViewModel : StatusPostViewModel<EmployerSGOC>
    {
        public EmployerPostSGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSGOCViewModel : StatusPutViewModel<EmployerSGOC>
    {
        public EmployerPutSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSGOCViewModel : StatusDeleteViewModel<EmployerSGOC>
    {
        public EmployerDeleteSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSGOCViewModel : StatusGetsViewModel<EmployerSGOC>
    {
        public EmployerGetsSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
