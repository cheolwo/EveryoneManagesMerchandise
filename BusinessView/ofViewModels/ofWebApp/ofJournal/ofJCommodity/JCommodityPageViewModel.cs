using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofJournal;
namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity
{
    public class JCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : JCommodityDTO, new()
    {
        private readonly JCommodityPostViewModel<TEntity> _JCommodityPostViewModel;
        private readonly JCommodityPutViewModel<TEntity> _JCommodityPutViewModel;
        private readonly JCommodityDeleteViewModel<TEntity> _JCommodityDeleteViewModel;
        private readonly JCommodityGetsViewModel<TEntity> _JCommodityGetViewMode;
        public JCommodityPageViewModel(
            JCommodityPostViewModel<TEntity> JCommodityPostViewModel, 
            JCommodityPutViewModel<TEntity> JCommodityPutViewModel,
            JCommodityDeleteViewModel<TEntity> JCommodityDeleteViewModel, 
            JCommodityGetsViewModel<TEntity> JCommodityGetViewModel)
                                            :base(JCommodityPostViewModel, JCommodityPutViewModel, JCommodityDeleteViewModel, JCommodityGetViewModel)
        {
            _JCommodityPostViewModel = JCommodityPostViewModel;
            _JCommodityDeleteViewModel = JCommodityDeleteViewModel;
            _JCommodityGetViewMode = JCommodityGetViewModel;
            _JCommodityPutViewModel = JCommodityPutViewModel;
        }
    }
}