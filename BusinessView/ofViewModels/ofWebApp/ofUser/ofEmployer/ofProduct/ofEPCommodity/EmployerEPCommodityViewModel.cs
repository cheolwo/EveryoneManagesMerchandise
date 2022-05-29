using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofEPCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class EmployerPostEPCommodityViewModel : EPCommodityPostViewModel<EmployerEPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEPCommodityViewModel : EPCommodityPutViewModel<EmployerEPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEPCommodityViewModel : EPCommodityDeleteViewModel<EmployerEPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEPCommodityViewModel : EPCommodityGetsViewModel<EmployerEPCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}