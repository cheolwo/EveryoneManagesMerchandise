using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostIncomingTagViewModel : IncomingTagPostViewModel<EmployerIncomingTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutIncomingTagViewModel : IncomingTagPutViewModel<EmployerIncomingTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteIncomingTagViewModel : IncomingTagDeleteViewModel<EmployerIncomingTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsIncomingTagViewModel : IncomingTagGetsViewModel<EmployerIncomingTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsIncomingTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
