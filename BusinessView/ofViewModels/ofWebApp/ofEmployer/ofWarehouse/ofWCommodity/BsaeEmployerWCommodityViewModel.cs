using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWCommodityViewModel : BaseCommodityViewModel<EmployerWCommodity>
    {
        public BaseEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostWCommodityViewModel : EmployerCommodityPostViewModel<EmployerWCommodity>
    {
        public EmployerPostWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWCommodityViewModel : EmployerCommodityPutViewModel<EmployerWCommodity>
    {
        public EmployerPutWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerWCommodity>
    {
        public EmployerDeleteWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWCommodityViewModel : EmployerCommodityGetsViewModel<EmployerWCommodity>
    {
        public EmployerGetsWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
