using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostPCommodityViewModel : PCommodityPostViewModel<EmployerPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutPCommodityViewModel : PCommodityPutViewModel<EmployerPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeletePCommodityViewModel : PCommodityDeleteViewModel<EmployerPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeletePCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsPCommodityViewModel : PCommodityGetsViewModel<EmployerPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
