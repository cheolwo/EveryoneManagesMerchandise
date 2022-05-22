using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerSGOCViewModel : BaseStatusViewModel<EmployerSGOC>
    {
        public BaseEmployerSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSGOCViewModel : EmployerStatusPostViewModel<EmployerSGOC>
    {
        public EmployerPostSGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSGOCViewModel : EmployerStatusPutViewModel<EmployerSGOC>
    {
        public EmployerPutSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSGOCViewModel : EmployerStatusDeleteViewModel<EmployerSGOC>
    {
        public EmployerDeleteSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSGOCViewModel : EmployerStatusGetsViewModel<EmployerSGOC>
    {
        public EmployerGetsSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
