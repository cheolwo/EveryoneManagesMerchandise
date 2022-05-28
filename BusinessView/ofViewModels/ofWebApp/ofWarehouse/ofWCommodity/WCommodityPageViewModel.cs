using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofWarehouse;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity
{
    public class WCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : WCommodityDTO, new()
    {
        private readonly WCommodityPostViewModel<TCommodity> _WCommodityPostViewModel;
        private readonly WCommodityPutViewModel<TCommodity> _WCommodityPutViewModel;
        private readonly WCommodityDeleteViewModel<TCommodity> _WCommodityDeleteViewModel;
        private readonly WCommodityGetsViewModel<TCommodity> _WCommodityGetViewMode;
        public WCommodityPageViewModel(
            WCommodityPostViewModel<TCommodity> WCommodityPostViewModel, 
            WCommodityPutViewModel<TCommodity> WCommodityPutViewModel,
            WCommodityDeleteViewModel<TCommodity> WCommodityDeleteViewModel, 
            WCommodityGetsViewModel<TCommodity> WCommodityGetViewModel)
                                            :base(WCommodityPostViewModel, WCommodityPutViewModel, WCommodityDeleteViewModel, WCommodityGetViewModel)
        {
            _WCommodityPostViewModel = WCommodityPostViewModel;
            _WCommodityDeleteViewModel = WCommodityDeleteViewModel;
            _WCommodityGetViewMode = WCommodityGetViewModel;
            _WCommodityPutViewModel = WCommodityPutViewModel;
        }
    }
}