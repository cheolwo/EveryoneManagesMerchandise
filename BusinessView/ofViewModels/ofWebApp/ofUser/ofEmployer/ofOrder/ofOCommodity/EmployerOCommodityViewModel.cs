using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class EmployerPostOCommodityViewModel : OCommodityPostViewModel<EmployerOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutOCommodityViewModel : OCommodityPutViewModel<EmployerOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteOCommodityViewModel : OCommodityDeleteViewModel<EmployerOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsOCommodityViewModel : OCommodityGetsViewModel<EmployerOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
