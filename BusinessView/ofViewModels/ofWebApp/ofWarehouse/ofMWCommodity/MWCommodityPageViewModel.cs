using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofWarehouse;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity
{
    public class MWCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : MWCommodityDTO, new()
    {
        private readonly MWCommodityPostViewModel<TEntity> _MWCommodityPostViewModel;
        private readonly MWCommodityPutViewModel<TEntity> _MWCommodityPutViewModel;
        private readonly MWCommodityDeleteViewModel<TEntity> _MWCommodityDeleteViewModel;
        private readonly MWCommodityGetsViewModel<TEntity> _MWCommodityGetViewMode;
        public MWCommodityPageViewModel(
            MWCommodityPostViewModel<TEntity> MWCommodityPostViewModel, 
            MWCommodityPutViewModel<TEntity> MWCommodityPutViewModel,
            MWCommodityDeleteViewModel<TEntity> MWCommodityDeleteViewModel, 
            MWCommodityGetsViewModel<TEntity> MWCommodityGetViewModel)
                                            :base(MWCommodityPostViewModel, MWCommodityPutViewModel, MWCommodityDeleteViewModel, MWCommodityGetViewModel)
        {
            _MWCommodityPostViewModel = MWCommodityPostViewModel;
            _MWCommodityDeleteViewModel = MWCommodityDeleteViewModel;
            _MWCommodityGetViewMode = MWCommodityGetViewModel;
            _MWCommodityPutViewModel = MWCommodityPutViewModel;
        }
    }
}