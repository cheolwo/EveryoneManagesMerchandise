using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofMarket;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity
{
    public class MCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : MCommodityDTO, new()
    {
        private readonly MCommodityPostViewModel<TEStatus> _MCommodityPostViewModel;
        private readonly MCommodityPutViewModel<TEStatus> _MCommodityPutViewModel;
        private readonly MCommodityDeleteViewModel<TEStatus> _MCommodityDeleteViewModel;
        private readonly MCommodityGetsViewModel<TEStatus> _MCommodityGetViewMode;
        public MCommodityPageViewModel(
            MCommodityPostViewModel<TEStatus> MCommodityPostViewModel, 
            MCommodityPutViewModel<TEStatus> MCommodityPutViewModel,
            MCommodityDeleteViewModel<TEStatus> MCommodityDeleteViewModel, 
            MCommodityGetsViewModel<TEStatus> MCommodityGetViewModel)
                                            :base(MCommodityPostViewModel, MCommodityPutViewModel, MCommodityDeleteViewModel, MCommodityGetViewModel)
        {
            _MCommodityPostViewModel = MCommodityPostViewModel;
            _MCommodityDeleteViewModel = MCommodityDeleteViewModel;
            _MCommodityGetViewMode = MCommodityGetViewModel;
            _MCommodityPutViewModel = MCommodityPutViewModel;
        }
    }
}