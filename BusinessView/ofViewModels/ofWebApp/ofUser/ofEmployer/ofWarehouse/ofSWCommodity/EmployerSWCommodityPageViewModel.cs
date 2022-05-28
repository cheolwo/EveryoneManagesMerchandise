using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofSWCommodity
{
    public class EmployerSWCommodityPageViewModel : SWCommodityPageViewModel<EmployerSWCommodity> 
    {
        public readonly EmployerPostSWCommodityViewModel _EmployerPostSWCommodityViewModel;
        public readonly EmployerPutSWCommodityViewModel _EmployerPutSWCommodityViewModel;
        public readonly EmployerDeleteSWCommodityViewModel _EmployerDeleteSWCommodityViewModel;
        public readonly EmployerGetsSWCommodityViewModel _EmployerGetsSWCommodityViewModel;

        public EmployerSWCommodityPageViewModel(EmployerPostSWCommodityViewModel EmployerPostSWCommodityViewModel, 
                                        EmployerPutSWCommodityViewModel EmployerPutSWCommodityViewModel,
                                        EmployerDeleteSWCommodityViewModel EmployerDeleteSWCommodityViewModel,
                                        EmployerGetsSWCommodityViewModel EmployerGetsSWCommodityViewModel)
                :base(EmployerPostSWCommodityViewModel, EmployerPutSWCommodityViewModel, EmployerDeleteSWCommodityViewModel, EmployerGetsSWCommodityViewModel)
                    
        {
            _EmployerPostSWCommodityViewModel = EmployerPostSWCommodityViewModel;
            _EmployerPutSWCommodityViewModel = EmployerPutSWCommodityViewModel;
            _EmployerDeleteSWCommodityViewModel = EmployerDeleteSWCommodityViewModel;
            _EmployerGetsSWCommodityViewModel = EmployerGetsSWCommodityViewModel;
        }
    }
}