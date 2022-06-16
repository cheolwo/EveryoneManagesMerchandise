using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class EmployerPostMOCommodityViewModel : MOCommodityPostViewModel<EmployerMOCommodity>
    {
        public EmployerPostMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMOCommodityViewModel : MOCommodityPutViewModel<EmployerMOCommodity>
    {
        public EmployerPutMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMOCommodityViewModel : MOCommodityDeleteViewModel<EmployerMOCommodity>
    {
        public EmployerDeleteMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMOCommodityViewModel : MOCommodityGetsViewModel<EmployerMOCommodity>
    {
        public EmployerGetsMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
