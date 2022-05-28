using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostDividedTagViewModel : EmployerPostViewModel<EmployerDividedTag>
    {
        public EmployerPostDividedTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutDividedTagViewModel : EmployerPutViewModel<EmployerDividedTag>
    {
        public EmployerPutDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteDividedTagViewModel : EmployerDeleteViewModel<EmployerDividedTag>
    {
        public EmployerDeleteDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsDividedTagViewModel : EmployerGetsViewModel<EmployerDividedTag>
    {
        public EmployerGetsDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
