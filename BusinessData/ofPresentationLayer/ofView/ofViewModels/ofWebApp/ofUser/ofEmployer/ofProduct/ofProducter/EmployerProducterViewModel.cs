using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostProducterViewModel : ProducterPostViewModel<EmployerProducter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostProducterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutProducterViewModel : ProducterPutViewModel<EmployerProducter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteProducterViewModel : ProducterDeleteViewModel<EmployerProducter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsProducterViewModel : ProducterGetsViewModel<EmployerProducter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsProducterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}