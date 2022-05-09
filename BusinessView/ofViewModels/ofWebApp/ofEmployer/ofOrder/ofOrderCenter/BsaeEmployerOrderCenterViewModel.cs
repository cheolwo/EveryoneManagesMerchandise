using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOrderCenterViewModel : BaseCenterViewModel<EmployerOrderCenter>
    {
        public BaseEmployerOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostOrderCenterViewModel : CenterPostViewModel<EmployerOrderCenter>
    {
        public EmployerPostOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutOrderCenterViewModel : CenterPutViewModel<EmployerOrderCenter>
    {
        public EmployerPutOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteOrderCenterViewModel : CenterDeleteViewModel<EmployerOrderCenter>
    {
        public EmployerDeleteOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsOrderCenterViewModel : CenterGetsViewModel<EmployerOrderCenter>
    {
        public EmployerGetsOrderCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
