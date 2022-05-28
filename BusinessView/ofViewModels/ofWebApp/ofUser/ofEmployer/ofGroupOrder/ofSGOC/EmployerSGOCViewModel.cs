using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class EmployerPostSGOCViewModel : SGOCPostViewModel<EmployerSGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSGOCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSGOCViewModel : SGOCPutViewModel<EmployerSGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSGOCViewModel : SGOCDeleteViewModel<EmployerSGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSGOCViewModel : SGOCGetsViewModel<EmployerSGOC>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSGOCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
