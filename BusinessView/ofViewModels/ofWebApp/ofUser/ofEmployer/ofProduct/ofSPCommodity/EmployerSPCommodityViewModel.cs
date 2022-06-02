using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostSPCommodityViewModel : SPCommodityPostViewModel<EmployerSPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSPCommodityViewModel : SPCommodityPutViewModel<EmployerSPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSPCommodityViewModel : SPCommodityDeleteViewModel<EmployerSPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSPCommodityViewModel : SPCommodityGetsViewModel<EmployerSPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
