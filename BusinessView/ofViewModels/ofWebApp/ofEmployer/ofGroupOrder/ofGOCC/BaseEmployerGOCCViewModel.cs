using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder
{
    public class BaseEmployerGOCCViewModel : BaseCommodityViewModel<EmployerGOCC>
    {
        public BaseEmployerGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostGOCCViewModel : EmployerCommodityPostViewModel<EmployerGOCC>
    {
        public EmployerPostGOCCViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutGOCCViewModel : EmployerCommodityPutViewModel<EmployerGOCC>
    {
        public EmployerPutGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteGOCCViewModel : EmployerCommodityDeleteViewModel<EmployerGOCC>
    {
        public EmployerDeleteGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsGOCCViewModel : EmployerCommodityGetsViewModel<EmployerGOCC>
    {
        public EmployerGetsGOCCViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
