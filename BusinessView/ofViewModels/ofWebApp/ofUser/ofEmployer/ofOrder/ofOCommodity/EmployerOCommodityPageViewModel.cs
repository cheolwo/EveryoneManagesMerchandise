using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOCommodity
{
    public class EmployerOCommodityPageViewModel : OCommodityPageViewModel<EmployerOCommodity> 
    {
        public readonly EmployerPostOCommodityViewModel _EmployerPostOCommodityViewModel;
        public readonly EmployerPutOCommodityViewModel _EmployerPutOCommodityViewModel;
        public readonly EmployerDeleteOCommodityViewModel _EmployerDeleteOCommodityViewModel;
        public readonly EmployerGetsOCommodityViewModel _EmployerGetsOCommodityViewModel;

        public EmployerOCommodityPageViewModel(EmployerPostOCommodityViewModel EmployerPostOCommodityViewModel, 
                                        EmployerPutOCommodityViewModel EmployerPutOCommodityViewModel,
                                        EmployerDeleteOCommodityViewModel EmployerDeleteOCommodityViewModel,
                                        EmployerGetsOCommodityViewModel EmployerGetsOCommodityViewModel)
                :base(EmployerPostOCommodityViewModel, EmployerPutOCommodityViewModel, EmployerDeleteOCommodityViewModel, EmployerGetsOCommodityViewModel)
                    
        {
            _EmployerPostOCommodityViewModel = EmployerPostOCommodityViewModel;
            _EmployerPutOCommodityViewModel = EmployerPutOCommodityViewModel;
            _EmployerDeleteOCommodityViewModel = EmployerDeleteOCommodityViewModel;
            _EmployerGetsOCommodityViewModel = EmployerGetsOCommodityViewModel;
        }
    }
}