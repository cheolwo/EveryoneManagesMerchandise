using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOrderCenter
{
    public class EmployerOrderCenterPageViewModel : OrderCenterPageViewModel<EmployerOrderCenter> 
    {
        public readonly EmployerPostOrderCenterViewModel _EmployerPostOrderCenterViewModel;
        public readonly EmployerPutOrderCenterViewModel _EmployerPutOrderCenterViewModel;
        public readonly EmployerDeleteOrderCenterViewModel _EmployerDeleteOrderCenterViewModel;
        public readonly EmployerGetsOrderCenterViewModel _EmployerGetsOrderCenterViewModel;

        public EmployerOrderCenterPageViewModel(EmployerPostOrderCenterViewModel EmployerPostOrderCenterViewModel, 
                                        EmployerPutOrderCenterViewModel EmployerPutOrderCenterViewModel,
                                        EmployerDeleteOrderCenterViewModel EmployerDeleteOrderCenterViewModel,
                                        EmployerGetsOrderCenterViewModel EmployerGetsOrderCenterViewModel)
                :base(EmployerPostOrderCenterViewModel, EmployerPutOrderCenterViewModel, EmployerDeleteOrderCenterViewModel, EmployerGetsOrderCenterViewModel)
                    
        {
            _EmployerPostOrderCenterViewModel = EmployerPostOrderCenterViewModel;
            _EmployerPutOrderCenterViewModel = EmployerPutOrderCenterViewModel;
            _EmployerDeleteOrderCenterViewModel = EmployerDeleteOrderCenterViewModel;
            _EmployerGetsOrderCenterViewModel = EmployerGetsOrderCenterViewModel;
        }
    }
}