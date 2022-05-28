using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder;
namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC
{
    public class GOCCPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : GOCCDTO, new()
    {
        private readonly GOCCPostViewModel<TCenter> _GOCCPostViewModel;
        private readonly GOCCPutViewModel<TCenter> _GOCCPutViewModel;
        private readonly GOCCDeleteViewModel<TCenter> _GOCCDeleteViewModel;
        private readonly GOCCGetsViewModel<TCenter> _GOCCGetViewMode;
        public GOCCPageViewModel(
            GOCCPostViewModel<TCenter> GOCCPostViewModel, 
            GOCCPutViewModel<TCenter> GOCCPutViewModel,
            GOCCDeleteViewModel<TCenter> GOCCDeleteViewModel, 
            GOCCGetsViewModel<TCenter> GOCCGetViewModel)
                                            :base(GOCCPostViewModel, GOCCPutViewModel, GOCCDeleteViewModel, GOCCGetViewModel)
        {
            _GOCCPostViewModel = GOCCPostViewModel;
            _GOCCDeleteViewModel = GOCCDeleteViewModel;
            _GOCCGetViewMode = GOCCGetViewModel;
            _GOCCPutViewModel = GOCCPutViewModel;
        }
    }
}