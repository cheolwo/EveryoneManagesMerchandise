using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOrderCenterViewModel : BaseCenterViewModel<EmployerOrderCenter>
    {
        public BaseEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostOrderCenterViewModel : EmployerCenterPostViewModel<EmployerOrderCenter>
    {
        public EmployerPostOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutOrderCenterViewModel : EmployerCenterPutViewModel<EmployerOrderCenter>
    {
        public EmployerPutOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteOrderCenterViewModel : EmployerCenterDeleteViewModel<EmployerOrderCenter>
    {
        public EmployerDeleteOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsOrderCenterViewModel : EmployerCenterGetsViewModel<EmployerOrderCenter>
    {
        public EmployerGetsOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
