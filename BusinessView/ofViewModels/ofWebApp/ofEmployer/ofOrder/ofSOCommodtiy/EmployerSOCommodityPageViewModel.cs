using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofSOCommodity
{
    public class EmployerSOCommodityPageViewModel : StatusPageViewModel<EmployerSOCommodity> 
    {
        public readonly EmployerPostSOCommodityViewModel _EmployerPostSOCommodityViewModel;
        public readonly EmployerPutSOCommodityViewModel _EmployerPutSOCommodityViewModel;
        public readonly EmployerDeleteSOCommodityViewModel _EmployerDeleteSOCommodityViewModel;
        public readonly EmployerGetsSOCommodityViewModel _EmployerGetsSOCommodityViewModel;
        public EmployerSOCommodityPageViewModel(EmployerPostSOCommodityViewModel EmployerPostSOCommodityViewModel, 
                                        EmployerPutSOCommodityViewModel EmployerPutSOCommodityViewModel,
                                        EmployerDeleteSOCommodityViewModel EmployerDeleteSOCommodityViewModel,
                                        EmployerGetsSOCommodityViewModel EmployerGetsSOCommodityViewModel)
                :base(EmployerPostSOCommodityViewModel, EmployerPutSOCommodityViewModel, EmployerDeleteSOCommodityViewModel, EmployerGetsSOCommodityViewModel)
                    
        {
            _EmployerPostSOCommodityViewModel = EmployerPostSOCommodityViewModel;
            _EmployerPutSOCommodityViewModel = EmployerPutSOCommodityViewModel;
            _EmployerDeleteSOCommodityViewModel = EmployerDeleteSOCommodityViewModel;
            _EmployerGetsSOCommodityViewModel = EmployerGetsSOCommodityViewModel;
        }
    }
}