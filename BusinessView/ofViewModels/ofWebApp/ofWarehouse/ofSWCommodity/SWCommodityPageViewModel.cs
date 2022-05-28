using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofWarehouse;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity
{
    public class SWCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : SWCommodityDTO, new()
    {
        private readonly SWCommodityPostViewModel<TMStatus> _SWCommodityPostViewModel;
        private readonly SWCommodityPutViewModel<TMStatus> _SWCommodityPutViewModel;
        private readonly SWCommodityDeleteViewModel<TMStatus> _SWCommodityDeleteViewModel;
        private readonly SWCommodityGetsViewModel<TMStatus> _SWCommodityGetViewMode;
        public SWCommodityPageViewModel(
            SWCommodityPostViewModel<TMStatus> SWCommodityPostViewModel, 
            SWCommodityPutViewModel<TMStatus> SWCommodityPutViewModel,
            SWCommodityDeleteViewModel<TMStatus> SWCommodityDeleteViewModel, 
            SWCommodityGetsViewModel<TMStatus> SWCommodityGetViewModel)
                                            :base(SWCommodityPostViewModel, SWCommodityPutViewModel, SWCommodityDeleteViewModel, SWCommodityGetViewModel)
        {
            _SWCommodityPostViewModel = SWCommodityPostViewModel;
            _SWCommodityDeleteViewModel = SWCommodityDeleteViewModel;
            _SWCommodityGetViewMode = SWCommodityGetViewModel;
            _SWCommodityPutViewModel = SWCommodityPutViewModel;
        }
    }
}