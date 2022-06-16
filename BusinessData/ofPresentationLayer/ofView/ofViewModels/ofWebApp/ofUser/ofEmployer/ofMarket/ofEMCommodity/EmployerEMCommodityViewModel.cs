using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostEMCommodityViewModel : EMCommodityPostViewModel<EmployerEMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEMCommodityViewModel : EMCommodityPutViewModel<EmployerEMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEMCommodityViewModel : EMCommodityDeleteViewModel<EmployerEMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEMCommodityViewModel : EMCommodityGetsViewModel<EmployerEMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
