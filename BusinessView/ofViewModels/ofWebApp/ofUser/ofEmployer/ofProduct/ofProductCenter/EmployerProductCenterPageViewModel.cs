using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductCenter
{
    public class EmployerProductCenterPageViewModel : ProductCenterPageViewModel<EmployerProductCenter> 
    {
        public readonly EmployerPostProductCenterViewModel _EmployerPostProductCenterViewModel;
        public readonly EmployerPutProductCenterViewModel _EmployerPutProductCenterViewModel;
        public readonly EmployerDeleteProductCenterViewModel _EmployerDeleteProductCenterViewModel;
        public readonly EmployerGetsProductCenterViewModel _EmployerGetsProductCenterViewModel;

        public EmployerProductCenterPageViewModel(EmployerPostProductCenterViewModel EmployerPostProductCenterViewModel, 
                                        EmployerPutProductCenterViewModel EmployerPutProductCenterViewModel,
                                        EmployerDeleteProductCenterViewModel EmployerDeleteProductCenterViewModel,
                                        EmployerGetsProductCenterViewModel EmployerGetsProductCenterViewModel)
                :base(EmployerPostProductCenterViewModel, EmployerPutProductCenterViewModel, EmployerDeleteProductCenterViewModel, EmployerGetsProductCenterViewModel)
                    
        {
            _EmployerPostProductCenterViewModel = EmployerPostProductCenterViewModel;
            _EmployerPutProductCenterViewModel = EmployerPutProductCenterViewModel;
            _EmployerDeleteProductCenterViewModel = EmployerDeleteProductCenterViewModel;
            _EmployerGetsProductCenterViewModel = EmployerGetsProductCenterViewModel;
        }
    }
}