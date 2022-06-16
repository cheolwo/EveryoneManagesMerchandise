using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofEMCommodity
{
    public class EmployerEMCommodityPageViewModel : EMCommodityPageViewModel<EmployerEMCommodity> 
    {
        public readonly EmployerPostEMCommodityViewModel _EmployerPostEMCommodityViewModel;
        public readonly EmployerPutEMCommodityViewModel _EmployerPutEMCommodityViewModel;
        public readonly EmployerDeleteEMCommodityViewModel _EmployerDeleteEMCommodityViewModel;
        public readonly EmployerGetsEMCommodityViewModel _EmployerGetsEMCommodityViewModel;

        public EmployerEMCommodityPageViewModel(EmployerPostEMCommodityViewModel EmployerPostEMCommodityViewModel, 
                                        EmployerPutEMCommodityViewModel EmployerPutEMCommodityViewModel,
                                        EmployerDeleteEMCommodityViewModel EmployerDeleteEMCommodityViewModel,
                                        EmployerGetsEMCommodityViewModel EmployerGetsEMCommodityViewModel)
                :base(EmployerPostEMCommodityViewModel, EmployerPutEMCommodityViewModel, EmployerDeleteEMCommodityViewModel, EmployerGetsEMCommodityViewModel)
                    
        {
            _EmployerPostEMCommodityViewModel = EmployerPostEMCommodityViewModel;
            _EmployerPutEMCommodityViewModel = EmployerPutEMCommodityViewModel;
            _EmployerDeleteEMCommodityViewModel = EmployerDeleteEMCommodityViewModel;
            _EmployerGetsEMCommodityViewModel = EmployerGetsEMCommodityViewModel;
        }
    }
}