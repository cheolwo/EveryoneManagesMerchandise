using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProducterViewModel : BaseCenterViewModel<EmployerProducter>
    {
        public BaseEmployerProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostProducterViewModel : EmployerCenterPostViewModel<EmployerProducter>
    {
        public EmployerPostProducterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProducterViewModel : EmployerCenterPutViewModel<EmployerProducter>
    {
        public EmployerPutProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProducterViewModel : EmployerCenterDeleteViewModel<EmployerProducter>
    {
        public EmployerDeleteProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProducterViewModel : EmployerCenterGetsViewModel<EmployerProducter>
    {
        public EmployerGetsProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
