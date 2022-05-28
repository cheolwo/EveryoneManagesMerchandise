using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofEPCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofEPCommodity
{
    public class EmployerEPCommodityPageViewModel : EPCommodityPageViewModel<EmployerEPCommodity> 
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