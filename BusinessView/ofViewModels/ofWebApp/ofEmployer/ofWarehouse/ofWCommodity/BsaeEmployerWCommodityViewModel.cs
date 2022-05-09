using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWCommodityViewModel : BaseCommodityViewModel<EmployerWCommodity>
    {
        public BaseEmployerWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostWCommodityViewModel : CommodityPostViewModel<EmployerWCommodity>
    {
        public EmployerPostWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWCommodityViewModel : CommodityPutViewModel<EmployerWCommodity>
    {
        public EmployerPutWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWCommodityViewModel : CommodityDeleteViewModel<EmployerWCommodity>
    {
        public EmployerDeleteWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWCommodityViewModel : CommodityGetsViewModel<EmployerWCommodity>
    {
        public EmployerGetsWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
