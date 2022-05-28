using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostProductLandViewModel : EmployerPostViewModel<EmployerProductLand>
    {
        public EmployerPostProductLandViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProductLandViewModel : EmployerPutViewModel<EmployerProductLand>
    {
        public EmployerPutProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProductLandViewModel : EmployerDeleteViewModel<EmployerProductLand>
    {
        public EmployerDeleteProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProductLandViewModel : EmployerGetsViewModel<EmployerProductLand>
    {
        public EmployerGetsProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
