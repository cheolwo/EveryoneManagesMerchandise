using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofCommon.ofTrade;
namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity
{
    public class STCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : STCommodityDTO, new()
    {
        private readonly STCommodityPostViewModel<TMStatus> _STCommodityPostViewModel;
        private readonly STCommodityPutViewModel<TMStatus> _STCommodityPutViewModel;
        private readonly STCommodityDeleteViewModel<TMStatus> _STCommodityDeleteViewModel;
        private readonly STCommodityGetsViewModel<TMStatus> _STCommodityGetViewMode;
        public STCommodityPageViewModel(
            STCommodityPostViewModel<TMStatus> STCommodityPostViewModel, 
            STCommodityPutViewModel<TMStatus> STCommodityPutViewModel,
            STCommodityDeleteViewModel<TMStatus> STCommodityDeleteViewModel, 
            STCommodityGetsViewModel<TMStatus> STCommodityGetViewModel)
                                            :base(STCommodityPostViewModel, STCommodityPutViewModel, STCommodityDeleteViewModel, STCommodityGetViewModel)
        {
            _STCommodityPostViewModel = STCommodityPostViewModel;
            _STCommodityDeleteViewModel = STCommodityDeleteViewModel;
            _STCommodityGetViewMode = STCommodityGetViewModel;
            _STCommodityPutViewModel = STCommodityPutViewModel;
        }
    }
}