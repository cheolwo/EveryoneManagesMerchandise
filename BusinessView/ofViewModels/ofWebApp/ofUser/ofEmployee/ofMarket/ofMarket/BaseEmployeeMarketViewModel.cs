using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeeMarketViewModel : BaseCenterViewModel<EmployeeMarket>
    {
        public BaseEmployeeMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMarketViewModel : CenterPostViewModel<EmployeeMarket>
    {
        public EmployeePostMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMarketViewModel : CenterPutViewModel<EmployeeMarket>
    {
        public EmployeePutMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMarketViewModel : CenterDeleteViewModel<EmployeeMarket>
    {
        public EmployeeDeleteMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMarketViewModel : CenterGetsViewModel<EmployeeMarket>
    {
        public EmployeeGetsMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
