using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class EmployerPostJCommodityViewModel : JCommodityPostViewModel<EmployerJCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostJCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutJCommodityViewModel : JCommodityPutViewModel<EmployerJCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteJCommodityViewModel : JCommodityDeleteViewModel<EmployerJCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsJCommodityViewModel : JCommodityGetsViewModel<EmployerJCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
