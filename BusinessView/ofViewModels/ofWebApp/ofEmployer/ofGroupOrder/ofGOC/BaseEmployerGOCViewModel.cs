using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCViewModel : BaseCenterViewModel<EmployerGOC>
    {
        public BaseEmployerGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostGOCViewModel : CenterPostViewModel<EmployerGOC>
    {
        public EmployerPostGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutGOCViewModel : CenterPutViewModel<EmployerGOC>
    {
        public EmployerPutGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteGOCViewModel : CenterDeleteViewModel<EmployerGOC>
    {
        public EmployerDeleteGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsGOCViewModel : CenterGetsViewModel<EmployerGOC>
    {
        public EmployerGetsGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
