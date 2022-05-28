using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class EmployerPostEGOCViewModel : EGOCPostViewModel<EmployerEGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEGOCViewModel : EGOCPutViewModel<EmployerEGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEGOCViewModel : EGOCDeleteViewModel<EmployerEGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEGOCViewModel : EGOCGetsViewModel<EmployerEGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
