using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofEWCommodity
{
    public class EmployerEWCommodityPageViewModel : EWCommodityPageViewModel<EmployerEWCommodity> 
    {
        public readonly EmployerPostEWCommodityViewModel _EmployerPostEWCommodityViewModel;
        public readonly EmployerPutEWCommodityViewModel _EmployerPutEWCommodityViewModel;
        public readonly EmployerDeleteEWCommodityViewModel _EmployerDeleteEWCommodityViewModel;
        public readonly EmployerGetsEWCommodityViewModel _EmployerGetsEWCommodityViewModel;

        public EmployerEWCommodityPageViewModel(EmployerPostEWCommodityViewModel EmployerPostEWCommodityViewModel, 
                                        EmployerPutEWCommodityViewModel EmployerPutEWCommodityViewModel,
                                        EmployerDeleteEWCommodityViewModel EmployerDeleteEWCommodityViewModel,
                                        EmployerGetsEWCommodityViewModel EmployerGetsEWCommodityViewModel)
                :base(EmployerPostEWCommodityViewModel, EmployerPutEWCommodityViewModel, EmployerDeleteEWCommodityViewModel, EmployerGetsEWCommodityViewModel)
                    
        {
            _EmployerPostEWCommodityViewModel = EmployerPostEWCommodityViewModel;
            _EmployerPutEWCommodityViewModel = EmployerPutEWCommodityViewModel;
            _EmployerDeleteEWCommodityViewModel = EmployerDeleteEWCommodityViewModel;
            _EmployerGetsEWCommodityViewModel = EmployerGetsEWCommodityViewModel;
        }
    }
}