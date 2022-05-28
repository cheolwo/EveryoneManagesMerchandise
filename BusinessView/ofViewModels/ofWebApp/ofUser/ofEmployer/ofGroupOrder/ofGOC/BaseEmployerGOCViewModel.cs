using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCViewModel : BaseCenterViewModel<EmployerGOC>
    {
        public BaseEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostGOCViewModel : EmployerCenterPostViewModel<EmployerGOC>
    {
        public EmployerPostGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutGOCViewModel : EmployerCenterPutViewModel<EmployerGOC>
    {
        public EmployerPutGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteGOCViewModel : EmployerCenterDeleteViewModel<EmployerGOC>
    {
        public EmployerDeleteGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsGOCViewModel : EmployerCenterGetsViewModel<EmployerGOC>
    {
        public EmployerGetsGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
