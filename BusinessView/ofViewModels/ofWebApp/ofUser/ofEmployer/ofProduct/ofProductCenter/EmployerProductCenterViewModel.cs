using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostProductCenterViewModel : ProductCenterPostViewModel<EmployerProductCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostProductCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutProductCenterViewModel : ProductCenterPutViewModel<EmployerProductCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteProductCenterViewModel : ProductCenterDeleteViewModel<EmployerProductCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsProductCenterViewModel : ProductCenterGetsViewModel<EmployerProductCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsProductCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
