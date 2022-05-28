using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofOrder;
namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity
{
    public class MOCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : MOCommodityDTO, new()
    {
        private readonly MOCommodityPostViewModel<TEStatus> _MOCommodityPostViewModel;
        private readonly MOCommodityPutViewModel<TEStatus> _MOCommodityPutViewModel;
        private readonly MOCommodityDeleteViewModel<TEStatus> _MOCommodityDeleteViewModel;
        private readonly MOCommodityGetsViewModel<TEStatus> _MOCommodityGetViewMode;
        public MOCommodityPageViewModel(
            MOCommodityPostViewModel<TEStatus> MOCommodityPostViewModel, 
            MOCommodityPutViewModel<TEStatus> MOCommodityPutViewModel,
            MOCommodityDeleteViewModel<TEStatus> MOCommodityDeleteViewModel, 
            MOCommodityGetsViewModel<TEStatus> MOCommodityGetViewModel)
                                            :base(MOCommodityPostViewModel, MOCommodityPutViewModel, MOCommodityDeleteViewModel, MOCommodityGetViewModel)
        {
            _MOCommodityPostViewModel = MOCommodityPostViewModel;
            _MOCommodityDeleteViewModel = MOCommodityDeleteViewModel;
            _MOCommodityGetViewMode = MOCommodityGetViewModel;
            _MOCommodityPutViewModel = MOCommodityPutViewModel;
        }
    }
}