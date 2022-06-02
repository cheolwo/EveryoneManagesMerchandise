using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class EmployerPostMGOCViewModel : MGOCPostViewModel<EmployerMGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMGOCViewModel : MGOCPutViewModel<EmployerMGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMGOCViewModel : MGOCDeleteViewModel<EmployerMGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMGOCViewModel : MGOCGetsViewModel<EmployerMGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
