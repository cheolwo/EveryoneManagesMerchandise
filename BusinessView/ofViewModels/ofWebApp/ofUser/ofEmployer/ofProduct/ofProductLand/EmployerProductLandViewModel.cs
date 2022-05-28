using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostProductLandViewModel : ProductLandPostViewModel<EmployerProductLand>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostProductLandViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutProductLandViewModel : ProductLandPutViewModel<EmployerProductLand>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteProductLandViewModel : ProductLandDeleteViewModel<EmployerProductLand>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsProductLandViewModel : ProductLandGetsViewModel<EmployerProductLand>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsProductLandViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
