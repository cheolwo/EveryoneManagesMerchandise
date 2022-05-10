using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCCViewModel : BaseCommodityViewModel<EmployerGOCC>
    {
        public BaseEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostGOCCViewModel : CommodityPostViewModel<EmployerGOCC>
    {
        public EmployerPostGOCCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutGOCCViewModel : CommodityPutViewModel<EmployerGOCC>
    {
        public EmployerPutGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteGOCCViewModel : CommodityDeleteViewModel<EmployerGOCC>
    {
        public EmployerDeleteGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsGOCCViewModel : CommodityGetsViewModel<EmployerGOCC>
    {
        public EmployerGetsGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
