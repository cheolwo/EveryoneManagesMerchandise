using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostDividedTagViewModel : DividedTagPostViewModel<EmployerDividedTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostDividedTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutDividedTagViewModel : DividedTagPutViewModel<EmployerDividedTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteDividedTagViewModel : DividedTagDeleteViewModel<EmployerDividedTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsDividedTagViewModel : DividedTagGetsViewModel<EmployerDividedTag>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
