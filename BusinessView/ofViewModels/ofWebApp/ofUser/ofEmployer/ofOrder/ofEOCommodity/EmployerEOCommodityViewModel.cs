using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class EmployerPostEOCommodityViewModel : EOCommodityPostViewModel<EmployerEOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEOCommodityViewModel : EOCommodityPutViewModel<EmployerEOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEOCommodityViewModel : EOCommodityDeleteViewModel<EmployerEOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEOCommodityViewModel : EOCommodityGetsViewModel<EmployerEOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
