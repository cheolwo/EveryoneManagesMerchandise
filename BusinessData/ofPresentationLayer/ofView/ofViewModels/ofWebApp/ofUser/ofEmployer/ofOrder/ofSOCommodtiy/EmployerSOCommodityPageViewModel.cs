using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofSOCommodity
{
    public class EmployerSOCommodityPageViewModel : SOCommodityPageViewModel<EmployerSOCommodity> 
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