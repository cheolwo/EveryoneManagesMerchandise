using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJCommodity
{
    public class EmployerJCommodityPageViewModel : JCommodityPageViewModel<EmployerJCommodity> 
    {
        public readonly EmployerPostJCommodityViewModel _EmployerPostJCommodityViewModel;
        public readonly EmployerPutJCommodityViewModel _EmployerPutJCommodityViewModel;
        public readonly EmployerDeleteJCommodityViewModel _EmployerDeleteJCommodityViewModel;
        public readonly EmployerGetsJCommodityViewModel _EmployerGetsJCommodityViewModel;

        public EmployerJCommodityPageViewModel(EmployerPostJCommodityViewModel EmployerPostJCommodityViewModel, 
                                        EmployerPutJCommodityViewModel EmployerPutJCommodityViewModel,
                                        EmployerDeleteJCommodityViewModel EmployerDeleteJCommodityViewModel,
                                        EmployerGetsJCommodityViewModel EmployerGetsJCommodityViewModel)
                :base(EmployerPostJCommodityViewModel, EmployerPutJCommodityViewModel, EmployerDeleteJCommodityViewModel, EmployerGetsJCommodityViewModel)
                    
        {
            _EmployerPostJCommodityViewModel = EmployerPostJCommodityViewModel;
            _EmployerPutJCommodityViewModel = EmployerPutJCommodityViewModel;
            _EmployerDeleteJCommodityViewModel = EmployerDeleteJCommodityViewModel;
            _EmployerGetsJCommodityViewModel = EmployerGetsJCommodityViewModel;
        }
    }
}