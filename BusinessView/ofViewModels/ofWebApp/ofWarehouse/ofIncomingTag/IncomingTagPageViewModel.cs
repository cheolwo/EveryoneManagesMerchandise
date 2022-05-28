using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofWarehouse;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag
{
    public class IncomingTagPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : IncomingTagDTO, new()
    {
        private readonly IncomingTagPostViewModel<TEntity> _IncomingTagPostViewModel;
        private readonly IncomingTagPutViewModel<TEntity> _IncomingTagPutViewModel;
        private readonly IncomingTagDeleteViewModel<TEntity> _IncomingTagDeleteViewModel;
        private readonly IncomingTagGetsViewModel<TEntity> _IncomingTagGetViewMode;
        public IncomingTagPageViewModel(
            IncomingTagPostViewModel<TEntity> IncomingTagPostViewModel, 
            IncomingTagPutViewModel<TEntity> IncomingTagPutViewModel,
            IncomingTagDeleteViewModel<TEntity> IncomingTagDeleteViewModel, 
            IncomingTagGetsViewModel<TEntity> IncomingTagGetViewModel)
                                            :base(IncomingTagPostViewModel, IncomingTagPutViewModel, IncomingTagDeleteViewModel, IncomingTagGetViewModel)
        {
            _IncomingTagPostViewModel = IncomingTagPostViewModel;
            _IncomingTagDeleteViewModel = IncomingTagDeleteViewModel;
            _IncomingTagGetViewMode = IncomingTagGetViewModel;
            _IncomingTagPutViewModel = IncomingTagPutViewModel;
        }
    }
}