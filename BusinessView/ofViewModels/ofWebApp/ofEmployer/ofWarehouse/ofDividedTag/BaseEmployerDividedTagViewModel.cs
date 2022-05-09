using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerDividedTagViewModel : BaseEntityViewModel<EmployerDividedTag>
    {
        public BaseEmployerDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostDividedTagViewModel : EntityPostViewModel<EmployerDividedTag>
    {
        public EmployerPostDividedTagViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutDividedTagViewModel : EntityPutViewModel<EmployerDividedTag>
    {
        public EmployerPutDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteDividedTagViewModel : EntityDeleteViewModel<EmployerDividedTag>
    {
        public EmployerDeleteDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsDividedTagViewModel : EntityGetsViewModel<EmployerDividedTag>
    {
        public EmployerGetsDividedTagViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
