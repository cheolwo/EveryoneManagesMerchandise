using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProductCenterViewModel : BaseCenterViewModel<EmployerProductCenter>
    {
        public BaseEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostProductCenterViewModel : EmployerCenterPostViewModel<EmployerProductCenter>
    {
        public EmployerPostProductCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProductCenterViewModel : EmployerCenterPutViewModel<EmployerProductCenter>
    {
        public EmployerPutProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProductCenterViewModel : EmployerCenterDeleteViewModel<EmployerProductCenter>
    {
        public EmployerDeleteProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProductCenterViewModel : EmployerCenterGetsViewModel<EmployerProductCenter>
    {
        public EmployerGetsProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
