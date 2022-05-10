using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerProductLandViewModel : BaseEntityViewModel<EmployerProductLand>
    {
        public BaseEmployerProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostProductLandViewModel : EntityPostViewModel<EmployerProductLand>
    {
        public EmployerPostProductLandViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutProductLandViewModel : EntityPutViewModel<EmployerProductLand>
    {
        public EmployerPutProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteProductLandViewModel : EntityDeleteViewModel<EmployerProductLand>
    {
        public EmployerDeleteProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsProductLandViewModel : EntityGetsViewModel<EmployerProductLand>
    {
        public EmployerGetsProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
