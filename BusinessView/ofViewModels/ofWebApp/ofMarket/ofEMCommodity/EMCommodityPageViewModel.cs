using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofMarket;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity
{
    public class EMCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EMCommodityDTO, new()
    {
        private readonly EMCommodityPostViewModel<TEntity> _EMCommodityPostViewModel;
        private readonly EMCommodityPutViewModel<TEntity> _EMCommodityPutViewModel;
        private readonly EMCommodityDeleteViewModel<TEntity> _EMCommodityDeleteViewModel;
        private readonly EMCommodityGetsViewModel<TEntity> _EMCommodityGetViewMode;
        public EMCommodityPageViewModel(
            EMCommodityPostViewModel<TEntity> EMCommodityPostViewModel, 
            EMCommodityPutViewModel<TEntity> EMCommodityPutViewModel,
            EMCommodityDeleteViewModel<TEntity> EMCommodityDeleteViewModel, 
            EMCommodityGetsViewModel<TEntity> EMCommodityGetViewModel)
                                            :base(EMCommodityPostViewModel, EMCommodityPutViewModel, EMCommodityDeleteViewModel, EMCommodityGetViewModel)
        {
            _EMCommodityPostViewModel = EMCommodityPostViewModel;
            _EMCommodityDeleteViewModel = EMCommodityDeleteViewModel;
            _EMCommodityGetViewMode = EMCommodityGetViewModel;
            _EMCommodityPutViewModel = EMCommodityPutViewModel;
        }
    }
}