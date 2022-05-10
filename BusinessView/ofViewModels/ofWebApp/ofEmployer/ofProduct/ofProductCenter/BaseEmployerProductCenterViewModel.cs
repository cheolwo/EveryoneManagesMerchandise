using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProductCenterViewModel : BaseCenterViewModel<EmployerProductCenter>
    {
        public BaseEmployerProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostProductCenterViewModel : CenterPostViewModel<EmployerProductCenter>
    {
        public EmployerPostProductCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProductCenterViewModel : CenterPutViewModel<EmployerProductCenter>
    {
        public EmployerPutProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProductCenterViewModel : CenterDeleteViewModel<EmployerProductCenter>
    {
        public EmployerDeleteProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProductCenterViewModel : CenterGetsViewModel<EmployerProductCenter>
    {
        public EmployerGetsProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
