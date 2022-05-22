using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofEPCommodity
{
    public class EmployerEPCommodityPageViewModel : EmployerStatusPageViewModel<EmployerEPCommodity> 
    {
        public readonly EmployerPostEPCommodityViewModel _EmployerPostEPCommodityViewModel;
        public readonly EmployerPutEPCommodityViewModel _EmployerPutEPCommodityViewModel;
        public readonly EmployerDeleteEPCommodityViewModel _EmployerDeleteEPCommodityViewModel;
        public readonly EmployerGetsEPCommodityViewModel _EmployerGetsEPCommodityViewModel;
        public EmployerEPCommodityPageViewModel(EmployerPostEPCommodityViewModel EmployerPostEPCommodityViewModel, 
                                        EmployerPutEPCommodityViewModel EmployerPutEPCommodityViewModel,
                                        EmployerDeleteEPCommodityViewModel EmployerDeleteEPCommodityViewModel,
                                        EmployerGetsEPCommodityViewModel EmployerGetsEPCommodityViewModel)
                :base(EmployerPostEPCommodityViewModel, EmployerPutEPCommodityViewModel, EmployerDeleteEPCommodityViewModel, EmployerGetsEPCommodityViewModel)
                    
        {
            _EmployerPostEPCommodityViewModel = EmployerPostEPCommodityViewModel;
            _EmployerPutEPCommodityViewModel = EmployerPutEPCommodityViewModel;
            _EmployerDeleteEPCommodityViewModel = EmployerDeleteEPCommodityViewModel;
            _EmployerGetsEPCommodityViewModel = EmployerGetsEPCommodityViewModel;
        }
    }
}