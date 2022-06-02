using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class EmployerPostGOCCViewModel : GOCCPostViewModel<EmployerGOCC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostGOCCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutGOCCViewModel : GOCCPutViewModel<EmployerGOCC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteGOCCViewModel : GOCCDeleteViewModel<EmployerGOCC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsGOCCViewModel : GOCCGetsViewModel<EmployerGOCC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
