using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProducterViewModel : BaseCenterViewModel<EmployerProducter>
    {
        public BaseEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostProducterViewModel : CenterPostViewModel<EmployerProducter>
    {
        public EmployerPostProducterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProducterViewModel : CenterPutViewModel<EmployerProducter>
    {
        public EmployerPutProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProducterViewModel : CenterDeleteViewModel<EmployerProducter>
    {
        public EmployerDeleteProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProducterViewModel : CenterGetsViewModel<EmployerProducter>
    {
        public EmployerGetsProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
