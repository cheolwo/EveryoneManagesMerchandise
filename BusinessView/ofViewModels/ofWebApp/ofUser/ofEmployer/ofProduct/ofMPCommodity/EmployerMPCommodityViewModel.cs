using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostMPCommodityViewModel : MPCommodityPostViewModel<EmployerMPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMPCommodityViewModel : MPCommodityPutViewModel<EmployerMPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMPCommodityViewModel : MPCommodityDeleteViewModel<EmployerMPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMPCommodityViewModel : MPCommodityGetsViewModel<EmployerMPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
