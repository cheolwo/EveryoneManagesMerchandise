using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class EmployerPostGOCViewModel : GOCPostViewModel<EmployerGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutGOCViewModel : GOCPutViewModel<EmployerGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteGOCViewModel : GOCDeleteViewModel<EmployerGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsGOCViewModel : GOCGetsViewModel<EmployerGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
